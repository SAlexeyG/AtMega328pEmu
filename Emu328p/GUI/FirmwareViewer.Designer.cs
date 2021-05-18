
namespace Emu328p.GUI
{
	partial class FirmwareViewer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.opcodeListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// opcodeListBox
			// 
			this.opcodeListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.opcodeListBox.BackColor = System.Drawing.Color.Black;
			this.opcodeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.opcodeListBox.ColumnWidth = 80;
			this.opcodeListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.opcodeListBox.ForeColor = System.Drawing.Color.Green;
			this.opcodeListBox.FormattingEnabled = true;
			this.opcodeListBox.IntegralHeight = false;
			this.opcodeListBox.ItemHeight = 19;
			this.opcodeListBox.Location = new System.Drawing.Point(9, 9);
			this.opcodeListBox.Margin = new System.Windows.Forms.Padding(0);
			this.opcodeListBox.MultiColumn = true;
			this.opcodeListBox.Name = "opcodeListBox";
			this.opcodeListBox.Size = new System.Drawing.Size(558, 426);
			this.opcodeListBox.TabIndex = 2;
			// 
			// FirmwareViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(576, 446);
			this.ControlBox = false;
			this.Controls.Add(this.opcodeListBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FirmwareViewer";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Прошивка";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox opcodeListBox;
	}
}