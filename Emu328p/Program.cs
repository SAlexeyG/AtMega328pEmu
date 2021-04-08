using Emu328p.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emu328p
{
	internal static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (UserPrefs.IsNewUser())
			{
				Application.Run(new GUI.StartForm());
			}
			else
			{
				Application.Run(new GUI.PasswordCheckForm());
			}
		}
	}
}
