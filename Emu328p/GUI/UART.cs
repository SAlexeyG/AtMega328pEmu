using Emu328p.Emulator;
using Emu328p.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emu328p.GUI
{
	public partial class UART : Form
	{
		private IUART uartUnit = null;
		private Action<char> addSymbol;

		public UART()
		{
			InitializeComponent();
			addSymbol = (symbol) => textBox.Text += symbol;
		}

		public void SetUARTUnit(IUART uartUnit)
		{
			this.uartUnit = uartUnit;
			this.uartUnit.OnCharWriting += WriteChar;
		}

		public void Clear()
		{
			textBox.Text = "";
		}

		private void WriteChar(object sender, UARTEventArgs e)
		{
			if (!IsDisposed)
			{
				Invoke(addSymbol, e.Symbol);
			}
		}

		private void reciveButton_Click(object sender, EventArgs e)
		{
			uartUnit?.ReadByte(reciveTextBox.Text[0]);
		}
	}
}
