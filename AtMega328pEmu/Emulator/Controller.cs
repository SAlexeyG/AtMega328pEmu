using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtMega328pEmu.Emulator
{
	public class Controller
	{
		private ISRAM sramManager = null;
		private IFlash flashManager = null;
		private IExecuter opcodeExecuter = null;
		private IUART uartUnit = null;

		public Controller(byte[] firmware)
		{
			sramManager = new SRAMManager();
			flashManager = new FlashManager(firmware);
			opcodeExecuter = new ExecutionUnit();
			uartUnit = new UARTUnit(sramManager);
		}

		public void Run()
		{
			bool isError = false;
			Stopwatch timer = new Stopwatch();
			timer.Start();

			while (!flashManager.IsEndOfMemory() && !isError)
			{
				isError = !opcodeExecuter.ExecuteNextMicrocommand(sramManager, flashManager);
				timer.Restart();
			}

			timer.Stop();
			Console.WriteLine("Done");
		}
	}
}
