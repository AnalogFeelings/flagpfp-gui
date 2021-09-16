using FlagPFPCore.Exceptions;
using FlagPFPCore.FlagMaking;
using System;
using System.IO;
using System.Windows.Forms;

namespace FlagPFPGUI
{
    public partial class MainForm : Form
    {
        public FlagCoreObject FlagMaker = new FlagCoreObject("Flags");

        public MainForm()
        {
            InitializeComponent();
            try
            {
                FlagMaker.LoadFlagDefsFromDir("Flag JSONs");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Flag JSON directory not found!", "Error!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            catch (NoFlagsFoundException)
            {
                MessageBox.Show("No flags found in JSON directory!", "Error!", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            flagCombo.DataSource = new BindingSource(FlagMaker.FlagDictionary, null);
            flagCombo.DisplayMember = "Key";
            flagCombo.ValueMember = "Key";
            flagCombo.SelectedIndex = 0;

            flagCombo2.DataSource = new BindingSource(FlagMaker.FlagDictionary, null);
            flagCombo2.DisplayMember = "Key";
            flagCombo2.ValueMember = "Key";
            flagCombo2.SelectedIndex = -1;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            DisableControls();
            int pixelMargin = 0;
            int fullSize = 0;
            int innerSize = 0;

            if (!CheckInputOutputBox()) return;
            if (!CheckFlagCombo()) return;
            if (!CheckMarginBox(ref pixelMargin)) return;
            if (!CheckInnerSizeBox(ref innerSize)) return;
            if (!CheckFullSizeBox(ref fullSize)) return;

            try
            {
                FlagMaker.ExecuteProcessing(inputBox.Text, pixelMargin, innerSize, fullSize,
                    outputBox.Text, flagCombo.GetItemText(flagCombo.SelectedItem),
                    flagCombo2.SelectedIndex == -1 ? "" : flagCombo2.GetItemText(flagCombo2.SelectedItem));
            }
            catch (InvalidFlagException)
            {
                MessageBox.Show("How did you even pass an invalid flag? There's checks for it...", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Exception:\n" + ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls();
                return;
            }
            previewPicture.ImageLocation = outputBox.Text;
            EnableControls();
        }

        public void DisableControls()
        {
            inputBox.Enabled = false;
            inputBrowseButton.Enabled = false;
            flagCombo.Enabled = false;
            marginBox.Enabled = false;
            insizeBox.Enabled = false;
            fsizeBox.Enabled = false;
            outputBox.Enabled = false;
            outputBrowseButton.Enabled = false;
        }

        public void EnableControls()
        {
            inputBox.Enabled = true;
            inputBrowseButton.Enabled = true;
            flagCombo.Enabled = true;
            marginBox.Enabled = true;
            insizeBox.Enabled = true;
            fsizeBox.Enabled = true;
            outputBox.Enabled = true;
            outputBrowseButton.Enabled = true;
        }

        private void inputBrowseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg, .jpeg)|*.jpg;.jpeg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void outputBrowseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg, .jpeg)|*.jpg;.jpeg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
