using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Tools
{
	class FileWriter
	{
		public static void WriteBin(string filePath, byte[] firmware)
		{
			System.IO.File.WriteAllBytes(filePath, firmware);
		}
	}
}
