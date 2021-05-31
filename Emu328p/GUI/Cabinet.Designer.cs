
namespace Emu328p.GUI
{
	partial class Cabinet
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
			this.loginLabel = new MetroFramework.Controls.MetroLabel();
			this.loginTextBox = new MetroFramework.Controls.MetroTextBox();
			this.passTextBox = new MetroFramework.Controls.MetroTextBox();
			this.passLabel = new MetroFramework.Controls.MetroLabel();
			this.mailTextBox = new MetroFramework.Controls.MetroTextBox();
			this.mailLabel = new MetroFramework.Controls.MetroLabel();
			this.changeButton = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Location = new System.Drawing.Point(4, 13);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(75, 19);
			this.loginLabel.TabIndex = 0;
			this.loginLabel.Text = "Ваш логин";
			// 
			// loginTextBox
			// 
			// 
			// 
			// 
			this.loginTextBox.CustomButton.Image = null;
			this.loginTextBox.CustomButton.Location = new System.Drawing.Point(82, 2);
			this.loginTextBox.CustomButton.Name = "";
			this.loginTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
			this.loginTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.loginTextBox.CustomButton.TabIndex = 1;
			this.loginTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.loginTextBox.CustomButton.UseSelectable = true;
			this.loginTextBox.CustomButton.Visible = false;
			this.loginTextBox.Lines = new string[0];
			this.loginTextBox.Location = new System.Drawing.Point(85, 12);
			this.loginTextBox.MaxLength = 32767;
			this.loginTextBox.Name = "loginTextBox";
			this.loginTextBox.PasswordChar = '\0';
			this.loginTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.loginTextBox.SelectedText = "";
			this.loginTextBox.SelectionLength = 0;
			this.loginTextBox.SelectionStart = 0;
			this.loginTextBox.ShortcutsEnabled = true;
			this.loginTextBox.Size = new System.Drawing.Size(100, 20);
			this.loginTextBox.TabIndex = 2;
			this.loginTextBox.UseSelectable = true;
			this.loginTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.loginTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.loginTextBox.TextChanged += new System.EventHandler(this.userInfoTextBox_TextChanged);
			// 
			// passTextBox
			// 
			// 
			// 
			// 
			this.passTextBox.CustomButton.Image = null;
			this.passTextBox.CustomButton.Location = new System.Drawing.Point(82, 2);
			this.passTextBox.CustomButton.Name = "";
			this.passTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
			this.passTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.passTextBox.CustomButton.TabIndex = 1;
			this.passTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.passTextBox.CustomButton.UseSelectable = true;
			this.passTextBox.CustomButton.Visible = false;
			this.passTextBox.Lines = new string[0];
			this.passTextBox.Location = new System.Drawing.Point(85, 38);
			this.passTextBox.MaxLength = 32767;
			this.passTextBox.Name = "passTextBox";
			this.passTextBox.PasswordChar = '\0';
			this.passTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.passTextBox.SelectedText = "";
			this.passTextBox.SelectionLength = 0;
			this.passTextBox.SelectionStart = 0;
			this.passTextBox.ShortcutsEnabled = true;
			this.passTextBox.Size = new System.Drawing.Size(100, 20);
			this.passTextBox.TabIndex = 3;
			this.passTextBox.UseSelectable = true;
			this.passTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.passTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.passTextBox.TextChanged += new System.EventHandler(this.userInfoTextBox_TextChanged);
			// 
			// passLabel
			// 
			this.passLabel.AutoSize = true;
			this.passLabel.Location = new System.Drawing.Point(4, 39);
			this.passLabel.Name = "passLabel";
			this.passLabel.Size = new System.Drawing.Size(83, 19);
			this.passLabel.TabIndex = 2;
			this.passLabel.Text = "Ваш пароль";
			// 
			// mailTextBox
			// 
			// 
			// 
			// 
			this.mailTextBox.CustomButton.Image = null;
			this.mailTextBox.CustomButton.Location = new System.Drawing.Point(82, 2);
			this.mailTextBox.CustomButton.Name = "";
			this.mailTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
			this.mailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mailTextBox.CustomButton.TabIndex = 1;
			this.mailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mailTextBox.CustomButton.UseSelectable = true;
			this.mailTextBox.CustomButton.Visible = false;
			this.mailTextBox.Lines = new string[0];
			this.mailTextBox.Location = new System.Drawing.Point(85, 64);
			this.mailTextBox.MaxLength = 32767;
			this.mailTextBox.Name = "mailTextBox";
			this.mailTextBox.PasswordChar = '\0';
			this.mailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mailTextBox.SelectedText = "";
			this.mailTextBox.SelectionLength = 0;
			this.mailTextBox.SelectionStart = 0;
			this.mailTextBox.ShortcutsEnabled = true;
			this.mailTextBox.Size = new System.Drawing.Size(100, 20);
			this.mailTextBox.TabIndex = 4;
			this.mailTextBox.UseSelectable = true;
			this.mailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mailTextBox.TextChanged += new System.EventHandler(this.userInfoTextBox_TextChanged);
			// 
			// mailLabel
			// 
			this.mailLabel.AutoSize = true;
			this.mailLabel.Location = new System.Drawing.Point(4, 65);
			this.mailLabel.Name = "mailLabel";
			this.mailLabel.Size = new System.Drawing.Size(71, 19);
			this.mailLabel.TabIndex = 4;
			this.mailLabel.Text = "Ваш email";
			// 
			// changeButton
			// 
			this.changeButton.Enabled = false;
			this.changeButton.Location = new System.Drawing.Point(4, 87);
			this.changeButton.Name = "changeButton";
			this.changeButton.Size = new System.Drawing.Size(75, 23);
			this.changeButton.TabIndex = 100;
			this.changeButton.Text = "Изменить";
			this.changeButton.UseSelectable = true;
			this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
			// 
			// Cabinet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(189, 116);
			this.ControlBox = false;
			this.Controls.Add(this.changeButton);
			this.Controls.Add(this.mailTextBox);
			this.Controls.Add(this.mailLabel);
			this.Controls.Add(this.passTextBox);
			this.Controls.Add(this.passLabel);
			this.Controls.Add(this.loginTextBox);
			this.Controls.Add(this.loginLabel);
			this.Location = new System.Drawing.Point(702, 485);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Cabinet";
			this.Resizable = false;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel loginLabel;
		private MetroFramework.Controls.MetroTextBox loginTextBox;
		private MetroFramework.Controls.MetroTextBox passTextBox;
		private MetroFramework.Controls.MetroLabel passLabel;
		private MetroFramework.Controls.MetroTextBox mailTextBox;
		private MetroFramework.Controls.MetroLabel mailLabel;
		private MetroFramework.Controls.MetroButton changeButton;
	}
}