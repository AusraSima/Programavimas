using System;

namespace Uzduotis34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.Ivesti du skaicius is konsoles.
             * 2.Paklausti vartotojo, koki veiksma jis noris atlikti: daugyba ar dalyba?
             * 3.Parasyti po metoda kiekvienam veiksmui (daugybai naudoti int tipa, o dalybai double.
             * 4.Su if patikrinti koki veiksma atlikti ir issikviesti atitinkama metoda, jei tokio 
             * veiksmo nera, informuoti vartotoja, kad tokio veiksmo nera.
             */

            Console.WriteLine("Iveskite pirma skaiciu: ");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu: ");
            int antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pasirinkite, kokius veiksmus atlikti, dalyba ar daugyba: ");
            string veiksmas = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            if (veiksmas == "daugyba")
            {
                Console.WriteLine($"Skaiciu {pirmas} ir {antras} sandauga yra lygi {Daugyba(pirmas, antras)}");
            }
            else if (veiksmas == "dalyba")
            {
                Console.WriteLine($"{pirmas} padalinis is {antras} gausime {Dalyba(pirmas, antras)}");
            }
            else 
            {
                Console.WriteLine("Tokio veiksmo nera");
            }
        }
        private static int Daugyba(int a, int b)
        {
            return a * b;
        }
        private static double Dalyba(double x, double y)
        {
            return (double) x / y;
        }
    }
}
