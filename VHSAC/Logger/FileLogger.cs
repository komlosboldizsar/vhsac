using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VHSAC.Logger
{
    public class FileLogger
    {

        private string _fileName;

        public FileLogger(string fileName)
        {
            _fileName = fileName;
            Logger.Handlers += NewLogMessageHandler;
        }

        public void NewLogMessageHandler(string message)
        {
            using (StreamWriter sw = File.AppendText(_fileName))
            {
                sw.WriteLine(message);
            }
        }

    }
}
