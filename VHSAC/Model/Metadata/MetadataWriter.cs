using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VHSAC.Model.CaptureDevice;

namespace VHSAC.Model.Metadata
{
    class MetadataWriter
    {

        private static string _logFileName;
        private static string _csvFileName;

        public static void Init()
        {
            string fileNameTimestamp = DateTime.Now.ToString("yyyyMMdd-HHmmss");
            _logFileName = string.Format("metadata-{0}.log", fileNameTimestamp);
            _csvFileName = string.Format("metadata-{0}.csv", fileNameTimestamp);
        }

        public static void Write(ICapture capture)
        {

            // Write .log
            using (StreamWriter sw = File.AppendText(_logFileName))
            {
                sw.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
                sw.WriteLine("Title: {0}", capture.Metadata.Title);
                sw.WriteLine("Description: {0}", capture.Metadata.Description);
                sw.WriteLine("Tape length: {0} minutes", capture.Metadata.Minutes);
                sw.WriteLine("");
                sw.WriteLine("Capture length: {0} seconds", capture.Length);
                sw.WriteLine("VTR: {0}", capture.UsedVTR.Name);
                sw.WriteLine("Capture device: {0}", capture.Device.Name);
                sw.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<");
                sw.WriteLine("");
            }

            // Write .csv
            using (StreamWriter sw = File.AppendText(_csvFileName))
            {
                sw.WriteLine("\"{0}\";\"{1}\";\"{2}\";\"{3}\";\"{4}\";\"{5}\"",
                    sanitizeForCsv(capture.Metadata.Title),
                    sanitizeForCsv(capture.Metadata.Description),
                    capture.Metadata.Minutes,
                    capture.Length,
                    sanitizeForCsv(capture.UsedVTR.Name),
                    sanitizeForCsv(capture.Device.Name));
            }

        }

        private static string sanitizeForCsv(string str)
        {
            return str.Replace("\"", "\"\"").Replace("\n", "\\n").Replace("\r", "\\r");
        }

    }
}
