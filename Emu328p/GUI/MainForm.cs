using Emu328p.Emulator;
using Emu328p.GUI;
using Emu328p.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emu328p.GUI
{
	public partial class MainForm : Form
	{
		private Controller microcontroller = null;
		private Dictionary<string, Action> playType = new Dictionary<string, Action>();
		private UART uartWindow;
		private Action<PictureBox> LedSwitcher;

		public MainForm()
		{
			InitializeComponent();
			uartWindow = new UART();
			uartWindow.Show();
			uartWindow.Visible = false;
			LedSwitcher = (led) => led.Visible = !led.Visible;
		}

		private void menuPlay_Click(object sender, EventArgs e)
		{
			playType[menuPlayType.Text]?.Invoke();
			onLedPicture.Visible = true;
		}

		private void menuWindowUART_Click(object sender, EventArgs e)
		{
			uartWindow.Visible = menuWindowUART.Checked;
		}

		private void file_open_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}

			string filePath = openFileDialog.FileName;
			byte[] firmware = FileReader.ReadBin(filePath);

			microcontroller = new Controller(firmware);

			playType.Add("Запуск", PlayRunning);
			playType.Add("Отладка", PlayDebugging);

			menuPlay.Enabled = true;
			FillOpcodeListBox(firmware);
			uartWindow.SetUARTUnit(microcontroller.UartUnit);
			microcontroller.UartUnit.OnCharWriting += TXBlinckAsync;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (microcontroller != null)
			{
				microcontroller.UartUnit.OnCharWriting -= TXBlinckAsync;
				microcontroller.Stop();
			}
		}

		private void menuStop_Click(object sender, EventArgs e)
		{
			menuPlayType.Enabled = true;
			menuStop.Enabled = false;
			menuPlay.Enabled = true;
			menuPlay.Text = "Пуск";

			playType["Отладка"] -= DebugNext;
			playType["Отладка"] += PlayDebugging;

			microcontroller.Stop();
			microcontroller.Reset();

			uartWindow.Clear();
		}

		private void resetButtonPicture_Click(object sender, EventArgs e)
		{
			microcontroller.Stop();
			microcontroller.Reset();
		}

		private void FillOpcodeListBox(byte[] firmware)
		{
			for (int i = 0; i < firmware.Length; i += 2)
			{
				ushort opcode = firmware[i + 1];
				opcode <<= 8;
				opcode |= firmware[i];
				opcodeListBox.Items.Add(opcode.ToHexString());
			}
		}

		private void PlayRunning()
		{
			menuPlayType.Enabled = false;
			menuStop.Enabled = true;
			menuPlay.Enabled = false;
			microcontroller.RunAsync();
		}

		private void PlayDebugging()
		{
			menuPlayType.Enabled = false;
			menuStop.Enabled = true;
			menuPlay.Text = "Далее";
			playType["Отладка"] -= PlayDebugging;
			playType["Отладка"] += DebugNext;
			opcodeListBox.SelectedIndex = (int)microcontroller.FlashManager.PC / 2;
		}

		private void DebugNext()
		{
			microcontroller.ExecuteOneAsync();
			opcodeListBox.SelectedIndex = (int)microcontroller.FlashManager.PC / 2;
		}

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
	}
}
