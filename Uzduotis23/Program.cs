using System;
using System.Linq;

namespace Uzduotis23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* Susikurti kintamąjį,nurodantį kiek degalų vidutiniškai sunaudoja automobilis 100-ui km.
             * Sukurti masyvą skirtingų kelionių nuvažiuotiems kilometrams.  Rasti: trumpiausią kelionę,
             * ilgiausią kelionę, kiek kuro sunaudojo automobilis (skaičiavimams rasti visus nuvažiuotus kilometrus).
             */

            double vidutinissunaudojimas = 5.9;
            double[] kilometrai = new double[] { 100, 114.6, 248.9, 46.5, 98.3, 67.2, 115 };
            double minkelione = kilometrai[0];
            for (int i = 1; i < kilometrai.Length; i++) 
            {
                if (kilometrai[i] < minkelione) 
                {
                     minkelione = kilometrai[i];
                }
            }
            Console.WriteLine($"Trumpiausia kelione buvo {minkelione} kilometrai");
            Console.WriteLine();

            double maxkelione = kilometrai[0];
            for (int i = 1; i < kilometrai.Length; i++)
            {
                if (kilometrai[i] > maxkelione)
                {
                    maxkelione = kilometrai[i];
                }
            }
            Console.WriteLine($"Ilgiausia kelione buvo {maxkelione} kilometrai");
            Console.WriteLine();

            double sanaudos = kilometrai.Sum();
            sanaudos = (sanaudos * vidutinissunaudojimas) / 100;
            Console.WriteLine($"Automobilis nuvaziavo {kilometrai.Sum()} kilometru, sunaudojo {sanaudos} litru kuro");
            Console.WriteLine();
        }
    }
}
