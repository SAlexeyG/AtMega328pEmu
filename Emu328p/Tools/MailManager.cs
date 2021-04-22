using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emu328p.Tools
{
	static class MailManager
	{
		private const string smtpClient = "smtp.gmail.com";
		private const string senderMail = "dp.328emu@gmail.com";
		private const string senderPass = "4kDP35_tp";
		private const string emailMask = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";

		public static void SendMessage(string email, string subject, string body)
		{
			SmtpClient Smtp = new SmtpClient(smtpClient, 587);
			Smtp.Credentials = new NetworkCredential(senderMail, senderPass);
			Smtp.EnableSsl = true;

			MailMessage message = new MailMessage();
			message.From = new MailAddress(senderMail);
			message.To.Add(new MailAddress(email));
			message.Subject = subject;
			message.Body = body;

			try
			{
				Smtp.Send(message);
				MessageBox.Show("Сообщение отправлено");
			}
			catch (SmtpException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public static bool IsMailValid(string email)
		{
			return Regex.Match(email, emailMask, RegexOptions.IgnoreCase).Success;
		}
	}
}
