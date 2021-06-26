using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public class Type7 : Type
	{
		public override ushort OperandMask => 0xfc00;

		public Type7()
		{
			decodingTable.Add(0xf400, Brbc);
			decodingTable.Add(0xf000, Brbs);
		}

		private void Brbc(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			byte sreg = sramManager.GetByte(Registers.IO.SREG);
			byte status = GetStatus(opcode);
			uint offset = GetOffset(opcode, flashManager);
			sreg <<= 7 - status;
			sreg >>= 7;

			if (sreg == 0)
			{
				flashManager.PC = offset;
			}
		}

		private void Brbs(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			byte sreg = sramManager.GetByte(Registers.IO.SREG);
			byte status = GetStatus(opcode);
			uint offset = GetOffset(opcode, flashManager);
			sreg <<= 7 - status;
			sreg >>= 7;

			if (sreg != 0)
			{
				flashManager.PC = offset;
			}
		}

		private static uint GetOffset(ushort opcode, IFlash flashManager)
		{
			int k = (opcode & 0x03f8) >> 3;
			k -= k > 0x3f ? 0x80 : 0x00;
			uint offset = (uint)(flashManager.PC + (k << 1));
			return offset;
		}

		private static byte GetStatus(ushort opcode)
		{
			return (byte)(opcode & 0x0007);
		}
	}
}
