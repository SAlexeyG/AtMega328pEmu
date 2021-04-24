﻿using Emu328p.Tools;
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
	public partial class PasswordCheckForm : Form
	{
		public PasswordCheckForm()
		{
			InitializeComponent();
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

		private void PasswordCheckForm_Load(object sender, EventArgs e)
		{
			UserPrefs.LoadUserPrefs();
		}

		private void changePassLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			new NewPass().Show();
		}
	}
}
