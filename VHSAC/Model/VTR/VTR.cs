using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VHSAC.Model.CaptureDevice;
using VHSAC.Model.Metadata;
using VHSAC.Model.Router;
using VHSAC.Model.VTRController;

namespace VHSAC.Model.VTR
{
    public class VTR
    {

        public string Name { get; private set; }

        private List<IRouterCrosspoint> _routerCrosspoints;
        private ICaptureDevice _captureDevice;
        private Controller.Adapter _controllerAdapter;

        #region Property: State
        private VTRState _state;

        public VTRState State {
            get { return _state; }
            set
            {
                VTRState oldValue = _state;
                _state = value;
                if (oldValue != value)
                    StateChanged?.Invoke(this, value);
            }
        }

        public delegate void StateChangedHandler(VTR vtr, VTRState newState);

        public event StateChangedHandler StateChanged;
        #endregion

        #region Property: CaptureLength
        private int _captureLength;

        public int CaptureLength
        {
            get { return _captureLength; }
            set
            {
                int oldValue = _captureLength;
                _captureLength = value;
                if (oldValue != value)
                    CaptureLengthChanged?.Invoke(this, value);
            }
        }

        public delegate void CaptureLengthChangedHandler(VTR vtr, int newLength);

        public event CaptureLengthChangedHandler CaptureLengthChanged;
        #endregion

        #region Property: UseInNextBatch
        private bool _useInNextBatch = true;

        public bool UseInNextBatch
        {
            get { return _useInNextBatch; }
            set
            {
                bool oldValue = _useInNextBatch;
                _useInNextBatch = value;
                if (oldValue != value)
                    UseInNextBatchChanged?.Invoke(this, value);
            }
        }

        public delegate void UseInNextBatchChangedHandler(VTR vtr, bool newValue);

        public event UseInNextBatchChangedHandler UseInNextBatchChanged;
        #endregion

        #region Property: CaptureFilename
        private string _captureFilename;

        public string CaptureFilename
        {
            get { return _captureFilename; }
            set
            {
                string oldValue = _captureFilename;
                _captureFilename = value;
                if (oldValue != value)
                    CaptureFilenameChanged?.Invoke(this, value);
            }
        }

        public delegate void CaptureFilenameChangedHandler(VTR vtr, string newCaptureFilename);

        public event CaptureFilenameChangedHandler CaptureFilenameChanged;
        #endregion

        #region Property: CaptureMetadata
        private CaptureMetadata _captureMetadata = new CaptureMetadata();

        public CaptureMetadata CaptureMetadata
        {
            get => _captureMetadata;
        }
        #endregion

        private Thread _mainCaptureThread;
        private Thread _stateCheckThread;
        private ICapture _capture;

        ManualResetEvent _stopTapeEnded = new ManualResetEvent(false);
        ManualResetEvent _stopManually = new ManualResetEvent(false);
        ManualResetEvent _stopFailure = new ManualResetEvent(false);

        public VTR(string name, List<IRouterCrosspoint> routerCrosspoints, ICaptureDevice captureDevice, Controller.Adapter controllerAdapter)
        {
            Name = name;
            _routerCrosspoints = routerCrosspoints;
            _captureDevice = captureDevice;
            _controllerAdapter = controllerAdapter;
        }

        public void StartCapture()
        {
            if(State != VTRState.Reset)
            {
                throw new Exception("VTR must be in 'reset' state to start capture!");
            }
            _mainCaptureThread = new Thread(mainCaptureThreadMethod);
            _mainCaptureThread.IsBackground = true;
            _mainCaptureThread.Start();
        }

        public void StopCapture(bool manual = false)
        {
            if(State != VTRState.Capturing)
            {
                throw new Exception("VTR can only be stopped when it's capturing!");
            }
            _stopManually.Set();
        }

        public void Reset()
        {
            if (State == VTRState.Capturing)
            {
                string errMsg = string.Format("Can't reset VTR [{0}], because capture is in process.", Name);
                throw new Exception(errMsg);
            }
            State = VTRState.Reset;
            _captureMetadata = new CaptureMetadata();
        }

        private readonly static int UNKNOWN_STATE_LIMIT = 5;

        private void mainCaptureThreadMethod()
        {

            startCaptureProcess();

            WaitHandle[] waitHandles = new WaitHandle[] { _stopTapeEnded, _stopManually, _stopFailure };
            WaitHandle.WaitAny(waitHandles);

            if (_stopTapeEnded.WaitOne(1))
                stopCaptureProcess(StopReason.TapeEnded);
            else if (_stopManually.WaitOne(1))
                stopCaptureProcess(StopReason.Manually);
            else
                stopCaptureProcess(StopReason.Failure);

        }

        private void stateCheckThreadMethod()
        {

            int unknownStateCounter = 0;
            while (true)
            {

                PhysicalVTRState state = _controllerAdapter.GetVTRState();
                if (state == PhysicalVTRState.Stopped)
                {
                    _stopTapeEnded.Set();
                    break;
                }
                else if (state != PhysicalVTRState.Playing)
                {
                    unknownStateCounter++;
                }
                else
                {
                    unknownStateCounter = 0;
                }

                if (unknownStateCounter > UNKNOWN_STATE_LIMIT)
                {
                    _stopFailure.Set();
                    break;
                }

                Thread.Sleep(1000);

            }

        }

        private void startCaptureProcess()
        {

            try
            {

                State = VTRState.Starting;

                _routerCrosspoints.ForEach(r => r.Take());

                _capture = _captureDevice.StartCapture(this, CaptureFilename, _captureMetadata);
                _capture.LengthChanged += captureLengthChangedHandler;
                _capture.StateChanged += captureStateChangedHandler;
                Thread.Sleep(1000);

                _controllerAdapter.StartVTR();
                Thread.Sleep(5000);

                _stateCheckThread = new Thread(stateCheckThreadMethod);
                _stateCheckThread.IsBackground = true;
                _stateCheckThread.Start();

                State = VTRState.Capturing;

            }
            catch (Exception e)
            {
                string errMsg = string.Format("Can't start capture on VTR [{0}]. See inner exception for details.", Name);
                throw new Exception(errMsg, e);
            }

        }

        private void stopCaptureProcess(StopReason reason)
        {

            State = VTRState.Stopping;

            _stateCheckThread.Abort();

            _controllerAdapter.StopVTR();
            Thread.Sleep(3000);

            _capture.Stop();
            _capture.LengthChanged -= captureLengthChangedHandler;
            _capture.StateChanged -= captureStateChangedHandler;

            _capture = null;
            _stateCheckThread = null;

            Thread.Sleep(1000);

            switch (reason)
            {
                case StopReason.TapeEnded:
                    State = VTRState.Ready;
                    break;
                case StopReason.Manually:
                    State = VTRState.ManuallyStopped;
                    break;
                case StopReason.Failure:
                default:
                    State = VTRState.Failure;
                    break;
            }

        }

        private void captureLengthChangedHandler(ICapture capture, int newLength)
        {
            CaptureLength = newLength;
        }

        private void captureStateChangedHandler(ICapture capture, CaptureState newState)
        {
            if (newState == CaptureState.Failure)
                _stopFailure.Set();
        }

        private enum StopReason
        {
            TapeEnded,
            Manually,
            Failure
        }

    }
}
