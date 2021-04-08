using Emu328p.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Emu328p.Tools
{
	internal class User
	{
		public string Login;
		public string Password;
		public string Mail;
	}

	public static class UserPrefs
	{
		private static User user;

		public static string Login => user.Login;
		public static string Password => user.Password;
		public static string Mail => user.Mail;

		public static bool IsNewUser()
		{
			if (!IsProgrammDirectoryExists()) return true;
			if (!IsPrefsExists()) return true;
			return false;
		}

		public static void LoadUserPrefs()
		{
			user = JsonConvert.DeserializeObject<User>(File.ReadAllText(GetUserPrefsFilePath()));
		}

		public static void SaveUserPrefs(string Login, string Password, string Mail)
		{
			if (!IsProgrammDirectoryExists()) Directory.CreateDirectory(GetProgrammDirectoryPath());
			File.WriteAllText(GetUserPrefsFilePath(), JsonConvert.SerializeObject(
				new User() { Login = Login, Mail = Mail, Password = Password }
				));
		}

		private static bool IsProgrammDirectoryExists() =>
			Directory.Exists(GetProgrammDirectoryPath());

		private static bool IsPrefsExists() =>
			File.Exists(GetUserPrefsFilePath());

		private static string GetProgrammDirectoryPath()
		{
			return Path.Combine(
							Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
							Settings.Default.ProgrammFolder
							);
		}


		private static string GetUserPrefsFilePath()
		{
			return Path.Combine(
							Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
							Settings.Default.ProgrammFolder,
							Settings.Default.PrefsFolder
							);
		}
	}
}
