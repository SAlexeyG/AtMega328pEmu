using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtMega328pEmu.Emulator.Decoding
{
	public interface IOpcodeFormatType
	{
		ushort OperandMask { get; }

		Action<ushort, ISRAM, IFlash> GetDecodedOperation(ushort opcodeWithoutOperands);

		bool HasDecodedOperation(ushort opcodeWithoutOperands);
	}
}
