using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public class Type5 : IOpcodeFormatType
	{
		private Dictionary<ushort, Action<ushort, ISRAM, IFlash>> decodingTable =
			new Dictionary<ushort, Action<ushort, ISRAM, IFlash>>();

		public ushort OperandMask => 0xff8f;

		public Action<ushort, ISRAM, IFlash> GetDecodedOperation(ushort opcodeWithoutOperands)
		{
			return decodingTable[opcodeWithoutOperands];
		}

		public bool HasDecodedOperation(ushort opcodeWithoutOperands)
		{
			return decodingTable.ContainsKey(opcodeWithoutOperands);
		}

		public Type5()
		{
			decodingTable.Add(0x9488, Bclr);
		}

		private void Bclr(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			byte sreg = sramManager.GetByte(Registers.IO.SREG);
			byte mask = 1;
			mask <<= GetStatus(opcode);
			mask ^= 0;
			sreg &= mask;
			sramManager.SetByte(Registers.IO.SREG, sreg);
		}

		private static byte GetStatus(ushort opcode)
		{
			return (byte)(opcode & 0x0070);
		}
	}
}
