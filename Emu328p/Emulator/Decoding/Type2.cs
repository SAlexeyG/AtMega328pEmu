using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	class Type2 : Type
	{
		public override ushort OperandMask => 0xff00;

		public Type2()
		{
			decodingTable.Add(0x9700, Sbiw);
			decodingTable.Add(0x9600, Adiw);
		}

		private void Sbiw(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			uint destination = GetDestination(opcode);
			ushort operand1 = sramManager.GetWord(destination);
			byte operand2 = GetValue(opcode);
			ushort value = (ushort)(operand1 - operand2);
			sramManager.SetWord(destination, value);

			byte sreg = sramManager.GetByte(Registers.IO.SREG);

			byte vFlag = (byte)(((value & 0x80) >> 15) & (((operand1 ^ operand1) & 0x80) >> 15));
			if (vFlag == 1)
			{
				sreg |= 0x08;
			}
			else
			{
				sreg &= 0xf7;
			}

			byte negativeFlag = (byte)(value >> 15);
			if (negativeFlag == 1)
			{
				sreg |= 0x14;
			}
			else
			{
				sreg &= 0xeb;
			}

			if (value == 0)
			{
				sreg |= 0x02;
			}
			else
			{
				sreg &= 0xfd;
			}

			byte carryFlag = (byte)(((value & 0x80) >> 15) & (((operand1 ^ operand1) & 0x80) >> 15));
			if (carryFlag == 1)
			{
				sreg |= 0x01;
			}
			else
			{
				sreg &= 0xfe;
			}

			byte sFlag = (byte)((negativeFlag ^ vFlag) & 0x01);
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

		private void Adiw(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			uint destination = GetDestination(opcode);
			ushort operand1 = sramManager.GetWord(destination);
			byte operand2 = GetValue(opcode);
			ushort value = (ushort)(operand1 + operand2);
			sramManager.SetWord(destination, value);

			byte sreg = sramManager.GetByte(Registers.IO.SREG);

			byte vFlag = (byte)(((value & 0x80) >> 15) & (((operand1 ^ operand1) & 0x80) >> 15));
			if (vFlag == 1)
			{
				sreg |= 0x08;
			}
			else
			{
				sreg &= 0xf7;
			}

			byte negativeFlag = (byte)(value >> 15);
			if (negativeFlag == 1)
			{
				sreg |= 0x14;
			}
			else
			{
				sreg &= 0xeb;
			}

			if (value == 0)
			{
				sreg |= 0x02;
			}
			else
			{
				sreg &= 0xfd;
			}

			byte carryFlag = (byte)(((value & 0x80) >> 15) & (((operand1 ^ operand1) & 0x80) >> 15));
			if (carryFlag == 1)
			{
				sreg |= 0x01;
			}
			else
			{
				sreg &= 0xfe;
			}

			byte sFlag = (byte)((negativeFlag ^ vFlag) & 0x01);
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

		private static uint GetDestination(ushort opcode)
		{
			return (uint)(((opcode & 0x0030) >> 4) + 0x18);
		}

		private static byte GetValue(ushort opcode)
		{
			return (byte)((opcode & 0x000f) | ((opcode & 0x00c0) >> 2));
		}
	}
}
