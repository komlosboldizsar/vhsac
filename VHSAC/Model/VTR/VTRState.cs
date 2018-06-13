using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VHSAC.Model.VTR
{
    public enum VTRState
    {
        Reset,
        Starting,
        Capturing,
        Stopping,
        Ready,
        ManuallyStopped,
        Failure
    }
}
