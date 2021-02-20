using Emu328p.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public interface IOpcodeFormatType
	{
		ushort OperandMask { get; }

		DecodedOperation GetDecodedOperation(ushort opcodeWithoutOperands);

		bool HasDecodedOperation(ushort opcodeWithoutOperands);
	}
}
