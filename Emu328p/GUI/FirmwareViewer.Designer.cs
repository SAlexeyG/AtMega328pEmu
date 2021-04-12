
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
			this.opcodeListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.opcodeListBox.FormattingEnabled = true;
			this.opcodeListBox.ItemHeight = 19;
			this.opcodeListBox.Location = new System.Drawing.Point(12, 12);
			this.opcodeListBox.Name = "opcodeListBox";
			this.opcodeListBox.Size = new System.Drawing.Size(204, 403);
			this.opcodeListBox.TabIndex = 2;
			// 
			// FirmwareViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 423);
			this.Controls.Add(this.opcodeListBox);
			this.Name = "FirmwareViewer";
			this.Text = "FirmwareViewer";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox opcodeListBox;
	}
}