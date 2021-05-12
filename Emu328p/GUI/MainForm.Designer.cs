
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
			this.menuWindowBoardModel = new System.Windows.Forms.ToolStripMenuItem();
			this.menuWindowFirmware = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuWindowUser = new System.Windows.Forms.ToolStripMenuItem();
			this.menuPlayType = new System.Windows.Forms.ToolStripComboBox();
			this.menuPlay = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStop = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip.SuspendLayout();
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
			this.menuStrip.Size = new System.Drawing.Size(912, 27);
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
            this.menuWindowUART,
            this.menuWindowBoardModel,
            this.menuWindowFirmware,
            this.toolStripSeparator1,
            this.menuWindowUser});
			this.menuWindow.Name = "menuWindow";
			this.menuWindow.Size = new System.Drawing.Size(48, 23);
			this.menuWindow.Text = "Окно";
			// 
			// menuWindowUART
			// 
			this.menuWindowUART.CheckOnClick = true;
			this.menuWindowUART.Name = "menuWindowUART";
			this.menuWindowUART.Size = new System.Drawing.Size(166, 22);
			this.menuWindowUART.Text = "UART";
			this.menuWindowUART.Click += new System.EventHandler(this.menuWindowUART_Click);
			// 
			// menuWindowBoardModel
			// 
			this.menuWindowBoardModel.CheckOnClick = true;
			this.menuWindowBoardModel.Name = "menuWindowBoardModel";
			this.menuWindowBoardModel.Size = new System.Drawing.Size(166, 22);
			this.menuWindowBoardModel.Text = "Модель платы";
			this.menuWindowBoardModel.Click += new System.EventHandler(this.menuWindowBoardModel_Click);
			// 
			// menuWindowFirmware
			// 
			this.menuWindowFirmware.CheckOnClick = true;
			this.menuWindowFirmware.Name = "menuWindowFirmware";
			this.menuWindowFirmware.Size = new System.Drawing.Size(166, 22);
			this.menuWindowFirmware.Text = "Прошивка";
			this.menuWindowFirmware.Click += new System.EventHandler(this.menuWindowFirmware_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
			// 
			// menuWindowUser
			// 
			this.menuWindowUser.CheckOnClick = true;
			this.menuWindowUser.Name = "menuWindowUser";
			this.menuWindowUser.Size = new System.Drawing.Size(166, 22);
			this.menuWindowUser.Text = "Личный кабинет";
			this.menuWindowUser.Click += new System.EventHandler(this.menuWindowUser_Click);
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
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.Filter = "Binary files(*.bin)|*.bin|Hexadecimal files(*.hex)|*.hex|All files(*.*)|*.*";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(912, 653);
			this.Controls.Add(this.menuStrip);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Emu328p";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
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
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ToolStripMenuItem menuWindowUART;
		private System.Windows.Forms.ToolStripMenuItem menuStop;
		private System.Windows.Forms.ToolStripMenuItem menuWindowBoardModel;
		private System.Windows.Forms.ToolStripMenuItem menuWindowFirmware;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuWindowUser;
	}
}

