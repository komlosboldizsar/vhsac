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
            this.batchManagerControl1 = new VHSAC.GUI.BatchManagerControl();
            this.logMessagesTextbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // vtrControllerContainer
            // 
            this.vtrControllerContainer.AutoScroll = true;
            this.vtrControllerContainer.AutoSize = true;
            this.vtrControllerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vtrControllerContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.vtrControllerContainer.Location = new System.Drawing.Point(0, 38);
            this.vtrControllerContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vtrControllerContainer.Name = "vtrControllerContainer";
            this.vtrControllerContainer.Size = new System.Drawing.Size(1132, 498);
            this.vtrControllerContainer.TabIndex = 0;
            this.vtrControllerContainer.WrapContents = false;
            // 
            // batchManagerControl1
            // 
            this.batchManagerControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.batchManagerControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.batchManagerControl1.Location = new System.Drawing.Point(0, 0);
            this.batchManagerControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.batchManagerControl1.Name = "batchManagerControl1";
            this.batchManagerControl1.Size = new System.Drawing.Size(1132, 38);
            this.batchManagerControl1.TabIndex = 0;
            // 
            // logMessagesTextbox
            // 
            this.logMessagesTextbox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logMessagesTextbox.Location = new System.Drawing.Point(0, 536);
            this.logMessagesTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logMessagesTextbox.Name = "logMessagesTextbox";
            this.logMessagesTextbox.ReadOnly = true;
            this.logMessagesTextbox.Size = new System.Drawing.Size(1132, 117);
            this.logMessagesTextbox.TabIndex = 0;
            this.logMessagesTextbox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1132, 653);
            this.Controls.Add(this.vtrControllerContainer);
            this.Controls.Add(this.logMessagesTextbox);
            this.Controls.Add(this.batchManagerControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1150, 1000);
            this.Name = "MainForm";
            this.Text = "VHS Archivation Controller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel vtrControllerContainer;
        private GUI.BatchManagerControl batchManagerControl1;
        private System.Windows.Forms.RichTextBox logMessagesTextbox;
    }
}

