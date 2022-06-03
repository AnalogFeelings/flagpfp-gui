using FlagPFPCore.Exceptions;
using FlagPFPCore.FlagMaking;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace FlagPFPGUI
{
	public partial class MainForm : Form
	{
		public FlagCoreObject FlagMaker = new FlagCoreObject("Flags");

		public int InputWidth = 0;
		public int InputHeight = 0;

		public MainForm()
		{
			InitializeComponent();

			this.Text += Assembly.GetAssembly(typeof(MainForm)).GetName().Version.ToString(2);

			try
			{
				FlagMaker.LoadFlagDefsFromDir("Flag JSONs");
			}
			catch (DirectoryNotFoundException)
			{
				MessageBox.Show("Flag JSON directory not found!", "Error!", MessageBoxButtons.OK,
									MessageBoxIcon.Error);

				Environment.Exit(1);
			}
			catch (NoFlagsFoundException)
			{
				MessageBox.Show("No flags found in JSON directory!", "Error!", MessageBoxButtons.OK,
									MessageBoxIcon.Error);

				Environment.Exit(1);
			}

			DataGridViewComboBoxColumn ComboColumn = new DataGridViewComboBoxColumn
			{
				DataSource = new BindingSource(FlagMaker.FlagDictionary, null),
				ValueMember = "Key",
				DisplayMember = "Key",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			};

			flagsDataGrid.Columns.Add(ComboColumn);
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
	}
}
