using System;

namespace Uzduotis11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trys skaiciai
            Console.Write("Iveskite pirma skaiciu x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite trecia skaiciu z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            if (x > y)
                Console.WriteLine("Pirmas skaicius didesnis uz antra");
            else
                Console.WriteLine("Pirmas skaicius mazesnis arba lygus antram");
            if (y > z)
                Console.WriteLine("Antras skaicius didesnis uz trecia");
            else
                Console.WriteLine("Antras skaicius mazesnis arba lygus treciam");
            if (z > x)
                Console.WriteLine("Trecias skaicius didesnis uz pirma");
            else
                Console.WriteLine("Trecias skaicius mazesnis arba lygus pirmam");
            if (x == y)
                Console.WriteLine("Pirmas skaicius lygus antram");
            Console.WriteLine();

            //Temperatura
            Console.Write("Iveskite sios dienos oro temperatura: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 0)
                Console.WriteLine("Ziauriai salta");
            else if (temp < 10)
                Console.WriteLine("Labai salta");
            else if (temp < 20)
                Console.WriteLine("Salta");
            else if (temp < 30)
                Console.WriteLine("Normali temperatura");
            else if (temp < 40)
                Console.WriteLine("Karsta");
            else 
                Console.WriteLine("Visiskai degina");
            Console.WriteLine();
        }
    }
}
