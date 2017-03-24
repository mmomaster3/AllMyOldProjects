using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void AboutImage_Click(object sender, System.EventArgs e)
        {
            Process.Start("http://extrime-code.ru/");
            Process.Start("http://brutezone.ru/");
        }

        private void AboutImage_Load(object sender, System.EventArgs e)
        {
            AboutImage.Size = AboutImage.Image.Size;
            this.Size = AboutImage.Image.Size;
            this.Size = new Size(this.Size.Width + 5, this.Size.Height + 15);
        }

        private void FrmAbout_Load(object sender, System.EventArgs e)
        {
            var rand = new Random();
            AboutImage.ImageLocation = "http://extrime-code.ru/gif/" + rand.Next(1, 17) + ".gif";
        }

        private void AboutImage_Load(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {

        }
}
