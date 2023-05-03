using System;

namespace Uzduotis05
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Atitmetiniai veiksmai
            int a = 8;
            int b = 4;
            
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine();

            //Kvadratas ir kubas
            int x = 5;
            int y = 2;
            int z = 3;

            Console.WriteLine($"{x} kvadtatu yra {Math.Pow(x, y)}");
            Console.WriteLine($"{x} kubu yra {Math.Pow(x, z)}");
            Console.WriteLine();

            //Triju skaiciu sandauga
            Console.WriteLine($"{x} * {y} * {z} = {x * y * z}");
        }
    }
}
