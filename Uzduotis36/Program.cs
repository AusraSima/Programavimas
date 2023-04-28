using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Uzduotis36
{
    internal class Program
    {
        /* 1.Sukurti klase Mokinys su kintamaisiais: vardas, pavarde, amzius, klase ir pazymiu sarasa, 
         * kur saugosime 5 pazymius.
         * 2.Sukurti konstruktoriu, kad priskirtu reiksmes.
         * 3.Klases viduje sukurti metoda, kad isvestu visa informacija apie mokini.
         * 4.Sukurti 3 objektus, jiems priskiti reiksmes ir naudojant sukurta metoda isvesti kiekvieno 
         * mokinio informacija.
         * 
         * Uzduoties 36 papildymas:
         * 1.Klases viduje sukurti void tipo metoda, kuris isvestu i ekrana uz kiek metu mokinys baigs mokykla.
         * Jei atsakymas 0, tada isvesti "Mokinys mokykla baigs siais metais". Iskviesti  metod1 Main-o viduje
         * visiems objektams.
         * 2.Main-o viduje, naudojant Saraso komandas Max() ir Min() isvesti i ekrana kiekvieno mokinio geriausia
         * ir blogiausia pazymi.
         * 3. Sukurti int tipo metoda (pagrindines klases viduje), kuriam paduosim kintamaji, kurio tipas yra Mokinys.
         * Metodas turi apskaiciuoti, kiek yra pazymiu didesniu uz 4. Isvesti sia informacija apie kiekviena mokini.
         */

        public static void Main(string[] args)
        {
            Mokinys pirmas = new Mokinys("Darius", "Petraitis", 7, "1B", new List<int> { 8, 9, 10, 9, 9 });
            Mokinys antras = new Mokinys("Rita", "Petraityte", 10, "4C", new List<int> { 9, 8, 9, 10, 10 });
            Mokinys trecias = new Mokinys("Saulius", "Jocas", 18, "12A", new List<int> { 7, 6, 4, 8, 7 });

            List<Mokinys> mokiniai = new List<Mokinys>() { pirmas, antras, trecias };

            foreach (Mokinys mokinys in mokiniai)
            {
                mokinys.InformacijosIsvedimas();
                mokinys.KadaBaigsMokykla();
                Console.WriteLine($"Mokinio {mokinys.vardas} geriausias pažymys: {mokinys.pazymiai.Max()}");
                Console.WriteLine($"Mokinio {mokinys.vardas} blogiausias pažymys: {mokinys.pazymiai.Min()}");
                Console.WriteLine($"Mokinio {mokinys.vardas} teigiamų pažymių kiekis: {TeigiamuPazymiuKiekis(mokinys)}");
                Console.WriteLine();
            }
            int TeigiamuPazymiuKiekis(Mokinys mokinys)
            {
                int kiekis = 0;

                foreach (int pazymys in mokinys.pazymiai)
                {
                    if (pazymys > 4)
                    {
                        kiekis++;
                    }
                }
                return kiekis;
            }
        }
        public class Mokinys
        {
            public string vardas;
            public string pavarde;
            public int amzius;
            public string klase;
            public List<int> pazymiai;
            internal Mokinys(string vardas, string pavarde, int amzius, string klase, List<int> pazymiai)
            {
                this.vardas = vardas;
                this.pavarde = pavarde;
                this.amzius = amzius;
                this.klase = klase;
                this.pazymiai = pazymiai;

            }
            public void InformacijosIsvedimas()
            {
                Console.Write("Mokinys: ");
                Console.Write($"{vardas} ");
                Console.Write($"{pavarde}, ");
                Console.Write($"{amzius} m., ");
                Console.Write($"klase {klase}, ");
                Console.Write($"pažymiai: ");
                for (int i = 0; i < pazymiai.Count; i++)
                {
                    Console.Write(pazymiai[i]);

                    if (i != pazymiai.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            public void KadaBaigsMokykla()
            {
                string klasesSkaiciausIstraukimas = klase.Substring(0, klase.Length - 1);
                int klasesNumeris = int.Parse(klasesSkaiciausIstraukimas);
                int rezultatas = 12 - klasesNumeris;

                if (rezultatas > 0)
                {
                    Console.WriteLine($"Mokinys baigs mokykla po {rezultatas} metu");
                }
                else
                {
                    Console.WriteLine("Mokinys mokykla baigs siais metais");
                }
            }
            private static int TeigiamuPazymiuKiekis(Mokinys mokinys)
            {
                int kiekis = 0;

                foreach (int pazymys in mokinys.pazymiai)
                {
                    if (pazymys > 4)
                    {
                        kiekis++;
                    }
                }
                return kiekis;
            }

        }
    }
}
    
 
    