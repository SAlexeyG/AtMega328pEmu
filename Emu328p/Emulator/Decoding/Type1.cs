using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public class Type1 : IOpcodeFormatType
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

		public Type1()
		{
			decodingTable.Add(0x2400, Eor);
		}

		private void Eor(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			uint destination = GetDestination(opcode);
			uint resource = GetResource(opcode);
			byte result = (byte)(sramManager.GetByte(destination) ^ sramManager.GetByte(resource));
			sramManager.SetByte(destination, result);

			byte sreg = sramManager.GetByte(Registers.IO.SREG);

			byte negativeFlag = (byte)(result >> 7);
			if (negativeFlag == 1)
			{
				sreg |= 0x14;
			}
			else
			{
				sreg &= 0xeb;
			}

			sreg &= 0xf7;

			if (result == 0)
			{
				sreg |= 0x02;
			}
			else
			{
				sreg &= 0xfd;
			}

			byte sFlag = (byte)(negativeFlag ^ 0);
			if (sFlag == 1)
			{
				sreg |= 0x10;
			}
			else
			{
				sreg &= 0xef;
			}

			sramManager.SetByte(Registers.IO.SREG, sreg);
		}

		private uint GetResource(ushort opcode)
		{
			return (uint)((opcode & 0x000f) | ((opcode & 0x0200) >> 5));
		}

		private uint GetDestination(ushort opcode)
		{
			return (uint)((opcode & 0x01f0) >> 4);
		}
	}
}
