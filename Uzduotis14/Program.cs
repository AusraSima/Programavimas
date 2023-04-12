using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sunumeruotu pasirinkimu tikrinimas su komanda switch
            Console.WriteLine("1 - stacionarus kompiuteris");
            Console.WriteLine("2 - nesiojamas kompiuteris");
            Console.WriteLine("3 - plansete");
            Console.Write("Iveskite pasirinkimo numeri: ");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            switch (pasirinkimas) 
            { 
            case 1:
                    Console.WriteLine("Stacionariu kompiuteriu galite naudotis tik namuose arba darbo vietoje");
                    break;
            case 2:
                    Console.WriteLine("Nesiojamuoju kompiuteriu galite naudotis visur");
                    break;
            case 3:
                    Console.WriteLine("Plansete galite naudotis visur");
                    break;
            default:
                    Console.WriteLine("Tokio pasirinkimo nera");
                    break;
            }
        }
    }
}
