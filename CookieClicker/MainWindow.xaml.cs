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
using System.Threading;

namespace CookieClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int c = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Clicker();
        }

        private void AutoClick()
        {
            
        }

        private void Clicker()
        {
            if (c < 50)
            {
                c = c + 1;
                AutoClick();
            }
            else if (c < 100)
            {
                c = c + 2;
                label2.Content = "x2";
            }
            else if (c < 500)
            {
                c = c + 5;
                label2.Content = "x3";
                label3.Content = "Keep going!";
            }
            else if (c < 1000)
            {
                c = c + 10;
                label2.Content = "x4";
            }
            else if (c < 3000)
            {
                c = c + 20;
                label2.Content = "x5";
                label3.Content = "You're doing great!";
            }
            else if (c < 7000)
            {
                c = c + 50;
                label2.Content = "x10";
                label3.Content = "AAAAAAAAAAAA";
                grid.Background = Brushes.Black;
                button1.Background = Brushes.Red;
                label1.Background = Brushes.Red;
                label2.Background = Brushes.Red;

            }

            label1.Content = c;
        }

    }
}
