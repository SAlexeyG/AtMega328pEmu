using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public class Type7 : IOpcodeFormatType
	{
		private Dictionary<ushort, Action<ushort, ISRAM, IFlash>> decodingTable =
			new Dictionary<ushort, Action<ushort, ISRAM, IFlash>>();

		public ushort OperandMask => 0xfc00;

		public Action<ushort, ISRAM, IFlash> GetDecodedOperation(ushort opcodeWithoutOperands)
		{
			return decodingTable[opcodeWithoutOperands];
		}

		public bool HasDecodedOperation(ushort opcodeWithoutOperands)
		{
			return decodingTable.ContainsKey(opcodeWithoutOperands);
		}

		public Type7()
		{
			decodingTable.Add(0xf400, Brbc);
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

		private static uint GetOffset(ushort opcode, IFlash flashManager)
		{
			uint offset = (uint)(flashManager.PC + ((((opcode & 0x03f8) >> 3) - 0x80) << 1));
			return offset;
		}

		private static byte GetStatus(ushort opcode)
		{
			return (byte)(opcode & 0x0007);
		}
	}
}
