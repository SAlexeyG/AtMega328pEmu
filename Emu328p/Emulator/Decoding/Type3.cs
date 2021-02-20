using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public class Type3 : Type
	{
		public override ushort OperandMask => 0xf000;

		public Type3()
		{
			decodingTable.Add(0xc000, Rjmp);
		}

		private void Rjmp(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			flashManager.PC = GetOffset(opcode, flashManager);
			byte sreg = sramManager.GetByte(Registers.IO.SREG);
			sreg |= 0x80;
			sramManager.SetByte(Registers.IO.SREG, sreg);
		}

		private static uint GetOffset(ushort opcode, IFlash flashManager)
		{
			return (uint)(flashManager.PC + (((opcode & 0x0fff) << 20) >> 19));
		}
	}
}
