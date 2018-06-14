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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadVTRs();
            Logger.Logger.Handlers += NewLogMessageHandler;
        }

        private void loadVTRs()
        {
            foreach(VTR vtr in Program.VTRs)
            {
                UserControl uc = new VTRControl(vtr);
                vtrControllerContainer.Controls.Add(uc);
            }
        }

        private void NewLogMessageHandler(string message, DateTime timestamp)
        {
            string formattedMessage = string.Format("[{0}] {1}\r\n", timestamp.ToString("yyyy.MM.dd. HH:mm:ss"), message);
            logMessagesTextbox.Text += formattedMessage;
            logMessagesTextbox.ScrollToCaret();
        }

    }
}
