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
	public partial class About : MetroForm
	{
		public About()
		{
			InitializeComponent();
		}

		private void About_Load(object sender, EventArgs e)
		{
			textBox.Text = "Разработал: Смышляев Алексей Геннадьевич. " +
				"\r\nГруппа 35ТП." +
				"\r\nУО\"МГК Электроники\"" +
				"\r\n2020г.";
		}
	}
}
