using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public class Type1 : Type
	{
		public override ushort OperandMask => 0xfc00;

		public Type1()
		{
			decodingTable.Add(0x2400, Eor);
			decodingTable.Add(0x2000, And);
			decodingTable.Add(0x2c00, Mov);
			decodingTable.Add(0x0400, Cpc);
			decodingTable.Add(0x0c00, Add);
			decodingTable.Add(0x1c00, Adc);
			decodingTable.Add(0x2800, Or);
			decodingTable.Add(0x1800, Sub);
			decodingTable.Add(0x0800, Sbc);
			decodingTable.Add(0x1400, Cp);
			decodingTable.Add(0x1000, Cpse);
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

		private void And(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			uint destination = GetDestination(opcode);
			uint resource = GetResource(opcode);
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

		private void Mov(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			sramManager.SetByte(GetDestination(opcode), sramManager.GetByte(GetResource(opcode)));
		}


		private void Cpc(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			byte operand1 = sramManager.GetByte(GetDestination(opcode));
			byte operand2 = sramManager.GetByte(GetResource(opcode));
			byte sreg = sramManager.GetByte(Registers.IO.SREG);
			byte value = (byte)(operand1 - operand2 - (sreg & 0x1));

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

			byte zeroFlag = (byte)((sreg & 0x2) >> 1);
			if (value == 0 && zeroFlag == 1)
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

		private void Add(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			byte operand1 = sramManager.GetByte(GetDestination(opcode));
			byte operand2 = sramManager.GetByte(GetResource(opcode));
			byte sreg = sramManager.GetByte(Registers.IO.SREG);
			byte value = (byte)(operand1 + operand2);
			sramManager.SetByte(GetDestination(opcode), value);

			byte hFlag = (byte)(
				(((operand1 & 0x08) >> 3) & ((operand2 & 0x08) >> 3)) |
				(((operand2 & 0x08) >> 3) & (((value ^ value) & 0x08) >> 3)) |
				((((value ^ value) & 0x08) >> 3) & ((operand1 & 0x08) >> 3))
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
				(((operand1 & 0x80) >> 7) & ((operand2 & 0x80) >> 7) & (((value ^ value) & 0x80) >> 7)) |
				((((operand1 ^ operand1) & 0x80) >> 7) & (((operand2 ^ operand2) & 0x80) >> 7) & ((value & 0x80) >> 7))
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
				(((operand1 & 0x80) >> 7) & ((operand2 & 0x80) >> 7)) |
				(((operand2 & 0x80) >> 7) & (((value ^ value) & 0x80) >> 7)) |
				((((value ^ value) & 0x80) >> 7) & ((operand1 & 0x80) >> 7))
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

		private void Adc(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			byte operand1 = sramManager.GetByte(GetDestination(opcode));
			byte operand2 = sramManager.GetByte(GetResource(opcode));
			byte sreg = sramManager.GetByte(Registers.IO.SREG);
			byte value = (byte)(operand1 + operand2 + (sreg & 0x1));
			sramManager.SetByte(GetDestination(opcode), value);

			byte hFlag = (byte)(
				(((operand1 & 0x08) >> 3) & ((operand2 & 0x08) >> 3)) |
				(((operand2 & 0x08) >> 3) & (((value ^ value) & 0x08) >> 3)) |
				((((value ^ value) & 0x08) >> 3) & ((operand1 & 0x08) >> 3))
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
				(((operand1 & 0x80) >> 7) & ((operand2 & 0x80) >> 7) & (((value ^ value) & 0x80) >> 7)) |
				((((operand1 ^ operand1) & 0x80) >> 7) & (((operand2 ^ operand2) & 0x80) >> 7) & ((value & 0x80) >> 7))
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
				(((operand1 & 0x80) >> 7) & ((operand2 & 0x80) >> 7)) |
				(((operand2 & 0x80) >> 7) & (((value ^ value) & 0x80) >> 7)) |
				((((value ^ value) & 0x80) >> 7) & ((operand1 & 0x80) >> 7))
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

		private void Cpse(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			byte operand1 = sramManager.GetByte(GetDestination(opcode));
			byte operand2 = sramManager.GetByte(GetResource(opcode));

			if (operand1 == operand2)
			{
				int[] type11Opcodes = new int[] { 0x940c, 0x940e };
				int[] type14Opcodes = new int[] { 0x9200, 0x9000 };

				ushort nextOpcode = flashManager.GetWord();
				if (type11Opcodes.Contains(nextOpcode & 0xfe0e) || type14Opcodes.Contains(nextOpcode & 0xfe0f))
				{
					_ = flashManager.GetWord();
				}
			}
		}

		private void Or(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			uint destination = GetDestination(opcode);
			uint resource = GetResource(opcode);
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

		private void Sub(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			byte operand1 = sramManager.GetByte(GetDestination(opcode));
			byte operand2 = sramManager.GetByte(GetResource(opcode));
			byte sreg = sramManager.GetByte(Registers.IO.SREG);
			byte value = (byte)(operand1 - operand2);
			sramManager.SetByte(GetDestination(opcode), value);

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

		private void Sbc(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			byte operand1 = sramManager.GetByte(GetDestination(opcode));
			byte operand2 = sramManager.GetByte(GetResource(opcode));
			byte sreg = sramManager.GetByte(Registers.IO.SREG);
			byte value = (byte)(operand1 - operand2 - (sreg & 0x1));
			sramManager.SetByte(GetDestination(opcode), value);

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

			byte zeroFlag = (byte)((sreg & 0x2) >> 1);
			if (value == 0 && zeroFlag == 1)
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

		private void Cp(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			byte operand1 = sramManager.GetByte(GetDestination(opcode));
			byte operand2 = sramManager.GetByte(GetResource(opcode));
			byte sreg = sramManager.GetByte(Registers.IO.SREG);
			byte value = (byte)(operand1 - operand2);

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
				((((operand1 ^ 0xffffffff) & 0x80) >> 7) & ((operand2 & 0x80) >> 7)) |
				(((operand2 & 0x80) >> 7) & ((value & 0x80) >> 7)) |
				(((value & 0x80) >> 7) & (((operand1 ^ 0xffffffff) & 0x80) >> 7))
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
