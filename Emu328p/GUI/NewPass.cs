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
	public partial class NewPass : Form
	{
		private string secretCode = string.Empty;

		public NewPass()
		{
			InitializeComponent();
			SendSecretCode();
		}

		private void SendSecretCode()
		{
			Random rand = new Random();
			byte[] byteBuffer = new byte[3];
			rand.NextBytes(byteBuffer);

			foreach (byte b in byteBuffer)
			{
				secretCode += Convert.ToString(b, 16).ToUpper();
			}

			MailManager.SendMessage(UserPrefs.Mail, "Смена пароля", $"Секретный код: {secretCode}");
		}

		private void checkButton_Click(object sender, EventArgs e)
		{
			if (codeTextBox.Text == secretCode)
			{
				UserPrefs.SaveUserPrefs(UserPrefs.Login, newPassTextBox.Text, UserPrefs.Mail);
				UserPrefs.LoadUserPrefs();
				MessageBox.Show("Пароль успешно сменен");
				Close();
			}
			else
			{
				codeErrorLabel.Visible = true;
			}
		}

		private void sendErrorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SendSecretCode();
		}

		private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '\r') return;
			checkButton_Click(sender, e);
		}
	}
}
