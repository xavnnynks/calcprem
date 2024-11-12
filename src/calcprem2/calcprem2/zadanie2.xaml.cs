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
    /// Логика взаимодействия для zadanie2.xaml
    /// </summary>
    public partial class zadanie2 : Window
    {
        public zadanie2()
        {
            InitializeComponent();
        }

        private void butprev_Click(object sender, RoutedEventArgs e)
        {
            zadanie1 pW = new zadanie1();
            pW.Show();
            this.Close();
        }

        private void butnext_Click(object sender, RoutedEventArgs e)
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

        private void butkv_Click(object sender, RoutedEventArgs e)
        {
            result2.Content = string.Empty;
            for (int i = 10; i > 9 & i < 21; i++)
            {
                result2.Content += " " + (i * i);
            }
        }
    }
}
