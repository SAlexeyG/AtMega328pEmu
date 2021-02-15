using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Tools
{
	public static class FileReader
	{
		public static byte[] ReadBin(string filePath)
		{
			return File.ReadAllBytes(filePath);
		}
	}
}
