using Emu328p.Emulator.Decoding;
using Emu328p.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emu328p.Emulator
{
	public class ExecutionUnit : IExecuter
	{
		private IDecodingUnit decodingUnit = new DecodingUnit();

		public bool ExecuteNextMicrocommand(ISRAM sramManager, IFlash flashManager)
		{
			ushort opcode = flashManager.GetWord();
			DecodedOperation action = decodingUnit.Decode(opcode);

			if (action == null)
			{
				MessageBox.Show($"Opcode {Convert.ToString(opcode, 16)} does not defined");
				return false;
			}

			action.Invoke(opcode, sramManager, flashManager);

			//try
			//{
			//	action.Invoke(opcode, sramManager, flashManager);
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show($"{ex.Message}", $"{Convert.ToString(flashManager.PC, 16)} - Error with opcode " +
			//		$"{Convert.ToString(opcode, 16)}");
			//	return false;
			//}

			return true;
		}
	}
}
