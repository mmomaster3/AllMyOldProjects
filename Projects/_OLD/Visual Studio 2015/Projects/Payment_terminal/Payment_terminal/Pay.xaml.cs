using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

using System.IO;
using System.Diagnostics;

namespace Payment_terminal
{
    /// <summary>
    /// Логика взаимодействия для Pay.xaml
    /// </summary>
    public partial class Pay : Window
    {
        Services SerivcesForm;
        string operatorsButton;

        public Pay(Services SerivcesForm)
        {
            InitializeComponent();
            focuserdTB = textBox_number;
            this.SerivcesForm = SerivcesForm;
        }

        public Pay(string operatorsButton)
        {
            InitializeComponent();

            this.operatorsButton = operatorsButton;
            focuserdTB = textBox_number;
            if (operatorsButton == "buttonJEKX")
            {
                label_namePay.Content = "Номер ЛС:";
                textBox_375.Text = "";
                comboBox_Cod.Items.Clear();
                textBox_375.IsEnabled = false;
                comboBox_Cod.IsEnabled = false;
                textBox_number.Margin = new Thickness(392, 154, 3, 0);
            }

            if (operatorsButton == "buttonCosmosTV")
            {
                label_namePay.Content = "Номер договора:";
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/res/cosmostv-logo.png"));
                textBox_375.Text = "";
                comboBox_Cod.Items.Clear();
                textBox_375.IsEnabled = false;
                comboBox_Cod.IsEnabled = false;
                textBox_number.Margin = new Thickness(392, 154, 3, 0);
            }
            if (operatorsButton == "buttonTricolor")
            {
                label_namePay.Content = "Номер договора:";
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/res/cosmostv-logo.png"));
                textBox_375.Text = "";
                comboBox_Cod.Items.Clear();
                textBox_375.IsEnabled = false;
                comboBox_Cod.IsEnabled = false;
                textBox_number.Margin = new Thickness(392, 154, 3, 0);
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/res/Триколор_ТВ.png"));
            }
            if (operatorsButton == "buttonByFly")
            {
                label_namePay.Content = "Номер договора:";
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/res/cosmostv-logo.png"));
                textBox_375.Text = "";
                comboBox_Cod.Items.Clear();
                textBox_375.IsEnabled = false;
                comboBox_Cod.IsEnabled = false;
                textBox_number.Margin = new Thickness(392, 154, 3, 0);
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/res/byfly_isp.gif"));
            }
            if (operatorsButton == "buttonatlant")
            {
                label_namePay.Content = "Номер договора:";
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/res/cosmostv-logo.png"));
                textBox_375.Text = "";
                comboBox_Cod.Items.Clear();
                textBox_375.IsEnabled = false;
                comboBox_Cod.IsEnabled = false;
                textBox_number.Margin = new Thickness(392, 154, 3, 0);
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/res/atl.jpg"));
            }

            if (operatorsButton == "buttonMTS")
            {
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/res/MTSlogo.jpg"));
                comboBox_Cod.Items.Clear();
                comboBox_Cod.Items.Add("29");
                comboBox_Cod.Items.Add("33");
            }
            if (operatorsButton == "buttonVelcom")
            {
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/res/velcom_logo_main_color.png"));
                comboBox_Cod.Items.Clear();
                comboBox_Cod.Items.Add("29");
                comboBox_Cod.Items.Add("44");
            }
            if (operatorsButton == "buttonLife")
            {
                image.Source = new BitmapImage(new Uri(@"pack://application:,,,/res/image.png"));
                comboBox_Cod.Items.Clear();
                comboBox_Cod.Items.Add("35");
            }
            comboBox_Cod.SelectedIndex = 0;

        }

