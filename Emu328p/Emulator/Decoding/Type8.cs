using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public class Type8 : Type
	{
		public override ushort OperandMask => 0xffff;

		public Type8()
		{
			decodingTable.Add(0x0000, Nop);
		}

		private void Nop(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			return;
		}
	}
}
