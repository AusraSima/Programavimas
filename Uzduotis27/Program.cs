using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Sukurti zodziu sarasa. Rasti trumpiausia ir ilgiausia zodzius, isvesti juos i ekrana,
             * nurodant is kiek raidziu jie sudaryti.
             */

            List<string> zodziai = new List<string> { "samtis", "laiptai", "spinta", "programa", "oras" };
            
            int maxzodis = int.MinValue;
            int minzodis = int.MaxValue;
            string ilgiausiaszodis = zodziai[0];
            string trumpiausiaszodis = zodziai[0];

            for (int i = 0; i <= zodziai.Count-1; i++)
            {
                int ilgis = zodziai[i].Length;
                Console.Write(zodziai[i] + ' ' + ilgis);
                Console.WriteLine();

                if (ilgis > maxzodis)
                {
                    maxzodis = ilgis;
                    ilgiausiaszodis = zodziai[i]; 
                }
                if (ilgis < minzodis)
                {
                    minzodis = ilgis;
                    trumpiausiaszodis = zodziai[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Ilgiausia zodi {ilgiausiaszodis} sudaro {maxzodis} raides");
            Console.WriteLine($"Trumpiausia zodi {trumpiausiaszodis} sudaro {minzodis} raides");
            Console.WriteLine();
        }
    }
}
