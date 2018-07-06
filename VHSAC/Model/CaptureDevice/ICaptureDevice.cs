using VHSAC.Model.Metadata;

namespace VHSAC.Model.CaptureDevice
{
    public interface ICaptureDevice
    {

        ICapture StartCapture(VTR.VTR vtr, string fileName, CaptureMetadata metadata);
        void StopCapture();

        string Name { get; }

    }
}
