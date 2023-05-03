using System;

namespace Uzduotis33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.Ivesti du skaicius is konsoles.
             * 2.Paklausti vartotojo, koki veiksma su tais skaiciais jis nori atlikti: sud4tis, atimtis, kelimas 4 laipsniu sudejus
             * abu skaicius,kvadratine saknis sudejus abu skaicius.
             * 3.Parasyti po atskira metoda kiekvienam veiksmui (sudexiai ir atimciai naudoti int tipa, kitiems naudoti double tipa).
             * 4.Su switch() patikrinti koki veiksma reikia atlikti ir kiekviename case-e issikviesti atitinkama metoda, jei tokio 
             * case-o nera, informuoti vartotoja, kad tokio veiksmo nera.
             */

            Console.WriteLine("Iveskite pirma skaiciu: ");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu: ");
            int antras = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pasirinkite, kokius veiksmus atlikti su ivestais skaiciais: ");
            Console.WriteLine("suma - abieju skaiciu sudetis,");
            Console.WriteLine(" atimtis - is pirmo skaiciaus atimti antra skaiciu,");
            Console.WriteLine("laipsnis - abieju skaiciu sumos kelimas 4 laipsniu,");
            Console.WriteLine("saknis - abieju skaiciu sumos kvadratine saknis.");
            string veiksmas = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            switch (veiksmas)
            {
                case "suma":
                    Console.WriteLine($"Skaiciu {pirmas} ir {antras} suma yra {Suma(pirmas, antras)}");
                    break;
                case "atimtis":
                    Console.WriteLine($"Is skaiciaus {pirmas} atemus skaiciu {antras} rezultatas yra {Atimtis(pirmas, antras)}");
                    break;
                case "laipsnis":
                    Console.WriteLine($"Skaiciu {pirmas} ir {antras} suma pakelus 4 laipsniu gausime {KetvirtasLaipsnis(pirmas, antras)}");
                    break;
                case "saknis":
                    Console.WriteLine($"Skaiciu {pirmas} ir {antras} sumos kvadratine saknis yra {KvadratineSaknis(pirmas, antras)}");
                    break;
                default:
                    Console.WriteLine("Tokio veiksmo nera");
                    break;
            }
        }
        private static int Suma(int x, int y)
        {
            return x + y;
        }
        private static int Atimtis(int x, int y)
        {
            return x - y;
        }
        private static double KetvirtasLaipsnis(int x, int y) 
        {
            return (double)Math.Pow((x +y), 4);
        }
        private static double KvadratineSaknis(int x, int y)
        {
            return (double)Math.Sqrt((x + y));
        }
    }
}
