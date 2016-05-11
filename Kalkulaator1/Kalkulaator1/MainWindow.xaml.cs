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
    /// 

    public partial class MainWindow : Window
    {
        public string RistkülikuPindala(double pikkus, double laius)
        {
            return pikkus * laius + " cm²";
        }
        public string RistkülikuÜmbermõõt(double pikkus, double laius)
        {
            return 2 * (pikkus + laius) + " cm";
        }

        // Ruut
        public string RuuduPindala(double pikkus)
        {
            return Math.Pow(pikkus, 2) + " cm²";
        }
        public string RuuduÜmbermõõt(double pikkus)
        {
            return 4 * pikkus +  "cm";
        }

        // Kolmnurk
        public string KolmnurgaPindala(double alus, double kõrgus)
        {
            return (alus * kõrgus) / 2 + " cm²";
        }
        public string KolmnurgaÜmbermõõt(double kaatet1, double kaatet2, double hüpotenuus)
        {
            return kaatet1 + kaatet2 + hüpotenuus + " cm";
        } 

        // Ring
        public string RingiPindala(double raadius)
        {

            return Math.Round(Math.PI * Math.Pow(raadius, 2), 2) + " cm²";
        }
        public string RingjoonePikkus(double raadius)
        {
            return Math.Round(2 * Math.PI * raadius, 2) + " cm";
        }
        public void resetAll()
        {
            Kaatet1.Visibility = Visibility.Hidden;
            Kaatet2.Visibility = Visibility.Hidden;
            Hypotenuus.Visibility = Visibility.Hidden;
            Raadius.Visibility = Visibility.Hidden;
            Laius.Visibility = Visibility.Hidden;
            Pikkus.Visibility = Visibility.Hidden;
            SisestageAndmed.Visibility = Visibility.Hidden;
            Andmed1.Visibility = Visibility.Hidden;
            Andmed2.Visibility = Visibility.Hidden;
            Andmed3.Visibility = Visibility.Hidden;
            PindalaLabel.Visibility = Visibility.Hidden;
            YmbermootLabel.Visibility = Visibility.Hidden;
            Pindala.Visibility = Visibility.Hidden;
            Ymbermoot.Visibility = Visibility.Hidden;
            ArvutaRistkylik.Visibility = Visibility.Hidden;
            ArvutaKolmnurk.Visibility = Visibility.Hidden;
            ArvutaRing.Visibility = Visibility.Hidden;
            ArvutaRuut.Visibility = Visibility.Hidden;
            Andmed4.Visibility = Visibility.Hidden;
            KõrgusLabel.Visibility = Visibility.Hidden;
            Ringjoonepikkus.Visibility = Visibility.Hidden;;
            SisestageAndmed.Background = Brushes.Cyan;
            ValiKujund.Background = Brushes.DarkRed;
        }
        public MainWindow()
        {
            InitializeComponent();
            Kaatet1.Visibility = Visibility.Hidden;
            Kaatet2.Visibility = Visibility.Hidden;
            Hypotenuus.Visibility = Visibility.Hidden;
            Raadius.Visibility = Visibility.Hidden;
            Laius.Visibility = Visibility.Hidden;
            Pikkus.Visibility = Visibility.Hidden;
            Andmed1.Visibility = Visibility.Hidden;
            Andmed2.Visibility = Visibility.Hidden;
            Andmed3.Visibility = Visibility.Hidden;
            PindalaLabel.Visibility = Visibility.Hidden;
            YmbermootLabel.Visibility = Visibility.Hidden;
            Pindala.Visibility = Visibility.Hidden;
            Ymbermoot.Visibility = Visibility.Hidden;
            ArvutaRistkylik.Visibility = Visibility.Hidden;
            ArvutaKolmnurk.Visibility = Visibility.Hidden;
            ArvutaRing.Visibility = Visibility.Hidden;
            ArvutaRuut.Visibility = Visibility.Hidden;
            Andmed4.Visibility = Visibility.Hidden;
            KõrgusLabel.Visibility = Visibility.Hidden;
            Ringjoonepikkus.Visibility = Visibility.Hidden;

        }
        //Ristkylik
        private void Ristkylik_Click(object sender, RoutedEventArgs e)
        {//Ristkylik
            resetAll();
            Pikkus.Visibility = Visibility.Visible;
            Andmed1.Visibility = Visibility.Visible;
            Laius.Visibility = Visibility.Visible;
            Andmed2.Visibility = Visibility.Visible;
            SisestageAndmed.Visibility = Visibility.Visible;
            ArvutaRistkylik.Visibility = Visibility.Visible;
            
        }
        //Ruut
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            resetAll();
            Pikkus.Visibility = Visibility.Visible;
            Andmed1.Visibility = Visibility.Visible;
            ArvutaRuut.Visibility = Visibility.Visible;
            SisestageAndmed.Visibility = Visibility.Visible;
            
        }

        private void ArvutaRuut_Click(object sender, RoutedEventArgs e)
        {
            SisestageAndmed.Background = Brushes.DarkCyan;
            ValiKujund.Background = Brushes.Red;
            double _Pikkus = int.Parse(Andmed1.Text);
            Pindala.Visibility = Visibility.Visible;
            Pindala.Text = RuuduPindala(_Pikkus).ToString();
            Ymbermoot.Visibility = Visibility.Visible;
            Ymbermoot.Text = RuuduÜmbermõõt(_Pikkus).ToString();
            PindalaLabel.Visibility = Visibility.Visible;
            YmbermootLabel.Visibility = Visibility.Visible;
        }

        private void ArvutaRistkylik_Click_1(object sender, RoutedEventArgs e)
        {
            //RistKylik ArvutaNupp
            SisestageAndmed.Background = Brushes.DarkCyan;
            ValiKujund.Background = Brushes.Red;
            double _Pikkus = int.Parse(Andmed1.Text);
            double _Laius = int.Parse(Andmed2.Text);
            Pindala.Visibility = Visibility.Visible;
            Pindala.Text = RistkülikuPindala(_Pikkus, _Laius).ToString();
            PindalaLabel.Visibility = Visibility.Visible;
            YmbermootLabel.Visibility = Visibility.Visible;
            Ymbermoot.Text = RistkülikuÜmbermõõt(_Pikkus, _Laius).ToString();
            Ymbermoot.Visibility = Visibility.Visible;
        }

        private void ArvutaKolmnurk_Click(object sender, RoutedEventArgs e)
        {
            SisestageAndmed.Background = Brushes.DarkCyan;
            ValiKujund.Background = Brushes.Red;
            double _Kaatet1 = int.Parse(Andmed1.Text);
            double _Kaatet2 = int.Parse(Andmed2.Text);
            double _Hypotenuus = int.Parse(Andmed3.Text);
            double _Kõrgus = int.Parse(Andmed4.Text);
            Pindala.Text = KolmnurgaPindala(_Hypotenuus, _Kõrgus).ToString();
            Ymbermoot.Text = KolmnurgaÜmbermõõt(_Kaatet1, _Kaatet2, _Hypotenuus).ToString();
            Pindala.Visibility = Visibility.Visible;
            YmbermootLabel.Visibility = Visibility.Visible;
            PindalaLabel.Visibility = Visibility.Visible;
            Ymbermoot.Visibility = Visibility.Visible;
        }

        private void Kolmnurk_Click(object sender, RoutedEventArgs e)
        {
            resetAll(); 
            SisestageAndmed.Visibility = Visibility.Visible;
            Kaatet1.Visibility = Visibility.Visible;
            Kaatet2.Visibility = Visibility.Visible;
            Andmed2.Visibility = Visibility.Visible;
            Andmed1.Visibility = Visibility.Visible;
            Hypotenuus.Visibility = Visibility.Visible;
            Andmed3.Visibility = Visibility;
            ArvutaKolmnurk.Visibility = Visibility.Visible;
            KõrgusLabel.Visibility = Visibility.Visible;
            Andmed4.Visibility = Visibility.Visible;
        }

        private void Ring_Click(object sender, RoutedEventArgs e)
        {
            resetAll();
            SisestageAndmed.Visibility = Visibility.Visible;
            Raadius.Visibility = Visibility.Visible;
            Andmed1.Visibility = Visibility.Visible;
            ArvutaRing.Visibility = Visibility.Visible;
        }

        private void ArvutaRing_Click(object sender, RoutedEventArgs e)
        {
            SisestageAndmed.Background = Brushes.DarkCyan;
            ValiKujund.Background = Brushes.Red;
            double _raadius = int.Parse(Andmed1.Text);
            Ringjoonepikkus.Visibility = Visibility.Visible;
            Ymbermoot.Visibility = Visibility.Visible;
            Pindala.Text = RingiPindala(_raadius).ToString();
            Ymbermoot.Text = RingjoonePikkus(_raadius).ToString();
            Pindala.Visibility = Visibility.Visible;
            Ringjoonepikkus.Visibility = Visibility.Visible;
            PindalaLabel.Visibility = Visibility.Visible;
        }


    }
}
