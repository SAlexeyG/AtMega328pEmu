
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
			this.greatingLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 97);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(45, 13);
			this.passwordLabel.TabIndex = 0;
			this.passwordLabel.Text = "Пароль";
			// 
			// mailLabel
			// 
			this.mailLabel.AutoSize = true;
			this.mailLabel.Location = new System.Drawing.Point(12, 136);
			this.mailLabel.Name = "mailLabel";
			this.mailLabel.Size = new System.Drawing.Size(37, 13);
			this.mailLabel.TabIndex = 1;
			this.mailLabel.Text = "Почта";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Location = new System.Drawing.Point(12, 113);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(292, 20);
			this.passwordTextBox.TabIndex = 2;
			// 
			// registrateButton
			// 
			this.registrateButton.Location = new System.Drawing.Point(12, 178);
			this.registrateButton.Name = "registrateButton";
			this.registrateButton.Size = new System.Drawing.Size(129, 23);
			this.registrateButton.TabIndex = 4;
			this.registrateButton.Text = "Зарегистрироваться";
			this.registrateButton.UseVisualStyleBackColor = true;
			this.registrateButton.Click += new System.EventHandler(this.registrateButton_Click);
			// 
			// mailTextBox
			// 
			this.mailTextBox.Location = new System.Drawing.Point(12, 152);
			this.mailTextBox.Name = "mailTextBox";
			this.mailTextBox.Size = new System.Drawing.Size(291, 20);
			this.mailTextBox.TabIndex = 5;
			// 
			// greatingLabel
			// 
			this.greatingLabel.AutoSize = true;
			this.greatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.greatingLabel.Location = new System.Drawing.Point(64, 9);
			this.greatingLabel.Name = "greatingLabel";
			this.greatingLabel.Size = new System.Drawing.Size(126, 20);
			this.greatingLabel.TabIndex = 6;
			this.greatingLabel.Text = "Здравствуйте, ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(32, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(248, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Вы впервые зашли на Emu328p";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(20, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(272, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Пожалуйста введите свои данные";
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(315, 214);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.greatingLabel);
			this.Controls.Add(this.mailTextBox);
			this.Controls.Add(this.registrateButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.mailLabel);
			this.Controls.Add(this.passwordLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "StartForm";
			this.ShowIcon = false;
			this.Text = "Авторизация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label mailLabel;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button registrateButton;
		private System.Windows.Forms.TextBox mailTextBox;
		private System.Windows.Forms.Label greatingLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}