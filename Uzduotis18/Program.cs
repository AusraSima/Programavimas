using System;

namespace Uzduotis18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kepyklos darbo apskaiciavimas

            int valandos = 8;  
            Console.WriteLine("Iveskite kiek kepalu per diena gali iskepti darbuotojas: ");
            int kepalai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite kiek darbuotoju turi kepykla: ");
            int darbuotojai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite vieno kepalo savikaina: ");
            double savikaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite vieno kepalo pardavimo kaina: ");
            double kaina = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite kiek kepalu kepykla turi iskepti ta diena: ");
            int uzsakymai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Kiek kepalu kepykla iskeps per diena
            Console.WriteLine($"Per diena kepykla iskeps {kepalai * darbuotojai * valandos} kepalu");
            Console.WriteLine();

            //Patikrinti ar kepykla ivykdys tos dienos uzsakymus, jei ne, kiek kepalu nespes iskepti
            if (kepalai * darbuotojai * valandos >= uzsakymai) 
            {
                Console.WriteLine("Kepykla spes iskepti visus dienos uzsakymus");
            }
            else
            {
                Console.WriteLine($"Iki dienos uzsakymu ivykdymo truks {uzsakymai - (kepalai * darbuotojai * valandos)} kepalu");
            }
            Console.WriteLine();

            //Suskaiciuoti pelna uz ta diena iskeptus kepalus
            Console.Write("Pelnas uz per diena iskeptus kepalus: ");
            double dienoskaina = kepalai * darbuotojai * valandos * kaina;
            double dienossavikaina = kepalai * darbuotojai * valandos * savikaina;
            Console.WriteLine(dienoskaina - dienossavikaina);
            Console.WriteLine();
        }
    }
}
