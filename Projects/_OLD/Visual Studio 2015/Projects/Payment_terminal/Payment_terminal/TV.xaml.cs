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
    /// Логика взаимодействия для TV.xaml
    /// </summary>
    public partial class TV : Window
    {
        public TV()
        {
            InitializeComponent();
        }

        private void button_prev_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TVButton_Click(object sender, RoutedEventArgs e)
        {
            new Pay(((Button)sender as Button).Name).Show();
            this.Hide();
        }
    }
}
