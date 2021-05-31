
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
			this.textBox = new MetroFramework.Controls.MetroTextBox();
			this.reciveTextBox = new MetroFramework.Controls.MetroTextBox();
			this.reciveButton = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox.BackColor = System.Drawing.SystemColors.Control;
			// 
			// 
			// 
			this.textBox.CustomButton.Image = null;
			this.textBox.CustomButton.Location = new System.Drawing.Point(596, 2);
			this.textBox.CustomButton.Name = "";
			this.textBox.CustomButton.Size = new System.Drawing.Size(69, 69);
			this.textBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.textBox.CustomButton.TabIndex = 1;
			this.textBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.textBox.CustomButton.UseSelectable = true;
			this.textBox.CustomButton.Visible = false;
			this.textBox.Lines = new string[0];
			this.textBox.Location = new System.Drawing.Point(9, 36);
			this.textBox.Margin = new System.Windows.Forms.Padding(0);
			this.textBox.MaxLength = 32767;
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.PasswordChar = '\0';
			this.textBox.ReadOnly = true;
			this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox.SelectedText = "";
			this.textBox.SelectionLength = 0;
			this.textBox.SelectionStart = 0;
			this.textBox.ShortcutsEnabled = true;
			this.textBox.Size = new System.Drawing.Size(668, 74);
			this.textBox.TabIndex = 0;
			this.textBox.UseSelectable = true;
			this.textBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.textBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// reciveTextBox
			// 
			// 
			// 
			// 
			this.reciveTextBox.CustomButton.Image = null;
			this.reciveTextBox.CustomButton.Location = new System.Drawing.Point(82, 2);
			this.reciveTextBox.CustomButton.Name = "";
			this.reciveTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
			this.reciveTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.reciveTextBox.CustomButton.TabIndex = 1;
			this.reciveTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.reciveTextBox.CustomButton.UseSelectable = true;
			this.reciveTextBox.CustomButton.Visible = false;
			this.reciveTextBox.Lines = new string[0];
			this.reciveTextBox.Location = new System.Drawing.Point(9, 13);
			this.reciveTextBox.MaxLength = 1;
			this.reciveTextBox.Name = "reciveTextBox";
			this.reciveTextBox.PasswordChar = '\0';
			this.reciveTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.reciveTextBox.SelectedText = "";
			this.reciveTextBox.SelectionLength = 0;
			this.reciveTextBox.SelectionStart = 0;
			this.reciveTextBox.ShortcutsEnabled = true;
			this.reciveTextBox.Size = new System.Drawing.Size(100, 20);
			this.reciveTextBox.TabIndex = 1;
			this.reciveTextBox.UseSelectable = true;
			this.reciveTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.reciveTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// reciveButton
			// 
			this.reciveButton.Location = new System.Drawing.Point(115, 13);
			this.reciveButton.Name = "reciveButton";
			this.reciveButton.Size = new System.Drawing.Size(75, 20);
			this.reciveButton.TabIndex = 2;
			this.reciveButton.Text = "Отправить";
			this.reciveButton.UseSelectable = true;
			this.reciveButton.Click += new System.EventHandler(this.reciveButton_Click);
			// 
			// UART
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 130);
			this.ControlBox = false;
			this.Controls.Add(this.reciveButton);
			this.Controls.Add(this.reciveTextBox);
			this.Controls.Add(this.textBox);
			this.Location = new System.Drawing.Point(0, 485);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(220, 130);
			this.Name = "UART";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox textBox;
		private MetroFramework.Controls.MetroTextBox reciveTextBox;
		private MetroFramework.Controls.MetroButton reciveButton;
	}
}