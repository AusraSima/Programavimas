using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Vartotojas turi ivesti 2 sveikuosius skaicius i programa.
             * Sukurti ir panaudoti siuos metodus:
             * suma, skirtumas, sandauga, dalmuo
             */

            int pirmasSkaicius = Konvertavimas(Ivedimas("Iveskite pirma skaiciu:"));
            int antrasSkaicius = Konvertavimas(Ivedimas("Iveskite antra skaiciu:"));

            int suma = Suma(pirmasSkaicius, antrasSkaicius);
            int skirtumas = Skirtumas(pirmasSkaicius, antrasSkaicius);
            int sandauga = Sandauga(pirmasSkaicius, antrasSkaicius);
            double dalmuo = Dalyba(pirmasSkaicius, antrasSkaicius);

            Spausdinimas(pirmasSkaicius, antrasSkaicius, suma.ToString(), '+');
            Spausdinimas(pirmasSkaicius, antrasSkaicius, skirtumas.ToString(), '-');
            Spausdinimas(pirmasSkaicius, antrasSkaicius, sandauga.ToString(), '*');
            Spausdinimas(pirmasSkaicius, antrasSkaicius, dalmuo.ToString(), '/');
        }

        private static void Spausdinimas(int pirmasSkaicius, int antrasSkaicius, string rezultatas, char veiksmas)
        {
            Console.WriteLine($"{pirmasSkaicius} {veiksmas} {antrasSkaicius} = {rezultatas}");
        }

        private static int Suma(int pirmasSkaicius, int antrasSkaicius)
        {
            return pirmasSkaicius + antrasSkaicius;
        }

        private static int Skirtumas(int pirmasSkaicius, int antrasSkaicius)
        {
            return pirmasSkaicius - antrasSkaicius;
        }

        private static int Sandauga(int pirmasSkaicius, int antrasSkaicius)
        {
            return pirmasSkaicius * antrasSkaicius;
        }

        private static double Dalyba(int pirmasSkaicius, int antrasSkaicius)
        {
            return (double)pirmasSkaicius / antrasSkaicius;
        }

        private static int Konvertavimas(string ivedimas)
        {
            return Convert.ToInt32(ivedimas);
        }

        private static string Ivedimas(string zinute)
        {
            Console.WriteLine($"{zinute}");
            return Console.ReadLine();
        }
    }
}
