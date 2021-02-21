using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Tools
{
	public class UARTEventArgs : EventArgs
	{
		public char Symbol { get; }

		public UARTEventArgs(char symbol)
		{
			Symbol = symbol;
		}
	}
}
