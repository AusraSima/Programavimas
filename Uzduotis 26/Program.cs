using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*Sugeneruoti sarasa, kuri reikia uzpildyti atsitiktiniais skaiciais nuo 1 iki 100.  Rasti:
            * maziausia skaiciu, didziausia skaiciu, vidurki, kiek skaiciu yra zemesni uz vidurki, lyginiu skaiciu suma.
            */

            
            Random skaiciai = new Random();
            List<int> atsitiktiniaiSkaiciai = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int skaicius = skaiciai.Next(1, 101);
                atsitiktiniaiSkaiciai.Add(skaicius);
            }
            Console.WriteLine("Atsitiktiniai skaiciai:");
            foreach (int skaicius in atsitiktiniaiSkaiciai)
            {
                Console.WriteLine(skaicius);
            }
            Console.WriteLine();
            
            Console.WriteLine($"Maziausias saraso skaicius yra {atsitiktiniaiSkaiciai.Min()}");
            Console.WriteLine($"Didiausias saraso skaicius yra {atsitiktiniaiSkaiciai.Max()}");
            Console.WriteLine($"Saraso skaiciu vidurkis yra {atsitiktiniaiSkaiciai.Average()}");
            int maziauUzVidurki = 0;
            int vidurkis = (int)atsitiktiniaiSkaiciai.Average();
            int lyginiuSkaicius = 0;
            for (int i = 0; i < 10; i++)
            {
                if (atsitiktiniaiSkaiciai[i] < vidurkis)
                {
                    maziauUzVidurki++;
                }
                if ((atsitiktiniaiSkaiciai[i] % 2) == 0)
                {
                    lyginiuSkaicius += atsitiktiniaiSkaiciai[i];
                }
            }
            Console.WriteLine($"Sarase yra {maziauUzVidurki} skaiciai, mazesni uz vidurki");
            Console.WriteLine($"Saraso lyginiu skaiciu suma yra lygi {lyginiuSkaicius}");
        }
    }
}
