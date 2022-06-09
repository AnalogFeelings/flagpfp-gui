using FlagPFPCore.Exceptions;
using FlagPFPCore.FlagMaking;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
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

		private const string API_RELEASES_URL = "https://api.github.com/repos/AestheticalZ/flagpfp-gui/releases/latest";
		private const string GIT_LATEST_RELEASE_URL = "https://github.com/AestheticalZ/flagpfp-gui/releases/latest";

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

			CheckForUpdates();
		}

		private void CheckForUpdates()
		{
			using (WebClient Client = new WebClient())
			{
				try
				{
					Version ParsedNewVersion;
					Version CurrentVersion = Assembly.GetAssembly(typeof(MainForm)).GetName().Version;

					//Github wants me to set a user agent, sure!
					Client.Headers.Add("Accept", "application/vnd.github.v3+json");
					Client.Headers.Add("User-Agent", "AestheticalZ/flagpfp-gui");

					JsonSerializerSettings DeserializeSettings = new JsonSerializerSettings
					{
						MissingMemberHandling = MissingMemberHandling.Ignore
					};

					UpdaterResponse Response = JsonConvert.DeserializeObject<UpdaterResponse>(Client.DownloadString(API_RELEASES_URL), DeserializeSettings);

					//Version is invalid? Die
					if (!Version.TryParse(Response.VersionTag, out ParsedNewVersion)) return;

					ReleaseAsset PackageAsset = Response.Assets.FirstOrDefault(x => x.Filename.EndsWith(".zip"));
					ReleaseAsset ChecksumAsset = Response.Assets.FirstOrDefault(x => x.Filename.EndsWith(".md5"));

					if (ParsedNewVersion > CurrentVersion)
					{
						//Missing required files? The update must have changed the structure!
						if (PackageAsset == default(ReleaseAsset) || PackageAsset == null || ChecksumAsset == default(ReleaseAsset) || ChecksumAsset == null)
						{
							DialogResult Result = MessageBox.Show("The updater found an update, but it could not find the necessary files, meaning that the updater may have been updated.\n\n" +
																"The updater is not designed to update itself, so you must download and update FlagPFP-GUI yourself.\n\n" +
																"Do you want to go to the latest GitHub release?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

							if (Result == DialogResult.Yes) Process.Start(GIT_LATEST_RELEASE_URL);

							return;
						}

						UpdaterForm Form = new UpdaterForm(ParsedNewVersion, Response.Description, PackageAsset, ChecksumAsset);
						Form.Show();
					}
				}
				catch (Exception)
				{
					return; //Do nothing.
				}
			}
		}

		public void LoadFlags()
		{
			FlagMaker.LoadFlagDefsFromDir("Flag JSONs");

			if (GridSource != null)
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
