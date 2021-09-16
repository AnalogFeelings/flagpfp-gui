using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool CheckFlagCombo()
        {
            if (flagCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Select a flag!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls();
                return false;
            }
            if(!FlagMaker.FlagDictionary.ContainsKey(flagCombo.GetItemText(flagCombo.SelectedItem)))
            {
                MessageBox.Show("Invalid flag!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                EnableControls();
                return false;
            }
            if (flagCombo2.SelectedIndex != -1 && !FlagMaker.FlagDictionary.ContainsKey(flagCombo2.GetItemText(flagCombo2.SelectedItem)))
            {
                MessageBox.Show("Invalid secondary flag!", "Error!",
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
