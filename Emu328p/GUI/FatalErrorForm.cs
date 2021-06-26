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
	public partial class FatalErrorForm : MetroForm
	{
		private string errorMessage;

		public FatalErrorForm(Exception exception)
		{
			Exception innerException = exception;

			while (innerException.InnerException != null)
			{
				innerException = innerException.InnerException;
			}

			errorMessage = "Sender: " + UserPrefs.Mail + "\r\n" +
				innerException.Message + "\r\n" +
				innerException.Source + "\r\n" +
				innerException.TargetSite + "\r\n" + 
				innerException.StackTrace;

			InitializeComponent();
			errorTextBox.Text = innerException.Message;
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void sendErrorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MailManager.SendMessage("dp.328emu@gmail.com", "Error", errorMessage);
		}
	}
}
