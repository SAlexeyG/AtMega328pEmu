using Emu328p.Emulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Tools
{
	public delegate void DecodedOperation(ushort opcode, ISRAM sramManager, IFlash flashManager);
}
