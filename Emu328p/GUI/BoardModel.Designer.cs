
namespace Emu328p.GUI
{
	partial class BoardModel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardModel));
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripRotateButton = new System.Windows.Forms.ToolStripButton();
			this.picturePanel = new System.Windows.Forms.Panel();
			this.resetButtonPicture = new System.Windows.Forms.PictureBox();
			this.onLedPicture = new System.Windows.Forms.PictureBox();
			this.txLedPicture = new System.Windows.Forms.PictureBox();
			this.rxLedPicture = new System.Windows.Forms.PictureBox();
			this.toolStrip.SuspendLayout();
			this.picturePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.resetButtonPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.onLedPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txLedPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rxLedPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripRotateButton});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(303, 25);
			this.toolStrip.TabIndex = 5;
			this.toolStrip.Text = "toolStrip1";
			// 
			// toolStripRotateButton
			// 
			this.toolStripRotateButton.BackgroundImage = global::Emu328p.Properties.Resources.button_50_hover;
			this.toolStripRotateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.toolStripRotateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripRotateButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRotateButton.Image")));
			this.toolStripRotateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripRotateButton.Name = "toolStripRotateButton";
			this.toolStripRotateButton.Size = new System.Drawing.Size(23, 22);
			this.toolStripRotateButton.Text = "toolStripButton1";
			this.toolStripRotateButton.Click += new System.EventHandler(this.toolStripRotateButton_Click);
			// 
			// picturePanel
			// 
			this.picturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picturePanel.BackgroundImage = global::Emu328p.Properties.Resources.arduino_board2;
			this.picturePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picturePanel.Controls.Add(this.resetButtonPicture);
			this.picturePanel.Controls.Add(this.onLedPicture);
			this.picturePanel.Controls.Add(this.txLedPicture);
			this.picturePanel.Controls.Add(this.rxLedPicture);
			this.picturePanel.Location = new System.Drawing.Point(12, 28);
			this.picturePanel.Name = "picturePanel";
			this.picturePanel.Size = new System.Drawing.Size(270, 403);
			this.picturePanel.TabIndex = 4;
			// 
			// resetButtonPicture
			// 
			this.resetButtonPicture.BackColor = System.Drawing.Color.Transparent;
			this.resetButtonPicture.Location = new System.Drawing.Point(233, 78);
			this.resetButtonPicture.Name = "resetButtonPicture";
			this.resetButtonPicture.Size = new System.Drawing.Size(15, 15);
			this.resetButtonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.resetButtonPicture.TabIndex = 5;
			this.resetButtonPicture.TabStop = false;
			// 
			// onLedPicture
			// 
			this.onLedPicture.BackColor = System.Drawing.Color.Transparent;
			this.onLedPicture.Image = global::Emu328p.Properties.Resources.OnLED;
			this.onLedPicture.Location = new System.Drawing.Point(174, 316);
			this.onLedPicture.Name = "onLedPicture";
			this.onLedPicture.Size = new System.Drawing.Size(32, 32);
			this.onLedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.onLedPicture.TabIndex = 4;
			this.onLedPicture.TabStop = false;
			this.onLedPicture.Visible = false;
			// 
			// txLedPicture
			// 
			this.txLedPicture.BackColor = System.Drawing.Color.Transparent;
			this.txLedPicture.Image = global::Emu328p.Properties.Resources.LED;
			this.txLedPicture.Location = new System.Drawing.Point(171, 153);
			this.txLedPicture.Name = "txLedPicture";
			this.txLedPicture.Size = new System.Drawing.Size(32, 32);
			this.txLedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.txLedPicture.TabIndex = 3;
			this.txLedPicture.TabStop = false;
			this.txLedPicture.Visible = false;
			// 
			// rxLedPicture
			// 
			this.rxLedPicture.BackColor = System.Drawing.Color.Transparent;
			this.rxLedPicture.Image = global::Emu328p.Properties.Resources.LED;
			this.rxLedPicture.Location = new System.Drawing.Point(163, 153);
			this.rxLedPicture.Name = "rxLedPicture";
			this.rxLedPicture.Size = new System.Drawing.Size(32, 32);
			this.rxLedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.rxLedPicture.TabIndex = 2;
			this.rxLedPicture.TabStop = false;
			this.rxLedPicture.Visible = false;
			// 
			// BoardModel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 446);
			this.ControlBox = false;
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.picturePanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(589, 0);
			this.Name = "BoardModel";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Модель платы";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BoardModel_FormClosing);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.picturePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.resetButtonPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.onLedPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txLedPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rxLedPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel picturePanel;
		private System.Windows.Forms.PictureBox resetButtonPicture;
		private System.Windows.Forms.PictureBox onLedPicture;
		private System.Windows.Forms.PictureBox txLedPicture;
		private System.Windows.Forms.PictureBox rxLedPicture;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton toolStripRotateButton;
	}
}