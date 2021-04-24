using Emu328p.Tools;
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
	public partial class Cabinet : Form
	{
		public Cabinet()
		{
			InitializeComponent();
			loginTextBox.Text = UserPrefs.Login;
			passTextBox.Text = UserPrefs.Password;
			mailTextBox.Text = UserPrefs.Mail;
		}

		private void userInfoTextBox_TextChanged(object sender, EventArgs e)
		{
			changeButton.Enabled = 
				loginTextBox.Text != UserPrefs.Login ||
				passTextBox.Text != UserPrefs.Password ||
				mailTextBox.Text != UserPrefs.Mail;
		}

		private void changeButton_Click(object sender, EventArgs e)
		{
			UserPrefs.SaveUserPrefs(loginTextBox.Text, passTextBox.Text, mailTextBox.Text);
			UserPrefs.LoadUserPrefs();
			MessageBox.Show("Данные успешно изменены");
		}
	}
}
