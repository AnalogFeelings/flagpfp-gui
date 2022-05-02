using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlagPFPGUI
{
	public partial class MainForm
	{
		private void generateButton_Click(object sender, EventArgs e)
		{
			DisableControls();

			int PixelMargin = 0;
			int FullSize = 0;
			int InnerSize = 0;

			if (!CheckInputOutputBox()) return;
			if (!CheckFlagRows()) return;
			if (!CheckMarginBox(ref PixelMargin)) return;
			if (!CheckInnerSizeBox(ref InnerSize)) return;
			if (!CheckFullSizeBox(ref FullSize)) return;

			try
			{
				List<string> ChosenFlags = new List<string>();

				foreach (DataGridViewRow Row in flagsDataGrid.Rows)
				{
					string rowValue = (Row.Cells[0] as DataGridViewComboBoxCell).FormattedValue.ToString();
					if (rowValue == string.Empty) continue;
					ChosenFlags.Add(rowValue);
				}

				FlagMaker.ExecuteProcessing(inputBox.Text, PixelMargin, InnerSize, FullSize,
					outputBox.Text, ChosenFlags.ToArray());
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

		private void inputBrowseButton_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog FileDialog = new OpenFileDialog())
			{
				FileDialog.InitialDirectory = "c:\\";
				FileDialog.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg, .jpeg)|*.jpg;.jpeg";

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
				FileDialog.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg, .jpeg)|*.jpg;.jpeg";

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
			Application.Exit();
		}
		private void flagsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewComboBoxEditingControl EditingControl = flagsDataGrid.EditingControl as DataGridViewComboBoxEditingControl;

			if (EditingControl != null) EditingControl.DroppedDown = true;
		}
	}
}
