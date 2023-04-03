using System;

namespace Uzduotis07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vardo ir amžiaus įvedimas
            Console.Write("Iveskite savo varda: ");
            string vardas = Console.ReadLine();
            Console.Write("Ieskite savo amziu: ");
            int amzius = Convert.ToInt32(Console.ReadLine()); 
            Console.Write($"Jusu vardas {vardas}, o amzius {amzius}.");
            Console.WriteLine();

            Kvadratas iš simbolio
            Console.Write("Iveskite simboli: ");
            string simbolis = Console.ReadLine();
            Console.WriteLine($"{simbolis}{simbolis}{simbolis}\n{simbolis} {simbolis} \n{simbolis}{simbolis}{simbolis}");
            Console.WriteLine();

            //Skaičiaus kvadratas
            Console.Write("Iveskite skaiciu: ");
            double skaicius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Įvestas skaičius: {skaicius}\nĮvesto skaičiaus kvadratas:  {Math.Pow(skaicius, 2)}");
            Console.WriteLine();

            //Trijų skaičių suma
            Console.Write("Iveskite skaičių x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite skaičių y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Iveskite skaičių z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{x} + {y} + {z} = {x + y + z}");
            Console.WriteLine();
        }
    }
}
