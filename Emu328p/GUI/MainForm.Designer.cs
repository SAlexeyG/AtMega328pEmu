
namespace Emu328p.GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.file_open = new System.Windows.Forms.ToolStripMenuItem();
			this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.menuWindowUART = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPlayType = new System.Windows.Forms.ToolStripComboBox();
			this.menuPlay = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStop = new System.Windows.Forms.ToolStripMenuItem();
			this.opcodeListBox = new System.Windows.Forms.ListBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.picturePanel = new System.Windows.Forms.Panel();
			this.resetButtonPicture = new System.Windows.Forms.PictureBox();
			this.onLedPicture = new System.Windows.Forms.PictureBox();
			this.txLedPicture = new System.Windows.Forms.PictureBox();
			this.rxLedPicture = new System.Windows.Forms.PictureBox();
			this.menuStrip.SuspendLayout();
			this.picturePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.resetButtonPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.onLedPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txLedPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rxLedPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuWindow,
            this.menuPlayType,
            this.menuPlay,
            this.menuStop});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(769, 27);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_open});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(48, 23);
			this.menuFile.Text = "Файл";
			// 
			// file_open
			// 
			this.file_open.Name = "file_open";
			this.file_open.Size = new System.Drawing.Size(130, 22);
			this.file_open.Text = "Открыть...";
			this.file_open.Click += new System.EventHandler(this.file_open_Click);
			// 
			// menuWindow
			// 
			this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWindowUART});
			this.menuWindow.Name = "menuWindow";
			this.menuWindow.Size = new System.Drawing.Size(48, 23);
			this.menuWindow.Text = "Окно";
			// 
			// menuWindowUART
			// 
			this.menuWindowUART.CheckOnClick = true;
			this.menuWindowUART.Name = "menuWindowUART";
			this.menuWindowUART.Size = new System.Drawing.Size(102, 22);
			this.menuWindowUART.Text = "UART";
			this.menuWindowUART.Click += new System.EventHandler(this.menuWindowUART_Click);
			// 
			// menuPlayType
			// 
			this.menuPlayType.Items.AddRange(new object[] {
            "Запуск",
            "Отладка"});
			this.menuPlayType.Name = "menuPlayType";
			this.menuPlayType.Size = new System.Drawing.Size(121, 23);
			this.menuPlayType.Text = "Запуск";
			// 
			// menuPlay
			// 
			this.menuPlay.BackColor = System.Drawing.Color.LightGreen;
			this.menuPlay.Enabled = false;
			this.menuPlay.Name = "menuPlay";
			this.menuPlay.Size = new System.Drawing.Size(46, 23);
			this.menuPlay.Text = "Пуск";
			this.menuPlay.Click += new System.EventHandler(this.menuPlay_Click);
			// 
			// menuStop
			// 
			this.menuStop.BackColor = System.Drawing.Color.Brown;
			this.menuStop.Enabled = false;
			this.menuStop.Name = "menuStop";
			this.menuStop.Size = new System.Drawing.Size(46, 23);
			this.menuStop.Text = "Стоп";
			this.menuStop.Click += new System.EventHandler(this.menuStop_Click);
			// 
			// opcodeListBox
			// 
			this.opcodeListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.opcodeListBox.FormattingEnabled = true;
			this.opcodeListBox.ItemHeight = 19;
			this.opcodeListBox.Location = new System.Drawing.Point(12, 30);
			this.opcodeListBox.Name = "opcodeListBox";
			this.opcodeListBox.Size = new System.Drawing.Size(204, 403);
			this.opcodeListBox.TabIndex = 1;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.Filter = "Binary files(*.bin)|*.bin|Hexadecimal files(*.hex)|*.hex|All files(*.*)|*.*";
			// 
			// picturePanel
			// 
			this.picturePanel.BackgroundImage = global::Emu328p.Properties.Resources.arduino_board2;
			this.picturePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picturePanel.Controls.Add(this.resetButtonPicture);
			this.picturePanel.Controls.Add(this.onLedPicture);
			this.picturePanel.Controls.Add(this.txLedPicture);
			this.picturePanel.Controls.Add(this.rxLedPicture);
			this.picturePanel.Location = new System.Drawing.Point(222, 30);
			this.picturePanel.Name = "picturePanel";
			this.picturePanel.Size = new System.Drawing.Size(535, 403);
			this.picturePanel.TabIndex = 3;
			// 
			// resetButtonPicture
			// 
			this.resetButtonPicture.BackColor = System.Drawing.Color.Transparent;
			this.resetButtonPicture.Location = new System.Drawing.Point(366, 78);
			this.resetButtonPicture.Name = "resetButtonPicture";
			this.resetButtonPicture.Size = new System.Drawing.Size(15, 15);
			this.resetButtonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.resetButtonPicture.TabIndex = 5;
			this.resetButtonPicture.TabStop = false;
			this.resetButtonPicture.Click += new System.EventHandler(this.resetButtonPicture_Click);
			// 
			// onLedPicture
			// 
			this.onLedPicture.BackColor = System.Drawing.Color.Transparent;
			this.onLedPicture.Image = global::Emu328p.Properties.Resources.OnLED;
			this.onLedPicture.Location = new System.Drawing.Point(307, 316);
			this.onLedPicture.Name = "onLedPicture";
			this.onLedPicture.Size = new System.Drawing.Size(32, 32);
			this.onLedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.onLedPicture.TabIndex = 4;
			this.onLedPicture.TabStop = false;
			this.onLedPicture.Visible = false;
			// 
			// txLedPicture
			// 
			this.txLedPicture.BackColor = System.Drawing.Color.Transparent;
			this.txLedPicture.Image = global::Emu328p.Properties.Resources.LED;
			this.txLedPicture.Location = new System.Drawing.Point(304, 153);
			this.txLedPicture.Name = "txLedPicture";
			this.txLedPicture.Size = new System.Drawing.Size(32, 32);
			this.txLedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.txLedPicture.TabIndex = 3;
			this.txLedPicture.TabStop = false;
			this.txLedPicture.Visible = false;
			// 
			// rxLedPicture
			// 
			this.rxLedPicture.BackColor = System.Drawing.Color.Transparent;
			this.rxLedPicture.Image = global::Emu328p.Properties.Resources.LED;
			this.rxLedPicture.Location = new System.Drawing.Point(296, 153);
			this.rxLedPicture.Name = "rxLedPicture";
			this.rxLedPicture.Size = new System.Drawing.Size(32, 32);
			this.rxLedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.rxLedPicture.TabIndex = 2;
			this.rxLedPicture.TabStop = false;
			this.rxLedPicture.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 446);
			this.Controls.Add(this.picturePanel);
			this.Controls.Add(this.opcodeListBox);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "Emu328p";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.picturePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.resetButtonPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.onLedPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txLedPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rxLedPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem file_open;
		private System.Windows.Forms.ToolStripMenuItem menuWindow;
		private System.Windows.Forms.ToolStripComboBox menuPlayType;
		private System.Windows.Forms.ToolStripMenuItem menuPlay;
		private System.Windows.Forms.ListBox opcodeListBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.PictureBox rxLedPicture;
		private System.Windows.Forms.Panel picturePanel;
		private System.Windows.Forms.PictureBox onLedPicture;
		private System.Windows.Forms.PictureBox txLedPicture;
		private System.Windows.Forms.ToolStripMenuItem menuWindowUART;
		private System.Windows.Forms.ToolStripMenuItem menuStop;
		private System.Windows.Forms.PictureBox resetButtonPicture;
	}
}

