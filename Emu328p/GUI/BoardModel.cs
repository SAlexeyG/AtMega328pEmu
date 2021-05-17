using Emu328p.Emulator;
using Emu328p.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
		private bool isRotated = false;

		private Dictionary<PictureBox, Point> rotationVectors 
			= new Dictionary<PictureBox, Point>();

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
			rotationVectors.Add(onLedPicture, new Point(-85, -164));
			rotationVectors.Add(rxLedPicture, new Point(66, -15));
			rotationVectors.Add(txLedPicture, new Point(60, -4));
			rotationVectors.Add(resetButtonPicture, new Point(80, 126));
		}

		public void SetMicrocontroller(Controller microcontroller)
		{
			this.microcontroller = microcontroller;
			this.microcontroller.OnStatusChanged += ChangeOnLed;
			this.microcontroller.UartUnit.OnCharWriting += TXBlinckAsync;
		}

		private void ChangeOnLed()
		{
			onLedPicture.Visible = microcontroller.IsRunning;
		}

		private void BoardModel_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (microcontroller != null)
			{
				microcontroller.UartUnit.OnCharWriting -= TXBlinckAsync;
			}
		}

		private void RotatePicture(PictureBox picture)
		{
			Point vector = rotationVectors[picture];

			vector.X *= !isRotated ? 1 : -1;
			vector.Y *= !isRotated ? 1 : -1;

			Point tmp = picture.Location;
			tmp.Offset(vector);
			picture.Location = tmp;
		}

		private void toolStripRotateButton_Click(object sender, EventArgs e)
		{
			Image image = Properties.Resources.arduino_board2;

			if (!isRotated)
			{
				image.RotateFlip(RotateFlipType.Rotate270FlipXY);
			}

			picturePanel.BackgroundImage = image;
			
			int tmp = Width;
			Width = Height;
			Height = tmp;

			RotatePicture(onLedPicture);
			RotatePicture(rxLedPicture);
			RotatePicture(txLedPicture);
			RotatePicture(resetButtonPicture);

			isRotated = !isRotated;
		}
	}
}
