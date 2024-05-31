using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasznaltAutok
{
    internal class Auto
    {
        public string marka;
        public string tipus;
        public string meghajtas;
        public string uzemanyag;
        public int ar;

        public Auto(string sor)
        {
            var adatok = sor.Split(',').ToList();
            marka = adatok[0];
            tipus = adatok[1];
            meghajtas = adatok[2];
            uzemanyag= adatok[3];
            ar = int.Parse(adatok[4]);
        }

        public override string ToString()
        {
            return marka;
        }
    }

}
