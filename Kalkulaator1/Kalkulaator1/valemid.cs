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
        public double RistkülikuPindala(double pikkus, double laius)
        {
            return pikkus * laius;
        }
        public double RistkülikuÜmbermõõt(double pikkus, double laius)
        {
            return 2 * (pikkus + laius);
        }

        // Ruut
        public double RuuduPindala(double pikkus)
        {
            return Math.Pow(pikkus, 2);
        }
        public double RuuduÜmbermõõt(double pikkus)
        {
            return 4 * pikkus;
        }

        // Kolmnurk
        public double KolmnurgaPindala(double alus, double kõrgus)
        {
            return (alus * kõrgus) / 2;
        }
        public double KolmnurgaÜmbermõõt(double kaatet1, double kaatet2, double hüpotenuus)
        {
            return kaatet1 + kaatet2 + hüpotenuus;
        } 

        // Ring
        public double RingiPindala(double raadius)
        {
            return Math.PI * Math.Pow(raadius, 2);
        }
        public double RingjoonePikkus(double raadius)
        {
            return 2 * Math.PI * raadius;
        }
    }
}
