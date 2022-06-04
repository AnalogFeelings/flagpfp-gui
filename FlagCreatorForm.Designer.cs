namespace FlagPFPGUI
{
	partial class FlagCreatorForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.BrowseButton = new System.Windows.Forms.Button();
			this.NameTextbox = new System.Windows.Forms.TextBox();
			this.FileTextbox = new System.Windows.Forms.TextBox();
			this.CreateButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.BrowseButton);
			this.groupBox1.Controls.Add(this.NameTextbox);
			this.groupBox1.Controls.Add(this.FileTextbox);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(405, 83);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Flag Parameters";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Image File";
			// 
			// BrowseButton
			// 
			this.BrowseButton.Location = new System.Drawing.Point(323, 22);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(76, 23);
			this.BrowseButton.TabIndex = 1;
			this.BrowseButton.Text = "Browse...";
			this.BrowseButton.UseVisualStyleBackColor = true;
			this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
			// 
			// NameTextbox
			// 
			this.NameTextbox.Location = new System.Drawing.Point(73, 51);
			this.NameTextbox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
			this.NameTextbox.Name = "NameTextbox";
			this.NameTextbox.Size = new System.Drawing.Size(326, 23);
			this.NameTextbox.TabIndex = 0;
			// 
			// FileTextbox
			// 
			this.FileTextbox.Location = new System.Drawing.Point(73, 22);
			this.FileTextbox.Name = "FileTextbox";
			this.FileTextbox.Size = new System.Drawing.Size(244, 23);
			this.FileTextbox.TabIndex = 0;
			// 
			// CreateButton
			// 
			this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateButton.Location = new System.Drawing.Point(342, 101);
			this.CreateButton.Name = "CreateButton";
			this.CreateButton.Size = new System.Drawing.Size(75, 23);
			this.CreateButton.TabIndex = 1;
			this.CreateButton.Text = "Create";
			this.CreateButton.UseVisualStyleBackColor = true;
			this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CancelButton.Location = new System.Drawing.Point(12, 101);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 2;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// FlagCreatorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 136);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.CreateButton);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FlagCreatorForm";
			this.ShowInTaskbar = false;
			this.Text = "Create Flag";
			this.TopMost = true;
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button CreateButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button BrowseButton;
		private System.Windows.Forms.TextBox FileTextbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox NameTextbox;
	}
}