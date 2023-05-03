using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lietuviškų raidžių rodymas console lange
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /* 1. Vartotojui įvesti 5 pažymius vienoje eilutėje, atskiriant tarpu. Rasti didžiausią pažymį.
             * 2. Vartotojui įvesti 5 pažymius vienoje eilutėje, atskiriant kableliu. Rasti mažiausią pažymį.
             */

            Console.Write("Iveskite 5 pazymius: ");
            int kiekis = 5;
            int[] masyvas = new int[kiekis];
            Console.WriteLine();

            int maxpazymys = masyvas[0];
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write("iveskite pazymi: ");
                masyvas[i] = Convert.ToInt32(Console.ReadLine());
                if (masyvas[i] > maxpazymys)
                    maxpazymys = masyvas[i];
            }
            foreach (int pazymys in masyvas)
            {
                Console.Write(pazymys + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Didziausias pazymys: {maxpazymys}");
            Console.WriteLine();

            int minpazymys = masyvas[0];
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.Write("iveskite pazymi: ");
                masyvas[i] = Convert.ToInt32(Console.ReadLine());
                if (masyvas[i] < minpazymys)
                    minpazymys = masyvas[i];
            }
            for (int i = 0; i < masyvas.Length-1; i++)
            {
                Console.Write(masyvas[i] + ", ");
            }
            Console.Write(masyvas.Last());
            Console.WriteLine();
            Console.WriteLine($"Zemiausias pazymys: {minpazymys}");
            Console.WriteLine();
        }
    }
}
