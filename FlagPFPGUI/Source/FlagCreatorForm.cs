using FlagPFPCore.Loading;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace FlagPFPGUI
{
    public partial class FlagCreatorForm : Form
    {
        private MainForm Instance;

        public FlagCreatorForm(MainForm MainInstance)
        {
            InitializeComponent();

            Instance = MainInstance;
        }

        private void BrowseButton_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog FileDialog = new OpenFileDialog())
            {
                FileDialog.InitialDirectory = "c:\\";
                FileDialog.Filter = "All Supported Files (*.png, *.jpeg, *.jpg)|*.png;*.jpg;*.jpeg|PNG files (*.png)|*.png|JPEG files (*.jpeg, *.jpg)|*.jpeg;*.jpg";

                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileTextbox.Text = FileDialog.FileName;
                }
            }
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void CreateButton_Click(object sender, System.EventArgs e)
        {
            if (!CheckFileBox()) return;
            if (!CheckFileBoxExtension()) return;
            if (!CheckFlagNameBox()) return;

            try
            {
                string TargetPath = Path.GetFullPath(Instance.FlagMaker.FlagImageDirectory);
                //User may have placed a relative path without the browse button, fix that.
                string SourceFile = Path.GetFullPath(FileTextbox.Text);
                string SourceFileFilename = Path.GetFileName(SourceFile);

                string FinalImagePath = Path.Combine(TargetPath, SourceFileFilename);

                if (File.Exists(FinalImagePath))
                {
                    DialogResult Result = MessageBox.Show($"File \"{SourceFileFilename}\" already exists in flag image directory. It will be overwritten.",
                        "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (Result == DialogResult.Cancel) return;
                }

                //Move flag image to flags image dir.
                File.Copy(SourceFile, FinalImagePath, true);

                string ImageFilename = Path.GetFileName(SourceFile);
                PrideFlag NewFlag = new PrideFlag
                {
                    FlagFile = ImageFilename,
                    ParameterName = NameTextbox.Text
                };

                string JsonContent = JsonConvert.SerializeObject(NewFlag, Formatting.Indented);

                File.WriteAllText(Path.Combine(Instance.FlagMaker.FlagJsonsDirectory, SanitizeFilename(NameTextbox.Text) + ".json"), JsonContent);

                Instance.LoadFlags();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating flag! Exception:\n" + ex.Message, "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show($"Successfully created flag \"{NameTextbox.Text}\"!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string SanitizeFilename(string Filename)
        {
            foreach (char InvalidChar in Path.GetInvalidFileNameChars())
            {
                Filename = Filename.Replace(InvalidChar, '_');
            }

            return Filename;
        }

        private bool CheckFileBox()
        {
            if (FileTextbox.Text == string.Empty || !File.Exists(FileTextbox.Text))
            {
                MessageBox.Show("Flag image file must be a valid image file!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private bool CheckFlagNameBox()
        {
            if (NameTextbox.Text == string.Empty)
            {
                MessageBox.Show("Flag image file must be a valid image file!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private bool CheckFileBoxExtension()
        {
            string Extension = Path.GetExtension(FileTextbox.Text);

            if (Extension != ".png" && Extension != ".jpg" && Extension != ".jpeg")
            {
                MessageBox.Show("Flag image file must be a PNG or JPEG file!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }
    }
}
