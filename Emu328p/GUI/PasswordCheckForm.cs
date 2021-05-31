using Emu328p.Tools;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emu328p.GUI
{
	public partial class PasswordCheckForm : MetroForm
	{
		public PasswordCheckForm()
		{
			UserPrefs.LoadUserPrefs();
			InitializeComponent();
			greatingLabel.Text += UserPrefs.Login + "!";
		}

		private void checkButton_Click(object sender, EventArgs e)
		{
			if(passwordTextBox.Text == UserPrefs.Password)
			{
				var mainForm = new MainForm();
				mainForm.Show();
				mainForm.FormClosed += (sender1, e1) => Close();
				Visible = false;
			}
			else
			{
				errorLabel.Visible = true;
			}
		}

		private void changePassLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new NewPass().Show();
		}

		private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '\r') return;
			checkButton_Click(sender, e);
		}
	}
}
