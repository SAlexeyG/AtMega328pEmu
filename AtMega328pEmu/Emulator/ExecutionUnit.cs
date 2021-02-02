using AtMega328pEmu.Emulator.Decoding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AtMega328pEmu.Emulator
{
	public class ExecutionUnit : IExecuter
	{
		private IDecodingUnit decodingUnit = new DecodingUnit();

		public bool ExecuteNextMicrocommand(ISRAM sramManager, IFlash flashManager)
		{
			ushort opcode = flashManager.GetWord();
			Action<ushort, ISRAM, IFlash> action = decodingUnit.Decode(opcode);

			if (action == null)
			{
				Console.WriteLine($"Opcode {Convert.ToString(opcode, 16)} does not defined");
				return false;
			}

			try
			{
				action.Invoke(opcode, sramManager, flashManager);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"{Convert.ToString(flashManager.PC, 16)} - Error with opcode " +
					$"{Convert.ToString(opcode, 16)}: {ex.Message}");
				return false;
			}

			return true;
		}
	}
}
