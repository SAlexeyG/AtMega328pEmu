using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Tools
{
	public static class HexConverter
	{
		public static string ToHexString(this ushort opcode)
		{
			string hexOpcode = Convert.ToString(opcode, 16).ToUpper();
			hexOpcode = hexOpcode.PadLeft(5, '0');
			hexOpcode = hexOpcode.Insert(1, "x");
			return hexOpcode;
		}
	}
}
