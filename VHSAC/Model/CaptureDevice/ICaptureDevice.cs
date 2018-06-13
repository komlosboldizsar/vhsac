using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VHSAC.Model.CaptureDevice
{
    public interface ICaptureDevice
    {
        ICapture StartCapture(string fileName);
        void StopCapture();
    }
}
