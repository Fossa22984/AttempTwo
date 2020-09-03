using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for FootballTest.xaml
    /// </summary>
    public partial class FootballTest : Window
    {
        public FootballTest()
        {
            InitializeComponent();
        }

        private void finishtestButton_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            if (answer1.IsChecked == true) i++;
            if (answer2.IsChecked == true) i++;
            if (answer3.IsChecked == true) i++;
            if (answer4.IsChecked == true) i++;
            if (answer5.IsChecked == true) i++;
            if (answer6.IsChecked == true) i++;
            MessageBox.Show($"Ваш балл: {i * 2} (2 балла за правильный ответ)");
        }
    }
}
