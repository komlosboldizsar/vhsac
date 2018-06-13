namespace VHSAC.GUI
{
    partial class VTRControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.statePanel = new System.Windows.Forms.Panel();
            this.stateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.captureFilenameLabel = new System.Windows.Forms.Label();
            this.editDetailsButton = new System.Windows.Forms.Button();
            this.captureLengthLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(3, 8);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(120, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "VTR: example";
            // 
            // statePanel
            // 
            this.statePanel.BackColor = System.Drawing.Color.Red;
            this.statePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel.Location = new System.Drawing.Point(199, 4);
            this.statePanel.Name = "statePanel";
            this.statePanel.Size = new System.Drawing.Size(28, 28);
            this.statePanel.TabIndex = 1;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(231, 5);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(82, 13);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.Text = "State: capturing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "to example.avi";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(99, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 4;
            // 
            // captureFilenameLabel
            // 
            this.captureFilenameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.captureFilenameLabel.AutoSize = true;
            this.captureFilenameLabel.Location = new System.Drawing.Point(4, 47);
            this.captureFilenameLabel.Name = "captureFilenameLabel";
            this.captureFilenameLabel.Size = new System.Drawing.Size(89, 13);
            this.captureFilenameLabel.TabIndex = 5;
            this.captureFilenameLabel.Text = "Capture filename:";
            // 
            // editDetailsButton
            // 
            this.editDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editDetailsButton.Location = new System.Drawing.Point(232, 42);
            this.editDetailsButton.Name = "editDetailsButton";
            this.editDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.editDetailsButton.TabIndex = 6;
            this.editDetailsButton.Text = "Edit details";
            this.editDetailsButton.UseVisualStyleBackColor = true;
            // 
            // captureLengthLabel
            // 
            this.captureLengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.captureLengthLabel.AutoSize = true;
            this.captureLengthLabel.Location = new System.Drawing.Point(358, 12);
            this.captureLengthLabel.Name = "captureLengthLabel";
            this.captureLengthLabel.Size = new System.Drawing.Size(124, 13);
            this.captureLengthLabel.TabIndex = 7;
            this.captureLengthLabel.Text = "Capture length: 00:14:33";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(361, 42);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Location = new System.Drawing.Point(442, 42);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(523, 42);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // VTRControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.captureLengthLabel);
            this.Controls.Add(this.editDetailsButton);
            this.Controls.Add(this.captureFilenameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.statePanel);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 0);
            this.Name = "VTRControl";
            this.Size = new System.Drawing.Size(604, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel statePanel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label captureFilenameLabel;
        private System.Windows.Forms.Button editDetailsButton;
        private System.Windows.Forms.Label captureLengthLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
    }
}
