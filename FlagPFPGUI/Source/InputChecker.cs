using System.IO;
using System.Windows.Forms;

namespace FlagPFPGUI
{
	public partial class MainForm
	{
		public bool CheckInputOutputBox()
		{
			if (inputBox.Text == string.Empty || !File.Exists(inputBox.Text))
			{
				MessageBox.Show("Input image field must be a valid file path!", "Error!",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				EnableControls();

				return false;
			}
			if (outputBox.Text == string.Empty)
			{
				MessageBox.Show("Output image field must be a valid file path!", "Error!",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				EnableControls();

				return false;
			}
			return true;
		}

		public bool CheckFlagRows()
		{
			bool Found = false;

			foreach (DataGridViewRow row in flagsDataGrid.Rows)
			{
				if (row.Cells[0].FormattedValue.ToString() == string.Empty) continue;
				Found = true;
				break;
			}

			if (!Found)
			{
				MessageBox.Show("Provide at least 1 flag!", "Error!",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				EnableControls();

				return false;
			}

			return true;
		}

		public bool CheckMarginBox()
		{
			if (marginBox.Value < 0)
			{
				MessageBox.Show("Margin must not be smaller than 0", "Error!",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				EnableControls();

				return false;
			}
			return true;
		}

		public bool CheckOutputExtension()
		{
			if (!FlagMaker.IsExtensionValid(outputBox.Text))
			{
				MessageBox.Show($"Output extension must be:\n{string.Join(", ", FlagMaker.GetValidExtensions().ToArray())}", "Error!",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				EnableControls();

				return false;
			}

			return true;
		}

		public bool CheckInputExtension()
		{
			if (!FlagMaker.IsExtensionValid(inputBox.Text))
			{
				MessageBox.Show($"Input extension must be:\n{string.Join(", ", FlagMaker.GetValidExtensions().ToArray())}", "Error!",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				EnableControls();

				return false;
			}

			return true;
		}
	}
}
