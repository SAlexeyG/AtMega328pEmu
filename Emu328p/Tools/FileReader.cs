using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Tools
{
	public static class FileReader
	{
		public static byte[] ReadBin(string filePath)
		{
			return System.IO.File.ReadAllBytes(filePath);
		}

		public static byte[] ReadHex(string filePath)
		{
			string file = System.IO.File.ReadAllText(filePath);
			string[] rows = file.Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

			List<byte> firmware = new List<byte>();

			foreach(string row in rows)
			{
				int count = Convert.ToInt32(row.Substring(0, 2), 16);

				for(int i = 8; i < 8 + count * 2; i += 2)
				{
					firmware.Add(Convert.ToByte(row.Substring(i, 2), 16));
				}
			}

			return firmware.ToArray();
		}
	}
}
