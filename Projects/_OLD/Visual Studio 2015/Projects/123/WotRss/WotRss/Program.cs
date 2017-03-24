using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.Xml;

namespace WotRss
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SyndicationItem> FeedList = new List<SyndicationItem>();
            using (XmlReader xr = XmlReader.Create("http://worldoftanks.ru/ru/rss/news/11/"))
            {
                var formatter = new Rss20FeedFormatter();
                formatter.ReadFrom(xr);
                FeedList.AddRange(formatter.Feed.Items);
            }

            foreach (var item in FeedList)
            {
                Console.WriteLine("Заголовок");
                Console.WriteLine(item.Title.Text);
                Console.WriteLine(item.Summary.Text);
                Console.ReadLine();
            }

            //var request = (HttpWebRequest)WebRequest.Create("http://worldoftanks.ru/ru/rss/news/11/");
            //var response = (HttpWebResponse)request.GetResponse();
            //var responseStirng = new StreamReader(response.GetResponseStream()).ReadToEnd();
            //List<string> RssList = new List<string>();
            //var itemRequest = (from n in responseStirng
            //                  .Skip(responseStirng.IndexOf("<item>"))
            //                  .Take(responseStirng.IndexOf("</item>"))
            //                  select n);

            //Console.WriteLine(itemRequest);
            //RssList.Add(itemRequest);

            //foreach (var item in RssList)
            //{
            //    Console.Write(item);
            //}

            Console.ReadLine();
        }
    }
}
