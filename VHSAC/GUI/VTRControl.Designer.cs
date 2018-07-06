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
            this.nameLabel.Location = new System.Drawing.Point(7, 12);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(149, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "VTR: example";
            // 
            // statePanel_Reset
            // 
            this.statePanel_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statePanel_Reset.BackColor = System.Drawing.Color.Aqua;
            this.statePanel_Reset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel_Reset.Location = new System.Drawing.Point(779, 10);
            this.statePanel_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.statePanel_Reset.Name = "statePanel_Reset";
            this.statePanel_Reset.Size = new System.Drawing.Size(37, 34);
            this.statePanel_Reset.TabIndex = 1;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(292, 10);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(108, 17);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.Text = "State: capturing";
            // 
            // captureFilenameLabel
            // 
            this.captureFilenameLabel.AutoSize = true;
            this.captureFilenameLabel.Location = new System.Drawing.Point(293, 24);
            this.captureFilenameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.captureFilenameLabel.Name = "captureFilenameLabel";
            this.captureFilenameLabel.Size = new System.Drawing.Size(98, 17);
            this.captureFilenameLabel.TabIndex = 3;
            this.captureFilenameLabel.Text = "to example.avi";
            // 
            // captureFilenameTextbox
            // 
            this.captureFilenameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.captureFilenameTextbox.Location = new System.Drawing.Point(136, 61);
            this.captureFilenameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.captureFilenameTextbox.Name = "captureFilenameTextbox";
            this.captureFilenameTextbox.Size = new System.Drawing.Size(168, 22);
            this.captureFilenameTextbox.TabIndex = 4;
            this.captureFilenameTextbox.TextChanged += new System.EventHandler(this.captureFilenameTextbox_TextChanged);
            // 
            // captureFilenameTextboxLabel
            // 
            this.captureFilenameTextboxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.captureFilenameTextboxLabel.AutoSize = true;
            this.captureFilenameTextboxLabel.Location = new System.Drawing.Point(9, 61);
            this.captureFilenameTextboxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.captureFilenameTextboxLabel.Name = "captureFilenameTextboxLabel";
            this.captureFilenameTextboxLabel.Size = new System.Drawing.Size(119, 17);
            this.captureFilenameTextboxLabel.TabIndex = 5;
            this.captureFilenameTextboxLabel.Text = "Capture filename:";
            // 
            // editDetailsButton
            // 
            this.editDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editDetailsButton.Location = new System.Drawing.Point(313, 57);
            this.editDetailsButton.Margin = new System.Windows.Forms.Padding(4);
            this.editDetailsButton.Name = "editDetailsButton";
            this.editDetailsButton.Size = new System.Drawing.Size(100, 28);
            this.editDetailsButton.TabIndex = 6;
            this.editDetailsButton.Text = "Edit details";
            this.editDetailsButton.UseVisualStyleBackColor = true;
            this.editDetailsButton.Click += new System.EventHandler(this.editDetailsButton_Click);
            // 
            // captureLengthLabel
            // 
            this.captureLengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captureLengthLabel.AutoSize = true;
            this.captureLengthLabel.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.captureLengthLabel.Location = new System.Drawing.Point(638, 25);
            this.captureLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.captureLengthLabel.Name = "captureLengthLabel";
            this.captureLengthLabel.Size = new System.Drawing.Size(116, 25);
            this.captureLengthLabel.TabIndex = 7;
            this.captureLengthLabel.Text = "00:14:33";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(735, 57);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(80, 28);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Location = new System.Drawing.Point(823, 57);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(80, 28);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(911, 57);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(80, 28);
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
            this.statePanel_Starting.Location = new System.Drawing.Point(839, 10);
            this.statePanel_Starting.Margin = new System.Windows.Forms.Padding(4);
            this.statePanel_Starting.Name = "statePanel_Starting";
            this.statePanel_Starting.Size = new System.Drawing.Size(37, 34);
            this.statePanel_Starting.TabIndex = 2;
            // 
            // statePanel_Capturing
            // 
            this.statePanel_Capturing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statePanel_Capturing.BackColor = System.Drawing.Color.DarkOrange;
            this.statePanel_Capturing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel_Capturing.Location = new System.Drawing.Point(885, 10);
            this.statePanel_Capturing.Margin = new System.Windows.Forms.Padding(4);
            this.statePanel_Capturing.Name = "statePanel_Capturing";
            this.statePanel_Capturing.Size = new System.Drawing.Size(37, 34);
            this.statePanel_Capturing.TabIndex = 2;
            // 
            // statePanel_Stopping
            // 
            this.statePanel_Stopping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statePanel_Stopping.BackColor = System.Drawing.Color.Yellow;
            this.statePanel_Stopping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel_Stopping.Location = new System.Drawing.Point(930, 10);
            this.statePanel_Stopping.Margin = new System.Windows.Forms.Padding(4);
            this.statePanel_Stopping.Name = "statePanel_Stopping";
            this.statePanel_Stopping.Size = new System.Drawing.Size(37, 34);
            this.statePanel_Stopping.TabIndex = 2;
            // 
            // statePanel_Ready
            // 
            this.statePanel_Ready.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statePanel_Ready.BackColor = System.Drawing.Color.Lime;
            this.statePanel_Ready.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel_Ready.Location = new System.Drawing.Point(991, 10);
            this.statePanel_Ready.Margin = new System.Windows.Forms.Padding(4);
            this.statePanel_Ready.Name = "statePanel_Ready";
            this.statePanel_Ready.Size = new System.Drawing.Size(37, 34);
            this.statePanel_Ready.TabIndex = 2;
            // 
            // statePanel_ManuallyStopped
            // 
            this.statePanel_ManuallyStopped.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statePanel_ManuallyStopped.BackColor = System.Drawing.Color.SeaGreen;
            this.statePanel_ManuallyStopped.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel_ManuallyStopped.Location = new System.Drawing.Point(1036, 10);
            this.statePanel_ManuallyStopped.Margin = new System.Windows.Forms.Padding(4);
            this.statePanel_ManuallyStopped.Name = "statePanel_ManuallyStopped";
            this.statePanel_ManuallyStopped.Size = new System.Drawing.Size(37, 34);
            this.statePanel_ManuallyStopped.TabIndex = 2;
            // 
            // statePanel_Failure
            // 
            this.statePanel_Failure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statePanel_Failure.BackColor = System.Drawing.Color.Red;
            this.statePanel_Failure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statePanel_Failure.Location = new System.Drawing.Point(1097, 10);
            this.statePanel_Failure.Margin = new System.Windows.Forms.Padding(4);
            this.statePanel_Failure.Name = "statePanel_Failure";
            this.statePanel_Failure.Size = new System.Drawing.Size(37, 34);
            this.statePanel_Failure.TabIndex = 11;
            // 
            // captureLengthLabelPreText
            // 
            this.captureLengthLabelPreText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.captureLengthLabelPreText.AutoSize = true;
            this.captureLengthLabelPreText.Location = new System.Drawing.Point(644, 7);
            this.captureLengthLabelPreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.captureLengthLabelPreText.Name = "captureLengthLabelPreText";
            this.captureLengthLabelPreText.Size = new System.Drawing.Size(105, 17);
            this.captureLengthLabelPreText.TabIndex = 12;
            this.captureLengthLabelPreText.Text = "Capture length:";
            // 
            // useInNextBatchCheckbox
            // 
            this.useInNextBatchCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.useInNextBatchCheckbox.AutoSize = true;
            this.useInNextBatchCheckbox.Location = new System.Drawing.Point(999, 60);
            this.useInNextBatchCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.useInNextBatchCheckbox.Name = "useInNextBatchCheckbox";
            this.useInNextBatchCheckbox.Size = new System.Drawing.Size(139, 21);
            this.useInNextBatchCheckbox.TabIndex = 13;
            this.useInNextBatchCheckbox.Text = "Use in next batch";
            this.useInNextBatchCheckbox.UseVisualStyleBackColor = true;
            this.useInNextBatchCheckbox.CheckedChanged += new System.EventHandler(this.useInNextBatchCheckbox_CheckedChanged);
            // 
            // VTRControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.Margin = new System.Windows.Forms.Padding(9, 4, 9, 5);
            this.Name = "VTRControl";
            this.Size = new System.Drawing.Size(1142, 95);
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
