using System;

namespace Uzduotis13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ivesti 3 skirtingus skaicius ir patikrinti pirmaji skaiciu su komanda switch
            Console.Write("Iveskite pirma skaiciu x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite trecia skaiciu z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            switch (x)
            {
                case 1:
                    Console.WriteLine(x + y + z);
                    break;
                case 2:
                    Console.WriteLine(x - z);
                    break;
                case 3:
                    Console.WriteLine(y * z);
                    break;
            }

            //Ivesti gyvuno pavadinima ir patikrinti su komanda switch
            Console.Write("Iveskite gyvuna: ");
            string gyvunas = Console.ReadLine();
            Console.WriteLine();
            switch (gyvunas)
            {
                case "suo":
                    Console.WriteLine("Ivestas gyvunas yra suo");
                    break;
                case "kate":
                    Console.WriteLine("Ivestas gyvunas yra kate");
                    break;
                case "ziurkenas":
                    Console.WriteLine("Ivestas gyvunas yra ziurkenas");
                    break;
            }
        }   
    }
}
