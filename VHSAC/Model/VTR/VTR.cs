using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VHSAC.Model.CaptureDevice;
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
                _state = value;
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
                _captureLength = value;
                CaptureLengthChanged?.Invoke(this, value);
            }
        }

        public delegate void CaptureLengthChangedHandler(VTR vtr, int newLength);

        public event CaptureLengthChangedHandler CaptureLengthChanged;
        #endregion

        private Thread _mainCaptureThread;
        private Thread _stateCheckThread;
        private ICapture _capture;

        ManualResetEvent _stopTapeEnded = new ManualResetEvent(false);
        ManualResetEvent _stopManually = new ManualResetEvent(false);
        ManualResetEvent _stopFailure = new ManualResetEvent(false);

        public VTR(string name)
        {
            Name = name;
        }

        public void StartCapture()
        {
            if(State != VTRState.Reset)
            {
                throw new Exception(); // TODO: Exception message
            }
            _mainCaptureThread = new Thread(mainCaptureThreadMethod);
            _mainCaptureThread.Start();
        }

        public void StopCapture(bool manual = false)
        {
            if(State != VTRState.Capturing)
            {
                throw new Exception(); // TODO: Exception message
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

                _routerCrosspoints.ForEach(r => r.Take());

                _capture = _captureDevice.StartCapture("random.avi");
                _capture.LengthChanged += captureLengthChangedHandler;
                _capture.StateChanged += captureStateChangedHandler;
                Thread.Sleep(1000);

                _controllerAdapter.StartVTR();
                Thread.Sleep(5000);

                _stateCheckThread = new Thread(stateCheckThreadMethod);
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

            _stateCheckThread.Abort();

            _controllerAdapter.StopVTR();
            Thread.Sleep(3000);

            _capture.Stop();
            _capture.LengthChanged -= captureLengthChangedHandler;
            _capture.StateChanged -= captureStateChangedHandler;

            _capture = null;
            _stateCheckThread = null;

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
