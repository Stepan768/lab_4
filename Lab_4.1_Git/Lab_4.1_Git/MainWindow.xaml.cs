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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_4._1_Git
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            string a = first.Text;
            string b = second.Text;
            int a1 = int.Parse(a);
            int b1 = int.Parse(b);
            int c = a1 * b1;
            int c1 = Convert.ToInt32(c);
            equality.Content = c1;
        }
    }
}
