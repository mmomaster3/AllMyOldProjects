using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace download
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"D:\$\input.txt", System.Text.Encoding.Default))
            using (var sw = new StreamWriter(@"D:\$\output.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string s = sr.ReadLine();
                    sw.WriteLine(s + " " + "--no-check-certificate");
                }
            }
        }
    }
}

