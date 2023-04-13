using System;

namespace Uzduotis20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Staciojo trikampio izambines radimas
            Console.Write("Iveskite staciojo trikampio pirmojo statinio ilgi a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite staciojo trikampio antrojo statinio ilgi b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Izambines ilgis {Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))}");
            Console.WriteLine();
        }
    }
}
