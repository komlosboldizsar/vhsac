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
            this.SuspendLayout();
            // 
            // vtrControllerContainer
            // 
            this.vtrControllerContainer.AutoScroll = true;
            this.vtrControllerContainer.AutoSize = true;
            this.vtrControllerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vtrControllerContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.vtrControllerContainer.Location = new System.Drawing.Point(0, 0);
            this.vtrControllerContainer.Name = "vtrControllerContainer";
            this.vtrControllerContainer.Size = new System.Drawing.Size(540, 361);
            this.vtrControllerContainer.TabIndex = 0;
            this.vtrControllerContainer.WrapContents = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(540, 361);
            this.Controls.Add(this.vtrControllerContainer);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.Name = "MainForm";
            this.Text = "VHS Archivation Controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel vtrControllerContainer;
    }
}

