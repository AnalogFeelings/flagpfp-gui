
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
			this.colorsDataGrid = new System.Windows.Forms.DataGridView();
			this.colorsLabel = new System.Windows.Forms.Label();
			this.backgroundModeCheckbox = new System.Windows.Forms.CheckBox();
			this.flipVeriCheckbox = new System.Windows.Forms.CheckBox();
			this.flipHoriCheckbox = new System.Windows.Forms.CheckBox();
			this.rotateCheckbox = new System.Windows.Forms.CheckBox();
			this.moveUp = new System.Windows.Forms.Button();
			this.moveDown = new System.Windows.Forms.Button();
			this.addColor = new System.Windows.Forms.Button();
			this.addFlag = new System.Windows.Forms.Button();
			this.removeColor = new System.Windows.Forms.Button();
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
			this.transTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.showAfterwardsCheckbox = new System.Windows.Forms.CheckBox();
			this.CreateFlagButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.marginBox = new FlagPFPGUI.Source.UnitedNumericUpDown();
			this.fsizeBox = new FlagPFPGUI.Source.UnitedNumericUpDown();
			this.insizeBox = new FlagPFPGUI.Source.UnitedNumericUpDown();
			this.previewPicture = new FlagPFPGUI.Source.PictureBoxWithText();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.colorsDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.flagsDataGrid)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.marginBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fsizeBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.insizeBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.previewPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.colorsDataGrid);
			this.groupBox2.Controls.Add(this.colorsLabel);
			this.groupBox2.Controls.Add(this.backgroundModeCheckbox);
			this.groupBox2.Controls.Add(this.marginBox);
			this.groupBox2.Controls.Add(this.fsizeBox);
			this.groupBox2.Controls.Add(this.insizeBox);
			this.groupBox2.Controls.Add(this.flipVeriCheckbox);
			this.groupBox2.Controls.Add(this.flipHoriCheckbox);
			this.groupBox2.Controls.Add(this.rotateCheckbox);
			this.groupBox2.Controls.Add(this.moveUp);
			this.groupBox2.Controls.Add(this.moveDown);
			this.groupBox2.Controls.Add(this.addColor);
			this.groupBox2.Controls.Add(this.addFlag);
			this.groupBox2.Controls.Add(this.removeColor);
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
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(827, 582);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Image Parameters";
			// 
			// colorsDataGrid
			// 
			this.colorsDataGrid.AllowUserToAddRows = false;
			this.colorsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.colorsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.colorsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.colorsDataGrid.Enabled = false;
			this.colorsDataGrid.Location = new System.Drawing.Point(136, 192);
			this.colorsDataGrid.Name = "colorsDataGrid";
			this.colorsDataGrid.Size = new System.Drawing.Size(685, 131);
			this.colorsDataGrid.TabIndex = 24;
			// 
			// colorsLabel
			// 
			this.colorsLabel.AutoSize = true;
			this.colorsLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.colorsLabel.Location = new System.Drawing.Point(133, 333);
			this.colorsLabel.Name = "colorsLabel";
			this.colorsLabel.Size = new System.Drawing.Size(487, 15);
			this.colorsLabel.TabIndex = 23;
			this.colorsLabel.Text = "These colors will be replaced with the flags. Leave it empty to use the image\'s t" +
    "ransparency.";
			this.colorsLabel.Visible = false;
			// 
			// backgroundModeCheckbox
			// 
			this.backgroundModeCheckbox.AutoSize = true;
			this.backgroundModeCheckbox.ForeColor = System.Drawing.SystemColors.ControlText;
			this.backgroundModeCheckbox.Location = new System.Drawing.Point(9, 192);
			this.backgroundModeCheckbox.Name = "backgroundModeCheckbox";
			this.backgroundModeCheckbox.Size = new System.Drawing.Size(124, 19);
			this.backgroundModeCheckbox.TabIndex = 10;
			this.backgroundModeCheckbox.Text = "Background Mode";
			this.backgroundModeCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.backgroundModeCheckbox.UseVisualStyleBackColor = true;
			this.backgroundModeCheckbox.CheckedChanged += new System.EventHandler(this.backgroundModeCheckbox_CheckedChanged);
			// 
			// flipVeriCheckbox
			// 
			this.flipVeriCheckbox.AutoSize = true;
			this.flipVeriCheckbox.Location = new System.Drawing.Point(340, 167);
			this.flipVeriCheckbox.Name = "flipVeriCheckbox";
			this.flipVeriCheckbox.Size = new System.Drawing.Size(95, 19);
			this.flipVeriCheckbox.TabIndex = 9;
			this.flipVeriCheckbox.Text = "Flip Vertically";
			this.flipVeriCheckbox.UseVisualStyleBackColor = true;
			// 
			// flipHoriCheckbox
			// 
			this.flipHoriCheckbox.AutoSize = true;
			this.flipHoriCheckbox.Location = new System.Drawing.Point(222, 167);
			this.flipHoriCheckbox.Name = "flipHoriCheckbox";
			this.flipHoriCheckbox.Size = new System.Drawing.Size(112, 19);
			this.flipHoriCheckbox.TabIndex = 8;
			this.flipHoriCheckbox.Text = "Flip Horizontally";
			this.flipHoriCheckbox.UseVisualStyleBackColor = true;
			// 
			// rotateCheckbox
			// 
			this.rotateCheckbox.AutoSize = true;
			this.rotateCheckbox.Location = new System.Drawing.Point(136, 167);
			this.rotateCheckbox.Name = "rotateCheckbox";
			this.rotateCheckbox.Size = new System.Drawing.Size(80, 19);
			this.rotateCheckbox.TabIndex = 7;
			this.rotateCheckbox.Text = "Rotate 90º";
			this.rotateCheckbox.UseVisualStyleBackColor = true;
			// 
			// moveUp
			// 
			this.moveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.moveUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.moveUp.Location = new System.Drawing.Point(136, 529);
			this.moveUp.Name = "moveUp";
			this.moveUp.Size = new System.Drawing.Size(83, 23);
			this.moveUp.TabIndex = 13;
			this.moveUp.Text = "Move Up";
			this.moveUp.UseVisualStyleBackColor = true;
			this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
			// 
			// moveDown
			// 
			this.moveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.moveDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.moveDown.Location = new System.Drawing.Point(222, 529);
			this.moveDown.Name = "moveDown";
			this.moveDown.Size = new System.Drawing.Size(83, 23);
			this.moveDown.TabIndex = 14;
			this.moveDown.Text = "Move Down";
			this.moveDown.UseVisualStyleBackColor = true;
			this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
			// 
			// addColor
			// 
			this.addColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addColor.Enabled = false;
			this.addColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.addColor.Location = new System.Drawing.Point(665, 329);
			this.addColor.Name = "addColor";
			this.addColor.Size = new System.Drawing.Size(75, 23);
			this.addColor.TabIndex = 15;
			this.addColor.Text = "Add";
			this.addColor.UseVisualStyleBackColor = true;
			this.addColor.Click += new System.EventHandler(this.addFlag_Click);
			// 
			// addFlag
			// 
			this.addFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.addFlag.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.addFlag.Location = new System.Drawing.Point(665, 529);
			this.addFlag.Name = "addFlag";
			this.addFlag.Size = new System.Drawing.Size(75, 23);
			this.addFlag.TabIndex = 15;
			this.addFlag.Text = "Add";
			this.addFlag.UseVisualStyleBackColor = true;
			this.addFlag.Click += new System.EventHandler(this.addFlag_Click);
			// 
			// removeColor
			// 
			this.removeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.removeColor.Enabled = false;
			this.removeColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.removeColor.Location = new System.Drawing.Point(746, 329);
			this.removeColor.Name = "removeColor";
			this.removeColor.Size = new System.Drawing.Size(75, 23);
			this.removeColor.TabIndex = 16;
			this.removeColor.Text = "Remove";
			this.removeColor.UseVisualStyleBackColor = true;
			this.removeColor.Click += new System.EventHandler(this.removeFlag_Click);
			// 
			// removeFlag
			// 
			this.removeFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.removeFlag.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.removeFlag.Location = new System.Drawing.Point(746, 529);
			this.removeFlag.Name = "removeFlag";
			this.removeFlag.Size = new System.Drawing.Size(75, 23);
			this.removeFlag.TabIndex = 16;
			this.removeFlag.Text = "Remove";
			this.removeFlag.UseVisualStyleBackColor = true;
			this.removeFlag.Click += new System.EventHandler(this.removeFlag_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(96, 358);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 15);
			this.label2.TabIndex = 19;
			this.label2.Text = "Flags";
			this.flagTooltip.SetToolTip(this.label2, "The list of flags that you want on the output.");
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label7.Location = new System.Drawing.Point(6, 558);
			this.label7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(290, 15);
			this.label7.TabIndex = 17;
			this.label7.Text = "Hover over the parameter names to see a help tooltip.\r\n";
			// 
			// flagsDataGrid
			// 
			this.flagsDataGrid.AllowUserToAddRows = false;
			this.flagsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flagsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.flagsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.flagsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.flagsDataGrid.Location = new System.Drawing.Point(136, 358);
			this.flagsDataGrid.MultiSelect = false;
			this.flagsDataGrid.Name = "flagsDataGrid";
			this.flagsDataGrid.Size = new System.Drawing.Size(685, 165);
			this.flagsDataGrid.TabIndex = 12;
			this.flagsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flagsDataGrid_CellClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(64, 55);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 15);
			this.label6.TabIndex = 13;
			this.label6.Text = "Output File";
			this.outputTooltip.SetToolTip(this.label6, "The output file. Must also be JPEG or PNG.");
			// 
			// outputBrowseButton
			// 
			this.outputBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.outputBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.outputBrowseButton.Location = new System.Drawing.Point(746, 51);
			this.outputBrowseButton.Name = "outputBrowseButton";
			this.outputBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.outputBrowseButton.TabIndex = 3;
			this.outputBrowseButton.Text = "Browse...";
			this.outputBrowseButton.UseVisualStyleBackColor = true;
			this.outputBrowseButton.Click += new System.EventHandler(this.outputBrowseButton_Click);
			// 
			// outputBox
			// 
			this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputBox.Location = new System.Drawing.Point(136, 51);
			this.outputBox.Name = "outputBox";
			this.outputBox.Size = new System.Drawing.Size(604, 23);
			this.outputBox.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(43, 168);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(87, 15);
			this.label8.TabIndex = 10;
			this.label8.Text = "Transformation";
			this.transTooltip.SetToolTip(this.label8, "Options regarding rotation of the flag images.");
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(75, 140);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "Total Size";
			this.fsizeTooltip.SetToolTip(this.label5, "The image size of the output.");
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(73, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "Inner Size";
			this.insizeTooltip.SetToolTip(this.label4, "Size of the inner image, for example, make it more than the original size to crop" +
        " it.");
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Border Margin";
			this.marginTooltip.SetToolTip(this.label3, "Pixel margin between border and inner window.\r\n");
			// 
			// inputBrowseButton
			// 
			this.inputBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.inputBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.inputBrowseButton.Location = new System.Drawing.Point(746, 22);
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
			this.label1.Location = new System.Drawing.Point(74, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Input File";
			this.inputTooltip.SetToolTip(this.label1, "The input image, in PNG or JPEG.");
			// 
			// inputBox
			// 
			this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inputBox.Location = new System.Drawing.Point(136, 22);
			this.inputBox.Name = "inputBox";
			this.inputBox.Size = new System.Drawing.Size(604, 23);
			this.inputBox.TabIndex = 0;
			// 
			// aboutButton
			// 
			this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aboutButton.Location = new System.Drawing.Point(84, 591);
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(75, 23);
			this.aboutButton.TabIndex = 20;
			this.aboutButton.Text = "About";
			this.aboutButton.UseVisualStyleBackColor = true;
			this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// quitButton
			// 
			this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.quitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quitButton.Location = new System.Drawing.Point(3, 591);
			this.quitButton.Name = "quitButton";
			this.quitButton.Size = new System.Drawing.Size(75, 23);
			this.quitButton.TabIndex = 21;
			this.quitButton.Text = "Quit";
			this.quitButton.UseVisualStyleBackColor = true;
			this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
			// 
			// generateButton
			// 
			this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.generateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.generateButton.Location = new System.Drawing.Point(755, 591);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(75, 23);
			this.generateButton.TabIndex = 17;
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
			this.marginTooltip.ToolTipTitle = "Border Margin";
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
			this.fsizeTooltip.ToolTipTitle = "Total Size";
			// 
			// outputTooltip
			// 
			this.outputTooltip.IsBalloon = true;
			this.outputTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.outputTooltip.ToolTipTitle = "Output";
			// 
			// transTooltip
			// 
			this.transTooltip.IsBalloon = true;
			this.transTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.transTooltip.ToolTipTitle = "Transformation";
			// 
			// showAfterwardsCheckbox
			// 
			this.showAfterwardsCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.showAfterwardsCheckbox.AutoSize = true;
			this.showAfterwardsCheckbox.Location = new System.Drawing.Point(593, 595);
			this.showAfterwardsCheckbox.Name = "showAfterwardsCheckbox";
			this.showAfterwardsCheckbox.Size = new System.Drawing.Size(156, 17);
			this.showAfterwardsCheckbox.TabIndex = 18;
			this.showAfterwardsCheckbox.Text = "Show in explorer afterwards";
			this.showAfterwardsCheckbox.UseVisualStyleBackColor = true;
			// 
			// CreateFlagButton
			// 
			this.CreateFlagButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.CreateFlagButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.CreateFlagButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateFlagButton.Location = new System.Drawing.Point(165, 591);
			this.CreateFlagButton.Name = "CreateFlagButton";
			this.CreateFlagButton.Size = new System.Drawing.Size(75, 23);
			this.CreateFlagButton.TabIndex = 19;
			this.CreateFlagButton.Text = "Create Flag";
			this.CreateFlagButton.UseVisualStyleBackColor = true;
			this.CreateFlagButton.Click += new System.EventHandler(this.CreateFlagButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.previewPicture);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(483, 611);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Image Preview";
			// 
			// splitContainer
			// 
			this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer.Location = new System.Drawing.Point(12, 12);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.groupBox1);
			this.splitContainer.Panel1MinSize = 400;
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer.Panel2.Controls.Add(this.showAfterwardsCheckbox);
			this.splitContainer.Panel2.Controls.Add(this.CreateFlagButton);
			this.splitContainer.Panel2.Controls.Add(this.generateButton);
			this.splitContainer.Panel2.Controls.Add(this.quitButton);
			this.splitContainer.Panel2.Controls.Add(this.aboutButton);
			this.splitContainer.Panel2MinSize = 800;
			this.splitContainer.Size = new System.Drawing.Size(1326, 617);
			this.splitContainer.SplitterDistance = 489;
			this.splitContainer.TabIndex = 20;
			this.splitContainer.TabStop = false;
			this.splitContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer_Paint);
			// 
			// marginBox
			// 
			this.marginBox.AddSpace = false;
			this.marginBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.marginBox.Location = new System.Drawing.Point(136, 80);
			this.marginBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.marginBox.Name = "marginBox";
			this.marginBox.SetCaretAtEnd = false;
			this.marginBox.Size = new System.Drawing.Size(685, 23);
			this.marginBox.TabIndex = 4;
			this.marginBox.UnitText = "px";
			// 
			// fsizeBox
			// 
			this.fsizeBox.AddSpace = false;
			this.fsizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fsizeBox.Location = new System.Drawing.Point(136, 138);
			this.fsizeBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.fsizeBox.Name = "fsizeBox";
			this.fsizeBox.SetCaretAtEnd = false;
			this.fsizeBox.Size = new System.Drawing.Size(685, 23);
			this.fsizeBox.TabIndex = 6;
			this.fsizeBox.UnitText = "px";
			// 
			// insizeBox
			// 
			this.insizeBox.AddSpace = false;
			this.insizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.insizeBox.Location = new System.Drawing.Point(136, 109);
			this.insizeBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.insizeBox.Name = "insizeBox";
			this.insizeBox.SetCaretAtEnd = false;
			this.insizeBox.Size = new System.Drawing.Size(685, 23);
			this.insizeBox.TabIndex = 5;
			this.insizeBox.UnitText = "px";
			// 
			// previewPicture
			// 
			this.previewPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.previewPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.previewPicture.EmptyText = "Nothing here yet...";
			this.previewPicture.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.previewPicture.Location = new System.Drawing.Point(6, 22);
			this.previewPicture.Name = "previewPicture";
			this.previewPicture.Size = new System.Drawing.Size(471, 583);
			this.previewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.previewPicture.TabIndex = 0;
			this.previewPicture.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1350, 641);
			this.Controls.Add(this.splitContainer);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(1300, 680);
			this.Name = "MainForm";
			this.Text = "FlagPFP GUI v";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.colorsDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.flagsDataGrid)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.marginBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fsizeBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.insizeBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.previewPicture)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button inputBrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
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
		private System.Windows.Forms.CheckBox rotateCheckbox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox flipHoriCheckbox;
		private System.Windows.Forms.CheckBox flipVeriCheckbox;
		private System.Windows.Forms.ToolTip transTooltip;
		private System.Windows.Forms.CheckBox showAfterwardsCheckbox;
		private System.Windows.Forms.Button CreateFlagButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private Source.UnitedNumericUpDown insizeBox;
		private Source.UnitedNumericUpDown marginBox;
		private Source.UnitedNumericUpDown fsizeBox;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.CheckBox backgroundModeCheckbox;
		private System.Windows.Forms.Label colorsLabel;
        private System.Windows.Forms.DataGridView colorsDataGrid;
        private System.Windows.Forms.Button addColor;
        private System.Windows.Forms.Button removeColor;
		private Source.PictureBoxWithText previewPicture;
	}
}

