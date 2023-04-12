using System;

namespace Uzduotis15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parasyti komanda for, kuri isvestu skaicius nuo 0 iki 10 atskirose eilutese
            for (int i = 0; i <= 10; i ++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //Parasyti komanda for, kuri isvestu kas antra skaiciu nuo 0 iki 15 vienoje eiluteje atskiriant tarpais
            for (int i = 0; i <= 15; i += 2)
            {
                Console.Write($"{i + 1} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Parasyti komanda for, kuri isvestu kas trecia skaiciu nuo 0 iki 20 vienoje eiluteje lauztiniuose skliaustuose
            for (int i = 0; i <= 20; i += 3)
            {
                Console.Write($"[{i + 2}]");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Parasyti for, tikrinanti kiekviena skaiciu nuo 1 iki 10, panaudoti if patikrinti ar lyginis ir lyginius isvesti
            for (int i = 1; i <= 10; i ++)
            {
                if (i % 2 == 0) 
                {
                    Console.Write(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
