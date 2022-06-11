
namespace FlagPFPGUI
{
    partial class AboutForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.githubLink = new System.Windows.Forms.LinkLabel();
			this.quitButton = new System.Windows.Forms.Button();
			this.VersionLabel = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(274, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(316, 45);
			this.label1.TabIndex = 1;
			this.label1.Text = "FlagPFP GUI";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(280, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(304, 144);
			this.label2.TabIndex = 2;
			this.label2.Text = "A neat little GUI frontend for FlagPFP.Core written in Windows Forms.\r\n\r\nThanks t" +
    "o any current and future contributors! I really appreciate your work.\r\n";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// githubLink
			// 
			this.githubLink.AutoSize = true;
			this.githubLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.githubLink.Location = new System.Drawing.Point(274, 253);
			this.githubLink.Name = "githubLink";
			this.githubLink.Size = new System.Drawing.Size(110, 15);
			this.githubLink.TabIndex = 3;
			this.githubLink.TabStop = true;
			this.githubLink.Text = "Visit me on GitHub!";
			this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
			// 
			// quitButton
			// 
			this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.quitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quitButton.Location = new System.Drawing.Point(515, 245);
			this.quitButton.Name = "quitButton";
			this.quitButton.Size = new System.Drawing.Size(75, 23);
			this.quitButton.TabIndex = 4;
			this.quitButton.Text = "OK";
			this.quitButton.UseVisualStyleBackColor = true;
			this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
			// 
			// VersionLabel
			// 
			this.VersionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.VersionLabel.Location = new System.Drawing.Point(274, 57);
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Size = new System.Drawing.Size(316, 21);
			this.VersionLabel.TabIndex = 1;
			this.VersionLabel.Text = "Version ";
			this.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(280, 87);
			this.label4.Margin = new System.Windows.Forms.Padding(9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(304, 2);
			this.label4.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Image = global::FlagPFPGUI.Properties.Resources.flagpfp;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(256, 256);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(602, 280);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.quitButton);
			this.Controls.Add(this.githubLink);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.VersionLabel);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutForm";
			this.ShowIcon = false;
			this.Text = "About FlagPFP GUI";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label VersionLabel;
		private System.Windows.Forms.Label label4;
	}
}