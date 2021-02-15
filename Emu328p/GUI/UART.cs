using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emu328p.Emulator;

namespace Emu328p.GUI
{
	public partial class UART : Form
	{
		private IUART uartUnit = null;
		private Action<char> AddSymbol; 

		public UART()
		{
			InitializeComponent();
			AddSymbol += (symbol) => textBox.Text += symbol;
		}

		public void SetUARTUnit(IUART uartUnit)
		{
			this.uartUnit = uartUnit;
			uartUnit.OnCharWriting += WriteChar;
		}

		private void WriteChar(char symbol)
		{
			Invoke(AddSymbol, symbol);
		}
	}
}
