using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
