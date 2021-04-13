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
		private IFlash flashManager;
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

		public void SetFlashManager(IFlash flashManager)
		{
			this.flashManager = flashManager;
			this.flashManager.OnPCChanged += UpdateListBox;
			FillOpcodeListBox(this.flashManager.GetFirmware);
		}

		private void UpdateListBox()
		{
			Invoke(changeListBoxSelectedIndex);
		}

		public FirmwareViewer()
		{
			changeListBoxSelectedIndex = 
				() => opcodeListBox.SelectedIndex = (int)flashManager.PC / 2;
			InitializeComponent();
		}
	}
}
