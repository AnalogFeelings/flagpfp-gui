using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DLH
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            githubLink.LinkVisited = true;

            Process.Start("https://github.com/AestheticalZ/flagpfp-gui");
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
