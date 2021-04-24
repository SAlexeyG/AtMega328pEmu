
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
			this.SuspendLayout();
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 15);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(45, 13);
			this.passwordLabel.TabIndex = 0;
			this.passwordLabel.Text = "Пароль";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(63, 12);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(147, 20);
			this.passwordTextBox.TabIndex = 1;
			// 
			// checkButton
			// 
			this.checkButton.Location = new System.Drawing.Point(12, 38);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(75, 23);
			this.checkButton.TabIndex = 2;
			this.checkButton.Text = "Войти";
			this.checkButton.UseVisualStyleBackColor = true;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// errorLabel
			// 
			this.errorLabel.AutoSize = true;
			this.errorLabel.Location = new System.Drawing.Point(109, 64);
			this.errorLabel.Name = "errorLabel";
			this.errorLabel.Size = new System.Drawing.Size(101, 13);
			this.errorLabel.TabIndex = 3;
			this.errorLabel.Text = "Не верный пароль";
			this.errorLabel.Visible = false;
			// 
			// changePassLabel
			// 
			this.changePassLabel.AutoSize = true;
			this.changePassLabel.Location = new System.Drawing.Point(12, 64);
			this.changePassLabel.Name = "changePassLabel";
			this.changePassLabel.Size = new System.Drawing.Size(91, 13);
			this.changePassLabel.TabIndex = 4;
			this.changePassLabel.TabStop = true;
			this.changePassLabel.Text = "Забыли пароль?";
			this.changePassLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changePassLabel_LinkClicked);
			// 
			// PasswordCheckForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(223, 90);
			this.Controls.Add(this.changePassLabel);
			this.Controls.Add(this.errorLabel);
			this.Controls.Add(this.checkButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.passwordLabel);
			this.Name = "PasswordCheckForm";
			this.Text = "PasswordCheckForm";
			this.Load += new System.EventHandler(this.PasswordCheckForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button checkButton;
		private System.Windows.Forms.Label errorLabel;
		private System.Windows.Forms.LinkLabel changePassLabel;
	}
}