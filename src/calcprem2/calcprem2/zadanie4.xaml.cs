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
    /// Логика взаимодействия для zadanie4.xaml
    /// </summary>
    public partial class zadanie4 : Window
    {
        public zadanie4()
        {
            InitializeComponent();
        }

        private void butprev_Click(object sender, RoutedEventArgs e)
        {
            zadanie3 pW = new zadanie3();
            pW.Show();
            this.Close();
        }

        private void main_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pW = new MainWindow();
            pW.Show();
            this.Close();
        }

        private void god_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void kopeyka_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(god.Text);
            double b = Convert.ToDouble(kopeyka.Text);
            if (a < 5)
            {
                result.Content = b * (10.0 / 100) + "р";
            }
            else if (a >= 5 && a < 10)
            {
                result.Content = b * (15.0 / 100) + "р";
            }
            else if (a >= 10 && a < 15)
            {
                result.Content = b * (25.0 / 100) + "р";
            }
            else if (a >= 15 && a < 20)
            {
                result.Content = b * (35.0 / 100) + "р";
            }
            else if (a >= 20 && a < 25)
            {
                result.Content = b * (45.0 / 100) + "р";
            }
            else if (a >= 25)
            {
                result.Content = b * (50.0 / 100) + "р";
            }
        }
    }
}
