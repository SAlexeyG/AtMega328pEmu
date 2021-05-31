
namespace Emu328p.GUI
{
	partial class NewPass
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
			this.newPassTextBox = new MetroFramework.Controls.MetroTextBox();
			this.newPassLabel = new MetroFramework.Controls.MetroLabel();
			this.codeLabel = new MetroFramework.Controls.MetroLabel();
			this.codeTextBox = new MetroFramework.Controls.MetroTextBox();
			this.checkButton = new MetroFramework.Controls.MetroButton();
			this.codeErrorLabel = new MetroFramework.Controls.MetroLabel();
			this.sendErrorLabel = new System.Windows.Forms.LinkLabel();
			this.label1 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// newPassTextBox
			// 
			// 
			// 
			// 
			this.newPassTextBox.CustomButton.Image = null;
			this.newPassTextBox.CustomButton.Location = new System.Drawing.Point(200, 2);
			this.newPassTextBox.CustomButton.Name = "";
			this.newPassTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
			this.newPassTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.newPassTextBox.CustomButton.TabIndex = 1;
			this.newPassTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.newPassTextBox.CustomButton.UseSelectable = true;
			this.newPassTextBox.CustomButton.Visible = false;
			this.newPassTextBox.Lines = new string[0];
			this.newPassTextBox.Location = new System.Drawing.Point(127, 106);
			this.newPassTextBox.MaxLength = 32767;
			this.newPassTextBox.Name = "newPassTextBox";
			this.newPassTextBox.PasswordChar = '*';
			this.newPassTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.newPassTextBox.SelectedText = "";
			this.newPassTextBox.SelectionLength = 0;
			this.newPassTextBox.SelectionStart = 0;
			this.newPassTextBox.ShortcutsEnabled = true;
			this.newPassTextBox.Size = new System.Drawing.Size(218, 20);
			this.newPassTextBox.TabIndex = 2;
			this.newPassTextBox.UseSelectable = true;
			this.newPassTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.newPassTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.newPassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			// 
			// newPassLabel
			// 
			this.newPassLabel.AutoSize = true;
			this.newPassLabel.Location = new System.Drawing.Point(23, 109);
			this.newPassLabel.Name = "newPassLabel";
			this.newPassLabel.Size = new System.Drawing.Size(98, 19);
			this.newPassLabel.TabIndex = 1;
			this.newPassLabel.Text = "Новый пароль";
			// 
			// codeLabel
			// 
			this.codeLabel.AutoSize = true;
			this.codeLabel.Location = new System.Drawing.Point(23, 135);
			this.codeLabel.Name = "codeLabel";
			this.codeLabel.Size = new System.Drawing.Size(101, 19);
			this.codeLabel.TabIndex = 3;
			this.codeLabel.Text = "Секретный код";
			// 
			// codeTextBox
			// 
			// 
			// 
			// 
			this.codeTextBox.CustomButton.Image = null;
			this.codeTextBox.CustomButton.Location = new System.Drawing.Point(200, 2);
			this.codeTextBox.CustomButton.Name = "";
			this.codeTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
			this.codeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.codeTextBox.CustomButton.TabIndex = 1;
			this.codeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.codeTextBox.CustomButton.UseSelectable = true;
			this.codeTextBox.CustomButton.Visible = false;
			this.codeTextBox.Lines = new string[0];
			this.codeTextBox.Location = new System.Drawing.Point(127, 132);
			this.codeTextBox.MaxLength = 32767;
			this.codeTextBox.Name = "codeTextBox";
			this.codeTextBox.PasswordChar = '\0';
			this.codeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.codeTextBox.SelectedText = "";
			this.codeTextBox.SelectionLength = 0;
			this.codeTextBox.SelectionStart = 0;
			this.codeTextBox.ShortcutsEnabled = true;
			this.codeTextBox.Size = new System.Drawing.Size(218, 20);
			this.codeTextBox.TabIndex = 3;
			this.codeTextBox.UseSelectable = true;
			this.codeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.codeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.codeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			// 
			// checkButton
			// 
			this.checkButton.Location = new System.Drawing.Point(23, 189);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(75, 23);
			this.checkButton.TabIndex = 100;
			this.checkButton.Text = "OK";
			this.checkButton.UseSelectable = true;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// codeErrorLabel
			// 
			this.codeErrorLabel.AutoSize = true;
			this.codeErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
			this.codeErrorLabel.Location = new System.Drawing.Point(124, 155);
			this.codeErrorLabel.Name = "codeErrorLabel";
			this.codeErrorLabel.Size = new System.Drawing.Size(101, 19);
			this.codeErrorLabel.TabIndex = 5;
			this.codeErrorLabel.Text = "Не верный код";
			this.codeErrorLabel.UseCustomForeColor = true;
			this.codeErrorLabel.Visible = false;
			// 
			// sendErrorLabel
			// 
			this.sendErrorLabel.AutoSize = true;
			this.sendErrorLabel.Location = new System.Drawing.Point(23, 161);
			this.sendErrorLabel.Name = "sendErrorLabel";
			this.sendErrorLabel.Size = new System.Drawing.Size(89, 13);
			this.sendErrorLabel.TabIndex = 101;
			this.sendErrorLabel.TabStop = true;
			this.sendErrorLabel.Text = "Не пришел код?";
			this.sendErrorLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sendErrorLabel_LinkClicked);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(261, 19);
			this.label1.TabIndex = 7;
			this.label1.Text = "На Вашу почту отправлен секретный код";
			// 
			// NewPass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 240);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sendErrorLabel);
			this.Controls.Add(this.codeErrorLabel);
			this.Controls.Add(this.checkButton);
			this.Controls.Add(this.codeLabel);
			this.Controls.Add(this.codeTextBox);
			this.Controls.Add(this.newPassLabel);
			this.Controls.Add(this.newPassTextBox);
			this.MaximizeBox = false;
			this.Name = "NewPass";
			this.Resizable = false;
			this.ShowIcon = false;
			this.Text = "Смена пароля";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox newPassTextBox;
		private MetroFramework.Controls.MetroLabel newPassLabel;
		private MetroFramework.Controls.MetroLabel codeLabel;
		private MetroFramework.Controls.MetroTextBox codeTextBox;
		private MetroFramework.Controls.MetroButton checkButton;
		private MetroFramework.Controls.MetroLabel codeErrorLabel;
		private System.Windows.Forms.LinkLabel sendErrorLabel;
		private MetroFramework.Controls.MetroLabel label1;
	}
}