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
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetAllButton = new System.Windows.Forms.Button();
            this.stopBatchButton = new System.Windows.Forms.Button();
            this.startBatchButton = new System.Windows.Forms.Button();
            this.logMessagesTextbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vtrControllerContainer
            // 
            this.vtrControllerContainer.AutoScroll = true;
            this.vtrControllerContainer.AutoSize = true;
            this.vtrControllerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vtrControllerContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.vtrControllerContainer.Location = new System.Drawing.Point(0, 35);
            this.vtrControllerContainer.Name = "vtrControllerContainer";
            this.vtrControllerContainer.Size = new System.Drawing.Size(539, 234);
            this.vtrControllerContainer.TabIndex = 0;
            this.vtrControllerContainer.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.resetAllButton);
            this.panel1.Controls.Add(this.stopBatchButton);
            this.panel1.Controls.Add(this.startBatchButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 35);
            this.panel1.TabIndex = 0;
            // 
            // resetAllButton
            // 
            this.resetAllButton.Location = new System.Drawing.Point(452, 6);
            this.resetAllButton.Name = "resetAllButton";
            this.resetAllButton.Size = new System.Drawing.Size(75, 23);
            this.resetAllButton.TabIndex = 2;
            this.resetAllButton.Text = "Reset all";
            this.resetAllButton.UseVisualStyleBackColor = true;
            this.resetAllButton.Click += new System.EventHandler(this.resetAllButton_Click);
            // 
            // stopBatchButton
            // 
            this.stopBatchButton.Location = new System.Drawing.Point(89, 6);
            this.stopBatchButton.Name = "stopBatchButton";
            this.stopBatchButton.Size = new System.Drawing.Size(75, 23);
            this.stopBatchButton.TabIndex = 1;
            this.stopBatchButton.Text = "Stop batch";
            this.stopBatchButton.UseVisualStyleBackColor = true;
            this.stopBatchButton.Click += new System.EventHandler(this.stopBatchButton_Click);
            // 
            // startBatchButton
            // 
            this.startBatchButton.Location = new System.Drawing.Point(8, 6);
            this.startBatchButton.Name = "startBatchButton";
            this.startBatchButton.Size = new System.Drawing.Size(75, 23);
            this.startBatchButton.TabIndex = 0;
            this.startBatchButton.Text = "Start batch";
            this.startBatchButton.UseVisualStyleBackColor = true;
            this.startBatchButton.Click += new System.EventHandler(this.startBatchButton_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(539, 361);
            this.Controls.Add(this.vtrControllerContainer);
            this.Controls.Add(this.logMessagesTextbox);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(555, 600);
            this.Name = "MainForm";
            this.Text = "VHS Archivation Controller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel vtrControllerContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startBatchButton;
        private System.Windows.Forms.Button resetAllButton;
        private System.Windows.Forms.Button stopBatchButton;
        private System.Windows.Forms.TextBox logMessagesTextbox;
    }
}

