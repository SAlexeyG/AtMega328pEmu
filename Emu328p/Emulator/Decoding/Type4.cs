using Emu328p.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public class Type4 : Type
	{
		public override ushort OperandMask => 0xfe0f;

		public Type4()
		{
			decodingTable.Add(0x920c, St(Registers.GP.X));
			decodingTable.Add(0x8208, St(Registers.GP.Y));
			decodingTable.Add(0x8200, St(Registers.GP.Z));

			decodingTable.Add(0x920d, StInc(Registers.GP.X));
			decodingTable.Add(0x9209, StInc(Registers.GP.Y));
			decodingTable.Add(0x9201, StInc(Registers.GP.Z));

			decodingTable.Add(0x920e, StDec(Registers.GP.X));
			decodingTable.Add(0x920A, StDec(Registers.GP.Y));
			decodingTable.Add(0x9202, StDec(Registers.GP.Z));

			decodingTable.Add(0x900c, Ld(Registers.GP.X));
			decodingTable.Add(0x8008, Ld(Registers.GP.Y));
			decodingTable.Add(0x8000, Ld(Registers.GP.Z));

			decodingTable.Add(0x900d, LdInc(Registers.GP.X));
			decodingTable.Add(0x9009, LdInc(Registers.GP.Y));
			decodingTable.Add(0x9001, LdInc(Registers.GP.Z));

			decodingTable.Add(0x900e, LdDec(Registers.GP.X));
			decodingTable.Add(0x900a, LdDec(Registers.GP.X));
			decodingTable.Add(0x9002, LdDec(Registers.GP.X));
		}

		private DecodedOperation St(uint register)
		{
			return (ushort opcode, ISRAM sramManager, IFlash flashManager) =>
			{
				uint offset = sramManager.GetWord(register);
				byte value = sramManager.GetByte(GetDestination(opcode));
				sramManager.SetByte(offset, value);
			};
		}

		private DecodedOperation StInc(uint register)
		{
			return (ushort opcode, ISRAM sramManager, IFlash flashManager) =>
			{
				uint offset = sramManager.GetWord(register);
				byte value = sramManager.GetByte(GetDestination(opcode));
				sramManager.SetByte(offset, value);
				offset++;
				sramManager.SetWord(register, (ushort)offset);
			};
		}

		private DecodedOperation StDec(uint register)
		{
			return (ushort opcode, ISRAM sramManager, IFlash flashManager) =>
			{
				uint offset = sramManager.GetWord(register);
				offset--;
				sramManager.SetWord(register, (ushort)offset);
				byte value = sramManager.GetByte(GetDestination(opcode));
				sramManager.SetByte(offset, value);
			};
		}

		private DecodedOperation Ld(uint register)
		{
			return (ushort opcode, ISRAM sramManager, IFlash flashManager) =>
			{
				uint offset = GetDestination(opcode);
				byte value = sramManager.GetByte(sramManager.GetWord(register));
				sramManager.SetByte(offset, value);
			};
		}

		private DecodedOperation LdInc(uint register)
		{
			return (ushort opcode, ISRAM sramManager, IFlash flashManager) =>
			{
				uint offset = GetDestination(opcode);
				byte value = sramManager.GetByte(sramManager.GetWord(register));
				sramManager.SetByte(offset, value);
				sramManager.SetWord(register, (ushort)(sramManager.GetWord(register) + 1));
			};
		}

		private DecodedOperation LdDec(uint register)
		{
			return (ushort opcode, ISRAM sramManager, IFlash flashManager) =>
			{
				uint offset = GetDestination(opcode);
				sramManager.SetWord(register, (ushort)(sramManager.GetWord(register) - 1));
				byte value = sramManager.GetByte(sramManager.GetWord(register));
				sramManager.SetByte(offset, value);
			};
		}

		private static uint GetDestination(ushort opcode)
		{
			return (uint)((opcode & 0x01f0) >> 4);
		}
	}
}
