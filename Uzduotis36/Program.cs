using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
             */
       
        class Mokinys
        {
            public string vardas;
            public string pavarde;
            public int amzius;
            public string klase;
            public int[] pazymiai;
            private List<int> pazymiai1;

            public Mokinys(string vardas, string pavarde, int amzius, string klase, int[] pazymiai)
            {
                this.vardas = vardas;
                this.pavarde = pavarde;
                this.amzius = amzius;
                this.klase = klase;
                this.pazymiai = pazymiai;
            }

            public Mokinys(string vardas, string pavarde, int amzius, string klase, List<int> pazymiai1)
            {
                this.vardas = vardas;
                this.pavarde = pavarde;
                this.amzius = amzius;
                this.klase = klase;
                this.pazymiai1 = pazymiai1;
            }

            public void Isvedimas()
            {
                Console.WriteLine("Vardas: " + vardas);
                Console.WriteLine("Pavarde: " + pavarde);
                Console.WriteLine("Amzius: " + amzius);
                Console.WriteLine("Klase: " + klase);
                Console.WriteLine("Pazymiai: ");
                foreach (int a in pazymiai)
                {
                    Console.WriteLine(a);
                }
            }
            static void Main(string[] args)
            {
                List<Mokinys> mokiniai = new List<Mokinys>();

                for (int i = 1; i <= 3; i++)
                {
                    Console.Write("Iveskite varda: ");
                    string vardas = Console.ReadLine();
                    Console.Write("Iveskite pavarde: ");
                    string pavarde = Console.ReadLine();
                    Console.Write("Iveskite amziu: ");
                    int amzius = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Iveskite klase: ");
                    string klase = Console.ReadLine();
                    Console.Write("Iveskite pazymius: ");
                    List<int> pazymiai = new List<int>();
                    for (int x = 1; x <= 5; x++)
                    {
                        Console.Write("Iveskite pazymi " + x + ": ");
                        int pazymys = Convert.ToInt32(Console.ReadLine());
                        pazymiai.Add(pazymys);
                    }
                    Mokinys mokinys = new Mokinys(vardas, pavarde, amzius, klase, pazymiai);
                    mokiniai.Add(mokinys);
                }
                // Deja, normaliai isvesti i ekrana visu mokiniu duomenu, kad atrodytu graziai ir tvarkingai, man nepavyko.
            }
        }
    }
}

     