using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator
{
	public class FlashManager : IFlash
	{
		private byte[] flash = null;
		private uint pc = 0;

		public uint PC
		{
			get => pc;
			set => pc = value;
		}

		public FlashManager(byte[] firmware)
		{
			flash = new byte[ControllerConfiguration.FLASH_AMOUNT_BYTES];
			firmware.CopyTo(flash, 0);
		}

		public byte GetByte()
		{
			pc++;
			return flash[pc];
		}

		public ushort GetWord()
		{
			ushort value = flash[pc + 1];
			value <<= 8;
			value |= flash[pc];
			pc += 2;
			return value;
		}

		public bool IsEndOfMemory()
		{
			return pc == ControllerConfiguration.FLASH_AMOUNT_BYTES - 1;
		}
	}
}
