using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public class Type9 : Type
	{
		public override ushort OperandMask => 0xf800;

		public Type9()
		{
			decodingTable.Add(0xb800, Out);
		}

		private void Out(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			byte value = sramManager.GetByte(GetResource(opcode));
			sramManager.SetByte(GetPort(opcode), value);
		}

		private static uint GetPort(ushort opcode)
		{
			return (uint)((opcode & 0x000f) | ((opcode & 0x0600) >> 5)) + 0x20;
		}

		private static uint GetResource(ushort opcode)
		{
			return (uint)((opcode & 0x01f0) >> 4);
		}
	}
}
