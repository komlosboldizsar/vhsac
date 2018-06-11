using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VHSAC.Model.CaptureDevice
{

    public interface ICapture
    {

        void Stop();

        CaptureState State { get; }
        event CaptureStateChangedHandler StateChanged;

        int Length { get; }
        event CaptureLengthChangedHandler LengthChanged;

    }

    public delegate void CaptureLengthChangedHandler(ICapture capture, int newLength);
    public delegate void CaptureStateChangedHandler(ICapture capture, CaptureState newState);

}
