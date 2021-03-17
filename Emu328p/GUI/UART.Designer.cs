
namespace Emu328p.GUI
{
	partial class UART
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
			this.textBox = new System.Windows.Forms.TextBox();
			this.reciveTextBox = new System.Windows.Forms.TextBox();
			this.reciveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.BackColor = System.Drawing.SystemColors.Control;
			this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox.Location = new System.Drawing.Point(12, 35);
			this.textBox.Margin = new System.Windows.Forms.Padding(0);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(639, 348);
			this.textBox.TabIndex = 0;
			// 
			// reciveTextBox
			// 
			this.reciveTextBox.Location = new System.Drawing.Point(12, 12);
			this.reciveTextBox.MaxLength = 1;
			this.reciveTextBox.Name = "reciveTextBox";
			this.reciveTextBox.Size = new System.Drawing.Size(100, 20);
			this.reciveTextBox.TabIndex = 1;
			// 
			// reciveButton
			// 
			this.reciveButton.Location = new System.Drawing.Point(118, 10);
			this.reciveButton.Name = "reciveButton";
			this.reciveButton.Size = new System.Drawing.Size(75, 23);
			this.reciveButton.TabIndex = 2;
			this.reciveButton.Text = "Отправить";
			this.reciveButton.UseVisualStyleBackColor = true;
			this.reciveButton.Click += new System.EventHandler(this.reciveButton_Click);
			// 
			// UART
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 388);
			this.ControlBox = false;
			this.Controls.Add(this.reciveButton);
			this.Controls.Add(this.reciveTextBox);
			this.Controls.Add(this.textBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UART";
			this.ShowIcon = false;
			this.Text = "UART";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.TextBox reciveTextBox;
		private System.Windows.Forms.Button reciveButton;
	}
}