        private void button_prev_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new MainWindow().Show();

        }
        // number
        private void button_number_Click(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(textBox_number.Text, @"[0-9]{7}"))
                return;
            textBox_number.Text += ((Button)sender).Content.ToString();
        }


        TextBox focuserdTB = null;
        private void focusOnTextBox(object sender, RoutedEventArgs e)
        {
            focuserdTB = (TextBox)sender;
        }
        //back space
        private void button_backspase_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_number.Text.Length > 0)
                textBox_number.Text = textBox_number.Text.Substring(0, textBox_number.Text.Length - 1);
        }

        List<string> kvp;
        string diskName = string.Empty;
        private void UsbDiskList()
        {
            kvp = new List<string>();
            //предварительно очищаем список
            comboBoxFlash.Items.Clear();

            //Получение списка накопителей подключенных через интерфейс USB
            foreach (System.Management.ManagementObject drive in
                      new System.Management.ManagementObjectSearcher(
                       "select * from Win32_DiskDrive where InterfaceType='USB'").Get())
            {
                //Получаем букву накопителя
                foreach (System.Management.ManagementObject partition in
                   new System.Management.ManagementObjectSearcher(
                    "ASSOCIATORS OF {Win32_DiskDrive.DeviceID='" + drive["DeviceID"]
                      + "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition").Get())
                {
                    foreach (System.Management.ManagementObject disk in
                       new System.Management.ManagementObjectSearcher(
                        "ASSOCIATORS OF {Win32_DiskPartition.DeviceID='"
                          + partition["DeviceID"]
                          + "'} WHERE AssocClass = Win32_LogicalDiskToPartition").Get())
                    {
                        //Получение буквы устройства
                        diskName = disk["Name"].ToString().Trim();
                        comboBoxFlash.Items.Add(diskName + " (" + drive["Model"] + ")");
                        kvp.Add(diskName);
                    }
                }
            }
        }
        //oplata
        private void button_next_Click(object sender, RoutedEventArgs e)
        {
            string pocket = "";
            int precent = 3;

            if (textBox_number.Text.Length != 7)
            {
                MessageBox.Show("Введите 7-ми значный номер");
                return;
            }


            if (!string.IsNullOrEmpty(diskName))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(diskName + "\\123456.txt"))
                    {
                        pocket = sr.ReadLine();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Вставте банковсткую карточку!");
                    return;
                }

                if (balance > 1 && balance < 4999)
                {
                    precent = 9;
                }
                if (balance >= 5000 && balance <= 50000)
                {
                    precent = 8;
                }
                if (balance >= 50001 && balance <= 250000)
                {
                    precent = 7;
                }
                if (balance >= 250001 && balance <= 400000)
                {
                    precent = 6;
                }
                if (balance >= 400001 && balance <= 600000)
                {
                    precent = 5;
                }
                if (balance >= 600001 && balance <= 750000)
                {
                    precent = 4;
                }
                if (int.Parse(pocket) < (balance + (balance / 100 * precent)))
                {
                    MessageBox.Show("Недостаточно средств");
                    return;
                }
                new LastName(balance, pocket, precent, diskName, textBox_375.Text + comboBox_Cod.Text + textBox_number.Text).Show();

            }
        }

        int balance = 0;
        int limit = 0;
        private void buttonRefresh_Click(object sender, RoutedEventArgs e)
        {

            //Загрузка букв USB накопителей при запуске программы
            UsbDiskList();
            //Выбор первого устройства в списке
            comboBoxFlash.SelectedIndex = 0;
            if (!string.IsNullOrEmpty(diskName))
                try
                {
                    using (StreamReader sr = new StreamReader(diskName + "\\123456.txt"))
                    {
                        balance = int.Parse(sr.ReadLine());
                        limit = balance;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Вставте банковсткую карточку!");
                    return;
                }
            BalansRubLabel.Content = balance;
            if (!comboBoxFlash.Items.IsEmpty)
            {
                slider.IsEnabled = true;
                slider.Maximum = limit;
                slider.Minimum = 0;

            }
            slider.Value = slider.Maximum;

        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BalansRubLabel.Content = Math.Round(slider.Value);
            balance = (int)Math.Round(slider.Value);

            if (slider.Value > 100)
            {
                if (!slider2.IsEnabled)
                    slider2.IsEnabled = true;
                slider2.Maximum = slider.Value + 100;
                slider2.Minimum = slider.Value - 100;
                slider2.Value = 0;
            }
        }

        private void comboBoxFlash_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        //value change
        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BalansRubLabel.Content = Math.Round(slider2.Value);
            balance = (int)Math.Round(slider2.Value);
        }
    }
}
