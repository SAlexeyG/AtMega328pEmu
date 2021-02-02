using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtMega328pEmu.Emulator.Decoding
{
	public class Type4 : IOpcodeFormatType
	{
		private Dictionary<ushort, Action<ushort, ISRAM, IFlash>> decodingTable =
			new Dictionary<ushort, Action<ushort, ISRAM, IFlash>>();

		public ushort OperandMask => 0xfe0f;

		public Action<ushort, ISRAM, IFlash> GetDecodedOperation(ushort opcodeWithoutOperands)
		{
			return decodingTable[opcodeWithoutOperands];
		}

		public bool HasDecodedOperation(ushort opcodeWithoutOperands)
		{
			return decodingTable.ContainsKey(opcodeWithoutOperands);
		}

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
		}

		private Action<ushort, ISRAM, IFlash> St(uint register)
		{
			return (ushort opcode, ISRAM sramManager, IFlash flashManager) =>
			{
				uint offset = sramManager.GetWord(register);
				byte value = sramManager.GetByte(GetDestination(opcode));
				sramManager.SetByte(offset, value);
			};
		}

		private Action<ushort, ISRAM, IFlash> StInc(uint register)
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

		private Action<ushort, ISRAM, IFlash> StDec(uint register)
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

		private static uint GetDestination(ushort opcode)
		{
			return (uint)((opcode & 0x01f0) >> 4);
		}
	}
}
