using System;

namespace Uzduotis32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.Paprasyti ivesti vartotojo varda.
             * 2.Sukurti string tipo metoda, kuris grazina fraze, pvz."Sveiki, Mantas".
             * 3.isvesti sia fraze i konsole.
             */

            Console.Write("Iveskite savo varda: ");
            string vardas = Console.ReadLine();
            Console.WriteLine(Pasisveikinimas(vardas));
        }
        private static string Pasisveikinimas(string vardas)
        {
            return $"Sveiki, {vardas}";
        }
    }
}
