namespace VHSAC
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vtrControllerContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.logMessagesTextbox = new System.Windows.Forms.TextBox();
            this.batchManagerControl1 = new VHSAC.GUI.BatchManagerControl();
            this.SuspendLayout();
            // 
            // vtrControllerContainer
            // 
            this.vtrControllerContainer.AutoScroll = true;
            this.vtrControllerContainer.AutoSize = true;
            this.vtrControllerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vtrControllerContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.vtrControllerContainer.Location = new System.Drawing.Point(0, 31);
            this.vtrControllerContainer.Name = "vtrControllerContainer";
            this.vtrControllerContainer.Size = new System.Drawing.Size(539, 238);
            this.vtrControllerContainer.TabIndex = 0;
            this.vtrControllerContainer.WrapContents = false;
            // 
            // logMessagesTextbox
            // 
            this.logMessagesTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logMessagesTextbox.Location = new System.Drawing.Point(0, 269);
            this.logMessagesTextbox.Multiline = true;
            this.logMessagesTextbox.Name = "logMessagesTextbox";
            this.logMessagesTextbox.Size = new System.Drawing.Size(539, 92);
            this.logMessagesTextbox.TabIndex = 0;
            // 
            // batchManagerControl1
            // 
            this.batchManagerControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.batchManagerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.batchManagerControl1.Location = new System.Drawing.Point(0, 0);
            this.batchManagerControl1.Name = "batchManagerControl1";
            this.batchManagerControl1.Size = new System.Drawing.Size(539, 31);
            this.batchManagerControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(539, 361);
            this.Controls.Add(this.vtrControllerContainer);
            this.Controls.Add(this.batchManagerControl1);
            this.Controls.Add(this.logMessagesTextbox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(555, 600);
            this.Name = "MainForm";
            this.Text = "VHS Archivation Controller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel vtrControllerContainer;
        private System.Windows.Forms.TextBox logMessagesTextbox;
        private GUI.BatchManagerControl batchManagerControl1;
    }
}

