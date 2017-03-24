using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace _try
{
    class Program
    {
        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);

        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int OpenFileDialog(IntPtr h, string m);

        [STAThread]
        static int Main()
        {
            string myString;
            OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {

            }

            Console.Write("Enter your message: ");
            myString = Console.ReadLine();
            return MessageBox((IntPtr)0, myString, "My Message Box", 0);
        }
    }
}
