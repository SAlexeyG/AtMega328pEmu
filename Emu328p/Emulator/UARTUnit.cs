using Emu328p.GUI;
using Emu328p.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emu328p.Emulator
{
	public class UARTUnit : IUART
	{
		private ISRAM sramManager;
		public event EventHandler<UARTEventArgs> OnCharWriting;

		public UARTUnit(ISRAM sramManager)
		{
			this.sramManager = sramManager;
			sramManager.OnSRAMChanged += WriteByte;
		}

		public void WriteByte()
		{
			byte[] byteArray = new byte[1];
			byteArray[0] = sramManager.GetByte(Registers.IO.UDR0);

			if (byteArray[0] == 0)
			{
				return;
			}

			sramManager.SetByte(Registers.IO.UDR0, 0);
			char[] charArray = Encoding.ASCII.GetChars(byteArray);

			OnCharWriting?.Invoke(this, new UARTEventArgs(charArray[0]));
		}
	}
}
