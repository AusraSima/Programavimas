using System;
using System.Linq;

namespace Uzduotis21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* Sukurti 2 masyvus išbandant 2 kūrimo būdus (iš karto su duomenimis, 
             * arba pirma nurodant dydį, po to priskiriant reikšmes),
             * išvesti norimus duomenis iš visų tų masyvų:
             *  - masyvas, skirtas studentų pažymių saugojimui.
             *  - masyvas, skirtas mašinų markėms saugoti.
             */

            // Masyvų kūrimas iš karto su duomenimis
            int[] pazymiuMasyvas = { 6, 8, 5, 9, 10, 8};
            for (int i = 0; i < pazymiuMasyvas.Length; i++)
            {
                Console.WriteLine(pazymiuMasyvas[i]);
            }
            Console.WriteLine();
            string[] masinuMasyvas = { "Audi", "Ford", "BMW", "Mercedes", "VW"};
            for (int i = 0; i < masinuMasyvas.Length; i++)
            {
                Console.WriteLine(masinuMasyvas[i]);
            }
            Console.WriteLine();

            // Masyvų kūrimas pirma nurodant masyvo dydį ir tik po to priskiriant reikšmes
            int[] masyvasPazymiai = new int[4];
            masyvasPazymiai[0] = 9;
            masyvasPazymiai[1] = 8;
            masyvasPazymiai[2] = 10;
            masyvasPazymiai[3] = 9;
            for (int i = 0; i < masyvasPazymiai.Length; i++)
            {
                Console.WriteLine(masyvasPazymiai[i]);
            }
            Console.WriteLine();

            string[] masyvasMasinos = new string[4];
            masyvasMasinos[0] = "Ford";
            masyvasMasinos[1] = "Audi";
            masyvasMasinos[2] = "Toyota";
            masyvasMasinos[3] = "Kia";
            for (int i = 0; i < masyvasMasinos.Length; i++)
            {
                Console.WriteLine(masyvasMasinos[i]);
            }
            Console.WriteLine();

            //Užduoties tęsinys: išvesti narių skaičių, pirmą ir paskutinį narius iš bent vieno pasirinkto masyvo
            Console.WriteLine(masyvasMasinos.Length);
            Console.WriteLine(masyvasMasinos.First());
            Console.WriteLine(masyvasMasinos.Last());
            Console.WriteLine();
        }
    }
}
