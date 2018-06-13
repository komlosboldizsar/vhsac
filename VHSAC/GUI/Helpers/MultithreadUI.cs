using System;
using System.ComponentModel;

namespace VHSAC.GUI.Helpers
{
    static class MultithreadUI
    {
        public static void InvokeIfRequired<T>(this T control, Action<T> action) where T : ISynchronizeInvoke
        {
            if (control.InvokeRequired)
                control.Invoke(new Action(() => action(control)), null);
            else
                action(control);
        }

    }
}
