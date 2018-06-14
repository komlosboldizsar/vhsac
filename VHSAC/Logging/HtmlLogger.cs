using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VHSAC.Logging
{
    public class HtmlLogger
    {

        private string _fileName;

        public HtmlLogger(string fileNamePrefix)
        {
            string fileNameTimestamp = DateTime.Now.ToString("yyyyMMdd-HHmmss");
            _fileName = string.Format("{0}-{1}.html", fileNamePrefix, fileNameTimestamp);
            writeToFile("<span style='color: #888888;'>Start of log.</span><br>");
            Logger.Handlers += NewLogMessageHandler;
        }

        private static readonly string MESSAGE_TEMPLATE = "<span style='color: {3};'>[{0}] [{1}] <strong>{2}</strong></span><br>";

        public void NewLogMessageHandler(string message, LogMessageType type, DateTime timestamp)
        {
            string timestampStr = timestamp.ToString("yyyy.MM.dd. HH:mm:ss");
            string typeStr = type.ToString().ToUpper();
            string colorStr = colorToHex(getColorByType(type));
            string formattedMessage = string.Format(MESSAGE_TEMPLATE, timestampStr, typeStr, message, colorStr);
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

        private static Color getColorByType(LogMessageType type)
        {
            switch (type)
            {
                case LogMessageType.Error:
                    return Color.Red;
                case LogMessageType.Info:
                default:
                    return Color.Black;
            }
        }

        private static string colorToHex(Color color)
        {
            return "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }

    }
}
