using System;

namespace Uzduotis19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parasyti for cikla, kuris skaiciuoja kiek skaciu intervale [0 - 1000) dalijasi is 16
            int x = 0;
            for (int i = 0; i < 1000; i++) 
            {
                if (i % 16 == 0)
                    x++; 
            }
            Console.WriteLine(x);
            Console.WriteLine();

            //Ivesto skaiciaus kelimas vis didesniu laipsniu kol skaicius taps didesnis uz 1500
            Console.Write("Iveskite teigiama skaiciu y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = 2;
            Console.WriteLine();
            while ((int)Math.Pow(y, z) <= 1501) 
            {
                Console.WriteLine((int)Math.Pow(y, z));
                z++;
            }
        }
    }
}
