
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
			this.passwordLabel = new System.Windows.Forms.Label();
			this.mailLabel = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.registrateButton = new System.Windows.Forms.Button();
			this.mailTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 9);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(45, 13);
			this.passwordLabel.TabIndex = 0;
			this.passwordLabel.Text = "Пароль";
			// 
			// mailLabel
			// 
			this.mailLabel.AutoSize = true;
			this.mailLabel.Location = new System.Drawing.Point(12, 35);
			this.mailLabel.Name = "mailLabel";
			this.mailLabel.Size = new System.Drawing.Size(37, 13);
			this.mailLabel.TabIndex = 1;
			this.mailLabel.Text = "Почта";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(71, 6);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
			this.passwordTextBox.TabIndex = 2;
			// 
			// registrateButton
			// 
			this.registrateButton.Location = new System.Drawing.Point(12, 58);
			this.registrateButton.Name = "registrateButton";
			this.registrateButton.Size = new System.Drawing.Size(129, 23);
			this.registrateButton.TabIndex = 4;
			this.registrateButton.Text = "Зарегистрироваться";
			this.registrateButton.UseVisualStyleBackColor = true;
			this.registrateButton.Click += new System.EventHandler(this.registrateButton_Click);
			// 
			// mailTextBox
			// 
			this.mailTextBox.Location = new System.Drawing.Point(71, 32);
			this.mailTextBox.Name = "mailTextBox";
			this.mailTextBox.Size = new System.Drawing.Size(100, 20);
			this.mailTextBox.TabIndex = 5;
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(183, 90);
			this.Controls.Add(this.mailTextBox);
			this.Controls.Add(this.registrateButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.mailLabel);
			this.Controls.Add(this.passwordLabel);
			this.Name = "StartForm";
			this.Text = "StartForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label mailLabel;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button registrateButton;
		private System.Windows.Forms.TextBox mailTextBox;
	}
}