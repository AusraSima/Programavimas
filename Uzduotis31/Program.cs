using System;

namespace Uzduotis31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.Parasyti sumos funkcija su 3 parametrais, kuri grazina int tipo atsakyma.
             * 2.Parasyti dalmens funkcija su 2 parametrais, kuri grazina double tipo atsakyma.
             * 3.Issikviesti abi funkcijas ir atsakymus isvesti i ekrana.
             */

            int skaicius1 = 6;
            int skaicius2 = 4;
            int skaicius3 = 10;
            int dalinys = 25;
            int daliklis = 5;

            int suma = Suma(skaicius1, skaicius2, skaicius3);
            double dalmuo = Dalmuo(dalinys, daliklis);

            Console.WriteLine($"Funkcijos Suma rezultatas: {suma}");
            Console.WriteLine($"Funkcijos Dalmuo rezultatas: {dalmuo}");
            Console.WriteLine();
        }
        internal static int Suma(int skaicius1, int skaicius2, int skaicius3)
        {
            return skaicius1 + skaicius2 + skaicius3;     
        }
        private static double Dalmuo(int dalinys, int daliklis)
        {
            return (double)dalinys / daliklis;
        }
    }
}
