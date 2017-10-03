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
            if(c < 50)
            {
                c = c + 1;
            } else if(c < 100)
            {
                c = c + 2;
                label2.Content = "x2";
            } else if(c < 500) {
                c = c + 3;
                label2.Content = "x3";
                label3.Content = "Keep going!";
            } else if(c < 1000)
            {
                c = c + 4;
                label2.Content = "x4";
            } else if(c < 2000) {
                c = c + 5;
                label2.Content = "x5";
            } else if(c < 4000)
            {
                c = c + 6;
                label2.Content = "x6";
            }

            label1.Content = c;
        }
    }
}
