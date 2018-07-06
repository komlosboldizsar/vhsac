using VHSAC.Model.Metadata;

namespace VHSAC.Model.CaptureDevice
{

    public interface ICapture
    {

        void Stop();

        CaptureState State { get; }
        event CaptureStateChangedHandler StateChanged;

        int Length { get; }
        event CaptureLengthChangedHandler LengthChanged;

        CaptureMetadata Metadata { get; }
        ICaptureDevice Device { get; }
        VTR.VTR UsedVTR { get; }

    }

    public delegate void CaptureLengthChangedHandler(ICapture capture, int newLength);
    public delegate void CaptureStateChangedHandler(ICapture capture, CaptureState newState);

}
