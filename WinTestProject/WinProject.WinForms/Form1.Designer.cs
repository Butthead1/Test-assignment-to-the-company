namespace WinProject.WinForms
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.uploadTextBox = new System.Windows.Forms.TextBox();
            this.saveTextBox = new System.Windows.Forms.TextBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.overwriteCheckBox = new System.Windows.Forms.CheckBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AccessibleName = "descriptionLabel";
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(330, 15);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "This is test application. First file will be copied in second path.";
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // uploadTextBox
            // 
            this.uploadTextBox.AccessibleName = "uploadTextBox";
            this.uploadTextBox.Location = new System.Drawing.Point(79, 27);
            this.uploadTextBox.Name = "uploadTextBox";
            this.uploadTextBox.Size = new System.Drawing.Size(343, 23);
            this.uploadTextBox.TabIndex = 1;
            this.uploadTextBox.TextChanged += new System.EventHandler(this.uploadTextBox_TextChanged);
            // 
            // saveTextBox
            // 
            this.saveTextBox.AccessibleName = "saveTextBox";
            this.saveTextBox.Location = new System.Drawing.Point(79, 56);
            this.saveTextBox.Name = "saveTextBox";
            this.saveTextBox.Size = new System.Drawing.Size(343, 23);
            this.saveTextBox.TabIndex = 2;
            this.saveTextBox.TextChanged += new System.EventHandler(this.saveTextBox_TextChanged);
            // 
            // uploadButton
            // 
            this.uploadButton.AccessibleName = "uploadButton";
            this.uploadButton.Location = new System.Drawing.Point(12, 27);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(61, 23);
            this.uploadButton.TabIndex = 3;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AccessibleName = "saveButton";
            this.saveButton.Location = new System.Drawing.Point(12, 56);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(61, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // overwriteCheckBox
            // 
            this.overwriteCheckBox.AccessibleName = "overwriteCheckBox";
            this.overwriteCheckBox.AutoSize = true;
            this.overwriteCheckBox.Location = new System.Drawing.Point(428, 59);
            this.overwriteCheckBox.Name = "overwriteCheckBox";
            this.overwriteCheckBox.Size = new System.Drawing.Size(134, 19);
            this.overwriteCheckBox.TabIndex = 5;
            this.overwriteCheckBox.Text = "DO NOT OVERWRITE";
            this.overwriteCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusTextBox
            // 
            this.statusTextBox.AccessibleName = "statusTextBox";
            this.statusTextBox.Location = new System.Drawing.Point(428, 27);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(244, 23);
            this.statusTextBox.TabIndex = 6;
            this.statusTextBox.Text = "Status: File is not uploaded.";
            this.statusTextBox.TextChanged += new System.EventHandler(this.statusTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AccessibleName = "Form1";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 93);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.overwriteCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.saveTextBox);
            this.Controls.Add(this.uploadTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.TextBox uploadTextBox;
		private System.Windows.Forms.TextBox saveTextBox;
		private System.Windows.Forms.Button uploadButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.CheckBox overwriteCheckBox;
		private System.Windows.Forms.TextBox statusTextBox;
	}
}
