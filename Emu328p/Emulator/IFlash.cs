using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator
{
	public interface IFlash
	{
		event Action OnPCChanged;
		uint PC { get; set; }
		byte[] GetFirmware { get; }
		byte GetByte();
		ushort GetWord();
		void SetWord(uint offset, ushort value);
		bool IsEndOfMemory();
	}
}
