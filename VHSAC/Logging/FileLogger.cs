using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VHSAC.Logging
{
    public class FileLogger
    {

        private string _fileName;

        public FileLogger(string fileName)
        {
            _fileName = fileName;
            Logger.Handlers += NewLogMessageHandler;
        }

        public void NewLogMessageHandler(string message, LogMessageType type, DateTime timestamp)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(_fileName))
                {
                    string formattedMessage = string.Format("[{0}] {1}", timestamp.ToString("yyyy.MM.dd. HH:mm:ss"), message);
                    sw.WriteLine(formattedMessage);
                }
            }
            catch
            { }
        }

    }
}
