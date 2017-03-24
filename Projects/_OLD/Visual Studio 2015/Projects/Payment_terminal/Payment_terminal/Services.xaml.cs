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

namespace Payment_terminal
{
    /// <summary>
    /// Логика взаимодействия для Services.xaml
    /// </summary>
    public partial class Services : Window
    {
        Window main_window2;

        public Services(MainWindow main_window)
        {
            InitializeComponent();
            main_window2 = main_window;

            main_window.Hide();
        }

        private void button_prev_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new MainWindow().Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            main_window2.Show();
            Close();
        }

        private void button_TV_Click(object sender, RoutedEventArgs e)
        {

        }


        private void MobiButton_Click(object sender, RoutedEventArgs e)
        {
            //new Pay(this).Show();
            Close();
            new Operators().Show();
            
        }

        private void buttonMTS_Click(object sender, RoutedEventArgs e)
        {
            new Pay("buttonMTS").Show();
            this.Hide();
        }

        private void buttonVelcom_Click(object sender, RoutedEventArgs e)
        {
            new Pay("buttonVelcom").Show();
            this.Hide();
        }

        private void ButtonInternet_Click(object sender, RoutedEventArgs e)
        {
            Close();
            new Providers().Show();
            
        }

        private void buttonTV_Click(object sender, RoutedEventArgs e)
        {
            Close();
            new TV().Show();
            
        }

        private void buttonJEKX_Click(object sender, RoutedEventArgs e)
        {
            Close();
            new Pay(((Button)sender as Button).Name).Show();
        }
        private MediaPlayer player = new MediaPlayer();
        private void ImgAds_MouseDown(object sender, MouseButtonEventArgs e)
        {
            player.Open(new Uri(@"/res/chilldren.mp3", UriKind.Relative));
            player.Play();
            MessageBox.Show("Вы помогли детям!");          
        }
    }
}
