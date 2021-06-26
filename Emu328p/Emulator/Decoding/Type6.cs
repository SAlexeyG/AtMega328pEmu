using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public class Type6 : Type
	{
		public override ushort OperandMask => 0xfe08;

		public Type6()
		{
			decodingTable.Add(0xfc00, Sbrc);
		}

		private void Sbrc(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			byte value = sramManager.GetByte(GetDestination(opcode));
			byte bit = (byte)(value << (byte)(8 - GetBit(opcode)) >> 7);

			if (bit == 0)
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

		private static uint GetDestination(ushort opcode)
		{
			return (uint)((opcode & 0x01f0) >> 4);
		}

		private static uint GetBit(ushort opcode)
		{
			return (uint)((opcode & 0x01f0) >> 4);
		}
	}
}
