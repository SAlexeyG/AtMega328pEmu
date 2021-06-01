
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
			this.changePanel = new System.Windows.Forms.Panel();
			this.newOpcodeLabel = new System.Windows.Forms.Label();
			this.changeButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.newOpcodeTextBox = new System.Windows.Forms.MaskedTextBox();
			this.changePanel.SuspendLayout();
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
			this.opcodeListBox.Location = new System.Drawing.Point(20, 60);
			this.opcodeListBox.Margin = new System.Windows.Forms.Padding(0);
			this.opcodeListBox.MultiColumn = true;
			this.opcodeListBox.Name = "opcodeListBox";
			this.opcodeListBox.Size = new System.Drawing.Size(510, 408);
			this.opcodeListBox.TabIndex = 2;
			this.opcodeListBox.DoubleClick += new System.EventHandler(this.opcodeListBox_DoubleClick);
			// 
			// changePanel
			// 
			this.changePanel.BackColor = System.Drawing.Color.White;
			this.changePanel.Controls.Add(this.newOpcodeLabel);
			this.changePanel.Controls.Add(this.changeButton);
			this.changePanel.Controls.Add(this.cancelButton);
			this.changePanel.Controls.Add(this.newOpcodeTextBox);
			this.changePanel.Location = new System.Drawing.Point(20, 60);
			this.changePanel.Name = "changePanel";
			this.changePanel.Size = new System.Drawing.Size(227, 89);
			this.changePanel.TabIndex = 3;
			this.changePanel.Visible = false;
			// 
			// newOpcodeLabel
			// 
			this.newOpcodeLabel.AutoSize = true;
			this.newOpcodeLabel.Location = new System.Drawing.Point(3, 6);
			this.newOpcodeLabel.Name = "newOpcodeLabel";
			this.newOpcodeLabel.Size = new System.Drawing.Size(89, 13);
			this.newOpcodeLabel.TabIndex = 7;
			this.newOpcodeLabel.Text = "Новое значение";
			// 
			// changeButton
			// 
			this.changeButton.Location = new System.Drawing.Point(146, 63);
			this.changeButton.Name = "changeButton";
			this.changeButton.Size = new System.Drawing.Size(75, 23);
			this.changeButton.TabIndex = 6;
			this.changeButton.Text = "Изменить";
			this.changeButton.UseVisualStyleBackColor = true;
			this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(3, 63);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 5;
			this.cancelButton.Text = "Закрыть";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// newOpcodeTextBox
			// 
			this.newOpcodeTextBox.Location = new System.Drawing.Point(98, 3);
			this.newOpcodeTextBox.Mask = "\\0x>A>A>A>A";
			this.newOpcodeTextBox.Name = "newOpcodeTextBox";
			this.newOpcodeTextBox.Size = new System.Drawing.Size(123, 20);
			this.newOpcodeTextBox.TabIndex = 4;
			// 
			// FirmwareViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(550, 488);
			this.ControlBox = false;
			this.Controls.Add(this.changePanel);
			this.Controls.Add(this.opcodeListBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FirmwareViewer";
			this.Opacity = 0.8D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Прошивка";
			this.changePanel.ResumeLayout(false);
			this.changePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox opcodeListBox;
		private System.Windows.Forms.Panel changePanel;
		private System.Windows.Forms.Label newOpcodeLabel;
		private System.Windows.Forms.Button changeButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.MaskedTextBox newOpcodeTextBox;
	}
}