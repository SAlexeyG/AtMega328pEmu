
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
			this.newPassTextBox = new System.Windows.Forms.TextBox();
			this.newPassLabel = new System.Windows.Forms.Label();
			this.codeLabel = new System.Windows.Forms.Label();
			this.codeTextBox = new System.Windows.Forms.TextBox();
			this.checkButton = new System.Windows.Forms.Button();
			this.codeErrorLabel = new System.Windows.Forms.Label();
			this.sendErrorLabel = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// newPassTextBox
			// 
			this.newPassTextBox.Location = new System.Drawing.Point(116, 55);
			this.newPassTextBox.Name = "newPassTextBox";
			this.newPassTextBox.PasswordChar = '*';
			this.newPassTextBox.Size = new System.Drawing.Size(218, 20);
			this.newPassTextBox.TabIndex = 2;
			this.newPassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			// 
			// newPassLabel
			// 
			this.newPassLabel.AutoSize = true;
			this.newPassLabel.Location = new System.Drawing.Point(12, 58);
			this.newPassLabel.Name = "newPassLabel";
			this.newPassLabel.Size = new System.Drawing.Size(80, 13);
			this.newPassLabel.TabIndex = 1;
			this.newPassLabel.Text = "Новый пароль";
			// 
			// codeLabel
			// 
			this.codeLabel.AutoSize = true;
			this.codeLabel.Location = new System.Drawing.Point(12, 84);
			this.codeLabel.Name = "codeLabel";
			this.codeLabel.Size = new System.Drawing.Size(84, 13);
			this.codeLabel.TabIndex = 3;
			this.codeLabel.Text = "Секретный код";
			// 
			// codeTextBox
			// 
			this.codeTextBox.Location = new System.Drawing.Point(116, 81);
			this.codeTextBox.Name = "codeTextBox";
			this.codeTextBox.Size = new System.Drawing.Size(218, 20);
			this.codeTextBox.TabIndex = 3;
			this.codeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			// 
			// checkButton
			// 
			this.checkButton.Location = new System.Drawing.Point(12, 138);
			this.checkButton.Name = "checkButton";
			this.checkButton.Size = new System.Drawing.Size(75, 23);
			this.checkButton.TabIndex = 100;
			this.checkButton.Text = "OK";
			this.checkButton.UseVisualStyleBackColor = true;
			this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
			// 
			// codeErrorLabel
			// 
			this.codeErrorLabel.AutoSize = true;
			this.codeErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
			this.codeErrorLabel.Location = new System.Drawing.Point(113, 104);
			this.codeErrorLabel.Name = "codeErrorLabel";
			this.codeErrorLabel.Size = new System.Drawing.Size(83, 13);
			this.codeErrorLabel.TabIndex = 5;
			this.codeErrorLabel.Text = "Не верный код";
			this.codeErrorLabel.Visible = false;
			// 
			// sendErrorLabel
			// 
			this.sendErrorLabel.AutoSize = true;
			this.sendErrorLabel.Location = new System.Drawing.Point(12, 104);
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
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(324, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "На Вашу почту отправлен секретный код";
			// 
			// NewPass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 174);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.sendErrorLabel);
			this.Controls.Add(this.codeErrorLabel);
			this.Controls.Add(this.checkButton);
			this.Controls.Add(this.codeLabel);
			this.Controls.Add(this.codeTextBox);
			this.Controls.Add(this.newPassLabel);
			this.Controls.Add(this.newPassTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "NewPass";
			this.ShowIcon = false;
			this.Text = "Смена пароля";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox newPassTextBox;
		private System.Windows.Forms.Label newPassLabel;
		private System.Windows.Forms.Label codeLabel;
		private System.Windows.Forms.TextBox codeTextBox;
		private System.Windows.Forms.Button checkButton;
		private System.Windows.Forms.Label codeErrorLabel;
		private System.Windows.Forms.LinkLabel sendErrorLabel;
		private System.Windows.Forms.Label label1;
	}
}