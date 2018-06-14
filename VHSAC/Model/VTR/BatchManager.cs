﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VHSAC.Model.VTR
{
    class BatchManager
    {

        #region Public methods
        public static void Init()
        {
            calculateGlobalState();
        }

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
        #endregion

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

        private static void calculateGlobalState()
        {

            bool canStart = true;
            bool canStop = true;
            bool canReset = true;
            foreach (VTR vtr in Program.VTRs)
            {
                if ((vtr.State == VTRState.Starting) || (vtr.State == VTRState.Capturing) || (vtr.State == VTRState.Stopping))
                    canReset = false;
                if (vtr.UseInNextBatch && (vtr.State != VTRState.Reset))
                    canStart = false;
            }

            CanStart = canStart;
            CanStop = canStop;
            CanReset = canReset;

        }

        public delegate void OperationEnableStateChangedHandler(bool newValue);

        #region Property: CanStart
        private static bool _canStart;

        public static bool CanStart
        {
            get { return _canStart; }
            set
            {
                bool oldValue = _canStart;
                _canStart = value;
                if (oldValue != value)
                    CanStartChanged?.Invoke(value);
            }
        }

        public static event OperationEnableStateChangedHandler CanStartChanged;
        #endregion

        #region Property: CanStop
        private static bool _canStop;

        public static bool CanStop
        {
            get { return _canStop; }
            set
            {
                bool oldValue = _canStop;
                _canStop = value;
                if (oldValue != value)
                    CanStopChanged?.Invoke(value);
            }
        }

        public static event OperationEnableStateChangedHandler CanStopChanged;
        #endregion

        #region Property: CanReset
        private static bool _canReset;

        public static bool CanReset
        {
            get { return _canReset; }
            set
            {
                bool oldValue = _canReset;
                _canReset = value;
                if (oldValue != value)
                    CanResetChanged?.Invoke(value);
            }
        }

        public static event OperationEnableStateChangedHandler CanResetChanged;
        #endregion

    }
}
