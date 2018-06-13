using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VHSAC.Model.VTR
{
    class BatchManager
    {

        public static void Start()
        {

            // Check states
            foreach (VTR vtr in Program.VTRs)
                if (vtr.UseInNextBatch && (vtr.State != VTRState.Reset))
                    throw new Exception(/* TODO */);

            startNextVTR();

        }

        public static void Stop()
        {

            if(currentVTR != null)
                currentVTR.StateChanged -= currentVTRStateChangedHandler;

            foreach (VTR vtr in Program.VTRs)
                if(vtr.State == VTRState.Capturing)
                    vtr.StopCapture();

        }

        public static void ResetAll()
        {

            // Check states
            foreach (VTR vtr in Program.VTRs)
                if ((vtr.State == VTRState.Starting) || (vtr.State == VTRState.Capturing) || (vtr.State == VTRState.Stopping))
                    throw new Exception(/* TODO */);

            // Reset all
            foreach (VTR vtr in Program.VTRs)
                vtr.Reset();

        }

        private static VTR currentVTR;

        private static void startNextVTR()
        {
            getNextUsableVTR();
            if(currentVTR != null)
            {
                currentVTR.StateChanged += currentVTRStateChangedHandler;
                currentVTR.StartCapture();
            }
        }

        private static void currentVTRStateChangedHandler(VTR vtr, VTRState newState)
        {
            if((newState == VTRState.ManuallyStopped) || (newState == VTRState.ManuallyStopped) || (newState == VTRState.Failure))
            {
                currentVTR.StateChanged -= currentVTRStateChangedHandler;
                startNextVTR();
            }
        }

        private static void getNextUsableVTR()
        {
            foreach (VTR vtr in Program.VTRs)
            {
                if (vtr.UseInNextBatch || (vtr.State == VTRState.Reset))
                {
                    currentVTR = vtr;
                    return;
                }
            }
            currentVTR = null;
        }
        

    }
}
