
namespace Emu328p.GUI
{
	partial class StartForm
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
			this.passwordLabel = new MetroFramework.Controls.MetroLabel();
			this.mailLabel = new MetroFramework.Controls.MetroLabel();
			this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
			this.registrateButton = new MetroFramework.Controls.MetroButton();
			this.mailTextBox = new MetroFramework.Controls.MetroTextBox();
			this.greatingLabel = new MetroFramework.Controls.MetroLabel();
			this.label1 = new MetroFramework.Controls.MetroLabel();
			this.label2 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(13, 142);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(54, 19);
			this.passwordLabel.TabIndex = 0;
			this.passwordLabel.Text = "Пароль";
			// 
			// mailLabel
			// 
			this.mailLabel.AutoSize = true;
			this.mailLabel.Location = new System.Drawing.Point(13, 187);
			this.mailLabel.Name = "mailLabel";
			this.mailLabel.Size = new System.Drawing.Size(45, 19);
			this.mailLabel.TabIndex = 1;
			this.mailLabel.Text = "Почта";
			// 
			// passwordTextBox
			// 
			// 
			// 
			// 
			this.passwordTextBox.CustomButton.Image = null;
			this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(274, 2);
			this.passwordTextBox.CustomButton.Name = "";
			this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
			this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.passwordTextBox.CustomButton.TabIndex = 1;
			this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.passwordTextBox.CustomButton.UseSelectable = true;
			this.passwordTextBox.CustomButton.Visible = false;
			this.passwordTextBox.Lines = new string[0];
			this.passwordTextBox.Location = new System.Drawing.Point(13, 164);
			this.passwordTextBox.MaxLength = 32767;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.passwordTextBox.SelectedText = "";
			this.passwordTextBox.SelectionLength = 0;
			this.passwordTextBox.SelectionStart = 0;
			this.passwordTextBox.ShortcutsEnabled = true;
			this.passwordTextBox.Size = new System.Drawing.Size(292, 20);
			this.passwordTextBox.TabIndex = 2;
			this.passwordTextBox.UseSelectable = true;
			this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			// 
			// registrateButton
			// 
			this.registrateButton.Location = new System.Drawing.Point(13, 235);
			this.registrateButton.Name = "registrateButton";
			this.registrateButton.Size = new System.Drawing.Size(129, 23);
			this.registrateButton.TabIndex = 100;
			this.registrateButton.Text = "Зарегистрироваться";
			this.registrateButton.UseSelectable = true;
			this.registrateButton.Click += new System.EventHandler(this.registrateButton_Click);
			// 
			// mailTextBox
			// 
			// 
			// 
			// 
			this.mailTextBox.CustomButton.Image = null;
			this.mailTextBox.CustomButton.Location = new System.Drawing.Point(273, 2);
			this.mailTextBox.CustomButton.Name = "";
			this.mailTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
			this.mailTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mailTextBox.CustomButton.TabIndex = 1;
			this.mailTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mailTextBox.CustomButton.UseSelectable = true;
			this.mailTextBox.CustomButton.Visible = false;
			this.mailTextBox.Lines = new string[0];
			this.mailTextBox.Location = new System.Drawing.Point(13, 209);
			this.mailTextBox.MaxLength = 32767;
			this.mailTextBox.Name = "mailTextBox";
			this.mailTextBox.PasswordChar = '\0';
			this.mailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mailTextBox.SelectedText = "";
			this.mailTextBox.SelectionLength = 0;
			this.mailTextBox.SelectionStart = 0;
			this.mailTextBox.ShortcutsEnabled = true;
			this.mailTextBox.Size = new System.Drawing.Size(291, 20);
			this.mailTextBox.TabIndex = 3;
			this.mailTextBox.UseSelectable = true;
			this.mailTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mailTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			// 
			// greatingLabel
			// 
			this.greatingLabel.AutoSize = true;
			this.greatingLabel.Location = new System.Drawing.Point(92, 60);
			this.greatingLabel.Name = "greatingLabel";
			this.greatingLabel.Size = new System.Drawing.Size(97, 19);
			this.greatingLabel.TabIndex = 6;
			this.greatingLabel.Text = "Здравствуйте, ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 19);
			this.label1.TabIndex = 7;
			this.label1.Text = "Вы впервые зашли на Emu328p";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(48, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(219, 19);
			this.label2.TabIndex = 8;
			this.label2.Text = "Пожалуйста, введите свои данные";
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 276);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.greatingLabel);
			this.Controls.Add(this.mailTextBox);
			this.Controls.Add(this.registrateButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.mailLabel);
			this.Controls.Add(this.passwordLabel);
			this.MaximizeBox = false;
			this.Name = "StartForm";
			this.Resizable = false;
			this.ShowIcon = false;
			this.Text = "Авторизация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroLabel mailLabel;
		private MetroFramework.Controls.MetroLabel passwordLabel;
		private MetroFramework.Controls.MetroTextBox passwordTextBox;
		private MetroFramework.Controls.MetroButton registrateButton;
		private MetroFramework.Controls.MetroTextBox mailTextBox;
		private MetroFramework.Controls.MetroLabel greatingLabel;
		private MetroFramework.Controls.MetroLabel label1;
		private MetroFramework.Controls.MetroLabel label2;
	}
}