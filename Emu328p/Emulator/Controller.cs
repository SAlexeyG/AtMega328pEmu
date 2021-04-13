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
		private bool isRunning = false;

		public ISRAM SramManager => sramManager;
		public IFlash FlashManager => flashManager;
		public IExecuter OpcodeExecuter => opcodeExecuter;
		public IUART UartUnit => uartUnit;
		public bool IsRunning
		{
			get => isRunning;
			private set
			{
				isRunning = value;
				OnStatusChanged?.Invoke();
			}
		}

		public Action OnStatusChanged;

		public Controller(byte[] firmware)
		{
			sramManager = new SRAMManager();
			flashManager = new FlashManager(firmware);
			opcodeExecuter = new ExecutionUnit();
			uartUnit = new UARTUnit(sramManager);
		}

		public async void RunAsync()
		{
			IsRunning = true;
			bool isError = false;

			await Task.Run(() =>
			{
				while (!flashManager.IsEndOfMemory() && !isError && IsRunning)
				{
					isError = !opcodeExecuter.ExecuteNextMicrocommand(sramManager, flashManager);
				}
			});
		}

		public async void ExecuteOneAsync()
		{
			await Task.Run(() =>
			{
				_ = opcodeExecuter.ExecuteNextMicrocommand(sramManager, flashManager);
			});
		}

		public void Reset()
		{
			sramManager.Clear();
			flashManager.PC = 0;
		}

		public void Stop()
		{
			IsRunning = false;
		}
	}
}
