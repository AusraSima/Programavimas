using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Daugybos lentele
            int daugiklis = 1;
            Console.Write("Iveskite sveika skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            while (daugiklis <= 5)
                Console.WriteLine($"{skaicius} * {daugiklis} = {skaicius * daugiklis++}");
            Console.WriteLine();

            //Vidurkis
            Console.Write("Iveskite pirma skaiciu: ");
            double pirmas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu: ");
            double antras = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite trecia skaiciu: ");
            double trecias = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Skaiciu {pirmas}, {antras} ir {trecias} vidurkis yra {(pirmas + antras + trecias) / 3}");
            Console.WriteLine();

            //Triju skaiciu kvadratai, kubai ir dalyba
            Console.Write("Iveskite pirma skaiciu: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite trecia skaiciu: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Skaiciaus {x} kvadratas: {Math.Pow(x, 2)}, kubas: {Math.Pow(x, 3)}, dalyba is 2: {x / 2}");
            Console.WriteLine($"Skaiciaus {y} kvadratas: {Math.Pow(y, 2)}, kubas: {Math.Pow(y, 3)}, dalyba is 2: {y / 2}");
            Console.WriteLine($"Skaiciaus {z} kvadratas: {Math.Pow(z, 2)}, kubas: {Math.Pow(z, 3)}, dalyba is 2: {z / 2}");
            Console.WriteLine();


        }
    }
}
