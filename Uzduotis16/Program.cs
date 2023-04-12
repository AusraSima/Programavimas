using System;

namespace Uzduotis16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skaiciu nuo 1 iki 100 suma
            int suma = 0;
            for (int i = 0; i <= 100; i++) 
            {
            suma += i;
            }
            Console.WriteLine(suma);
            Console.WriteLine();

            // Lyginiu skaiciu nuo 20 iki 40 suma
            int lygsuma = 0;
            for (int i = 20; i <= 40; i++)
            {
                if (i % 2 == 0)
                {
                    lygsuma += i;
                } 
                
            }
            Console.WriteLine(lygsuma);
            Console.WriteLine();

            // Nelyginiu skaiciu nuo 30 iki 60 suma
            int nelygsuma = 0;
            for (int i = 30; i <= 60; i++)
            {
                if (i % 2 != 0)
                {
                    nelygsuma += i;
                }

            }
            Console.WriteLine(nelygsuma);
            Console.WriteLine();

            // Skaiciu nuo 1 iki 999 besidalinanciu is 3 arba 5 suma
            int sumax = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumax += i;
                }

            }
            Console.WriteLine(sumax);
            Console.WriteLine();

        }
    }
}
