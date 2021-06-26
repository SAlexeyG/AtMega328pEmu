using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public class Type13 : Type
	{
		public override ushort OperandMask => 0xf000;

		public Type13()
		{
			decodingTable.Add(0xe000, Ldi);
			decodingTable.Add(0x5000, Subi);
			decodingTable.Add(0x4000, Sbci);
			decodingTable.Add(0x3000, Cpi);
			decodingTable.Add(0x6000, Ori);
			decodingTable.Add(0x7000, Andi);
		}

		private void Ldi(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			sramManager.SetByte(GetDestination(opcode), GetValue(opcode));
		}

		private void Subi(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			uint destination = GetDestination(opcode);
			byte operand1 = sramManager.GetByte(destination);
			byte operand2 = GetValue(opcode);
			byte value = (byte)(operand1 - operand2);
			sramManager.SetByte(destination, value);
			SetStatusFlags(sramManager, operand1, operand2, value);
		}

		private void Sbci(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			uint destination = GetDestination(opcode);
			byte zeroFlag = (byte)((sramManager.GetByte(Registers.IO.SREG) & 0x02) >> 1);
			byte operand1 = sramManager.GetByte(destination);
			byte operand2 = GetValue(opcode);
			byte value = (byte)(operand1 - operand2 - zeroFlag);
			sramManager.SetByte(destination, value);
			SetStatusFlags(sramManager, operand1, operand2, value);
		}

		private void Cpi(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			uint destination = GetDestination(opcode);
			byte operand1 = sramManager.GetByte(destination);
			byte operand2 = GetValue(opcode);
			byte value = (byte)(operand1 - operand2);
			SetStatusFlags(sramManager, operand1, operand2, value);
		}

		private void Ori(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			uint destination = GetDestination(opcode);
			uint resource = GetValue(opcode);
			byte result = (byte)(sramManager.GetByte(destination) | sramManager.GetByte(resource));
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

		private void Andi(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			uint destination = GetDestination(opcode);
			uint resource = GetValue(opcode);
			byte result = (byte)(sramManager.GetByte(destination) & sramManager.GetByte(resource));
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

		private static void SetStatusFlags(ISRAM sramManager, byte operand1, byte operand2, byte value)
		{
			byte sreg = sramManager.GetByte(Registers.IO.SREG);

			byte hFlag = (byte)(
				((((operand1 ^ operand1) & 0x08) >> 3) & ((operand2 & 0x08) >> 3)) |
				(((operand2 & 0x08) >> 3) & ((value & 0x08) >> 3)) |
				(((value & 0x08) >> 3) & (((operand1 ^ operand1) & 0x08) >> 3))
				);
			if (hFlag == 1)
			{
				sreg |= 0x20;
			}
			else
			{
				sreg &= 0xdf;
			}

			byte vFlag = (byte)(
				(((operand1 & 0x80) >> 7) & (((operand2 ^ operand2) & 0x80) >> 7) & (((value ^ value) & 0x80) >> 7)) |
				((((operand1 ^ operand1) & 0x80) >> 7) & ((operand2 & 0x80) >> 7) & ((value & 0x80) >> 7))
				);
			if (vFlag == 1)
			{
				sreg |= 0x08;
			}
			else
			{
				sreg &= 0xf7;
			}

			byte negativeFlag = (byte)(value >> 7);
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

			byte carryFlag = (byte)(
				((((operand1 ^ operand1) & 0x80) >> 7) & ((operand2 & 0x80) >> 7)) |
				(((operand2 & 0x80) >> 7) & ((value & 0x80) >> 7)) |
				(((value & 0x80) >> 7) & (((operand1 ^ operand1) & 0x80) >> 7))
				);
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
			return (uint)(((opcode & 0x00f0) + 0x0100) >> 4);
		}

		private static byte GetValue(ushort opcode)
		{
			return (byte)(((opcode & 0x0f00) >> 4) | (opcode & 0x000f));
		}
	}
}
