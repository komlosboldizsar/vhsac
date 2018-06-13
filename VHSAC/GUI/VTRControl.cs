using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VHSAC.Model.VTR;

namespace VHSAC.GUI
{
    public partial class VTRControl : UserControl
    {

        private VTR _vtr;

        public VTRControl(VTR vtr)
        {

            _vtr = vtr;
            InitializeComponent();
            subscribeEvents();

            setNameLabel(_vtr.Name);
            setStatePanel(_vtr.State);
            setButtonsEnableState(_vtr.State);
            setCaptureLength(0);

        }

        private void subscribeEvents()
        {
            _vtr.CaptureLengthChanged += vtrCaptureLengthChangedHandler;
            _vtr.StateChanged += vtrStateChangedHandler;
        }

        private void vtrStateChangedHandler(VTR vtr, VTRState newState)
        {
            setStatePanel(newState);
            setButtonsEnableState(newState);
        }

        private void vtrCaptureLengthChangedHandler(VTR vtr, int newLength)
        {
            setCaptureLength(newLength);
        }

        private void setNameLabel(string name)
        {
            nameLabel.Text = "VTR: " + name;
        }

        private void setStatePanel(VTRState state)
        {
            if (InvokeRequired) {
                Invoke(new Action(() => setStatePanel(state)), null);
                return;
            }
            switch (state)
            {
                case VTRState.Reset:
                    statePanel.BackColor = Color.LightBlue;
                    break;
                case VTRState.Capturing:
                    statePanel.BackColor = Color.Red;
                    break;
                case VTRState.Ready:
                    statePanel.BackColor = Color.Green;
                    break;
                case VTRState.ManuallyStopped:
                    statePanel.BackColor = Color.DarkGreen;
                    break;
                case VTRState.Failure:
                    statePanel.BackColor = Color.Orange;
                    break;
            }
        }

        private void setButtonsEnableState(VTRState state)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => setButtonsEnableState(state)), null);
                return;
            }
            startButton.Enabled = (state == VTRState.Reset);
            stopButton.Enabled = (state == VTRState.Capturing);
            resetButton.Enabled = (state != VTRState.Capturing);
        }

        private void setCaptureLength(int seconds)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => setCaptureLength(seconds)), null);
                return;
            }
            TimeSpan ts = TimeSpan.FromSeconds(seconds);
            captureLengthLabel.Text = string.Format("Capture length: {0:D2}:{1:D2}:{2:D2}", ts.Hours, ts.Minutes, ts.Seconds);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                _vtr.StartCapture();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            try
            {
                _vtr.StopCapture();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            try
            {
                _vtr.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
