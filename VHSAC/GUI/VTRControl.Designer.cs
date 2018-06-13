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
            this.statePanel_Reset = new System.Windows.Forms.Panel();
            this.stateLabel = new System.Windows.Forms.Label();
            this.captureFilenameLabel = new System.Windows.Forms.Label();
            this.captureFilenameTextbox = new System.Windows.Forms.TextBox();
            this.captureFilenameTextboxLabel = new System.Windows.Forms.Label();
            this.editDetailsButton = new System.Windows.Forms.Button();
            this.captureLengthLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.statePanel_Starting = new System.Windows.Forms.Panel();
            this.statePanel_Capturing = new System.Windows.Forms.Panel();
            this.statePanel_Stopping = new System.Windows.Forms.Panel();
            this.statePanel_Ready = new System.Windows.Forms.Panel();
            this.statePanel_ManuallyStopped = new System.Windows.Forms.Panel();
            this.statePanel_Failure = new System.Windows.Forms.Panel();
            this.captureLengthLabelPreText = new System.Windows.Forms.Label();
            this.useInNextBatchCheckbox = new System.Windows.Forms.CheckBox();
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
            // statePanel_Reset
            // 
            this.statePanel_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statePanel_Reset.BackColor = System.Drawing.Color.Aqua;
            this.statePanel_Reset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel_Reset.Location = new System.Drawing.Point(221, 8);
            this.statePanel_Reset.Name = "statePanel_Reset";
            this.statePanel_Reset.Size = new System.Drawing.Size(28, 28);
            this.statePanel_Reset.TabIndex = 1;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(6, 38);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(82, 13);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.Text = "State: capturing";
            // 
            // captureFilenameLabel
            // 
            this.captureFilenameLabel.AutoSize = true;
            this.captureFilenameLabel.Location = new System.Drawing.Point(8, 51);
            this.captureFilenameLabel.Name = "captureFilenameLabel";
            this.captureFilenameLabel.Size = new System.Drawing.Size(75, 13);
            this.captureFilenameLabel.TabIndex = 3;
            this.captureFilenameLabel.Text = "to example.avi";
            // 
            // captureFilenameTextbox
            // 
            this.captureFilenameTextbox.Location = new System.Drawing.Point(102, 80);
            this.captureFilenameTextbox.Name = "captureFilenameTextbox";
            this.captureFilenameTextbox.Size = new System.Drawing.Size(127, 20);
            this.captureFilenameTextbox.TabIndex = 4;
            this.captureFilenameTextbox.TextChanged += new System.EventHandler(this.captureFilenameTextbox_TextChanged);
            // 
            // captureFilenameTextboxLabel
            // 
            this.captureFilenameTextboxLabel.AutoSize = true;
            this.captureFilenameTextboxLabel.Location = new System.Drawing.Point(7, 83);
            this.captureFilenameTextboxLabel.Name = "captureFilenameTextboxLabel";
            this.captureFilenameTextboxLabel.Size = new System.Drawing.Size(89, 13);
            this.captureFilenameTextboxLabel.TabIndex = 5;
            this.captureFilenameTextboxLabel.Text = "Capture filename:";
            // 
            // editDetailsButton
            // 
            this.editDetailsButton.Location = new System.Drawing.Point(235, 78);
            this.editDetailsButton.Name = "editDetailsButton";
            this.editDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.editDetailsButton.TabIndex = 6;
            this.editDetailsButton.Text = "Edit details";
            this.editDetailsButton.UseVisualStyleBackColor = true;
            // 
            // captureLengthLabel
            // 
            this.captureLengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captureLengthLabel.AutoSize = true;
            this.captureLengthLabel.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.captureLengthLabel.Location = new System.Drawing.Point(410, 47);
            this.captureLengthLabel.Name = "captureLengthLabel";
            this.captureLengthLabel.Size = new System.Drawing.Size(98, 21);
            this.captureLengthLabel.TabIndex = 7;
            this.captureLengthLabel.Text = "00:14:33";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(7, 116);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(88, 116);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(169, 116);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // statePanel_Starting
            // 
            this.statePanel_Starting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statePanel_Starting.BackColor = System.Drawing.Color.Yellow;
            this.statePanel_Starting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel_Starting.Location = new System.Drawing.Point(271, 8);
            this.statePanel_Starting.Name = "statePanel_Starting";
            this.statePanel_Starting.Size = new System.Drawing.Size(28, 28);
            this.statePanel_Starting.TabIndex = 2;
            // 
            // statePanel_Capturing
            // 
            this.statePanel_Capturing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statePanel_Capturing.BackColor = System.Drawing.Color.DarkOrange;
            this.statePanel_Capturing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel_Capturing.Location = new System.Drawing.Point(305, 8);
            this.statePanel_Capturing.Name = "statePanel_Capturing";
            this.statePanel_Capturing.Size = new System.Drawing.Size(28, 28);
            this.statePanel_Capturing.TabIndex = 2;
            // 
            // statePanel_Stopping
            // 
            this.statePanel_Stopping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statePanel_Stopping.BackColor = System.Drawing.Color.Yellow;
            this.statePanel_Stopping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel_Stopping.Location = new System.Drawing.Point(339, 8);
            this.statePanel_Stopping.Name = "statePanel_Stopping";
            this.statePanel_Stopping.Size = new System.Drawing.Size(28, 28);
            this.statePanel_Stopping.TabIndex = 2;
            // 
            // statePanel_Ready
            // 
            this.statePanel_Ready.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statePanel_Ready.BackColor = System.Drawing.Color.Lime;
            this.statePanel_Ready.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel_Ready.Location = new System.Drawing.Point(389, 8);
            this.statePanel_Ready.Name = "statePanel_Ready";
            this.statePanel_Ready.Size = new System.Drawing.Size(28, 28);
            this.statePanel_Ready.TabIndex = 2;
            // 
            // statePanel_ManuallyStopped
            // 
            this.statePanel_ManuallyStopped.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statePanel_ManuallyStopped.BackColor = System.Drawing.Color.SeaGreen;
            this.statePanel_ManuallyStopped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel_ManuallyStopped.Location = new System.Drawing.Point(423, 8);
            this.statePanel_ManuallyStopped.Name = "statePanel_ManuallyStopped";
            this.statePanel_ManuallyStopped.Size = new System.Drawing.Size(28, 28);
            this.statePanel_ManuallyStopped.TabIndex = 2;
            // 
            // statePanel_Failure
            // 
            this.statePanel_Failure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statePanel_Failure.BackColor = System.Drawing.Color.Red;
            this.statePanel_Failure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel_Failure.Location = new System.Drawing.Point(473, 8);
            this.statePanel_Failure.Name = "statePanel_Failure";
            this.statePanel_Failure.Size = new System.Drawing.Size(28, 28);
            this.statePanel_Failure.TabIndex = 11;
            // 
            // captureLengthLabelPreText
            // 
            this.captureLengthLabelPreText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captureLengthLabelPreText.AutoSize = true;
            this.captureLengthLabelPreText.Location = new System.Drawing.Point(334, 51);
            this.captureLengthLabelPreText.Name = "captureLengthLabelPreText";
            this.captureLengthLabelPreText.Size = new System.Drawing.Size(79, 13);
            this.captureLengthLabelPreText.TabIndex = 12;
            this.captureLengthLabelPreText.Text = "Capture length:";
            // 
            // useInNextBatchCheckbox
            // 
            this.useInNextBatchCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.useInNextBatchCheckbox.AutoSize = true;
            this.useInNextBatchCheckbox.Location = new System.Drawing.Point(392, 82);
            this.useInNextBatchCheckbox.Name = "useInNextBatchCheckbox";
            this.useInNextBatchCheckbox.Size = new System.Drawing.Size(109, 17);
            this.useInNextBatchCheckbox.TabIndex = 13;
            this.useInNextBatchCheckbox.Text = "Use in next batch";
            this.useInNextBatchCheckbox.UseVisualStyleBackColor = true;
            this.useInNextBatchCheckbox.CheckedChanged += new System.EventHandler(this.useInNextBatchCheckbox_CheckedChanged);
            // 
            // VTRControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.useInNextBatchCheckbox);
            this.Controls.Add(this.captureLengthLabelPreText);
            this.Controls.Add(this.statePanel_Failure);
            this.Controls.Add(this.statePanel_ManuallyStopped);
            this.Controls.Add(this.statePanel_Ready);
            this.Controls.Add(this.statePanel_Stopping);
            this.Controls.Add(this.statePanel_Capturing);
            this.Controls.Add(this.statePanel_Starting);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.captureLengthLabel);
            this.Controls.Add(this.editDetailsButton);
            this.Controls.Add(this.captureFilenameTextboxLabel);
            this.Controls.Add(this.captureFilenameTextbox);
            this.Controls.Add(this.captureFilenameLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.statePanel_Reset);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(7, 3, 7, 4);
            this.Name = "VTRControl";
            this.Size = new System.Drawing.Size(510, 146);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel statePanel_Reset;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label captureFilenameLabel;
        private System.Windows.Forms.TextBox captureFilenameTextbox;
        private System.Windows.Forms.Label captureFilenameTextboxLabel;
        private System.Windows.Forms.Button editDetailsButton;
        private System.Windows.Forms.Label captureLengthLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel statePanel_Starting;
        private System.Windows.Forms.Panel statePanel_Capturing;
        private System.Windows.Forms.Panel statePanel_Stopping;
        private System.Windows.Forms.Panel statePanel_Ready;
        private System.Windows.Forms.Panel statePanel_ManuallyStopped;
        private System.Windows.Forms.Panel statePanel_Failure;
        private System.Windows.Forms.Label captureLengthLabelPreText;
        private System.Windows.Forms.CheckBox useInNextBatchCheckbox;
    }
}
