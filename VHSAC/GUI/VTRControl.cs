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
using VHSAC.GUI.Helpers;

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
            updateByStateChange(_vtr.State);
            setCaptureFilename(_vtr.CaptureFilename);
            setUseInNextBatch(_vtr.UseInNextBatch);
            setCaptureLength(0);

        }

        private void subscribeEvents()
        {
            _vtr.CaptureLengthChanged += vtrCaptureLengthChangedHandler;
            _vtr.StateChanged += vtrStateChangedHandler;
            _vtr.CaptureFilenameChanged += vtrCaptureFilenameChangedHandler;
            _vtr.UseInNextBatchChanged += vtrUseInNextBatchChangedHandler;
        }

        #region Property change event handlers
        private void vtrStateChangedHandler(VTR vtr, VTRState newState)
        {
            this.InvokeIfRequired(vtrControl => {
                vtrControl.updateByStateChange(newState);
            });
        }

        private void vtrCaptureLengthChangedHandler(VTR vtr, int newLength)
        {
            this.InvokeIfRequired(vtrControl =>
            {
                vtrControl.setCaptureLength(newLength);
            });
        }

        private void vtrCaptureFilenameChangedHandler(VTR vtr, string newCaptureFilename)
        {
            setCaptureFilename(newCaptureFilename);
        }

        private void vtrUseInNextBatchChangedHandler(VTR vtr, bool newValue)
        {
            setUseInNextBatch(newValue);
        }
        #endregion

        #region UI updater methods
        private void setNameLabel(string name)
        {
            nameLabel.Text = "VTR: " + name;
        }

        private void updateByStateChange(VTRState newState)
        {
            setStatePanels(newState);
            setStateLabel(newState);
            setButtonsEnableState(newState);
            setOtherElementsEnableState(newState);
        }

        private void setStatePanels(VTRState state)
        {
            statePanel_Reset.BackColor = (state == VTRState.Reset) ? Color.Aqua : Color.White;
            statePanel_Starting.BackColor = (state == VTRState.Starting) ? Color.Yellow : Color.White;
            statePanel_Capturing.BackColor = (state == VTRState.Capturing) ? Color.DarkOrange : Color.White;
            statePanel_Stopping.BackColor = (state == VTRState.Stopping) ? Color.Yellow : Color.White;
            statePanel_Ready.BackColor = (state == VTRState.Ready) ? Color.Lime : Color.White;
            statePanel_ManuallyStopped.BackColor = (state == VTRState.ManuallyStopped) ? Color.SeaGreen : Color.White;
            statePanel_Failure.BackColor = (state == VTRState.Failure) ? Color.Red : Color.White;
        }

        private void setStateLabel(VTRState state)
        {

            string stateLabelText = "";
            switch (state)
            {
                case VTRState.Reset:
                    stateLabelText = "reset";
                    break;
                case VTRState.Starting:
                    stateLabelText = "starting capturing";
                    break;
                case VTRState.Capturing:
                    stateLabelText = "capturing";
                    break;
                case VTRState.Stopping:
                    stateLabelText = "stopping capturing";
                    break;
                case VTRState.Ready:
                    stateLabelText = "ready";
                    break;
                case VTRState.ManuallyStopped:
                    stateLabelText = "ready (manually stopped)";
                    break;
                case VTRState.Failure:
                    stateLabelText = "failure";
                    break;
            }
            stateLabel.Text = "State: " + stateLabelText;

            captureFilenameLabel.Visible = (state == VTRState.Starting);

        }

        private void setButtonsEnableState(VTRState state)
        {
            startButton.Enabled = (state == VTRState.Reset);
            stopButton.Enabled = (state == VTRState.Capturing);
            resetButton.Enabled = (state != VTRState.Capturing);
        }

        private void setOtherElementsEnableState(VTRState state)
        {
            captureFilenameTextbox.Enabled = (state == VTRState.Reset);
            useInNextBatchCheckbox.Enabled = (state == VTRState.Reset);
            editDetailsButton.Enabled = (state == VTRState.Reset);
        }

        private void setCaptureFilename(string captureFilename)
        {
            if (captureFilename != captureFilenameTextbox.Text)
                captureFilenameTextbox.Text = captureFilename;
            captureFilenameLabel.Text = captureFilename;
        }

        private void setUseInNextBatch(bool use)
        {
            if (use != useInNextBatchCheckbox.Checked)
                useInNextBatchCheckbox.Checked = use;
        }

        private void setCaptureLength(int seconds)
        {
            TimeSpan ts = TimeSpan.FromSeconds(seconds);
            captureLengthLabel.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", ts.Hours, ts.Minutes, ts.Seconds);
        }
        #endregion

        #region Button click handlers
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
        #endregion

        #region UI change handlers
        private void captureFilenameTextbox_TextChanged(object sender, EventArgs e)
        {
            _vtr.CaptureFilename = captureFilenameTextbox.Text;
        }

        private void useInNextBatchCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            _vtr.UseInNextBatch = useInNextBatchCheckbox.Checked;
        }
        #endregion

    }
}
