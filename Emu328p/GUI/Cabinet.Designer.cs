
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
			this.loginLabel = new System.Windows.Forms.Label();
			this.loginTextBox = new System.Windows.Forms.TextBox();
			this.passTextBox = new System.Windows.Forms.TextBox();
			this.passLabel = new System.Windows.Forms.Label();
			this.mailTextBox = new System.Windows.Forms.TextBox();
			this.mailLabel = new System.Windows.Forms.Label();
			this.changeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Location = new System.Drawing.Point(12, 15);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(60, 13);
			this.loginLabel.TabIndex = 0;
			this.loginLabel.Text = "Ваш логин";
			// 
			// loginTextBox
			// 
			this.loginTextBox.Location = new System.Drawing.Point(85, 12);
			this.loginTextBox.Name = "loginTextBox";
			this.loginTextBox.Size = new System.Drawing.Size(100, 20);
			this.loginTextBox.TabIndex = 2;
			this.loginTextBox.TextChanged += new System.EventHandler(this.userInfoTextBox_TextChanged);
			// 
			// passTextBox
			// 
			this.passTextBox.Location = new System.Drawing.Point(85, 38);
			this.passTextBox.Name = "passTextBox";
			this.passTextBox.Size = new System.Drawing.Size(100, 20);
			this.passTextBox.TabIndex = 3;
			this.passTextBox.TextChanged += new System.EventHandler(this.userInfoTextBox_TextChanged);
			// 
			// passLabel
			// 
			this.passLabel.AutoSize = true;
			this.passLabel.Location = new System.Drawing.Point(12, 41);
			this.passLabel.Name = "passLabel";
			this.passLabel.Size = new System.Drawing.Size(67, 13);
			this.passLabel.TabIndex = 2;
			this.passLabel.Text = "Ваш пароль";
			// 
			// mailTextBox
			// 
			this.mailTextBox.Location = new System.Drawing.Point(85, 64);
			this.mailTextBox.Name = "mailTextBox";
			this.mailTextBox.Size = new System.Drawing.Size(100, 20);
			this.mailTextBox.TabIndex = 4;
			this.mailTextBox.TextChanged += new System.EventHandler(this.userInfoTextBox_TextChanged);
			// 
			// mailLabel
			// 
			this.mailLabel.AutoSize = true;
			this.mailLabel.Location = new System.Drawing.Point(12, 67);
			this.mailLabel.Name = "mailLabel";
			this.mailLabel.Size = new System.Drawing.Size(55, 13);
			this.mailLabel.TabIndex = 4;
			this.mailLabel.Text = "Ваш email";
			// 
			// changeButton
			// 
			this.changeButton.Enabled = false;
			this.changeButton.Location = new System.Drawing.Point(15, 90);
			this.changeButton.Name = "changeButton";
			this.changeButton.Size = new System.Drawing.Size(75, 23);
			this.changeButton.TabIndex = 100;
			this.changeButton.Text = "Изменить";
			this.changeButton.UseVisualStyleBackColor = true;
			this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
			// 
			// Cabinet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(190, 116);
			this.ControlBox = false;
			this.Controls.Add(this.changeButton);
			this.Controls.Add(this.mailTextBox);
			this.Controls.Add(this.mailLabel);
			this.Controls.Add(this.passTextBox);
			this.Controls.Add(this.passLabel);
			this.Controls.Add(this.loginTextBox);
			this.Controls.Add(this.loginLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(702, 467);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Cabinet";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Личный кабинет";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.TextBox loginTextBox;
		private System.Windows.Forms.TextBox passTextBox;
		private System.Windows.Forms.Label passLabel;
		private System.Windows.Forms.TextBox mailTextBox;
		private System.Windows.Forms.Label mailLabel;
		private System.Windows.Forms.Button changeButton;
	}
}