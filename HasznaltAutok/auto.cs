using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasznaltAutok
{
    internal class Auto
    {
        private string marka;
        private string tipus;
        private string meghajtas;
        private string uzemanyag;
        private int ar;

        public Auto(string sor)
        {
            var adatok = sor.Split(',').ToList();
            marka = adatok[0];
            tipus = adatok[1];
            meghajtas = adatok[2];
            uzemanyag= adatok[3];
            ar = int.Parse(adatok[4]);
        }
    }

}
