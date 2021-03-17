using Emu328p.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator
{
	public interface IUART
	{
		event EventHandler<UARTEventArgs> OnCharWriting;
		event EventHandler<UARTEventArgs> OnCharReading;

		void WriteByte();
		void ReadByte(char symbol);
	}
}
