using System;
using System.Windows.Forms;

namespace Engine_Brute
{
    public partial class FrmProxy : Form
    {
        public FrmProxy()
        {
            InitializeComponent();
        }

        private void FrmProxy_Load(object sender, EventArgs e)
        {

            Globals.TypeProxy = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.Proxy.Clear();
                Globals.Proxy.AddRange(Helper.LoadList(Helper.OpenDialog()));
                label3.Text = "Count Proxy: " + Globals.Proxy.Count;
            }
            catch (Exception ex)
            {
                Globals.Proxy.Clear();
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.MyForm.SetLabelTxt(Globals.Proxy.Count, comboBox1.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.Proxy.Clear();
                Globals.Proxy.AddRange(Helper.ParseProxy(textBox1.Text.Trim(), Globals.TypeProxy));
                label3.Text = "Count Proxy: " + Globals.Proxy.Count;
            } 
            catch(Exception ex)
            {
                Globals.Proxy.Clear();
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "HTTP")
            {
                Globals.TypeProxy = 1;
            }else if(comboBox1.Text == "Socks4")
            {
                Globals.TypeProxy = 2;
            }
            else if (comboBox1.Text == "Socks5")
            {
                Globals.TypeProxy = 3;
            }else
            {
                Globals.TypeProxy = 1;
                comboBox1.Text = "HTTP";
            }
        }
    }
}
