
namespace Emu328p.GUI
{
	partial class Help
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
			this.textBox.CustomButton.Location = new System.Drawing.Point(186, 1);
			this.textBox.CustomButton.Name = "";
			this.textBox.CustomButton.Size = new System.Drawing.Size(155, 155);
			this.textBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.textBox.CustomButton.TabIndex = 1;
			this.textBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.textBox.CustomButton.UseSelectable = true;
			this.textBox.CustomButton.Visible = false;
			this.textBox.Lines = new string[0];
			this.textBox.Location = new System.Drawing.Point(23, 63);
			this.textBox.MaxLength = 32767;
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.PasswordChar = '\0';
			this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox.SelectedText = "";
			this.textBox.SelectionLength = 0;
			this.textBox.SelectionStart = 0;
			this.textBox.ShortcutsEnabled = true;
			this.textBox.Size = new System.Drawing.Size(342, 157);
			this.textBox.TabIndex = 0;
			this.textBox.UseSelectable = true;
			this.textBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.textBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// Help
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 243);
			this.ControlBox = false;
			this.Controls.Add(this.textBox);
			this.MaximumSize = new System.Drawing.Size(713, 550);
			this.MinimumSize = new System.Drawing.Size(313, 157);
			this.Name = "Help";
			this.Text = "Справка";
			this.Load += new System.EventHandler(this.Help_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox textBox;
	}
}