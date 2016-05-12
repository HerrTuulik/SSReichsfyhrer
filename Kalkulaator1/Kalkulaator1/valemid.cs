using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulaator1
{
    class valemid
    {
        // Ristkülik
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
            return 4 * pikkus + " cm";
        }

        // Kolmnurk
        public string KolmnurgaPindala(double alus, double kaatet1, double kaatet2, double kõrgus, double hüpotenuus)
        {
            if (String.IsNullOrEmpty(kõrgus))
            {
                MessageBox.Show("Palun sisesta kõrgus ja proovi uuesti.");
                return;
            }
            else if (kaatet1 + kaatet2 > hüpotenuus)
            {
                return (alus * kõrgus) / 2 + " cm²";
            }
            else
            {
                return "Sellist kolmnurka pole olemas.";
            }
            
        }
        public string KolmnurgaÜmbermõõt(double kaatet1, double kaatet2, double hüpotenuus)
        {
            if (kaatet1 + kaatet2 > hüpotenuus)
            {
                return kaatet1 + kaatet2 + hüpotenuus + " cm";
            }
            else
            {
                return "Sellist kolmnurka pole olemas.";
            }
        } 

        // Ring
        public string RingiPindala(double raadius)
        {
            return Math.Round(Math.PI, 2) * Math.Pow(raadius, 2) + " cm²";
        }
        public string RingjoonePikkus(double raadius)
        {
            return 2 * Math.Round(Math.PI, 2) * raadius + " cm";
        }
    }
}
