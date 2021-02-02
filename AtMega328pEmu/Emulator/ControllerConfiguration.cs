using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtMega328pEmu.Emulator
{
	public static class ControllerConfiguration
	{
		public const uint SRAM_AMOUNT_BYTES = 2303;
		public const uint INTERNAL_SRAM_AMOUNT_BYTES = 2048;
		public const uint FLASH_AMOUNT_BYTES = 32768;
		public const uint OPCODES_AMOUNT = ushort.MaxValue;
		public const uint OPCODE_TYPES_COUNT = 16;
		public const ulong CPU_FREQUENCY = 20_000_000;
	}
}
