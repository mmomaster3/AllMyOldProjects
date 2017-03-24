using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Async2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var timer = Stopwatch.StartNew();
            textBox1.Text = new string('a', 399991);
            timer.Stop();

            textBox1.Text += timer.ElapsedMilliseconds.ToString();
            Console.ReadLine();
        }
    }
}
