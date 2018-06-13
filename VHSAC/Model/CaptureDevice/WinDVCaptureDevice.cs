using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VHSAC.Model.CaptureDevice
{
    public class WinDVCaptureDevice: ICaptureDevice
    {

        private Capture _currentCapture;

        private object _syncRoot = new object();

        private static readonly string WINDV_EXECUTABLE_NAME = "windv.exe";

        public ICapture StartCapture(string fileName)
        {
            lock(_syncRoot)
            {
                if (_currentCapture != null)
                    throw new Exception("Can't start capture, because device is already used!");
                _currentCapture = new Capture(this, fileName);
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
            private string _fileName;

            private Thread _thread;
            private Process _process;
            private Stopwatch _lengthStopwatch;

            private ManualResetEvent _stopRequest = new ManualResetEvent(false);
            private ManualResetEvent _stopFailure = new ManualResetEvent(false);

            public Capture(WinDVCaptureDevice device, string fileName)
            {
                _device = device;
                _fileName = fileName;
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

            public void Start()
            {
                if (State != CaptureState.WaitForStart)
                    throw new Exception("Can't start capture, because it's already started or stoppped!");
                _thread = new Thread(threadMethod);
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
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = false;
                startInfo.UseShellExecute = false;
                startInfo.FileName = WINDV_EXECUTABLE_NAME;
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.Arguments = _fileName; // TODO
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
