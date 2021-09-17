using FlagPFPCore.Exceptions;
using FlagPFPCore.FlagMaking;
using System;
using System.Collections.Generic;
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

            this.Text += Properties.Resources.ProgramVersion;

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

            DataGridViewComboBoxColumn comboCell = new DataGridViewComboBoxColumn();
            comboCell.DataSource = new BindingSource(FlagMaker.FlagDictionary, null);
            comboCell.ValueMember = "Key";
            comboCell.DisplayMember = "Key";
            comboCell.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            flagsDataGrid.Columns.Add(comboCell);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            DisableControls();
            int pixelMargin = 0;
            int fullSize = 0;
            int innerSize = 0;

            if (!CheckInputOutputBox()) return;
            if (!CheckFlagRows()) return;
            if (!CheckMarginBox(ref pixelMargin)) return;
            if (!CheckInnerSizeBox(ref innerSize)) return;
            if (!CheckFullSizeBox(ref fullSize)) return;

            try
            {
                List<string> chosenFlags = new List<string>();
                foreach(DataGridViewRow row in flagsDataGrid.Rows)
                {
                    string rowValue = (row.Cells[0] as DataGridViewComboBoxCell).FormattedValue.ToString();
                    if (rowValue == string.Empty) continue;
                    chosenFlags.Add(rowValue);
                }

                FlagMaker.ExecuteProcessing(inputBox.Text, pixelMargin, innerSize, fullSize,
                    outputBox.Text, chosenFlags.ToArray());
            }
            catch (InvalidFlagException)
            {
                MessageBox.Show("How did you even pass an invalid flag?", "Error!",
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
            flagsDataGrid.Enabled = false;
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
            flagsDataGrid.Enabled = true;
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

        private void removeFlag_Click(object sender, EventArgs e)
        {
            if (flagsDataGrid.SelectedRows.Count == 0) return;
            foreach (DataGridViewRow row in flagsDataGrid.SelectedRows)
            {
                if (row.IsNewRow) continue;
                flagsDataGrid.Rows.RemoveAt(row.Index);
            }
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            //weird garbage taken from stack overflow, too lazy.
            int totalRows = flagsDataGrid.Rows.Count;
            int rowIndex = flagsDataGrid.SelectedCells[0].OwningRow.Index;
            if (rowIndex == 0)
                return;
            int colIndex = flagsDataGrid.SelectedCells[0].OwningColumn.Index;
            DataGridViewRow selectedRow = flagsDataGrid.Rows[rowIndex];
            flagsDataGrid.Rows.Remove(selectedRow);
            flagsDataGrid.Rows.Insert(rowIndex - 1, selectedRow);
            flagsDataGrid.ClearSelection();
            flagsDataGrid.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            int totalRows = flagsDataGrid.Rows.Count;
            int rowIndex = flagsDataGrid.SelectedCells[0].OwningRow.Index;
            if (rowIndex == totalRows - 1)
                return;
            int colIndex = flagsDataGrid.SelectedCells[0].OwningColumn.Index;
            DataGridViewRow selectedRow = flagsDataGrid.Rows[rowIndex];
            flagsDataGrid.Rows.Remove(selectedRow);
            flagsDataGrid.Rows.Insert(rowIndex + 1, selectedRow);
            flagsDataGrid.ClearSelection();
            flagsDataGrid.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
