using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public interface IDecodingUnit
	{
		Action<ushort, ISRAM, IFlash> Decode(ushort opcode);
	}
}
