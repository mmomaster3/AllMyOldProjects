﻿using System;
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
    /// Логика взаимодействия для Video.xaml
    /// </summary>
    public partial class Video : Window
    {
        public Video()
        {
            InitializeComponent();
            

            mediaElement.Play();
        }

        private void button_prev_Click(object sender, RoutedEventArgs e)
        {
            Close();
            new MainWindow().Show();
        }
    }
}
