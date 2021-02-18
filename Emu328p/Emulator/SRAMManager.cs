using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator
{
	public class SRAMManager : ISRAM
	{
		private byte[] sram = new byte[ControllerConfiguration.SRAM_AMOUNT_BYTES];

		public event Action OnSRAMChanged;

		public void Clear()
		{
			for (int i = 0; i < sram.Length; i++)
				sram[i] = 0;
		}

		public byte GetByte(uint offset)
		{
			return sram[offset];
		}

		public ushort GetWord(uint offset)
		{
			ushort value = sram[offset + 1];
			value <<= 8;
			value |= sram[offset];
			return value;
		}

		public void SetByte(uint offset, byte value)
		{
			sram[offset] = value;
			OnSRAMChanged?.Invoke();
		}

		public void SetWord(uint offset, ushort value)
		{
			sram[offset] = (byte)(value & 0x00ff);
			sram[offset + 1] = (byte)(value >> 8);
			OnSRAMChanged?.Invoke();
		}
	}
}
