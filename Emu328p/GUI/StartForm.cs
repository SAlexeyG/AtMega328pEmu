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
	public partial class StartForm : Form
	{
		public StartForm()
		{
			InitializeComponent();
		}

		private void registrateButton_Click(object sender, EventArgs e)
		{
			UserPrefs.SaveUserPrefs(Environment.UserName, passwordTextBox.Text, mailTextBox.Text);
			var checkForm = new PasswordCheckForm();
			checkForm.Show();
			checkForm.FormClosed += (sender1, e1) => Close();
			Visible = false;
		}
	}
}
