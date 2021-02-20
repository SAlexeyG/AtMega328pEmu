using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public class Type14 : Type
	{
		public override ushort OperandMask => 0xfe0f;

		public Type14()
		{
			decodingTable.Add(0x9200, Sts);
		}

		private void Sts(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			sramManager.SetWord(flashManager.GetWord(), sramManager.GetByte(GetDestination(opcode)));
		}

		private static uint GetDestination(ushort opcode)
		{
			return (uint)((opcode & 0x01f0) >> 4);
		}
	}
}
