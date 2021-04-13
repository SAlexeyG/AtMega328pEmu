using Emu328p.Emulator;
using Emu328p.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emu328p.GUI
{
	public partial class BoardModel : Form
	{
		private Controller microcontroller;
		private Action<PictureBox> LedSwitcher;

		public bool IsTxLedActive => txLedPicture.Visible;
		public bool IsRxLedActive => rxLedPicture.Visible;
		public bool IsOnLedActive => onLedPicture.Visible;

		private async void TXBlinckAsync(object sender, UARTEventArgs e)
		{
			await Task.Run(() =>
			{
				if (!IsDisposed)
				{
					Invoke(LedSwitcher, txLedPicture);
				}

				Thread.Sleep(100);

				if (!IsDisposed)
				{
					Invoke(LedSwitcher, txLedPicture);
				}
			});
		}

		public BoardModel()
		{
			LedSwitcher = (led) => led.Visible = !led.Visible;
			InitializeComponent();
		}

		public void SetMicrocontroller(Controller microcontroller)
		{
			this.microcontroller = microcontroller;
			this.microcontroller.OnStatusChanged += ChangeOnLed;
			this.microcontroller.UartUnit.OnCharWriting += TXBlinckAsync;
		}

		private void ChangeOnLed() => onLedPicture.Visible = microcontroller.IsRunning;

		private void BoardModel_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (microcontroller != null)
			{
				microcontroller.UartUnit.OnCharWriting -= TXBlinckAsync;
			}
		}
	}
}
