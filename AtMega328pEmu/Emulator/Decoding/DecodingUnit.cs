using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtMega328pEmu.Emulator.Decoding
{
	public partial class DecodingUnit : IDecodingUnit
	{
		private IList<IOpcodeFormatType> opcodeFormatTypes = new List<IOpcodeFormatType>();

		public Action<ushort, ISRAM, IFlash> Decode(ushort opcode)
		{
			foreach (IOpcodeFormatType type in opcodeFormatTypes)
			{
				ushort opcodeWithoutOperands = opcode;
				opcodeWithoutOperands &= type.OperandMask;

				if (type.HasDecodedOperation(opcodeWithoutOperands))
				{
					return type.GetDecodedOperation(opcodeWithoutOperands);
				}
			}

			return null;
		}

		public DecodingUnit()
		{
			opcodeFormatTypes.Add(new Type1());
			opcodeFormatTypes.Add(new Type3());
			opcodeFormatTypes.Add(new Type4());
			opcodeFormatTypes.Add(new Type5());
			opcodeFormatTypes.Add(new Type7());
			opcodeFormatTypes.Add(new Type8());
			opcodeFormatTypes.Add(new Type9());
			opcodeFormatTypes.Add(new Type11());
			opcodeFormatTypes.Add(new Type13());
			opcodeFormatTypes.Add(new Type14());
		}
	}
}
