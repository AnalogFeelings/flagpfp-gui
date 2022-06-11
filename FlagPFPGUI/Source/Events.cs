using FlagPFPCore.Loading;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FlagPFPGUI
{
	public partial class MainForm
	{
		private void generateButton_Click(object sender, EventArgs e)
		{
			DisableControls();

			int PixelMargin = (int)Math.Floor(marginBox.Value);
			int FullSize = (int)Math.Floor(fsizeBox.Value);
			int InnerSize = (int)Math.Floor(insizeBox.Value);

			if (!CheckInputOutputBox()) return;
			if (!CheckInputExtension()) return;
			if (!CheckOutputExtension()) return;
			if (!CheckMarginBox()) return;
			if (!CheckFlagRows()) return;

			string FullOutputPath = Path.GetFullPath(outputBox.Text);

			if (FullSize % 2 != 0)
			{
				MessageBox.Show("The size of the output image is not even!\nThe scaling may look bad, especially if its low resolution pixel art.\n" +
					"The circular window in the middle will also be uncentered.", "Warning!",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			try
			{
				List<string> ChosenFlags = new List<string>();

				foreach (DataGridViewRow Row in flagsDataGrid.Rows)
				{
					string RowValue = (Row.Cells[0] as DataGridViewComboBoxCell).FormattedValue.ToString();
					if (RowValue == string.Empty) continue;

					ChosenFlags.Add(RowValue);
				}

				FlagParameters Parameters = new FlagParameters
				{
					InputImagePath = inputBox.Text,
					OutputImagePath = outputBox.Text,
					OutputImageSize = FullSize,
					InnerImageSize = InnerSize,
					RingPixelMargin = PixelMargin,
					RotateFlag90 = rotateCheckbox.Checked,
					FlipFlagHorizontally = flipHoriCheckbox.Checked,
					FlipFlagVertically = flipVeriCheckbox.Checked,
					Flags = ChosenFlags
				};

				Bitmap ProcessedImage = FlagMaker.ExecuteProcessing(Parameters);

				Bitmap ExportedImage = FlagMaker.ExportBitmap(ref ProcessedImage, Parameters.OutputImagePath);
				previewPicture.Image = new Bitmap(ExportedImage);

				ExportedImage.Dispose();

				if (showAfterwardsCheckbox.Checked)
				{
					//explorer.exe /select,"path"
					string arguments = string.Format("/select,\"{0}\"", FullOutputPath);

					Process.Start("explorer.exe", arguments);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error! Exception:\n" + ex.Message, "Error!",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				EnableControls();

				return;
			}

			EnableControls();
		}

		private void CreateFlagButton_Click(object sender, EventArgs e)
		{
			FlagCreatorForm CreatorForm = new FlagCreatorForm(this);
			CreatorForm.Show();
		}

		private void inputBrowseButton_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog FileDialog = new OpenFileDialog())
			{
				FileDialog.InitialDirectory = "c:\\";
				FileDialog.Filter = BrowserFilter;

				if (FileDialog.ShowDialog() == DialogResult.OK)
				{
					inputBox.Text = FileDialog.FileName;
				}
			}
		}

		private void outputBrowseButton_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog FileDialog = new OpenFileDialog())
			{
				FileDialog.InitialDirectory = "c:\\";
				FileDialog.Filter = BrowserFilter;

				if (FileDialog.ShowDialog() == DialogResult.OK)
				{
					outputBox.Text = FileDialog.FileName;
				}
			}
		}

		private void aboutButton_Click(object sender, EventArgs e)
		{
			AboutForm AboutForm = new AboutForm();
			AboutForm.Show();
		}

		private void addFlag_Click(object sender, EventArgs e)
		{
			flagsDataGrid.Rows.Add();
		}

		private void removeFlag_Click(object sender, EventArgs e)
		{
			if (flagsDataGrid.SelectedRows.Count == 0) return;

			foreach (DataGridViewRow Row in flagsDataGrid.SelectedRows)
			{
				if (Row.IsNewRow) continue;
				flagsDataGrid.Rows.RemoveAt(Row.Index);
			}
		}

		private void moveUp_Click(object sender, EventArgs e)
		{
			//weird garbage taken from stack overflow, too lazy.
			int RowIndex = flagsDataGrid.SelectedCells[0].OwningRow.Index;
			if (RowIndex == 0)
				return;
			int ColumnIndex = flagsDataGrid.SelectedCells[0].OwningColumn.Index;

			DataGridViewRow SelectedRow = flagsDataGrid.Rows[RowIndex];
			flagsDataGrid.Rows.Remove(SelectedRow);
			flagsDataGrid.Rows.Insert(RowIndex - 1, SelectedRow);
			flagsDataGrid.ClearSelection();
			flagsDataGrid.Rows[RowIndex - 1].Cells[ColumnIndex].Selected = true;
		}

		private void moveDown_Click(object sender, EventArgs e)
		{
			int TotalRows = flagsDataGrid.Rows.Count;
			int RowIndex = flagsDataGrid.SelectedCells[0].OwningRow.Index;
			if (RowIndex == TotalRows - 1)
				return;
			int ColumnIndex = flagsDataGrid.SelectedCells[0].OwningColumn.Index;

			DataGridViewRow SelectedRow = flagsDataGrid.Rows[RowIndex];
			flagsDataGrid.Rows.Remove(SelectedRow);
			flagsDataGrid.Rows.Insert(RowIndex + 1, SelectedRow);
			flagsDataGrid.ClearSelection();
			flagsDataGrid.Rows[RowIndex + 1].Cells[ColumnIndex].Selected = true;
		}

		private void quitButton_Click(object sender, EventArgs e)
		{
			DialogResult Result = MessageBox.Show("Are you sure you want to quit?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if(Result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void flagsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewComboBoxEditingControl EditingControl = flagsDataGrid.EditingControl as DataGridViewComboBoxEditingControl;

			if (EditingControl != null) EditingControl.DroppedDown = true;
		}

		private void backgroundModeCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (backgroundModeCheckbox.Checked)
			{
				marginBox.Enabled = false;
				pickColorButton.Enabled = true;
			}
			else
			{
				marginBox.Enabled = true;
				pickColorButton.Enabled = false;
			}
		}

		private void splitContainer_Paint(object sender, PaintEventArgs e)
		{
			SplitContainer Target = sender as SplitContainer;

			Rectangle Copy = Target.SplitterRectangle;
			Copy.X += 3;
			Copy.Width = 2;

			e.Graphics.FillRectangle(SystemBrushes.ControlLight, Copy);
		}
	}
}
