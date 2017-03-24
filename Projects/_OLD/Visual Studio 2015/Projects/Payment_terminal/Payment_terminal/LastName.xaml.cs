using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Word = Microsoft.Office.Interop.Word;
using System.Diagnostics;

namespace Payment_terminal
{
    /// <summary>
    /// Логика взаимодействия для LastName.xaml
    /// </summary>
    public partial class LastName : Window
    {
        int balance;
        string pocket;
        int precent;
        string diskName;
        string name;
        string number;

        public LastName(int balance, string pocket, int precent, string diskName, string number)
        {
            InitializeComponent();

            this.precent = precent;
            this.balance = balance;
            BalansRubLabel.Content = balance.ToString();
            this.pocket = pocket;
            this.diskName = diskName;
            this.number = number;
            label_number.Content += " " + number;
        }

        private void button_prev_Click(object sender, RoutedEventArgs e)
        {
            Close();
            new MainWindow().Show();
        }

        private void button_letter_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(textBox_FIO.Text, @"[А-Я]{50}"))
                return;
            textBox_FIO.Text += ((Button)sender).Content.ToString();
        }
        //button oplata
        private void button_next_Click(object sender, RoutedEventArgs e)
        {
            int com = 0;
            int summa = 0;
            int result = 0;
            DateTime date = DateTime.Now;
            if (BalansRubLabel.Content.ToString() == "0")
            {
                MessageBox.Show("Пожалуйста, пополните баланс!");
                return;
            }
            using (StreamReader sr = new StreamReader(diskName + "\\123456.txt", System.Text.Encoding.Default))
            {
                sr.ReadLine();
                name = sr.ReadLine();
            }
            if (name.ToUpper() == textBox_FIO.Text.ToUpper())
            {
                using (StreamWriter sw = new StreamWriter(diskName + "\\123456.txt", false, System.Text.Encoding.Default))
                {
                    com = (balance + (balance / 100 * precent));
                    summa = int.Parse(pocket);
                    result = summa - com;
                    sw.WriteLine(summa - com);
                    sw.WriteLine(name);
                }
            }
            else
            {
                MessageBox.Show("Ошибка в фамилии!");
                return;
            }
            //word
            var wordapp = new Word.Application();
            wordapp.Visible = false;
            try
            {
                string path = Directory.GetCurrentDirectory();
                var wordDocument = wordapp.Documents.Open(path + "\\tamplate.docx");
                ReplaceWordStub("{date}", date.ToString(), wordDocument);
                ReplaceWordStub("{number}", number.ToString(), wordDocument);
                ReplaceWordStub("{name}", name, wordDocument);
                ReplaceWordStub("{summa}", summa.ToString(), wordDocument);
                ReplaceWordStub("{com}", com.ToString(), wordDocument);
                ReplaceWordStub("{result}", result.ToString(), wordDocument);
                string resultFileName = path + "\\" + name + " " + date.Date.ToShortDateString() + ".docx";
                wordDocument.SaveAs2(FileName: resultFileName);
                wordDocument.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:" + ex);
                return;
            }
            finally
            {
                wordapp.Quit();
            }
            MessageBox.Show("Оплачено!");
            button_prev_Click(sender, e);
        }
        //word replace
        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
        // delete button
        private void button_backspase_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_FIO.Text.Length > 0)
                textBox_FIO.Text = textBox_FIO.Text.Substring(0, textBox_FIO.Text.Length - 1);
        }
    }
}
