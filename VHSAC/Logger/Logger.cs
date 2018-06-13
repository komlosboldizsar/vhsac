using System;

namespace VHSAC.Logger
{
    public class Logger
    {

        public delegate void NewLogMessageHandler(string message, DateTime timestamp);
        public static event NewLogMessageHandler Handlers;

        public static void Log(string message)
        {
            Handlers?.Invoke(message, DateTime.Now);
        }

    }
}
