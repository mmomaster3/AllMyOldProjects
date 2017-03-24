using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace HiWebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            const string urlStr = "http://kbp.by";

            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozila/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            Stream data = client.OpenRead(urlStr);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            data.Close();
            reader.Close();
            s.Replace("<title>Колледж бизнеса и права</title>", "<title>FZAZAZAZAZZAZAZAZ</title>");
            using (var sw = new StreamWriter("123.html"))
            {
                sw.WriteLine(s);
            }
            Console.ReadKey(true);
        }
    }
}
