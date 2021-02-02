using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtMega328pEmu.Tools
{
	public static class FileReader
	{
		public static byte[] Read()
		{
			string filePath;

			while (true)
			{
				Console.WriteLine("Enter file: ");
				filePath = Console.ReadLine();

				if (!File.Exists(filePath))
				{
					Console.WriteLine("File does not exists");
					continue;
				}

				break;
			}

			return File.ReadAllBytes(filePath);
		}
	}
}
