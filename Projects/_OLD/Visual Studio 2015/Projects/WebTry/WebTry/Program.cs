using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;

namespace WebTry
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPAddress> List = new List<IPAddress>();
            IPHostEntry host1 = Dns.GetHostEntry("rutor.is");
            Ping ping = new Ping();
            PingReply send;
            Console.WriteLine(host1.HostName);
            foreach (IPAddress ip in host1.AddressList)
            {
                Console.WriteLine(ip.ToString());
                send = ping.Send(ip);
                Console.WriteLine(send.RoundtripTime);
                List.Add(ip);
            }


            Console.WriteLine();

            IPHostEntry host2 = Dns.GetHostEntry("google.com");
            Console.WriteLine(host2.HostName);
            foreach (IPAddress ip in host2.AddressList)
            {
                Console.WriteLine(ip.ToString());
                send = ping.Send(ip);
                Console.WriteLine(send.RoundtripTime);
                List.Add(ip);
            }

            using (StreamWriter sw = new StreamWriter("new.txt"))
            {
                foreach (var item in List)
                {
                    sw.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
