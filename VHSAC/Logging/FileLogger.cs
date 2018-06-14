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

        public FileLogger(string fileNamePrefix)
        {
            string fileNameTimestamp = DateTime.Now.ToString("yyyyMMdd-HHmmss");
            _fileName = string.Format("{0}-{1}.log", fileNamePrefix, fileNameTimestamp);
            writeToFile("-- Start of log --");
            Logger.Handlers += NewLogMessageHandler;
        }

        public void NewLogMessageHandler(string message, LogMessageType type, DateTime timestamp)
        {
            string timestampStr = timestamp.ToString("yyyy.MM.dd. HH:mm:ss");
            string typeStr = type.ToString().ToUpper();
            string formattedMessage = string.Format("[{0}] [{1}] {2}", timestampStr, typeStr, message);
            writeToFile(formattedMessage);
        }

        private void writeToFile(string str)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(_fileName))
                {
                    sw.WriteLine(str);
                }
            }
            catch
            { }
        }

    }
}
