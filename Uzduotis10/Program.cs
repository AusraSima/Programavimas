using System;

namespace Uzduotis10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite skaiciu: ");
            double skaicius = Convert.ToDouble(Console.ReadLine());
            if (skaicius % 2 == 0)
                Console.WriteLine($"Ivestas skaicius {skaicius}, pakeltas 5 laipsniu {Math.Pow(skaicius, 5)}");
            if (skaicius % 4 != 0)
                Console.Write("Iveskite antra skaiciu: ");
                double kitas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Abieju skaiciu suma yra {skaicius + kitas}, o sandauga {skaicius * kitas}");
           Console.WriteLine();
        }
    }
}
