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

namespace calcprem2
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

        private void zad1_Click(object sender, RoutedEventArgs e)
        {
            zadanie1 pW = new zadanie1();
            pW.Show();
            this.Close();
        }

        private void zad2_Click(object sender, RoutedEventArgs e)
        {
            zadanie2 pW = new zadanie2();
            pW.Show();
            this.Close();
        }

        private void zad3_Click(object sender, RoutedEventArgs e)
        {
            zadanie3 pW = new zadanie3();
            pW.Show();
            this.Close();
        }

        private void zad4_Click(object sender, RoutedEventArgs e)
        {
            zadanie4 pW = new zadanie4();
            pW.Show();
            this.Close();
        }

        private void butnext_Click(object sender, RoutedEventArgs e)
        {
            zadanie1 pW = new zadanie1();
            pW.Show();
            this.Close();
        }
    }
}
