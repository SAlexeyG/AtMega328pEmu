﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtMega328pEmu.Emulator.Decoding
{
	public interface IDecodingUnit
	{
		Action<ushort, ISRAM, IFlash> Decode(ushort opcode);
	}
}