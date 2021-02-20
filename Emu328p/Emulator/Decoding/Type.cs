using Emu328p.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator.Decoding
{
	public abstract class Type : IOpcodeFormatType
	{
		protected Dictionary<ushort, DecodedOperation> decodingTable =
			new Dictionary<ushort, DecodedOperation>();

		public abstract ushort OperandMask { get; }

		public DecodedOperation GetDecodedOperation(ushort opcodeWithoutOperands)
		{
			return decodingTable[opcodeWithoutOperands];
		}

		public bool HasDecodedOperation(ushort opcodeWithoutOperands)
		{
			return decodingTable.ContainsKey(opcodeWithoutOperands);
		}
	}
}
