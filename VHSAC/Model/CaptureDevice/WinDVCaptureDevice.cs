using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using VHSAC.Model.Metadata;

namespace VHSAC.Model.CaptureDevice
{
    public class WinDVCaptureDevice: ICaptureDevice
    {

        private Capture _currentCapture;

        private object _syncRoot = new object();

        private static readonly string WINDV_EXECUTABLE_NAME = "windv.exe";

        private static readonly int WINDV_CAPTURE_LENGTH = 3600 * (4 + 1);

        #region Property: Name
        private string _name;

        public string Name
        {
            get => "";
        }
        #endregion

        public WinDVCaptureDevice(String name)
        {
            _name = name;
        }

        public ICapture StartCapture(VTR.VTR vtr, string fileName, CaptureMetadata metadata)
        {
            lock(_syncRoot)
            {
                if (_currentCapture != null)
                    throw new Exception("Can't start capture, because device is already used!");
                _currentCapture = new Capture(this, vtr, fileName, metadata);
                _currentCapture.Start();
                return _currentCapture;
            }
        }

        public void StopCapture()
        {
            lock(_syncRoot)
            {
                if (_currentCapture == null)
                    throw new Exception("There is no capture in process!");
                _currentCapture.Stop();
            }   
        }

        private void stopped(Capture capture)
        {
            if (_currentCapture == capture)
                _currentCapture = null;
        }

        public class Capture : ICapture
        {

            private WinDVCaptureDevice _device;
            private VTR.VTR _vtr;
            
            private string _fileName;
            private CaptureMetadata _metadata;

            private Thread _thread;
            private Process _process;
            private Stopwatch _lengthStopwatch;

            private ManualResetEvent _stopRequest = new ManualResetEvent(false);
            private ManualResetEvent _stopFailure = new ManualResetEvent(false);

            public Capture(WinDVCaptureDevice device, VTR.VTR vtr, string fileName, CaptureMetadata metadata)
            {
                if (fileName == "")
                    throw new Exception("Filename for capture can't be empty!");
                _device = device;
                _vtr = vtr;
                _fileName = fileName;
                _metadata = metadata;
            }

            #region Property: State
            private CaptureState _state = CaptureState.WaitForStart;

            public CaptureState State
            {
                get { return _state; }
                set
                {
                    _state = value;
                    StateChanged?.Invoke(this, value);
                }
            }

            public event CaptureStateChangedHandler StateChanged;
            #endregion

            #region Property: Length
            private int _length = 0;

            public int Length
            {
                get { return _length; }
                set
                {
                    _length = value;
                    LengthChanged?.Invoke(this, value);
                }
            }
            
            public event CaptureLengthChangedHandler LengthChanged;
            #endregion

            #region Public properties
            public CaptureMetadata Metadata {
                get => _metadata;
            }

            public ICaptureDevice Device {
                get => _device;
            }

            public VTR.VTR UsedVTR {
                get => _vtr;
            }
            #endregion

            public void Start()
            {

                if (State != CaptureState.WaitForStart)
                    throw new Exception("Can't start capture, because it's already started or stoppped!");

                MetadataWriter.Write(this);

                _thread = new Thread(threadMethod);
                _thread.IsBackground = true;
                _thread.Start();

            }

            public void Stop()
            {
                if (State == CaptureState.WaitForStart)
                    throw new Exception("Can't stop capture, because it's not started!");
                _stopRequest.Set();
            }

            private void threadMethod()
            {
                WaitHandle[] waitHandles = new WaitHandle[] { _stopRequest, _stopFailure };
                startThread();
                while (true)
                {
                    if(_process.HasExited)
                        _stopFailure.Set();
                    Thread.Sleep(500);
                    Length = (int)(_lengthStopwatch.ElapsedMilliseconds / 1000);
                    if (WaitHandle.WaitAny(waitHandles, 1) != WaitHandle.WaitTimeout)
                        break;
                }
                stopThread();
            }

            private void startThread()
            {
                ProcessStartInfo psi = getProcessStartInfo();
                _process = Process.Start(psi);
                _lengthStopwatch = new Stopwatch();
                _lengthStopwatch.Start();
                State = CaptureState.Capturing;
            }

            private void stopThread()
            {

                if (_process != null)
                {
                    try
                    {
                        _process.CloseMainWindow();
                        _process.Close();
                    }
                    catch
                    { }
                    _process = null;
                }

                if (_lengthStopwatch != null)
                {
                    _lengthStopwatch.Stop();
                    _lengthStopwatch = null;
                }

                if (_stopRequest.WaitOne(1))
                    State = CaptureState.Stopped;
                else
                    State = CaptureState.Failure;

                _device.stopped(this);

            }

            private ProcessStartInfo getProcessStartInfo()
            {
                string filePath = Settings.FileSavepath + Path.DirectorySeparatorChar + _fileName;
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = false;
                startInfo.UseShellExecute = false;
                startInfo.FileName = WINDV_EXECUTABLE_NAME;
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.Arguments = string.Format("capture {0} {1}", WINDV_CAPTURE_LENGTH, filePath);
                return startInfo;
            }

            private enum StopReason
            {
                Request,
                Failure
            }

        }

    }
}
