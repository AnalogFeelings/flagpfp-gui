using System.Windows.Forms;

namespace FlagPFPGUI
{
    public partial class MainForm : Form
    {
        public bool CheckInputOutputBox()
        {
            if (inputBox.Text == string.Empty)
            {
                MessageBox.Show("Input image field must not be empty!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls();
                return false;
            }
            if (outputBox.Text == string.Empty)
            {
                MessageBox.Show("Output image field must not be empty!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls();
                return false;
            }
            return true;
        }

        public bool CheckFlagRows()
        {
            if (flagsDataGrid.Rows.Count == 1 && flagsDataGrid.Rows[0].IsNewRow)
            {
                MessageBox.Show("Provide at least 1 flag!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls();
                return false;
            }
            return true;
        }

        public bool CheckMarginBox(ref int margin)
        {
            if (marginBox.Text == string.Empty)
            {
                MessageBox.Show("Add a pixel margin!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls();
                return false;
            }
            if (!int.TryParse(marginBox.Text, out margin))
            {
                MessageBox.Show("Provide a valid pixel margin!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls();
                return false;
            }
            return true;
        }

        public bool CheckInnerSizeBox(ref int insize)
        {
            if (insizeBox.Text == string.Empty)
            {
                MessageBox.Show("Add an inner size!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls();
                return false;
            }
            if (!int.TryParse(insizeBox.Text, out insize))
            {
                MessageBox.Show("Provide a valid inner size!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls();
                return false;
            }
            return true;
        }

        public bool CheckFullSizeBox(ref int fsize)
        {
            if (fsizeBox.Text == string.Empty)
            {
                MessageBox.Show("Add a full size!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls();
                return false;
            }
            if (!int.TryParse(fsizeBox.Text, out fsize))
            {
                MessageBox.Show("Provide a valid full size!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls();
                return false;
            }
            return true;
        }
    }
}
