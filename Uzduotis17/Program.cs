using System;

namespace Uzduotis17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teigiamo skaiciaus isvedimas mazejimo tvarka iki 0 atskirose eilutese
            Console.Write("Iveskite teigiama skaiciu: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (skaicius > 0) 
            {
                Console.WriteLine(skaicius);
                skaicius--;
            }
            Console.WriteLine();

            //Neigiamo skaiciaus isvedimas didejimoo tvarka iki 0 vienoje eiluteje atskiriant tarpais
            Console.Write("Iveskite neigiama skaiciu: ");
            int neigiamas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (neigiamas < 0)
            {
                Console.Write(neigiamas + " ");
                neigiamas++;
            }
            Console.WriteLine();
            Console.WriteLine();

            //Skaiciuotuvas
            string veiksmas = "t";
            while (veiksmas == "t") 
            {
                Console.WriteLine("Iveskite pirma skaiciu x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Iveskite antra skaiciu y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"{x} + {y} = {x + y}");
                Console.WriteLine($"{x} - {y} = {x - y}");
                Console.WriteLine($"{x} * {y} = {x * y}");
                Console.WriteLine($"{x} / {y} = {x / y}");
                Console.WriteLine($"{x} % {y} = {x % y}");
                Console.WriteLine("Jei norite testi skaiciavimus, spauskite t");
                veiksmas = Console.ReadLine();
            }
        }
    }
}
