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
		private Cabinet cabinetWindow;
		private About aboutWindow;
		private Help helpWindow;

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

			cabinetWindow = new Cabinet();
			cabinetWindow.MdiParent = this;
			cabinetWindow.Show();
			cabinetWindow.Visible = false;

			aboutWindow = new About();
			aboutWindow.MdiParent = this;
			aboutWindow.Show();
			aboutWindow.Visible = false;

			helpWindow = new Help();
			helpWindow.MdiParent = this;
			helpWindow.Show();
			helpWindow.Visible = false;
		}

		private void menuPlay_Click(object sender, EventArgs e)
		{
			playType[toolStripPlayType.Text]?.Invoke();
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

			playType.Clear();
			playType.Add("Запуск", PlayRunning);
			playType.Add("Отладка", PlayDebugging);

			toolStripPlay.Enabled = true;

			uartWindow.SetUARTUnit(microcontroller.UartUnit);
			boardWindow.SetMicrocontroller(microcontroller);
			firmwareWindow.SetFlashManager(microcontroller);
		}

		private void menuFileSaveAs_Click(object sender, EventArgs e)
		{
			if(saveFileDialog.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}

			string filePath = saveFileDialog.FileName;
			FileWriter.WriteBin(filePath, microcontroller != null ? microcontroller.FlashManager.GetFirmware : new byte[] { 0 });
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			microcontroller?.Stop();
		}

		private void menuStop_Click(object sender, EventArgs e)
		{
			toolStripPlayType.Enabled = true;
			toolStripStop.Enabled = false;
			toolStripPlay.Enabled = true;
			toolStripPlay.Text = "Пуск";

			playType["Отладка"] -= DebugNext;
			playType["Отладка"] -= PlayDebugging;
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
			toolStripPlayType.Enabled = false;
			toolStripStop.Enabled = true;
			toolStripPlay.Enabled = false;
			microcontroller.RunAsync();
		}

		private void PlayDebugging()
		{
			toolStripPlayType.Enabled = false;
			toolStripStop.Enabled = true;
			toolStripPlay.Text = "Далее";
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

		private void menuWindowUART_Click(object sender, EventArgs e)
		{
			uartWindow.Visible = menuWindowUART.Checked;
		}

		private void menuWindowUser_Click(object sender, EventArgs e)
		{
			cabinetWindow.Visible = menuWindowUser.Checked;
		}

		private void menuWindowAbout_Click(object sender, EventArgs e)
		{
			aboutWindow.Visible = menuWindowAbout.Checked;
		}

		private void menuWindowHelp_Click(object sender, EventArgs e)
		{
			helpWindow.Visible = menuWindowHelp.Checked;
		}
	}
}
