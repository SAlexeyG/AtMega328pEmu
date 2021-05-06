using Emu328p.Emulator.Decoding;
using Emu328p.GUI;
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
				new FatalErrorForm(new UndefinedOpcodeException($"Opcode {opcode.ToHexString()} does not defined")).ShowDialog();
				return false;
			}

			action.Invoke(opcode, sramManager, flashManager);
			return true;
		}
	}
}
