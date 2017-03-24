using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDZ
{
    public partial class Form1 : Form
    {
        static int x = 50;
        static int y = 60;
        static int width = 500;
        static int heigth = 500;

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = CreateGraphics();

            Pen EllipsePen = new Pen(Color.Black, 1);
            formGraphics.DrawEllipse(EllipsePen, x, y, width, heigth);
            Pen LinePen = new Pen(Color.Blue, 1);
            formGraphics.DrawLine(LinePen, x + width/2, y + heigth/2, width +x/2, heigth + y/2);
        }
    }
}
