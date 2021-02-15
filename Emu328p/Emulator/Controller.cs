using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Emu328p.Emulator
{
	public class Controller
	{
		private ISRAM sramManager = null;
		private IFlash flashManager = null;
		private IExecuter opcodeExecuter = null;
		private IUART uartUnit = null;

		public ISRAM SramManager => sramManager;
		public IFlash FlashManager => flashManager;
		public IExecuter OpcodeExecuter => opcodeExecuter;
		public IUART UartUnit => uartUnit;

		public Controller(byte[] firmware)
		{
			sramManager = new SRAMManager();
			flashManager = new FlashManager(firmware);
			opcodeExecuter = new ExecutionUnit();
			uartUnit = new UARTUnit(sramManager);
		}

		public async void RunAsync()
		{
			await Task.Run(() =>
			{
				bool isError = false;
				while (!flashManager.IsEndOfMemory() && !isError)
				{
					isError = !opcodeExecuter.ExecuteNextMicrocommand(sramManager, flashManager);
				}
			});
		}
	}
}
