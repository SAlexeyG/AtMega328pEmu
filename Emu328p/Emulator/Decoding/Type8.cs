using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public class Type8 : Type
	{
		public override ushort OperandMask => 0xffff;

		public Type8()
		{
			decodingTable.Add(0x0000, Nop);
			decodingTable.Add(0x9508, Ret);
		}

		private void Nop(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			return;
		}

		private void Ret(ushort opcode, ISRAM sramManager, IFlash flashManager)
		{
			ushort sp = sramManager.GetWord(Registers.IO.SPL);

			byte[] pc = new byte[4];

			for (int i = 0; i < pc.Length; i++, sp++)
			{
				pc[i] = sramManager.GetByte(sp);
			}

			pc = pc.Reverse().ToArray();

			uint offset = BitConverter.ToUInt32(pc, 0);

			sramManager.SetWord(Registers.IO.SPL, sp);
			flashManager.PC = offset;
		}
	}
}
