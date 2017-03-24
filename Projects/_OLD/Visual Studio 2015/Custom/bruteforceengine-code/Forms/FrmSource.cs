using System;
using System.Collections;
using System.Windows.Forms;

namespace Engine_Brute.Forms
{
    public partial class FrmSource : Form
    {
        public FrmSource()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.Source.Clear();
                Globals.Source.AddRange(Helper.LoadList(Helper.OpenDialog()));

                Program.MyForm.SetSourceTxt(Globals.Source.Count.ToString());
            }
            catch
            {
                Globals.Source.Clear();
                Program.MyForm.SetSourceTxt(Globals.Source.Count.ToString());
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList logins = new ArrayList();
                ArrayList passwords = new ArrayList();

                logins.AddRange(Helper.LoadList(Helper.OpenDialog()));
                passwords.AddRange(Helper.LoadList(Helper.OpenDialog()));

                for (int i = 0; i < logins.Count ; i++)
                {
                    for (int j = 0; j < passwords.Count ; j++)
                    {
                        Globals.Source.Add(logins[i] + Globals.Delimiter + passwords[j]);
                    }
                }


                MessageBox.Show("Done! Generated: " + Globals.Source.Count);
                Program.MyForm.SetSourceTxt(Globals.Source.Count.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();

        }
    }
}
