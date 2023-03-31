using System;

namespace Uzduotis06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Daugybos lentele
            int skaicius = 5;
            int daugiklis = 1;
            int rezultatas = skaicius * daugiklis;

            while (daugiklis <= 10) 
                Console.WriteLine($"{skaicius} * {daugiklis++} = {rezultatas}");
            Console.WriteLine();

            //Dvizenklio skaiciaus skaitmenu sandauga
            int sveikas = 25;
            int pirmas = sveikas / 10;
            int antras = sveikas % 10;
            Console.WriteLine($"Skaiciaus {skaicius} skaitmenu {pirmas} ir {antras} sandauga lygi {pirmas} * { antras}");            Console.WriteLine();
        }
    }
}
