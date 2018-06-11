using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VHSAC.Logger
{
    public class Logger
    {

        public delegate void NewLogMessageHandler(string message);
        public static event NewLogMessageHandler Handlers;

        public static void Log(string message)
        {
            Handlers?.Invoke(message);
        }

    }
}
