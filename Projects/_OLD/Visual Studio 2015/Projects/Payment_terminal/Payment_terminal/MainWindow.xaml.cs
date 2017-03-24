using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Payment_terminal
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            label_time.Content = DateTime.Now.TimeOfDay.ToString(@"hh\:mm");
            label_data.Content = DateTime.Now.ToString(@"dd MMMM yyyy");

            timer.Interval = TimeSpan.FromSeconds(10);
            

            timer.Tick += Timer_Tick;
            timer.Start();
                      
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label_time.Content = DateTime.Now.TimeOfDay.ToString(@"hh\:mm");
            label_data.Content = DateTime.Now.ToString(@"dd MMMM yyyy");
            expander_ads.IsExpanded = false ? false: true;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            new Services(this).Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void help_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"Help.chm");
        }

        private void info_button_Click(object sender, RoutedEventArgs e)
        {
            //new Video().Show();
            System.Diagnostics.Process.Start(@"D:\ONEKID\Documents\Visual Studio 2015\Projects\Payment_terminal\Payment_terminal\res\Video_2016-06-20_074240.wmv");
        }
    }
}
