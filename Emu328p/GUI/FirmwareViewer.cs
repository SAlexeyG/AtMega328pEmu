using Emu328p.Emulator;
using Emu328p.Tools;
using MetroFramework.Forms;
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
	public partial class FirmwareViewer : MetroForm
	{
		private Controller microcontroller;
		private Action changeListBoxSelectedIndex;

		private void FillOpcodeListBox(byte[] firmware)
		{
			opcodeListBox.Items.Clear();
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

		private void cancelButton_Click(object sender, EventArgs e)
		{
			changePanel.Visible = false;
		}

		private void changeButton_Click(object sender, EventArgs e)
		{
			if (!newOpcodeTextBox.MaskFull)
			{
				MessageBox.Show("Введите значение в поле ввода");
				return;
			}

			ushort opcode;
			uint offset = (uint)opcodeListBox.SelectedIndex * 2;

			try
			{
				opcode = (ushort)Convert.ToInt32(newOpcodeTextBox.Text.Substring(2).ToLower(), 16);
			}
			catch (Exception)
			{
				MessageBox.Show("Неверный формат ввода");
				return;
			}

			if(offset < 0)
			{
				MessageBox.Show("Выберите изменяемое значение");
				return;
			}

			microcontroller.FlashManager.SetWord(offset, opcode);
			FillOpcodeListBox(this.microcontroller.FlashManager.GetFirmware);
		}

		private void opcodeListBox_DoubleClick(object sender, EventArgs e)
		{
			if (microcontroller.IsRunning) return;
			changePanel.Visible = true;
		}
	}
}
