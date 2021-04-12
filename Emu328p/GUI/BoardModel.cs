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
		private Action<PictureBox> LedSwitcher;

		public bool IsTxLedActive
		{
			get => txLedPicture.Visible;
			set => txLedPicture.Visible = value;
		}

		public bool IsRxLedActive
		{
			get => rxLedPicture.Visible;
			set => rxLedPicture.Visible = value;
		}

		public bool IsOnLedActive
		{
			get => onLedPicture.Visible;
			set => onLedPicture.Visible = value;
		}

		public async void TXBlinckAsync(object sender, UARTEventArgs e)
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
	}
}
