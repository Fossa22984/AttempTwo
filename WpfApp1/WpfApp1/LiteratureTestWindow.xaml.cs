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
    /// Interaction logic for LiteratureTestWindow.xaml
    /// </summary>
    public partial class LiteratureTestWindow : Window
    {
        public LiteratureTestWindow()
        {
            InitializeComponent();
        }

        private void AnswereButton_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            if (AnswerRight1.IsChecked == true) i++;
            if (AnswerRight2.IsChecked == true) i++;
            if (AnswerRight3.IsChecked == true) i++;
            if (AnswerRight4.IsChecked == true) i++;
            if (AnswerRight5.IsChecked == true) i++;
            if (AnswerRight6.IsChecked == true) i++;
            MessageBox.Show($"Ваш балл: {i * 2} (2 балла за правильный ответ)");
        }
    }
}
