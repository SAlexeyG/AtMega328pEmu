
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
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.checkButton = new System.Windows.Forms.Button();
			this.errorLabel = new System.Windows.Forms.Label();
			this.changePassLabel = new System.Windows.Forms.LinkLabel();
			this.greatingLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 87);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(45, 13);
			this.passwordLabel.TabIndex = 0;
			this.passwordLabel.Text = "Пароль";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(63, 84);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(218, 20);
			this.passwordTextBox.TabIndex = 2;
			this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			// 
			// checkButton
			// 
			this.checkButton.Location = new System.Drawing.Point(12, 143);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(75, 23);
			this.checkButton.TabIndex = 100;
			this.checkButton.Text = "Войти";
			this.checkButton.UseVisualStyleBackColor = true;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
			this.errorLabel.Location = new System.Drawing.Point(110, 107);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(101, 13);
			this.errorLabel.TabIndex = 3;
			this.errorLabel.Text = "Не верный пароль";
			this.errorLabel.Visible = false;
			// 
			// changePassLabel
			// 
			this.changePassLabel.AutoSize = true;
			this.changePassLabel.Location = new System.Drawing.Point(13, 107);
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
			this.greatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.greatingLabel.Location = new System.Drawing.Point(12, 9);
			this.greatingLabel.Name = "greatingLabel";
			this.greatingLabel.Size = new System.Drawing.Size(126, 20);
			this.greatingLabel.TabIndex = 7;
			this.greatingLabel.Text = "Здравствуйте, ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(269, 20);
			this.label2.TabIndex = 9;
			this.label2.Text = "Пожалуйста введите свой пароль";
			// 
			// PasswordCheckForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 178);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.greatingLabel);
			this.Controls.Add(this.changePassLabel);
			this.Controls.Add(this.errorLabel);
			this.Controls.Add(this.checkButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.passwordLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "PasswordCheckForm";
			this.ShowIcon = false;
			this.Text = "Вход";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button checkButton;
		private System.Windows.Forms.Label errorLabel;
		private System.Windows.Forms.LinkLabel changePassLabel;
		private System.Windows.Forms.Label greatingLabel;
		private System.Windows.Forms.Label label2;
	}
}