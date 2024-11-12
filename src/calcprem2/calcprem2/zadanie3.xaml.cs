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
    /// Логика взаимодействия для zadanie3.xaml
    /// </summary>
    public partial class zadanie3 : Window
    {
        public zadanie3()
        {
            InitializeComponent();
        }

        private void butprev_Click(object sender, RoutedEventArgs e)
        {
            zadanie2 pW = new zadanie2();
            pW.Show();
            this.Close();
        }

        private void main_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pW = new MainWindow();
            pW.Show();
            this.Close();
        }

        private void butnext_Click(object sender, RoutedEventArgs e)
        {
            zadanie4 pW = new zadanie4();
            pW.Show();
            this.Close();
        }

        private void number3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void butn_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(number3.Text);
            int b = 0;
            for (int i = 0; i < a + 1; i++)
            {
                b += i;
            }
            result3.Content = b;
        }
    }
}
