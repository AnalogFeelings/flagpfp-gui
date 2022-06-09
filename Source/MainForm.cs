using FlagPFPCore.Exceptions;
using FlagPFPCore.FlagMaking;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace FlagPFPGUI
{
	public partial class MainForm : Form
	{
		public FlagCoreObject FlagMaker = new FlagCoreObject("Flags");
		public string BrowserFilter = "All Supported Formats (*{0})|*{1}";

		private BindingSource GridSource;
		private DataGridViewComboBoxColumn ComboColumn;

		public MainForm()
		{
			InitializeComponent();

			this.Text += Assembly.GetAssembly(typeof(MainForm)).GetName().Version.ToString(2);

			try
			{
				LoadFlags();
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

			List<string> AllExtensions = FlagMaker.GetValidExtensions();
			BrowserFilter = string.Format(BrowserFilter, string.Join(", *", AllExtensions), string.Join(";*", AllExtensions));

			GridSource = new BindingSource(FlagMaker.FlagDictionary, null);

			ComboColumn = new DataGridViewComboBoxColumn
			{
				DataSource = GridSource,
				ValueMember = "Key",
				DisplayMember = "Key",
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			};

			flagsDataGrid.Columns.Add(ComboColumn);
		}

		public void LoadFlags()
		{
			FlagMaker.LoadFlagDefsFromDir("Flag JSONs");

			if(GridSource != null)
			{
				GridSource = new BindingSource(FlagMaker.FlagDictionary, null);

				ComboColumn.DataSource = GridSource;
			}
		}

		public void DisableControls()
		{
			generateButton.Enabled = false;
			inputBox.Enabled = false;
			inputBrowseButton.Enabled = false;
			flagsDataGrid.Enabled = false;
			marginBox.Enabled = false;
			insizeBox.Enabled = false;
			fsizeBox.Enabled = false;
			rotateCheckbox.Enabled = false;
			flipHoriCheckbox.Enabled = false;
			flipVeriCheckbox.Enabled = false;
			outputBox.Enabled = false;
			outputBrowseButton.Enabled = false;
		}

		public void EnableControls()
		{
			generateButton.Enabled = true;
			inputBox.Enabled = true;
			inputBrowseButton.Enabled = true;
			flagsDataGrid.Enabled = true;
			marginBox.Enabled = true;
			insizeBox.Enabled = true;
			fsizeBox.Enabled = true;
			rotateCheckbox.Enabled = true;
			flipHoriCheckbox.Enabled = true;
			flipVeriCheckbox.Enabled = true;
			outputBox.Enabled = true;
			outputBrowseButton.Enabled = true;
		}
	}
}
