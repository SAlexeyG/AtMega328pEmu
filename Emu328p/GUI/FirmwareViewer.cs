using Emu328p.Emulator;
using Emu328p.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emu328p.GUI
{
	public partial class FirmwareViewer : Form
	{
		private Controller microcontroller;
		private Action changeListBoxSelectedIndex;

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

		public void SetFlashManager(Controller microcontroller)
		{
			this.microcontroller = microcontroller;
			this.microcontroller.FlashManager.OnPCChanged += UpdateListBox;
			FillOpcodeListBox(this.microcontroller.FlashManager.GetFirmware);
		}

		private void UpdateListBox()
		{
			if (microcontroller.IsRunning) return;
			Invoke(changeListBoxSelectedIndex);
		}

		public FirmwareViewer()
		{
			changeListBoxSelectedIndex = 
				() => opcodeListBox.SelectedIndex = (int)(microcontroller.FlashManager.PC / 2);
			InitializeComponent();
		}
	}
}
