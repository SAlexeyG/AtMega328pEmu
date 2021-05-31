
namespace Emu328p.GUI
{
	partial class FatalErrorForm
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
			this.errorTextBox = new MetroFramework.Controls.MetroTextBox();
			this.okButton = new MetroFramework.Controls.MetroButton();
			this.sendErrorLabel = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// errorTextBox
			// 
			this.errorTextBox.BackColor = System.Drawing.SystemColors.Control;
			// 
			// 
			// 
			this.errorTextBox.CustomButton.Image = null;
			this.errorTextBox.CustomButton.Location = new System.Drawing.Point(287, 2);
			this.errorTextBox.CustomButton.Name = "";
			this.errorTextBox.CustomButton.Size = new System.Drawing.Size(83, 83);
			this.errorTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.errorTextBox.CustomButton.TabIndex = 1;
			this.errorTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.errorTextBox.CustomButton.UseSelectable = true;
			this.errorTextBox.CustomButton.Visible = false;
			this.errorTextBox.Lines = new string[0];
			this.errorTextBox.Location = new System.Drawing.Point(23, 63);
			this.errorTextBox.MaxLength = 32767;
			this.errorTextBox.Multiline = true;
			this.errorTextBox.Name = "errorTextBox";
			this.errorTextBox.PasswordChar = '\0';
			this.errorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.errorTextBox.SelectedText = "";
			this.errorTextBox.SelectionLength = 0;
			this.errorTextBox.SelectionStart = 0;
			this.errorTextBox.ShortcutsEnabled = true;
			this.errorTextBox.Size = new System.Drawing.Size(373, 88);
			this.errorTextBox.TabIndex = 0;
			this.errorTextBox.UseSelectable = true;
			this.errorTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.errorTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(321, 157);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "OK";
			this.okButton.UseSelectable = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// sendErrorLabel
			// 
			this.sendErrorLabel.AutoSize = true;
			this.sendErrorLabel.Location = new System.Drawing.Point(23, 167);
			this.sendErrorLabel.Name = "sendErrorLabel";
			this.sendErrorLabel.Size = new System.Drawing.Size(114, 13);
			this.sendErrorLabel.TabIndex = 2;
			this.sendErrorLabel.TabStop = true;
			this.sendErrorLabel.Text = "Сообщить об ошибке";
			this.sendErrorLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sendErrorLabel_LinkClicked);
			// 
			// FatalErrorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 211);
			this.Controls.Add(this.sendErrorLabel);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.errorTextBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FatalErrorForm";
			this.Resizable = false;
			this.ShowIcon = false;
			this.Text = "Критическая ошибка";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox errorTextBox;
		private MetroFramework.Controls.MetroButton okButton;
		private System.Windows.Forms.LinkLabel sendErrorLabel;
	}
}