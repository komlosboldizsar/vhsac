using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VHSAC.GUI;
using VHSAC.Model.VTR;

namespace VHSAC
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            loadVTRs();
        }

        private void loadVTRs()
        {
            foreach(VTR vtr in Program.VTRs)
            {
                UserControl uc = new VTRControl(vtr);
                vtrControllerContainer.Controls.Add(uc);
            }
        }

        #region Button click handlers
        private void startBatchButton_Click(object sender, EventArgs e)
        {
            BatchManager.Start();
        }

        private void stopBatchButton_Click(object sender, EventArgs e)
        {
            BatchManager.Stop();
        }

        private void resetAllButton_Click(object sender, EventArgs e)
        {
            BatchManager.ResetAll();
        }
        #endregion

    }
}
