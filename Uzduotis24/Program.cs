using System;

namespace Uzduotis24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* Paklausti vartotojo, kiek duomenų nori suvesti į masyvą. 
             * Iš konsolės syvesti duomenis į nurodyto dydžio masyvą. Surasti 2 sumas.  
             * Suma1 - kai masyvo elementas yra lyginis skaičius,
             * Suma2 - kai masyvo indeksas nėra lyginis skaičius.
             */

            Console.Write("Iveskite skaiciu, kiek duomenu norite suvesti i masyva: ");
            int kiekis = Convert.ToInt32(Console.ReadLine());
            int[] masyvas = new int[kiekis];
            Console.WriteLine();

            int suma1 = 0;
            int suma2 = 0;
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write("iveskite skaiciu: ");
                masyvas[i] = Convert.ToInt32(Console.ReadLine());
                if (masyvas[i] % 2 == 0)
                {
                    suma1 += masyvas[i];
                }
                if (i % 2 != 0)
                {
                    suma2 += masyvas[i];
                }
            }
            Console.WriteLine($"Lyginiu masyvo elementu suma yra lygi {suma1}");
            Console.WriteLine($"masyvo elementu, kuriu indeksas nera lyginis, suma yra lygi {suma2}");
            Console.WriteLine();
        }
    }
}
