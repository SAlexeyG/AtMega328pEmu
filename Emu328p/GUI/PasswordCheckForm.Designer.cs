
namespace Emu328p.GUI
{
	partial class PasswordCheckForm
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
			this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
			this.checkButton = new MetroFramework.Controls.MetroButton();
			this.errorLabel = new MetroFramework.Controls.MetroLabel();
			this.changePassLabel = new System.Windows.Forms.LinkLabel();
			this.greatingLabel = new MetroFramework.Controls.MetroLabel();
			this.label2 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(23, 116);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(54, 19);
			this.passwordLabel.TabIndex = 0;
			this.passwordLabel.Text = "Пароль";
			// 
			// passwordTextBox
			// 
			// 
			// 
			// 
			this.passwordTextBox.CustomButton.Image = null;
			this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(200, 2);
			this.passwordTextBox.CustomButton.Name = "";
			this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
			this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.passwordTextBox.CustomButton.TabIndex = 1;
			this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.passwordTextBox.CustomButton.UseSelectable = true;
			this.passwordTextBox.CustomButton.Visible = false;
			this.passwordTextBox.Lines = new string[0];
			this.passwordTextBox.Location = new System.Drawing.Point(77, 115);
			this.passwordTextBox.MaxLength = 32767;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.passwordTextBox.SelectedText = "";
			this.passwordTextBox.SelectionLength = 0;
			this.passwordTextBox.SelectionStart = 0;
			this.passwordTextBox.ShortcutsEnabled = true;
			this.passwordTextBox.Size = new System.Drawing.Size(218, 20);
			this.passwordTextBox.TabIndex = 2;
			this.passwordTextBox.UseSelectable = true;
			this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			// 
			// checkButton
			// 
			this.checkButton.Location = new System.Drawing.Point(23, 194);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(75, 23);
			this.checkButton.TabIndex = 100;
			this.checkButton.Text = "Войти";
			this.checkButton.UseSelectable = true;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
			this.errorLabel.Location = new System.Drawing.Point(121, 158);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(124, 19);
			this.errorLabel.TabIndex = 3;
			this.errorLabel.Text = "Не верный пароль";
			this.errorLabel.UseCustomForeColor = true;
			this.errorLabel.Visible = false;
			// 
			// changePassLabel
			// 
			this.changePassLabel.AutoSize = true;
			this.changePassLabel.Location = new System.Drawing.Point(24, 164);
			this.changePassLabel.Name = "changePassLabel";
			this.changePassLabel.Size = new System.Drawing.Size(91, 13);
			this.changePassLabel.TabIndex = 101;
			this.changePassLabel.TabStop = true;
			this.changePassLabel.Text = "Забыли пароль?";
			this.changePassLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changePassLabel_LinkClicked);
			// 
			// greatingLabel
			// 
			this.greatingLabel.AutoSize = true;
			this.greatingLabel.Location = new System.Drawing.Point(23, 60);
			this.greatingLabel.Name = "greatingLabel";
			this.greatingLabel.Size = new System.Drawing.Size(97, 19);
			this.greatingLabel.TabIndex = 7;
			this.greatingLabel.Text = "Здравствуйте, ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(217, 19);
			this.label2.TabIndex = 9;
			this.label2.Text = "Пожалуйста, введите свой пароль";
			// 
			// PasswordCheckForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(318, 239);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.greatingLabel);
			this.Controls.Add(this.changePassLabel);
			this.Controls.Add(this.errorLabel);
			this.Controls.Add(this.checkButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.passwordLabel);
			this.MaximizeBox = false;
			this.Name = "PasswordCheckForm";
			this.Resizable = false;
			this.ShowIcon = false;
			this.Text = "Вход";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel passwordLabel;
		private MetroFramework.Controls.MetroTextBox passwordTextBox;
		private MetroFramework.Controls.MetroButton checkButton;
		private MetroFramework.Controls.MetroLabel errorLabel;
		private System.Windows.Forms.LinkLabel changePassLabel;
		private MetroFramework.Controls.MetroLabel greatingLabel;
		private MetroFramework.Controls.MetroLabel label2;
	}
}