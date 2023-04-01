using System;

namespace Uzduotis09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Amzius
            Console.Write("Iveskite savo amziu: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            if (amzius >= 18)
                Console.WriteLine("Jus galite balsuoti");
            Console.WriteLine();

            //If salygu tikrinimas
            Console.Write("Iveskite bet koki skaiciu: ");
            double skaicius = Convert.ToDouble(Console.ReadLine());
            if (skaicius < 0)
                Console.WriteLine("Blogai!");
            else
                Console.WriteLine("Sveikinu, gerai!");
            if (skaicius % 2 == 0)
                Console.WriteLine("Taip, skaicius yra lyginis");
            if (skaicius % 4 == 0)
                Console.WriteLine("Taip, dalinasi is 4");
            if (skaicius > 10)
                Console.WriteLine("Taip, skaicius didesnis uz 10");
            Console.WriteLine();

            //Vidurkis
            Console.Write("Iveskite pirma pazymi: ");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite antra pazymi: ");
            int antras = Convert.ToInt32(Console.ReadLine());
            if ((pirmas + antras) / 2 >= 5)
                Console.WriteLine("Valio!");
            Console.WriteLine();

        }
    }
}
