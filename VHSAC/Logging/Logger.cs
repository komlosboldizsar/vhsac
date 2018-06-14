using System;

namespace VHSAC.Logging
{
    public class Logger
    {

        public delegate void NewLogMessageHandler(string message, LogMessageType type, DateTime timestamp);

        public static event NewLogMessageHandler Handlers;

        public static void Log(LogMessageType type, string message, params string[] messageParams)
        {
            string formattedMessage = string.Format(message, messageParams);
            Handlers?.Invoke(formattedMessage, type, DateTime.Now);
        }

        public static void Log(string message, params string[] messageParams)
        {
            Log(LogMessageType.Info, message, messageParams);
        }

    }
}
