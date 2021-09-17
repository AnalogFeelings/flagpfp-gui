
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
            this.moveUp = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.removeFlag = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flagsDataGrid = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.outputBrowseButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fsizeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.insizeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.marginBox = new System.Windows.Forms.TextBox();
            this.inputBrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.inputTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.flagTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.marginTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.insizeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.fsizeTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.outputTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.previewPicture = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.moveUp);
            this.groupBox2.Controls.Add(this.moveDown);
            this.groupBox2.Controls.Add(this.removeFlag);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.flagsDataGrid);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.aboutButton);
            this.groupBox2.Controls.Add(this.quitButton);
            this.groupBox2.Controls.Add(this.generateButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.outputBrowseButton);
            this.groupBox2.Controls.Add(this.outputBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.fsizeBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.insizeBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.marginBox);
            this.groupBox2.Controls.Add(this.inputBrowseButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.inputBox);
            this.groupBox2.Location = new System.Drawing.Point(418, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 400);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FlagPFP Parameters";
            // 
            // moveUp
            // 
            this.moveUp.Location = new System.Drawing.Point(334, 316);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(75, 23);
            this.moveUp.TabIndex = 23;
            this.moveUp.Text = "Move Up";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveDown
            // 
            this.moveDown.Location = new System.Drawing.Point(415, 316);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(75, 23);
            this.moveDown.TabIndex = 22;
            this.moveDown.Text = "Move Down";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // removeFlag
            // 
            this.removeFlag.Location = new System.Drawing.Point(496, 316);
            this.removeFlag.Name = "removeFlag";
            this.removeFlag.Size = new System.Drawing.Size(23, 23);
            this.removeFlag.TabIndex = 21;
            this.removeFlag.Text = "-";
            this.removeFlag.UseVisualStyleBackColor = true;
            this.removeFlag.Click += new System.EventHandler(this.removeFlag_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Flags";
            this.flagTooltip.SetToolTip(this.label2, "The list of flags that you want on the output.");
            // 
            // flagsDataGrid
            // 
            this.flagsDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.flagsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flagsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.flagsDataGrid.Location = new System.Drawing.Point(66, 149);
            this.flagsDataGrid.MultiSelect = false;
            this.flagsDataGrid.Name = "flagsDataGrid";
            this.flagsDataGrid.Size = new System.Drawing.Size(455, 161);
            this.flagsDataGrid.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(6, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 26);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hover over the parameter names to see a help tooltip.\r\nSelect flag type twice to " +
    "add new item (investigating fix).\r\n";
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(87, 371);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 16;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(6, 371);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 15;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(446, 371);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 14;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Output";
            this.outputTooltip.SetToolTip(this.label6, "The output file.");
            // 
            // outputBrowseButton
            // 
            this.outputBrowseButton.Location = new System.Drawing.Point(446, 121);
            this.outputBrowseButton.Name = "outputBrowseButton";
            this.outputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.outputBrowseButton.TabIndex = 12;
            this.outputBrowseButton.Text = "Browse";
            this.outputBrowseButton.UseVisualStyleBackColor = true;
            this.outputBrowseButton.Click += new System.EventHandler(this.outputBrowseButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(66, 123);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(374, 20);
            this.outputBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Full Size";
            this.fsizeTooltip.SetToolTip(this.label5, "The image size of the output.");
            // 
            // fsizeBox
            // 
            this.fsizeBox.Location = new System.Drawing.Point(66, 97);
            this.fsizeBox.Name = "fsizeBox";
            this.fsizeBox.Size = new System.Drawing.Size(455, 20);
            this.fsizeBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inner Size";
            this.insizeTooltip.SetToolTip(this.label4, "Size of the inner image, for example, set it to more to crop it.");
            // 
            // insizeBox
            // 
            this.insizeBox.Location = new System.Drawing.Point(66, 71);
            this.insizeBox.Name = "insizeBox";
            this.insizeBox.Size = new System.Drawing.Size(455, 20);
            this.insizeBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Margin";
            this.marginTooltip.SetToolTip(this.label3, "Pixel margin between border and inner window.\r\n");
            // 
            // marginBox
            // 
            this.marginBox.Location = new System.Drawing.Point(66, 45);
            this.marginBox.Name = "marginBox";
            this.marginBox.Size = new System.Drawing.Size(455, 20);
            this.marginBox.TabIndex = 5;
            // 
            // inputBrowseButton
            // 
            this.inputBrowseButton.Location = new System.Drawing.Point(446, 17);
            this.inputBrowseButton.Name = "inputBrowseButton";
            this.inputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.inputBrowseButton.TabIndex = 2;
            this.inputBrowseButton.Text = "Browse";
            this.inputBrowseButton.UseVisualStyleBackColor = true;
            this.inputBrowseButton.Click += new System.EventHandler(this.inputBrowseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            this.inputTooltip.SetToolTip(this.label1, "The input image, in PNG or JPEG.");
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(66, 19);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(374, 20);
            this.inputBox.TabIndex = 0;
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
            this.previewPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewPicture.Location = new System.Drawing.Point(12, 12);
            this.previewPicture.Name = "previewPicture";
            this.previewPicture.Size = new System.Drawing.Size(400, 400);
            this.previewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.previewPicture.TabIndex = 2;
            this.previewPicture.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.previewPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "FlagPFP GUI v";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button inputBrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.PictureBox previewPicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox insizeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox marginBox;
        private System.Windows.Forms.Button outputBrowseButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fsizeBox;
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
    }
}

