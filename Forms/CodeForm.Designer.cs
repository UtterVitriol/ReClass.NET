﻿namespace ReClassNET.Forms
{
	partial class CodeForm
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
			this.bannerImage = new System.Windows.Forms.PictureBox();
			this.codeWebBrowser = new System.Windows.Forms.WebBrowser();
			((System.ComponentModel.ISupportInitialize)(this.bannerImage)).BeginInit();
			this.SuspendLayout();
			// 
			// bannerImage
			// 
			this.bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
			this.bannerImage.Location = new System.Drawing.Point(0, 0);
			this.bannerImage.Name = "bannerImage";
			this.bannerImage.Size = new System.Drawing.Size(588, 48);
			this.bannerImage.TabIndex = 2;
			this.bannerImage.TabStop = false;
			// 
			// codeWebBrowser
			// 
			this.codeWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.codeWebBrowser.Location = new System.Drawing.Point(0, 48);
			this.codeWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.codeWebBrowser.Name = "codeWebBrowser";
			this.codeWebBrowser.Size = new System.Drawing.Size(588, 421);
			this.codeWebBrowser.TabIndex = 1;
			// 
			// CodeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 469);
			this.Controls.Add(this.codeWebBrowser);
			this.Controls.Add(this.bannerImage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CodeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ReClass.NET - Code Generator";
			((System.ComponentModel.ISupportInitialize)(this.bannerImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.WebBrowser codeWebBrowser;
		private System.Windows.Forms.PictureBox bannerImage;
	}
}