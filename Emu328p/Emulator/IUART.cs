using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator
{
	public interface IUART
	{
		event Action<char> OnCharWriting;
		void WriteByte();
	}
}
