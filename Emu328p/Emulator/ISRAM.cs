using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator
{
	public interface ISRAM
	{
		event Action OnSRAMChanged;
		byte GetByte(uint offset);
		void SetByte(uint offset, byte value);
		ushort GetWord(uint offset);
		void SetWord(uint offset, ushort value);
	}
}
