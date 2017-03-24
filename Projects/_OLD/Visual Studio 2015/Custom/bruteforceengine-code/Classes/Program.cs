using System;
using System.IO;
using System.Windows.Forms;

namespace Engine_Brute
{
    static class Program
    {
        //ВСЕМ ЛЕЖАТЬ!111 РАБОТАЮТ ИНДУСЫ!111   
        public static FrmMain MyForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(!File.Exists("xNet.dll"))
            {
                File.WriteAllBytes("xNet.dll", Properties.Resources.xNet);
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MyForm = new FrmMain());
        }
    }
}
