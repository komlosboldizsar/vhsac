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
                    string timestampStr = timestamp.ToString("yyyy.MM.dd. HH:mm:ss");
                    string typeStr = type.ToString().ToUpper();
                    string formattedMessage = string.Format("[{0}] [{1}] {2}", timestampStr, typeStr, message);
                    sw.WriteLine(formattedMessage);
                }
            }
            catch
            { }
        }

    }
}
