namespace VHSAC.GUI
{
    partial class BatchManagerControl
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
            if (disposing)
            {
                unsubscribeEvents();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startBatchButton = new System.Windows.Forms.Button();
            this.stopBatchButton = new System.Windows.Forms.Button();
            this.resetAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBatchButton
            // 
            this.startBatchButton.Location = new System.Drawing.Point(4, 4);
            this.startBatchButton.Name = "startBatchButton";
            this.startBatchButton.Size = new System.Drawing.Size(75, 23);
            this.startBatchButton.TabIndex = 0;
            this.startBatchButton.Text = "Start batch";
            this.startBatchButton.UseVisualStyleBackColor = true;
            this.startBatchButton.Click += new System.EventHandler(this.startBatchButton_Click);
            // 
            // stopBatchButton
            // 
            this.stopBatchButton.Location = new System.Drawing.Point(86, 4);
            this.stopBatchButton.Name = "stopBatchButton";
            this.stopBatchButton.Size = new System.Drawing.Size(75, 23);
            this.stopBatchButton.TabIndex = 1;
            this.stopBatchButton.Text = "Stop batch";
            this.stopBatchButton.UseVisualStyleBackColor = true;
            this.stopBatchButton.Click += new System.EventHandler(this.stopBatchButton_Click);
            // 
            // resetAllButton
            // 
            this.resetAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetAllButton.Location = new System.Drawing.Point(263, 4);
            this.resetAllButton.Name = "resetAllButton";
            this.resetAllButton.Size = new System.Drawing.Size(75, 23);
            this.resetAllButton.TabIndex = 2;
            this.resetAllButton.Text = "Reset all";
            this.resetAllButton.UseVisualStyleBackColor = true;
            this.resetAllButton.Click += new System.EventHandler(this.resetAllButton_Click);
            // 
            // BatchManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.resetAllButton);
            this.Controls.Add(this.stopBatchButton);
            this.Controls.Add(this.startBatchButton);
            this.Name = "BatchManagerControl";
            this.Size = new System.Drawing.Size(341, 31);
            this.Load += new System.EventHandler(this.BatchManagerControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBatchButton;
        private System.Windows.Forms.Button stopBatchButton;
        private System.Windows.Forms.Button resetAllButton;
    }
}
