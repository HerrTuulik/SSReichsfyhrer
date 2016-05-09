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

namespace Kalkulaator1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Kaatet1.Visibility = Visibility.Hidden;
            Kaatet2.Visibility = Visibility.Hidden;
            Hypotenuus.Visibility = Visibility.Hidden;
            Raadius.Visibility = Visibility.Hidden;
            Laius.Visibility = Visibility.Hidden;
            Pikkus.Visibility = Visibility.Hidden;
            SisestageAndmed.Visibility = Visibility.Hidden;
            Pikkus1.Visibility = Visibility.Hidden;
            Laius1.Visibility = Visibility.Hidden;
            Hypotenuus1.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pikkus.Visibility = Visibility.Visible;
            Pikkus1.Visibility = Visibility.Visible;
            Laius.Visibility = Visibility.Visible;
            Laius1.Visibility = Visibility.Visible;
        }

    }
}
