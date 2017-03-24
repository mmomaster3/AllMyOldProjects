using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NoWeb
{
    class Program
    {
        public class MyClass
        {
            [DebuggerDisplay("Value = {myVariable}")]
            public string myVariable = "mydisplay";
        }

        static void Main(string[] args)
        {
            MyClass _class = new MyClass();
            Console.WriteLine("My Tips On ,{0}C#", Environment.NewLine);
            using (StreamWriter sr = new StreamWriter("text.txt"))
            {
                sr.WriteLine("WTF");
            }
            string s = null;

            s = s ?? "hfht";
        }
    }
}
