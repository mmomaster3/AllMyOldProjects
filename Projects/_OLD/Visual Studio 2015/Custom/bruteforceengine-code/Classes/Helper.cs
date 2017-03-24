using System;
using System.IO;
using System.Media;
using System.Collections;
using System.Windows.Forms;

using xNet.Net;

namespace Engine_Brute
{
    public static class Helper
    {
        public static string RawStatisitc()
        {
            string raw = "";

            raw += "Source: " + Globals.Source.Count.ToString() + Environment.NewLine;
            raw += "Proxy: " + Globals.Proxy.Count.ToString() + Environment.NewLine;
            raw += "Good: " + Globals.CountGood.ToString() + Environment.NewLine;
            raw += "Bad: " + Globals.CountBad.ToString() + Environment.NewLine;
            raw += "PPS: " + Globals.Pps.ToString() + Environment.NewLine;
            raw += "Left: " + (Globals.Source.Count - (Globals.CountGood + Globals.CountBad)).ToString();

            return raw;
        }
    

        /*
         * Сохранение строки в файл  
        */ 
        public static void SaveText(string file, string text)
        {
            try
            {
                var write = new StreamWriter(file, true);
                write.WriteLine(text);
                write.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /*
         * Диалог открытия файла
         * 
         */ 
        public static string OpenDialog()
        {
            var opd = new OpenFileDialog();
            opd.Filter = "*.txt | *.txt";
            opd.ShowDialog();
            return opd.FileName;
        }


        /*
         * Загрузка файла массив
        */ 
        public static object[] LoadList(string filename)
        {
            ArrayList raw = new ArrayList();
            raw.AddRange(File.ReadAllLines(filename));
            return raw.ToArray();
        }
        
        //
        public static void PlaySound()
        {
            try
            {
                new SoundPlayer("good.wav").Play();
            }
            catch
            {
                Console.Beep();
            }
        }

        /*
         * Возвращает проксю из списка
         * с указанным прокси клиентом
         * 
        */
        public static ProxyClient GetProxy(int index)
        {
            switch (Globals.TypeProxy)
            {
                case 1:
                    return ProxyClient.Parse(ProxyType.Http, Globals.Proxy[index].ToString());
                case 2:
                    return ProxyClient.Parse(ProxyType.Socks4, Globals.Proxy[index].ToString());
                case 3:
                    return ProxyClient.Parse(ProxyType.Socks5, Globals.Proxy[index].ToString());
                default:
                    return ProxyClient.Parse(ProxyType.Http, Globals.Proxy[index].ToString());
            }
        }

        public static string[] ParseProxy(string PremiumKey, int ProxyType)
        {
            try
            {
                string ParseRezult = "";
                string type = "";

                HttpRequest req = new HttpRequest();
                req.Cookies = new CookieDictionary();
                string chek = req.Post("http://hideme.ru/login", "c=" + PremiumKey).ToString();

                if (!chek.Contains("До конца действия:"))
                {
                    throw new Exception("Bad Key");
                }

                if (ProxyType == 1)
                {
                    type = "h";
                }
                if (ProxyType == 2)
                {
                    type = "4";
                }
                if (ProxyType == 3)
                {
                    type = "5";
                }

                ParseRezult = req.Get("https://hideme.ru/api/proxylist.txt?type=" + type + "&out=plain&lang=ru").ToString();
                string[] proxyArray = ParseRezult.Split('\n');

                return proxyArray;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }

}