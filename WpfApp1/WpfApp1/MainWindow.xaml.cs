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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Csharp_Click(object sender, RoutedEventArgs e)
        {
            Fossa22984WindowTest fossa22984 = new Fossa22984WindowTest();
            fossa22984.Show();
        }

        private void Literat_Click(object sender, RoutedEventArgs e)
        {
            LiteratureTestWindow literature = new LiteratureTestWindow();
            literature.Show();
        }

        private void footBall_Click(object sender, RoutedEventArgs e)
        {
            FootballTest football = new FootballTest();
            football.Show();
        }
    }
}
