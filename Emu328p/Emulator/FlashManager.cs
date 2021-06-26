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

		public event Action OnPCChanged;

		public uint PC
		{
			get => pc;
			set 
			{
				pc = value;
				OnPCChanged?.Invoke();
			}
		}

		public byte[] GetFirmware => flash;

		public FlashManager(byte[] firmware)
		{
			flash = new byte[ControllerConfiguration.FLASH_AMOUNT_BYTES];
			firmware.CopyTo(flash, 0);
		}

		public byte GetByte()
		{
			PC++;
			return flash[PC];
		}

		public ushort GetWord()
		{
			ushort value;
			try
			{
				value = flash[PC + 1];
			}
			catch (Exception)
			{
				pc = 0;
				value = flash[PC + 1];
			}
			value <<= 8;
			value |= flash[PC];
			PC += 2;
			return value;
		}

		public bool IsEndOfMemory()
		{
			return PC == ControllerConfiguration.FLASH_AMOUNT_BYTES - 1;
		}

		public void SetWord(uint offset, ushort value)
		{
			flash[offset] = (byte)(value & 0x00ff);
			flash[offset + 1] = (byte)(value >> 8);
		}
	}
}
