using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinProject.WinForms
{
	public partial class Form1 : Form
	{
		private static byte[] file = new byte[0];

		public Form1()
		{
			InitializeComponent();
		}

		private void uploadButton_Click(object sender, EventArgs e)
		{
			try
			{
				file = WinProject.Library.Upload.UploadFile(uploadTextBox.Text);
				statusTextBox.Text = "Status: File is uploaded";
			}
			catch (Exception)
			{
				statusTextBox.Text = "Status: Exception in upload file";
			}
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			try
			{
				if ((overwriteCheckBox.Checked && !File.Exists(saveTextBox.Text)) || !overwriteCheckBox.Checked)
				{
					WinProject.Library.Save.SaveFile(saveTextBox.Text, file);
					statusTextBox.Text = "Status: File is saved";
				}
				else statusTextBox.Text = "Status: File cannot be overwritten";
			}
			catch (Exception)
			{
				statusTextBox.Text = "Status: Exception in save file";
			}
		}

		private void descriptionLabel_Click(object sender, EventArgs e)
		{

		}

		private void saveTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void uploadTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void statusTextBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
