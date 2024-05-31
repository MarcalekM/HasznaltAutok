using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasznaltAutok
{
    internal class Auto
    {
        public string marka { get; set; }
        public string tipus { get; set; }
        public string meghajtas { get; set; }
        public string uzemanyag { get; set; }
        public int ar { get; set; }

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
