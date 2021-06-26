using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	class Type12 : Type
	{
		public override ushort OperandMask => 0xff00;

		public Type12()
		{
			decodingTable.Add(0x0100, Movw);
		}

		private void Movw(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			byte value1 = sramManager.GetByte(GetResource(opcode));
			byte value2 = sramManager.GetByte(GetResource(opcode) + 1);

			sramManager.SetByte(GetDestination(opcode), value1);
			sramManager.SetByte(GetDestination(opcode) + 1, value2);
		}

		private static uint GetDestination(ushort opcode)
		{
			return (uint)((opcode & 0x00f0) >> 5);
		}

		private static uint GetResource(ushort opcode)
		{
			return (uint)(opcode & 0x000f);
		}
	}
}
