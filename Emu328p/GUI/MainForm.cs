using Emu328p.Emulator;
using Emu328p.GUI;
using Emu328p.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
		private Dictionary<string, Action> playType =
			new Dictionary<string, Action>();

		private Dictionary<string, Func<string, byte[]>> readers =
			new Dictionary<string, Func<string, byte[]>>();

		private UART uartWindow;
		private BoardModel boardWindow;
		private FirmwareViewer firmwareWindow;

		public MainForm()
		{
			InitializeComponent();

			readers.Add(".bin", FileReader.ReadBin);
			readers.Add(".hex", FileReader.ReadHex);

			uartWindow = new UART();
			uartWindow.MdiParent = this;
			uartWindow.Show();
			uartWindow.Visible = false;

			boardWindow = new BoardModel();
			boardWindow.MdiParent = this;
			boardWindow.Show();
			boardWindow.Visible = false;

			firmwareWindow = new FirmwareViewer();
			firmwareWindow.MdiParent = this;
			firmwareWindow.Show();
			firmwareWindow.Visible = false;
		}

		private void menuPlay_Click(object sender, EventArgs e)
		{
			playType[menuPlayType.Text]?.Invoke();
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
			byte[] firmware = readers[filePath.Substring(filePath.Length - 4)](filePath);

			microcontroller = new Controller(firmware);

			playType.Add("Запуск", PlayRunning);
			playType.Add("Отладка", PlayDebugging);

			menuPlay.Enabled = true;

			uartWindow.SetUARTUnit(microcontroller.UartUnit);
			boardWindow.SetMicrocontroller(microcontroller);
			firmwareWindow.SetFlashManager(microcontroller.FlashManager);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			microcontroller?.Stop();
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
		}

		private void DebugNext()
		{
			microcontroller.ExecuteOneAsync();
		}

		private void menuWindowBoardModel_Click(object sender, EventArgs e)
		{
			boardWindow.Visible = menuWindowBoardModel.Checked;
		}

		private void menuWindowFirmware_Click(object sender, EventArgs e)
		{
			firmwareWindow.Visible = menuWindowFirmware.Checked;
		}
	}
}
