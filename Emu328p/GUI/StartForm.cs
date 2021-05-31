﻿using Emu328p.Tools;
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
	public partial class StartForm : MetroForm
	{
		public StartForm()
		{
			InitializeComponent();
			greatingLabel.Text += Environment.UserName + "!";
		}

		private void registrateButton_Click(object sender, EventArgs e)
		{
			if(!MailManager.IsMailValid(mailTextBox.Text))
			{
				MessageBox.Show("Неверный формат почты");
				return;
			}

			UserPrefs.SaveUserPrefs(Environment.UserName, passwordTextBox.Text, mailTextBox.Text);
			var checkForm = new PasswordCheckForm();
			checkForm.Show();
			checkForm.FormClosed += (sender1, e1) => Close();
			Visible = false;
		}

		private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '\r') return;
			registrateButton_Click(sender, e);
		}
	}
}
