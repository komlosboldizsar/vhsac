using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VHSAC.Model.VTRController
{
    public class Controller
    {

        private string _name;

        private SerialPort _serialPort;

        private const int SERIALPORT_BAUDRATE = 9600;
        private const int SERIALPORT_DATABITS = 8;
        private const Parity SERIALPORT_PARITY = Parity.None;
        private const StopBits SERIALPORT_STOPBITS = StopBits.One;

        public Controller(string name, string portName)
        {
            _name = name;
            openSerialPort(portName);
        }

        public void Dispose()
        {
            closeSerialPort();
        }

        private void openSerialPort(string portName)
        {
            try
            {
                _serialPort = new SerialPort(portName, SERIALPORT_BAUDRATE, SERIALPORT_PARITY, SERIALPORT_DATABITS, SERIALPORT_STOPBITS);
                _serialPort.Open();
            }
            catch (Exception e)
            {
                string errMsg = string.Format("Can't open serial port [{0}] for VTR controller [{1}].", portName, _name);
                throw new Exception(errMsg, e);
            }
        }

        private void closeSerialPort()
        {
            if ((_serialPort != null) && _serialPort.IsOpen)
                _serialPort.Close();
        }

        public void StartVTR(int channel)
        {

            if (!_serialPort.IsOpen)
            {
                string errMsg = string.Format("Can't start VTR [#{0}] with controller [{1}], because COM port is closed.", channel, _name);
                throw new Exception(errMsg);
            }

            string playCmd = string.Format("{0}p", channel);
            _serialPort.Write(playCmd);

        }

        public void StopVTR(int channel)
        {

            if (!_serialPort.IsOpen)
            {
                string errMsg = string.Format("Can't stop VTR [#{0}] with controller [{1}], because COM port is closed.", channel, _name);
                throw new Exception(errMsg);
            }

            string playCmd = string.Format("{0}s", channel);
            _serialPort.Write(playCmd);

        }

        public PhysicalVTRState GetVTRState(int channel)
        {

            if (!_serialPort.IsOpen)
            {
                string errMsg = string.Format("Can't get VTR [#{0}] state with controller [{1}], because COM port is closed.", channel, _name);
                throw new Exception(errMsg);
            }

            _serialPort.ReadExisting();
            string playCmd = string.Format("{0}?", channel);
            _serialPort.Write(playCmd);
            string reply = _serialPort.ReadLine();
            return PhysicalVTRStateConverter.Convert(reply);

        }

        public Adapter GetAdapter(int channel)
        {
            return new Adapter(this, channel);
        }

        public class Adapter
        {

            private Controller _controller;
            private int _channel;

            public Adapter(Controller controller, int channel)
            {
                _controller = controller;
                _channel = channel;
            }

            public void StartVTR()
            {
                _controller.StartVTR(_channel);
            }

            public void StopVTR()
            {
                _controller.StopVTR(_channel);
            }

            public PhysicalVTRState GetVTRState()
            {
                return _controller.GetVTRState(_channel);
            }

        }

    }
}
