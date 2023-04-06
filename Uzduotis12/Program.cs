using System;

namespace Uzduotis12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ivesti 3 skirtingus skaicius ir patikrinti kuris is ju didziausias
            Console.Write("Iveskite pirma skaiciu x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite trecia skaiciu z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            if (x > y && x > z)
            {
                Console.WriteLine("Pirmas skaicius yra didziausias");
            }
            else if (y > z && y > x)
            {
                Console.WriteLine("Antras skaicius yra didziausias");
            }
            else
                Console.WriteLine("Trecias skaicius yra didziausias");
            Console.WriteLine();

            //Ivesti egzamino rezultata ir patikrinti ar atitinka salygas
            Console.Write("Iveskite egzamino rezultata: ");
            int rezultatas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (rezultatas > 7 && rezultatas < 11)
            {
                Console.WriteLine("Rezultatas patenka i [8 - 10]");
            }
            else if (rezultatas > 4 && rezultatas < 8)
            {
                Console.WriteLine("Rezultatas patenka i [5 - 8)");
            }
            else
                Console.WriteLine("Rezultatas yra mazesnis uz 5");
            Console.WriteLine();

            //Ivesti du skaicius ir atlikti patikrinimus
            Console.Write("Iveskite pirma skaiciu a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            if (a > b || a == 0)
            {
                Console.WriteLine("Pirmas skaicius yra didesnis uz antra arba lygus 0");
            }
            if (b > a || b == 5)
            {
                Console.WriteLine("Antras skaicius yra didesnis uz pirma arba lygus 5");
            }
            if (a > b && a == 20)
            {
                Console.WriteLine("Pirmas skaicius yra didesnis uz pirma ir lygus 20");
            }
            if (b > a && b < 100)
            {
                Console.WriteLine("Antras skaicius yra didesnis uz pirma ir mazesnis uz 100");
            }
            Console.WriteLine();
        }
    }
}