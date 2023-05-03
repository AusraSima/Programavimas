using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.Sukurti klase Salis sukintamaisiais: pavadinimas, Prezidentas, Plotas, GyventojuSkaicius,
             * VidutinisAtlyginimas ir masyvu Augimas, kur saugosime 5 metu rodmenis, kiek gyventoju
             * gimė kasmet.
             * 2.Sukurti 4 skirtingus konstruktorius.
             * 3.Klasės viduje sukurti metoda, kad isvestu visa informacija apie sali.
             * 4.Susikurti 4 objektus, jiems priskirti reiksmes su skirtingais konstruktoriais, ir naudojant 
             * sukurta metoda isvesti kiekvienos salies informacija.
             * 5.Klasės viduje sukurti void tipo metoda, kuris pagal duotą reikšme is konsoles (masyvo indeksa / 
             * elemento vieta masyve) isvestu i ekrana masyvo elemento reiksme, ir jei reiksme didesne uz 
             * sekancia reiksme (n+1) isvesti ir ta reiksme
             */

            Salis salis = new Salis();
        }
    }
    internal class Salis
    {
        public string Pavadinimas;
        public string Prezidentas;
        public double Plotas;
        public int GyventojuSkaicius;
        public double VidAtlyginimas;
        public int[] Augimas;

        public Salis(string Pavadinimas, string Prezidentas, double Plotas, int GyventojuSkaicius, double VidAtlyginimas, int[] Augimas);
         {
             Pavadinimas = pavadinimas;
             Prezidentas = prezidentas;
             Plotas = plotas;
             GyventojuSkaicius - gyventojuSkaicius;
             VidAtlyginimas = vidAtlyginimas;
             Augimas = augimas;
         }
        
    }
}
