﻿
namespace FlagPFPGUI
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.flipVeriCheckbox = new System.Windows.Forms.CheckBox();
			this.flipHoriCheckbox = new System.Windows.Forms.CheckBox();
			this.rotateCheckbox = new System.Windows.Forms.CheckBox();
			this.fsizeBox = new System.Windows.Forms.NumericUpDown();
			this.insizeBox = new System.Windows.Forms.NumericUpDown();
			this.inputStatus = new System.Windows.Forms.Label();
			this.marginBox = new System.Windows.Forms.NumericUpDown();
			this.moveUp = new System.Windows.Forms.Button();
			this.moveDown = new System.Windows.Forms.Button();
			this.addFlag = new System.Windows.Forms.Button();
			this.removeFlag = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.flagsDataGrid = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.outputBrowseButton = new System.Windows.Forms.Button();
			this.outputBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.inputBrowseButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.inputBox = new System.Windows.Forms.TextBox();
			this.aboutButton = new System.Windows.Forms.Button();
			this.quitButton = new System.Windows.Forms.Button();
			this.generateButton = new System.Windows.Forms.Button();
			this.inputTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.flagTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.marginTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.insizeTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.fsizeTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.outputTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.previewPicture = new System.Windows.Forms.PictureBox();
			this.transTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.showAfterwardsCheckbox = new System.Windows.Forms.CheckBox();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fsizeBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.insizeBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.marginBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.flagsDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.previewPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.flipVeriCheckbox);
			this.groupBox2.Controls.Add(this.flipHoriCheckbox);
			this.groupBox2.Controls.Add(this.rotateCheckbox);
			this.groupBox2.Controls.Add(this.fsizeBox);
			this.groupBox2.Controls.Add(this.insizeBox);
			this.groupBox2.Controls.Add(this.inputStatus);
			this.groupBox2.Controls.Add(this.marginBox);
			this.groupBox2.Controls.Add(this.moveUp);
			this.groupBox2.Controls.Add(this.moveDown);
			this.groupBox2.Controls.Add(this.addFlag);
			this.groupBox2.Controls.Add(this.removeFlag);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.flagsDataGrid);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.outputBrowseButton);
			this.groupBox2.Controls.Add(this.outputBox);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.inputBrowseButton);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.inputBox);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(418, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(685, 419);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "FlagPFP Parameters";
			// 
			// flipVeriCheckbox
			// 
			this.flipVeriCheckbox.AutoSize = true;
			this.flipVeriCheckbox.Location = new System.Drawing.Point(303, 189);
			this.flipVeriCheckbox.Name = "flipVeriCheckbox";
			this.flipVeriCheckbox.Size = new System.Drawing.Size(95, 19);
			this.flipVeriCheckbox.TabIndex = 22;
			this.flipVeriCheckbox.Text = "Flip Vertically";
			this.flipVeriCheckbox.UseVisualStyleBackColor = true;
			// 
			// flipHoriCheckbox
			// 
			this.flipHoriCheckbox.AutoSize = true;
			this.flipHoriCheckbox.Location = new System.Drawing.Point(185, 189);
			this.flipHoriCheckbox.Name = "flipHoriCheckbox";
			this.flipHoriCheckbox.Size = new System.Drawing.Size(112, 19);
			this.flipHoriCheckbox.TabIndex = 22;
			this.flipHoriCheckbox.Text = "Flip Horizontally";
			this.flipHoriCheckbox.UseVisualStyleBackColor = true;
			// 
			// rotateCheckbox
			// 
			this.rotateCheckbox.AutoSize = true;
			this.rotateCheckbox.Location = new System.Drawing.Point(99, 189);
			this.rotateCheckbox.Name = "rotateCheckbox";
			this.rotateCheckbox.Size = new System.Drawing.Size(80, 19);
			this.rotateCheckbox.TabIndex = 21;
			this.rotateCheckbox.Text = "Rotate 90º";
			this.rotateCheckbox.UseVisualStyleBackColor = true;
			// 
			// fsizeBox
			// 
			this.fsizeBox.Location = new System.Drawing.Point(99, 161);
			this.fsizeBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.fsizeBox.Name = "fsizeBox";
			this.fsizeBox.Size = new System.Drawing.Size(578, 23);
			this.fsizeBox.TabIndex = 6;
			this.fsizeBox.Leave += new System.EventHandler(this.upAndDown_Leave);
			// 
			// insizeBox
			// 
			this.insizeBox.Location = new System.Drawing.Point(99, 132);
			this.insizeBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.insizeBox.Name = "insizeBox";
			this.insizeBox.Size = new System.Drawing.Size(578, 23);
			this.insizeBox.TabIndex = 5;
			this.insizeBox.Leave += new System.EventHandler(this.upAndDown_Leave);
			// 
			// inputStatus
			// 
			this.inputStatus.Location = new System.Drawing.Point(99, 48);
			this.inputStatus.Name = "inputStatus";
			this.inputStatus.Size = new System.Drawing.Size(580, 23);
			this.inputStatus.TabIndex = 20;
			this.inputStatus.Text = "Waiting for input...";
			this.inputStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// marginBox
			// 
			this.marginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.marginBox.Location = new System.Drawing.Point(99, 103);
			this.marginBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.marginBox.Name = "marginBox";
			this.marginBox.Size = new System.Drawing.Size(578, 23);
			this.marginBox.TabIndex = 4;
			this.marginBox.Leave += new System.EventHandler(this.upAndDown_Leave);
			// 
			// moveUp
			// 
			this.moveUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.moveUp.Location = new System.Drawing.Point(99, 366);
			this.moveUp.Name = "moveUp";
			this.moveUp.Size = new System.Drawing.Size(83, 23);
			this.moveUp.TabIndex = 8;
			this.moveUp.Text = "Move Up";
			this.moveUp.UseVisualStyleBackColor = true;
			this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
			// 
			// moveDown
			// 
			this.moveDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.moveDown.Location = new System.Drawing.Point(188, 366);
			this.moveDown.Name = "moveDown";
			this.moveDown.Size = new System.Drawing.Size(83, 23);
			this.moveDown.TabIndex = 9;
			this.moveDown.Text = "Move Down";
			this.moveDown.UseVisualStyleBackColor = true;
			this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
			// 
			// addFlag
			// 
			this.addFlag.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.addFlag.Location = new System.Drawing.Point(523, 366);
			this.addFlag.Name = "addFlag";
			this.addFlag.Size = new System.Drawing.Size(75, 23);
			this.addFlag.TabIndex = 10;
			this.addFlag.Text = "Add";
			this.addFlag.UseVisualStyleBackColor = true;
			this.addFlag.Click += new System.EventHandler(this.addFlag_Click);
			// 
			// removeFlag
			// 
			this.removeFlag.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.removeFlag.Location = new System.Drawing.Point(604, 366);
			this.removeFlag.Name = "removeFlag";
			this.removeFlag.Size = new System.Drawing.Size(75, 23);
			this.removeFlag.TabIndex = 11;
			this.removeFlag.Text = "Remove";
			this.removeFlag.UseVisualStyleBackColor = true;
			this.removeFlag.Click += new System.EventHandler(this.removeFlag_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 215);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 15);
			this.label2.TabIndex = 19;
			this.label2.Text = "Flags";
			this.flagTooltip.SetToolTip(this.label2, "The list of flags that you want on the output.");
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label7.Location = new System.Drawing.Point(6, 395);
			this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(290, 15);
			this.label7.TabIndex = 17;
			this.label7.Text = "Hover over the parameter names to see a help tooltip.\r\n";
			// 
			// flagsDataGrid
			// 
			this.flagsDataGrid.AllowUserToAddRows = false;
			this.flagsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.flagsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.flagsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.flagsDataGrid.Location = new System.Drawing.Point(99, 215);
			this.flagsDataGrid.MultiSelect = false;
			this.flagsDataGrid.Name = "flagsDataGrid";
			this.flagsDataGrid.Size = new System.Drawing.Size(578, 145);
			this.flagsDataGrid.TabIndex = 7;
			this.flagsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flagsDataGrid_CellClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 78);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 15);
			this.label6.TabIndex = 13;
			this.label6.Text = "Output File";
			this.outputTooltip.SetToolTip(this.label6, "The output file. Must also be JPEG or PNG.");
			// 
			// outputBrowseButton
			// 
			this.outputBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.outputBrowseButton.Location = new System.Drawing.Point(604, 74);
			this.outputBrowseButton.Name = "outputBrowseButton";
			this.outputBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.outputBrowseButton.TabIndex = 3;
			this.outputBrowseButton.Text = "Browse...";
			this.outputBrowseButton.UseVisualStyleBackColor = true;
			this.outputBrowseButton.Click += new System.EventHandler(this.outputBrowseButton_Click);
			// 
			// outputBox
			// 
			this.outputBox.Location = new System.Drawing.Point(99, 74);
			this.outputBox.Name = "outputBox";
			this.outputBox.Size = new System.Drawing.Size(499, 23);
			this.outputBox.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 190);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(87, 15);
			this.label8.TabIndex = 10;
			this.label8.Text = "Transformation";
			this.transTooltip.SetToolTip(this.label8, "Options regarding rotation of the flag images.");
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(20, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "Full Size (px)";
			this.fsizeTooltip.SetToolTip(this.label5, "The image size of the output.");
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Inner Size (px)";
			this.insizeTooltip.SetToolTip(this.label4, "Size of the inner image, for example, make it more than the original size to crop" +
        " it.");
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Margin (px)";
			this.marginTooltip.SetToolTip(this.label3, "Pixel margin between border and inner window.\r\n");
			// 
			// inputBrowseButton
			// 
			this.inputBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.inputBrowseButton.Location = new System.Drawing.Point(604, 22);
			this.inputBrowseButton.Name = "inputBrowseButton";
			this.inputBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.inputBrowseButton.TabIndex = 1;
			this.inputBrowseButton.Text = "Browse...";
			this.inputBrowseButton.UseVisualStyleBackColor = true;
			this.inputBrowseButton.Click += new System.EventHandler(this.inputBrowseButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Input File";
			this.inputTooltip.SetToolTip(this.label1, "The input image, in PNG or JPEG.");
			// 
			// inputBox
			// 
			this.inputBox.Location = new System.Drawing.Point(99, 22);
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(499, 23);
			this.inputBox.TabIndex = 0;
			this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
			// 
			// aboutButton
			// 
			this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutButton.Location = new System.Drawing.Point(499, 437);
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(75, 23);
			this.aboutButton.TabIndex = 13;
			this.aboutButton.Text = "About";
			this.aboutButton.UseVisualStyleBackColor = true;
			this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// quitButton
			// 
			this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.quitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quitButton.Location = new System.Drawing.Point(418, 437);
			this.quitButton.Name = "quitButton";
			this.quitButton.Size = new System.Drawing.Size(75, 23);
			this.quitButton.TabIndex = 14;
			this.quitButton.Text = "Quit";
			this.quitButton.UseVisualStyleBackColor = true;
			this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
			// 
			// generateButton
			// 
			this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.generateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.generateButton.Location = new System.Drawing.Point(1028, 437);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(75, 23);
			this.generateButton.TabIndex = 12;
			this.generateButton.Text = "Generate";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// inputTooltip
			// 
			this.inputTooltip.IsBalloon = true;
			this.inputTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.inputTooltip.ToolTipTitle = "Input";
			// 
			// flagTooltip
			// 
			this.flagTooltip.IsBalloon = true;
			this.flagTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.flagTooltip.ToolTipTitle = "Flags";
			// 
			// marginTooltip
			// 
			this.marginTooltip.IsBalloon = true;
			this.marginTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.marginTooltip.ToolTipTitle = "Margin";
			// 
			// insizeTooltip
			// 
			this.insizeTooltip.IsBalloon = true;
			this.insizeTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.insizeTooltip.ToolTipTitle = "Inner Size";
			// 
			// fsizeTooltip
			// 
			this.fsizeTooltip.IsBalloon = true;
			this.fsizeTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.fsizeTooltip.ToolTipTitle = "Full Size";
			// 
			// outputTooltip
			// 
			this.outputTooltip.IsBalloon = true;
			this.outputTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.outputTooltip.ToolTipTitle = "Output";
			// 
			// previewPicture
			// 
			this.previewPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.previewPicture.Location = new System.Drawing.Point(12, 12);
			this.previewPicture.Name = "previewPicture";
			this.previewPicture.Size = new System.Drawing.Size(400, 448);
			this.previewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.previewPicture.TabIndex = 2;
			this.previewPicture.TabStop = false;
			// 
			// transTooltip
			// 
			this.transTooltip.IsBalloon = true;
			this.transTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.transTooltip.ToolTipTitle = "Transformation";
			// 
			// showAfterwardsCheckbox
			// 
			this.showAfterwardsCheckbox.AutoSize = true;
			this.showAfterwardsCheckbox.Location = new System.Drawing.Point(866, 441);
			this.showAfterwardsCheckbox.Name = "showAfterwardsCheckbox";
			this.showAfterwardsCheckbox.Size = new System.Drawing.Size(156, 17);
			this.showAfterwardsCheckbox.TabIndex = 15;
			this.showAfterwardsCheckbox.Text = "Show in explorer afterwards";
			this.showAfterwardsCheckbox.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1115, 472);
			this.Controls.Add(this.showAfterwardsCheckbox);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.previewPicture);
			this.Controls.Add(this.generateButton);
			this.Controls.Add(this.aboutButton);
			this.Controls.Add(this.quitButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "FlagPFP GUI v";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fsizeBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.insizeBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.marginBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.flagsDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.previewPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button inputBrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.PictureBox previewPicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button outputBrowseButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.ToolTip inputTooltip;
        private System.Windows.Forms.ToolTip flagTooltip;
        private System.Windows.Forms.ToolTip marginTooltip;
        private System.Windows.Forms.ToolTip insizeTooltip;
        private System.Windows.Forms.ToolTip fsizeTooltip;
        private System.Windows.Forms.ToolTip outputTooltip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView flagsDataGrid;
        private System.Windows.Forms.Button removeFlag;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button moveUp;
		private System.Windows.Forms.Button addFlag;
		private System.Windows.Forms.NumericUpDown marginBox;
		private System.Windows.Forms.Label inputStatus;
		private System.Windows.Forms.NumericUpDown insizeBox;
		private System.Windows.Forms.NumericUpDown fsizeBox;
		private System.Windows.Forms.CheckBox rotateCheckbox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox flipHoriCheckbox;
		private System.Windows.Forms.CheckBox flipVeriCheckbox;
		private System.Windows.Forms.ToolTip transTooltip;
		private System.Windows.Forms.CheckBox showAfterwardsCheckbox;
	}
}

