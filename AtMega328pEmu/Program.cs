using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtMega328pEmu.Tools;
using AtMega328pEmu.Emulator;

namespace AtMega328pEmu
{
	class Program
	{
		static void Main(string[] args)
		{
			Controller controller = new Controller(FileReader.Read());
			controller.Run();

			_ = Console.ReadKey();
		}
	}
}
