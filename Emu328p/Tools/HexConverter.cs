using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Tools
{
	static class HexConverter
	{
		public static string ToHexString(this ushort opcode)
		{
			string hexOpcode = Convert.ToString(opcode, 16).ToUpper();
			while (hexOpcode.Length < 4)
			{
				hexOpcode = hexOpcode.Insert(0, "0");
			}

			hexOpcode = hexOpcode.Insert(0, "0x");
			return hexOpcode;
		}
	}
}
