
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
			this.errorTextBox = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.sendErrorLabel = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// errorTextBox
			// 
			this.errorTextBox.BackColor = System.Drawing.SystemColors.Control;
			this.errorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.errorTextBox.Location = new System.Drawing.Point(12, 12);
			this.errorTextBox.Multiline = true;
			this.errorTextBox.Name = "errorTextBox";
			this.errorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.errorTextBox.Size = new System.Drawing.Size(373, 88);
			this.errorTextBox.TabIndex = 0;
			// 
			// okButton
			// 
			this.okButton.Location = new System.Drawing.Point(310, 106);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(75, 23);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "OK";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// sendErrorLabel
			// 
			this.sendErrorLabel.AutoSize = true;
			this.sendErrorLabel.Location = new System.Drawing.Point(12, 111);
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
			this.ClientSize = new System.Drawing.Size(397, 141);
			this.Controls.Add(this.sendErrorLabel);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.errorTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FatalErrorForm";
			this.ShowIcon = false;
			this.Text = "Критическая ошибка";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox errorTextBox;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.LinkLabel sendErrorLabel;
	}
}