using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Parasyti metoda, kuris pasisveikintu su vartotoju.
             * Vartotojas turi ivesti savo vard1, amziu ir hobio pavadinima.
             * Metodas sia informacija isveda formatuotai.
             */

            string vardas = VartotojoDuomenys("Iveskite savo varda");
            int amzius = Convert.ToInt32(VartotojoDuomenys("Iveskite savo amziu"));
            string hobis = VartotojoDuomenys("Iveskite savo hobio pavadinima");

            PasisveikinimasSuVartotoju(vardas, amzius, hobis);
        }

        private static string VartotojoDuomenys(string zinute) 
        {
            Console.Write($"{zinute}: ");
            return Console.ReadLine();
        }

        private static void PasisveikinimasSuVartotoju(string vardas, int amzius, string hobis) 
        {
            Console.WriteLine();
            Console.WriteLine($"Labas, tavo vardas yra {vardas}, tau {amzius} metu, o tavo hobis yra {hobis}.");
            Console.WriteLine();
        }
    }
}
