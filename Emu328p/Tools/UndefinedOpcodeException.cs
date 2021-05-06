using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Tools
{
	class UndefinedOpcodeException : Exception
	{
		public UndefinedOpcodeException(string message) : base(message) { }
	}
}
