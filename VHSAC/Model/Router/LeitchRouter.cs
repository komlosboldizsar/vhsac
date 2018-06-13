using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VHSAC.Model.Router
{
    public class LeitchRouter: IRouter, IDisposable
    {

        private string _name;

        private SerialPort _serialPort;

        private const int SERIALPORT_BAUDRATE = 9600;
        private const int SERIALPORT_DATABITS = 8;
        private const Parity SERIALPORT_PARITY = Parity.None;
        private const StopBits SERIALPORT_STOPBITS = StopBits.One;

        public LeitchRouter(string name, string portName)
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
                string errMsg = string.Format("Can't open serial port [{0}] for Leitch Router [{1}].", portName, _name);
                throw new Exception(errMsg, e);
            }
        }

        private void closeSerialPort()
        {
            if ((_serialPort != null) && _serialPort.IsOpen)
                _serialPort.Close();
        }

        public void SetCrosspoint(int level, int destination, int source)
        {

            if(!_serialPort.IsOpen)
            {
                string errMsg = string.Format("Can't set crosspoint (L:{0} / S:{1} -> D:{2}) on Leitch Router [{3}], because COM port is closed.", level, source, destination, _name);
                throw new Exception(errMsg);
            }

            _serialPort.WriteLine("l" + level);
            _serialPort.WriteLine("s" + source);
            _serialPort.WriteLine("d" + destination);

        }

        public Crosspoint GetCrosspoint(int level, int destination, int source)
        {
            return new Crosspoint(this, level, destination, source);
        }

        public class Crosspoint: IRouterCrosspoint
        {

            private LeitchRouter _router;

            private int _level;
            private int _destination;
            private int _source;

            public Crosspoint(LeitchRouter router, int level, int destination, int source)
            {
                _router = router;
                _level = level;
                _destination = destination;
                _source = source;
            }

            public void Take()
            {
                _router.SetCrosspoint(_level, _destination, _source);
            }

        }

    }
}
