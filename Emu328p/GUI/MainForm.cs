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

		public MainForm()
		{
			InitializeComponent();
			uartWindow = new UART();
			uartWindow.Show();
			uartWindow.Visible = false;
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

			playType.Add("Запуск", () => 
			{
				menuPlayType.Enabled = false;
				menuStop.Enabled = true;
				menuPlay.Enabled = false;
				microcontroller.RunAsync(); 
			});

			playType.Add("Отладка", () => 
			{
				menuPlayType.Enabled = false;
				menuStop.Enabled = true;
				menuPlay.Text = "Далее";
				microcontroller.ExecuteOneAsync();
				opcodeListBox.SelectedIndex = (int) microcontroller.FlashManager.PC / 2;
			});

			menuPlay.Enabled = true;

			for (int i = 0; i < firmware.Length; i += 2)
			{
				ushort opcode = firmware[i + 1];
				opcode <<= 8;
				opcode |= firmware[i];
				opcodeListBox.Items.Add(UshortToHexString(opcode));
			}

			uartWindow.SetUARTUnit(microcontroller.UartUnit);
			microcontroller.UartUnit.OnCharWriting += TXBlinckAsync;
		}

		private string UshortToHexString(ushort opcode)
		{
			string hexOpcode = Convert.ToString(opcode, 16).ToUpper();
			while (hexOpcode.Length < 4)
			{
				hexOpcode = hexOpcode.Insert(0, "0");
			}

			hexOpcode = hexOpcode.Insert(0, "0x");
			return hexOpcode;
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

		private async void TXBlinckAsync(char _)
		{
			await Task.Run(() =>
			{
				Invoke(new Action(() => txLedPicture.Visible = true));
				Thread.Sleep(100);
				Invoke(new Action(() => txLedPicture.Visible = false));
			});
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

			microcontroller.Stop();
			microcontroller.Reset();

			uartWindow.Clear();
		}

		private void resetButtonPicture_Click(object sender, EventArgs e)
		{
			microcontroller.Stop();
			microcontroller.Reset();
		}
	}
}
