namespace VHSAC.GUI
{
    partial class MetadataEditorForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthNumericInput = new System.Windows.Forms.NumericUpDown();
            this.lengthUnitLabel = new System.Windows.Forms.Label();
            this.lengthButton60 = new System.Windows.Forms.Button();
            this.lengthButton90 = new System.Windows.Forms.Button();
            this.lengthButton120 = new System.Windows.Forms.Button();
            this.lengthButton150 = new System.Windows.Forms.Button();
            this.lengthButton180 = new System.Windows.Forms.Button();
            this.lengthButton195 = new System.Windows.Forms.Button();
            this.lengthButton200 = new System.Windows.Forms.Button();
            this.lengthButton210 = new System.Windows.Forms.Button();
            this.lengthButton300 = new System.Windows.Forms.Button();
            this.lengthButton270 = new System.Windows.Forms.Button();
            this.lengthButton240 = new System.Windows.Forms.Button();
            this.saveAndCloseButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumericInput)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextbox
            // 
            this.titleTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextbox.Location = new System.Drawing.Point(134, 12);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(677, 22);
            this.titleTextbox.TabIndex = 1;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextbox.Location = new System.Drawing.Point(134, 40);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(677, 92);
            this.descriptionTextbox.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 43);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(12, 142);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(56, 17);
            this.lengthLabel.TabIndex = 4;
            this.lengthLabel.Text = "Length:";
            // 
            // lengthNumericInput
            // 
            this.lengthNumericInput.Location = new System.Drawing.Point(134, 140);
            this.lengthNumericInput.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.lengthNumericInput.Name = "lengthNumericInput";
            this.lengthNumericInput.Size = new System.Drawing.Size(76, 22);
            this.lengthNumericInput.TabIndex = 5;
            // 
            // lengthUnitLabel
            // 
            this.lengthUnitLabel.AutoSize = true;
            this.lengthUnitLabel.Location = new System.Drawing.Point(216, 142);
            this.lengthUnitLabel.Name = "lengthUnitLabel";
            this.lengthUnitLabel.Size = new System.Drawing.Size(34, 17);
            this.lengthUnitLabel.TabIndex = 6;
            this.lengthUnitLabel.Text = "min.";
            // 
            // lengthButton60
            // 
            this.lengthButton60.Location = new System.Drawing.Point(256, 138);
            this.lengthButton60.Name = "lengthButton60";
            this.lengthButton60.Size = new System.Drawing.Size(45, 25);
            this.lengthButton60.TabIndex = 7;
            this.lengthButton60.Tag = "60";
            this.lengthButton60.Text = "60";
            this.lengthButton60.UseVisualStyleBackColor = true;
            this.lengthButton60.Click += new System.EventHandler(this.lengthButtonClick);
            // 
            // lengthButton90
            // 
            this.lengthButton90.Location = new System.Drawing.Point(307, 138);
            this.lengthButton90.Name = "lengthButton90";
            this.lengthButton90.Size = new System.Drawing.Size(45, 25);
            this.lengthButton90.TabIndex = 8;
            this.lengthButton90.Tag = "90";
            this.lengthButton90.Text = "90";
            this.lengthButton90.UseVisualStyleBackColor = true;
            // 
            // lengthButton120
            // 
            this.lengthButton120.Location = new System.Drawing.Point(358, 138);
            this.lengthButton120.Name = "lengthButton120";
            this.lengthButton120.Size = new System.Drawing.Size(45, 25);
            this.lengthButton120.TabIndex = 9;
            this.lengthButton120.Tag = "120";
            this.lengthButton120.Text = "120";
            this.lengthButton120.UseVisualStyleBackColor = true;
            // 
            // lengthButton150
            // 
            this.lengthButton150.Location = new System.Drawing.Point(409, 138);
            this.lengthButton150.Name = "lengthButton150";
            this.lengthButton150.Size = new System.Drawing.Size(45, 25);
            this.lengthButton150.TabIndex = 10;
            this.lengthButton150.Tag = "150";
            this.lengthButton150.Text = "150";
            this.lengthButton150.UseVisualStyleBackColor = true;
            // 
            // lengthButton180
            // 
            this.lengthButton180.Location = new System.Drawing.Point(460, 138);
            this.lengthButton180.Name = "lengthButton180";
            this.lengthButton180.Size = new System.Drawing.Size(45, 25);
            this.lengthButton180.TabIndex = 11;
            this.lengthButton180.Tag = "180";
            this.lengthButton180.Text = "180";
            this.lengthButton180.UseVisualStyleBackColor = true;
            // 
            // lengthButton195
            // 
            this.lengthButton195.Location = new System.Drawing.Point(511, 138);
            this.lengthButton195.Name = "lengthButton195";
            this.lengthButton195.Size = new System.Drawing.Size(45, 25);
            this.lengthButton195.TabIndex = 12;
            this.lengthButton195.Tag = "195";
            this.lengthButton195.Text = "195";
            this.lengthButton195.UseVisualStyleBackColor = true;
            // 
            // lengthButton200
            // 
            this.lengthButton200.Location = new System.Drawing.Point(562, 138);
            this.lengthButton200.Name = "lengthButton200";
            this.lengthButton200.Size = new System.Drawing.Size(45, 25);
            this.lengthButton200.TabIndex = 13;
            this.lengthButton200.Tag = "200";
            this.lengthButton200.Text = "200";
            this.lengthButton200.UseVisualStyleBackColor = true;
            // 
            // lengthButton210
            // 
            this.lengthButton210.Location = new System.Drawing.Point(613, 138);
            this.lengthButton210.Name = "lengthButton210";
            this.lengthButton210.Size = new System.Drawing.Size(45, 25);
            this.lengthButton210.TabIndex = 14;
            this.lengthButton210.Tag = "210";
            this.lengthButton210.Text = "210";
            this.lengthButton210.UseVisualStyleBackColor = true;
            // 
            // lengthButton300
            // 
            this.lengthButton300.Location = new System.Drawing.Point(766, 138);
            this.lengthButton300.Name = "lengthButton300";
            this.lengthButton300.Size = new System.Drawing.Size(45, 25);
            this.lengthButton300.TabIndex = 17;
            this.lengthButton300.Tag = "300";
            this.lengthButton300.Text = "300";
            this.lengthButton300.UseVisualStyleBackColor = true;
            // 
            // lengthButton270
            // 
            this.lengthButton270.Location = new System.Drawing.Point(715, 138);
            this.lengthButton270.Name = "lengthButton270";
            this.lengthButton270.Size = new System.Drawing.Size(45, 25);
            this.lengthButton270.TabIndex = 16;
            this.lengthButton270.Tag = "270";
            this.lengthButton270.Text = "270";
            this.lengthButton270.UseVisualStyleBackColor = true;
            // 
            // lengthButton240
            // 
            this.lengthButton240.Location = new System.Drawing.Point(664, 138);
            this.lengthButton240.Name = "lengthButton240";
            this.lengthButton240.Size = new System.Drawing.Size(45, 25);
            this.lengthButton240.TabIndex = 15;
            this.lengthButton240.Tag = "240";
            this.lengthButton240.Text = "240";
            this.lengthButton240.UseVisualStyleBackColor = true;
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAndCloseButton.Location = new System.Drawing.Point(666, 204);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(145, 27);
            this.saveAndCloseButton.TabIndex = 18;
            this.saveAndCloseButton.Text = "Save and close";
            this.saveAndCloseButton.UseVisualStyleBackColor = true;
            this.saveAndCloseButton.Click += new System.EventHandler(this.saveAndCloseButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(585, 204);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 27);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // MetadataEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 243);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveAndCloseButton);
            this.Controls.Add(this.lengthButton300);
            this.Controls.Add(this.lengthButton270);
            this.Controls.Add(this.lengthButton240);
            this.Controls.Add(this.lengthButton210);
            this.Controls.Add(this.lengthButton200);
            this.Controls.Add(this.lengthButton195);
            this.Controls.Add(this.lengthButton180);
            this.Controls.Add(this.lengthButton150);
            this.Controls.Add(this.lengthButton120);
            this.Controls.Add(this.lengthButton90);
            this.Controls.Add(this.lengthButton60);
            this.Controls.Add(this.lengthUnitLabel);
            this.Controls.Add(this.lengthNumericInput);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.titleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MetadataEditorForm";
            this.Text = "Edit metadata";
            this.Load += new System.EventHandler(this.MetadataEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumericInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.NumericUpDown lengthNumericInput;
        private System.Windows.Forms.Label lengthUnitLabel;
        private System.Windows.Forms.Button lengthButton60;
        private System.Windows.Forms.Button lengthButton90;
        private System.Windows.Forms.Button lengthButton120;
        private System.Windows.Forms.Button lengthButton150;
        private System.Windows.Forms.Button lengthButton180;
        private System.Windows.Forms.Button lengthButton195;
        private System.Windows.Forms.Button lengthButton200;
        private System.Windows.Forms.Button lengthButton210;
        private System.Windows.Forms.Button lengthButton300;
        private System.Windows.Forms.Button lengthButton270;
        private System.Windows.Forms.Button lengthButton240;
        private System.Windows.Forms.Button saveAndCloseButton;
        private System.Windows.Forms.Button cancelButton;
    }
}