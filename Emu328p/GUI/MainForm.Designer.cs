
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
			this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.menuWindowUART = new System.Windows.Forms.ToolStripMenuItem();
			this.menuWindowBoardModel = new System.Windows.Forms.ToolStripMenuItem();
			this.menuWindowFirmware = new System.Windows.Forms.ToolStripMenuItem();
			this.menuWindowSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.menuWindowUser = new System.Windows.Forms.ToolStripMenuItem();
			this.menuWindowAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.menuWindowHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripPlayType = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripPlay = new System.Windows.Forms.ToolStripButton();
			this.toolStripStop = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuWindow});
			this.menuStrip.Location = new System.Drawing.Point(20, 60);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(875, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_open,
            this.menuFileSaveAs});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(48, 20);
			this.menuFile.Text = "Файл";
			// 
			// file_open
			// 
			this.file_open.Name = "file_open";
			this.file_open.Size = new System.Drawing.Size(163, 22);
			this.file_open.Text = "Открыть...";
			this.file_open.Click += new System.EventHandler(this.file_open_Click);
			// 
			// menuFileSaveAs
			// 
			this.menuFileSaveAs.Name = "menuFileSaveAs";
			this.menuFileSaveAs.Size = new System.Drawing.Size(163, 22);
			this.menuFileSaveAs.Text = "Сохранить как...";
			this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
			// 
			// menuWindow
			// 
			this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWindowUART,
            this.menuWindowBoardModel,
            this.menuWindowFirmware,
            this.menuWindowSeparator,
            this.menuWindowUser,
            this.menuWindowAbout,
            this.menuWindowHelp});
			this.menuWindow.Name = "menuWindow";
			this.menuWindow.Size = new System.Drawing.Size(48, 20);
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
			// menuWindowSeparator
			// 
			this.menuWindowSeparator.Name = "menuWindowSeparator";
			this.menuWindowSeparator.Size = new System.Drawing.Size(163, 6);
			// 
			// menuWindowUser
			// 
			this.menuWindowUser.CheckOnClick = true;
			this.menuWindowUser.Name = "menuWindowUser";
			this.menuWindowUser.Size = new System.Drawing.Size(166, 22);
			this.menuWindowUser.Text = "Личный кабинет";
			this.menuWindowUser.Click += new System.EventHandler(this.menuWindowUser_Click);
			// 
			// menuWindowAbout
			// 
			this.menuWindowAbout.CheckOnClick = true;
			this.menuWindowAbout.Name = "menuWindowAbout";
			this.menuWindowAbout.Size = new System.Drawing.Size(166, 22);
			this.menuWindowAbout.Text = "О Программе";
			this.menuWindowAbout.Click += new System.EventHandler(this.menuWindowAbout_Click);
			// 
			// menuWindowHelp
			// 
			this.menuWindowHelp.CheckOnClick = true;
			this.menuWindowHelp.Name = "menuWindowHelp";
			this.menuWindowHelp.Size = new System.Drawing.Size(166, 22);
			this.menuWindowHelp.Text = "Справка";
			this.menuWindowHelp.Click += new System.EventHandler(this.menuWindowHelp_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.Filter = "Binary files(*.bin)|*.bin|Hexadecimal files(*.hex)|*.hex|All files(*.*)|*.*";
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripPlayType,
            this.toolStripPlay,
            this.toolStripStop,
            this.toolStripSeparator3});
			this.toolStrip.Location = new System.Drawing.Point(20, 84);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(875, 25);
			this.toolStrip.TabIndex = 2;
			this.toolStrip.Text = "toolStrip";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripPlayType
			// 
			this.toolStripPlayType.Items.AddRange(new object[] {
            "Запуск",
            "Отладка"});
			this.toolStripPlayType.Name = "toolStripPlayType";
			this.toolStripPlayType.Size = new System.Drawing.Size(121, 25);
			this.toolStripPlayType.Text = "Запуск";
			// 
			// toolStripPlay
			// 
			this.toolStripPlay.BackgroundImage = global::Emu328p.Properties.Resources.button_50_hover;
			this.toolStripPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.toolStripPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripPlay.Enabled = false;
			this.toolStripPlay.Image = global::Emu328p.Properties.Resources.play;
			this.toolStripPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripPlay.Name = "toolStripPlay";
			this.toolStripPlay.Size = new System.Drawing.Size(23, 22);
			this.toolStripPlay.Text = "Пуск";
			this.toolStripPlay.Click += new System.EventHandler(this.menuPlay_Click);
			// 
			// toolStripStop
			// 
			this.toolStripStop.BackgroundImage = global::Emu328p.Properties.Resources.button_50_hover;
			this.toolStripStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.toolStripStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripStop.Enabled = false;
			this.toolStripStop.Image = global::Emu328p.Properties.Resources.pause;
			this.toolStripStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripStop.Name = "toolStripStop";
			this.toolStripStop.Size = new System.Drawing.Size(23, 22);
			this.toolStripStop.Text = "Стоп";
			this.toolStripStop.ToolTipText = "Стоп";
			this.toolStripStop.Click += new System.EventHandler(this.menuStop_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "Binary files(*.bin)|*.bin";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 801);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Emu328p";
			this.TransparencyKey = System.Drawing.Color.Empty;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem file_open;
		private System.Windows.Forms.ToolStripMenuItem menuWindow;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ToolStripMenuItem menuWindowUART;
		private System.Windows.Forms.ToolStripMenuItem menuWindowBoardModel;
		private System.Windows.Forms.ToolStripMenuItem menuWindowFirmware;
		private System.Windows.Forms.ToolStripSeparator menuWindowSeparator;
		private System.Windows.Forms.ToolStripMenuItem menuWindowUser;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton toolStripPlay;
		private System.Windows.Forms.ToolStripButton toolStripStop;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripComboBox toolStripPlayType;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ToolStripMenuItem menuWindowAbout;
		private System.Windows.Forms.ToolStripMenuItem menuWindowHelp;
	}
}

