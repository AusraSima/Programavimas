using System;
using System.Linq;

namespace Uzduotis22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* 1. Sukurti savaitės temperatūros rodmenų masyvą. Rasti:
             * žemiausią temperatūrą, aukščiausią temperatūrą, vidurkį, žemesnių už vidurkį temperatūrų kiekį,
             * aukštesnių už vidurkį temperatūrų kiekį.
             */

            int[] temperaturuMasyvas = new int[]{ 14, 16, 17, 17, 17, 19, 17};
            int min = temperaturuMasyvas[0];
            for (int i = 0; i <  temperaturuMasyvas.Length; i++) 
            {
                if (temperaturuMasyvas[i] < min) 
                {
                    min = temperaturuMasyvas[i];
                }
            }
            Console.WriteLine($"Zemiausia savaites temperatura yra: {min}");
            Console.WriteLine();

            int max = temperaturuMasyvas[0];
            for (int i = 0; i < temperaturuMasyvas.Length; i++)
            {
                if (temperaturuMasyvas[i] > max)
                {
                    max = temperaturuMasyvas[i];
                }
            }
            Console.WriteLine($"Auksciausia savaites temperatura yra: {max}");
            Console.WriteLine();

            int vidurkis = temperaturuMasyvas.Sum();
            vidurkis = vidurkis / temperaturuMasyvas.Length;
            Console.WriteLine($"Savaites temperaturu vidurkis lygus: {vidurkis}");
            Console.WriteLine();

            int kiekiszemiauvidurkio = 0;
            foreach (int temperatura in temperaturuMasyvas) 
            {
                if (temperatura < vidurkis) 
                {
                    kiekiszemiauvidurkio++;
                }
            }
            Console.WriteLine($"Temperaturu zemiau vidurkio kiekis yra: {kiekiszemiauvidurkio}");
            Console.WriteLine();

            int kiekisdaugiauvidurkio = 0;
            for (int i = 0; i < temperaturuMasyvas.Length; i++)
            {
                if (temperaturuMasyvas[i] > vidurkis)
                {
                    kiekisdaugiauvidurkio++;
                }
            }
            Console.WriteLine($"Temperaturu didesniu uz vidurki kiekis yra: {kiekisdaugiauvidurkio}");
            Console.WriteLine();

            /*Sukurti pažymių masyvą.  Rasti : geriausią pažymį, kiek mokinių yra gavę dešimtukus,
             * kiek mokinių yra gavę neigiamą pažymį (žemiau nei 4), pažymių vidurkį.
             */

            int[] pazymiuMasyvas = new int[] { 9, 6, 3, 10, 8, 5, 9, 10, 7, 6, 8};
            int maxpazymys = pazymiuMasyvas[0];
            for (int i = 0; i < pazymiuMasyvas.Length; i++)
            {
                if (pazymiuMasyvas[i] > maxpazymys)
                {
                    maxpazymys = pazymiuMasyvas[i];
                }
            }
            Console.WriteLine($"Geriausias pazymys yra: {maxpazymys}");
            Console.WriteLine();

            int desimtukininkai = 0;
            for (int i = 0; i < pazymiuMasyvas.Length; i++)
            {
                if (pazymiuMasyvas[i] == 10)
                {
                    desimtukininkai++;
                }
            }
            Console.WriteLine($"Desimtukus gavusiu mokiniu skaicius yra {desimtukininkai}");
            Console.WriteLine();

            int nepazangus = 0;
            for (int i = 0; i < pazymiuMasyvas.Length; i++)
            {
                if (pazymiuMasyvas[i] < 4)
                {
                    nepazangus++;
                }
            }
            Console.WriteLine($"Neigiamus pazymius gavusiu mokiniu skaicius yra {nepazangus}");
            Console.WriteLine();

            int pazymiuvidurkis = pazymiuMasyvas.Sum();
            pazymiuvidurkis = pazymiuvidurkis / pazymiuMasyvas.Length;
            Console.WriteLine($"Pazymiu vidurkis lygus: {pazymiuvidurkis}");
            Console.WriteLine();
        }
    }
}
