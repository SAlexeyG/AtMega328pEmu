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
		public int SelectedOpcode
		{
			get => opcodeListBox.SelectedIndex;
			set => opcodeListBox.SelectedIndex = value;
		}

		public void FillOpcodeListBox(byte[] firmware)
		{
			for (int i = 0; i < firmware.Length; i += 2)
			{
				ushort opcode = firmware[i + 1];
				opcode <<= 8;
				opcode |= firmware[i];
				opcodeListBox.Items.Add(opcode.ToHexString());
			}
		}

		public FirmwareViewer()
		{
			InitializeComponent();
		}
	}
}
