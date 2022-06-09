using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace FlagPFPGUI
{
    public partial class UpdaterForm : Form
    {
        private ReleaseAsset PackageAsset;
        private ReleaseAsset ChecksumAsset;
        private string VersionString;

        public UpdaterForm(Version Version, string Description, ReleaseAsset PackageAsset, ReleaseAsset ChecksumAsset)
        {
            InitializeComponent();

            this.PackageAsset = PackageAsset;
            this.ChecksumAsset = ChecksumAsset;
            VersionString = Version.ToString(2);

            NativeMethods.SHSTOCKICONINFO StockIconInfo = new NativeMethods.SHSTOCKICONINFO();
            StockIconInfo.cbSize = (UInt32)Marshal.SizeOf(typeof(NativeMethods.SHSTOCKICONINFO));
			NativeMethods.SHGetStockIconInfo(NativeMethods.SHSTOCKICONID.SIID_INFO, NativeMethods.SHGSI.SHGSI_ICON | NativeMethods.SHGSI.SHGSI_SHELLICONSIZE, ref StockIconInfo);

            systemBitmap.Image = Icon.FromHandle(StockIconInfo.hIcon).ToBitmap();

            headerLabel.Text = headerLabel.Text.Replace("(version)", VersionString);

            changelogBox.Text = Description;
            changelogBox.BackColor = SystemColors.Window;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void yesButton_Click(object sender, EventArgs e)
        {
            string CurrentFilename = Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName);

            this.changelogBox.Select(0, 0);
            this.ControlBox = false;
            this.noButton.Enabled = false;
            this.yesButton.Enabled = false;

            try
            {
                using (WebClient Client = new WebClient())
                {
                    string DownloadedChecksum = string.Empty;

                    Client.Headers.Add("User-Agent", "AestheticalZ/flagpfp-gui");

                    Client.DownloadFile(new Uri(ChecksumAsset.DownloadUrl), ChecksumAsset.Filename);
                    DownloadedChecksum = File.ReadAllText(ChecksumAsset.Filename);

                    if (string.IsNullOrEmpty(DownloadedChecksum)) throw new Exception("The checksum file was empty.");

                    Client.DownloadProgressChanged += (senderObj, eventArg) =>
                    {
                        downloadProgress.Value = eventArg.ProgressPercentage;
                        statusLabel.Text = $"Status: Downloading {eventArg.ProgressPercentage}%";
                    };

                    await Client.DownloadFileTaskAsync(new Uri(PackageAsset.DownloadUrl), PackageAsset.Filename);

                    statusLabel.Text = "Status: Verifying...";

                    using (MD5 md5 = MD5.Create())
                    {
                        using (FileStream stream = File.OpenRead(PackageAsset.Filename))
                        {
                            string convertedChecksum;

                            byte[] hash = md5.ComputeHash(stream);
                            convertedChecksum = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

                            if (DownloadedChecksum != convertedChecksum) throw new Exception("Verification failed. Update package is probably corrupted.");
                        }
                    }

                    ProcessStartInfo updaterProcess = new ProcessStartInfo("FlagPFPGUI.Updater.exe");
					//Arg 0: New version
					//Arg 1: FlagPFP process name
					//Arg 2: Checksum filename
					//Arg 3: Package filename
					updaterProcess.Arguments = $"{VersionString} {FixSpaces(CurrentFilename)} {ChecksumAsset.Filename} {PackageAsset.Filename}";
                    updaterProcess.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    updaterProcess.UseShellExecute = true;
                    Process.Start(updaterProcess);

                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                this.ControlBox = true;
                this.noButton.Enabled = true;
                this.yesButton.Enabled = true;
                this.downloadProgress.Value = 0;
                statusLabel.Text = "Status: Idle";

                MessageBox.Show("An error has ocurred while downloading and verifying the update package.\n" +
                               $"{ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FixSpaces(string Text)
        {
            if (Text.Contains(" ")) return $"\"{Text}\"";
            else return Text;
        }
    }
}
