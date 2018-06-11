using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VHSAC.Model.CaptureDevice
{
    public enum CaptureState
    {
        WaitForStart,
        Capturing,
        Stopped,
        Failure
    }
}
