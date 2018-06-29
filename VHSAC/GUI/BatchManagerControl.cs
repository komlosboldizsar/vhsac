using System;
using System.Windows.Forms;
using VHSAC.Model.VTR;
using VHSAC.GUI.Helpers;

namespace VHSAC.GUI
{
    public partial class BatchManagerControl : UserControl
    {

        public BatchManagerControl()
        {
            InitializeComponent();
        }

        private void BatchManagerControl_Load(object sender, EventArgs e)
        {
            startBatchButton.Enabled = BatchManager.CanStart;
            stopBatchButton.Enabled = BatchManager.CanStop;
            resetAllButton.Enabled = BatchManager.CanReset;
            subscribeEvents();
        }

        private void subscribeEvents()
        {
            BatchManager.CanStartChanged += BatchManager_CanStartChanged;
            BatchManager.CanStopChanged += BatchManager_CanStopChanged;
            BatchManager.CanResetChanged += BatchManager_CanResetChanged;
        }

        private void unsubscribeEvents()
        {
            BatchManager.CanStartChanged -= BatchManager_CanStartChanged;
            BatchManager.CanStopChanged -= BatchManager_CanStopChanged;
            BatchManager.CanResetChanged -= BatchManager_CanResetChanged;
        }

        private void BatchManager_CanStartChanged(bool newValue)
        {
            this.InvokeIfRequired(control =>
            {
                control.startBatchButton.Enabled = newValue;
            });
        }

        private void BatchManager_CanStopChanged(bool newValue)
        {
            this.InvokeIfRequired(control =>
            {
                control.stopBatchButton.Enabled = newValue;
            });
        }

        private void BatchManager_CanResetChanged(bool newValue)
        {
            this.InvokeIfRequired(control =>
            {
                control.resetAllButton.Enabled = newValue;
            });
        }

        private void startBatchButton_Click(object sender, EventArgs e)
        {
            try
            {
                BatchManager.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void stopBatchButton_Click(object sender, EventArgs e)
        {
            try
            {
                BatchManager.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                BatchManager.ResetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
