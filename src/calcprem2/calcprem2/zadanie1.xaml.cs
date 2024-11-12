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

namespace calcprem2
{
    /// <summary>
    /// Логика взаимодействия для zadanie1.xaml
    /// </summary>
    public partial class zadanie1 : Window
    {
        public zadanie1()
        {
            InitializeComponent();
        }

        private void butprev_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pW = new MainWindow();
            pW.Show();
            this.Close();
        }

        private void butnext_Click(object sender, RoutedEventArgs e)
        {
            zadanie2 pW = new zadanie2();
            pW.Show();
            this.Close();
        }

        private void number1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void number2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void butminus_Click(object sender, RoutedEventArgs e)
        {
            int a;
            a = Convert.ToInt32(number1.Text);
            int b;
            b = Convert.ToInt32(number2.Text);
            if (a < b)
            {
                butminus.Background = Brushes.Green;
                butplus.Background = Brushes.Gray;
                result.Background = Brushes.Green;
                int n = 0;
                for (int i = a + 1; i < b; i++)
                {
                    n += i;
                }
                result.Content = n;
            }
            else
            {
                result.Content = "a !< b";
                result.Background = Brushes.Gray;
            }
        }

        private void butplus_Click(object sender, RoutedEventArgs e)
        {
            result.Content = string.Empty;
            int a;
            a = Convert.ToInt32(number1.Text);
            int b;
            b = Convert.ToInt32(number2.Text);
            if (a < b)
            {
                butplus.Background = Brushes.Green;
                butminus.Background = Brushes.Gray;
                result.Background = Brushes.Green;
                for (int i = a; i < b; i++)
                {
                    if (i % 2 != 0)
                    {
                        string c = Convert.ToString(i);
                        result.Content += " " + c;
                    }
                }
            }
            else
            {
                result.Content = "a !< b";
                result.Background = Brushes.Gray;
            }
        }
    }
}
