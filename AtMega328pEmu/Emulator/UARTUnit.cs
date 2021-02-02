using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtMega328pEmu.Emulator
{
	public class UARTUnit : IUART
	{
		private ISRAM sramManager;

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
			Console.Write(charArray[0]);
		}
	}
}
