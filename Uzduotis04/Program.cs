using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string marke = "Ford";   //Automobilio marke
            string modelis = "Ecosport";   // Automobilio modelis
            int metai = 2019;   //Automobilio metai
            int rida = 30590;   //Automobilio rida

            Console.WriteLine();
            Console.WriteLine($"Automobilis {marke} {modelis} ({metai} m.), rida - {rida} km.");
            Console.WriteLine();
        }
    }
}
