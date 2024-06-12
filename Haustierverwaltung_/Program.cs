using Haustier;
using System.Security.Cryptography;
namespace Haustierverwaltung_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fisch[] aquarium = new Fisch[99];

            aquarium[5] = new Guppy("Günther", "Thorsten");
            aquarium[12] = new Guppy("Harald", "Thorsten");
            aquarium[14] = new Goldfisch("Bob", "Thorsten");
            aquarium[15] = new Guppy("Reinhard", "Thorsten");
            aquarium[17] = new Goldfisch("Jessica", "Thorsten");
            aquarium[18] = new Goldfisch("Goldi", "Thorsten");
            aquarium[30] = new Guppy("Rupert", "Thorsten");
            aquarium[32] = new Guppy("Robert", "Thorsten");


            foreach (Fisch f in aquarium)
            {
                if (f != null)
                {
                    Console.WriteLine(f.Pflege());
                    Console.WriteLine(f.Schwimmen());
                }
            }

            Saeuger[] garten = new Saeuger[10];

            garten[1] = new Kaninchen("Fred", "Thorsten");
            garten[2] = new Katze("Herbert", "Thorsten");
            garten[3] = new Kaninchen("Klaus", "Thorsten");
            garten[4] = new Katze("Fridolin", "Thorsten");
            garten[5] = new Kaninchen("Horst", "Thorsten");
            garten[6] = new Katze("Pascal", "Thorsten");
            garten[7] = new Katze("Karl-Heinz", "Thorsten");
            garten[8] = new Kaninchen("Victor", "Thorsten");

            foreach (Saeuger s in garten)
            {
                if (s != null)
                {
                    Console.WriteLine(s.Pflege());
                    Console.WriteLine(s.Fortbewegen());
                }
            }

            Haustier.Haustier[][] zoo = new Haustier.Haustier[4][];

            zoo[0] = aquarium;
            zoo[2] = garten;

            foreach (Haustier.Haustier[] h in zoo)
            {
                if (h != null)
                {
                    foreach (Haustier.Haustier h1 in h)
                    {
                        if (h1 != null)
                        {
                            if (h1 is Saeuger)
                            {
                                Console.WriteLine(((Saeuger)h1).Streicheln());
                                Console.WriteLine(((Saeuger)h1).Fortbewegen());

                                Katze? k = h1 as Katze;
                                if (k is not null) Console.WriteLine(k.Fressen());

                                Kaninchen? r = h1 as Kaninchen;
                                if (r is not null) Console.WriteLine(r.Fressen());
                                
                            }
                            else if (h1 is Goldfisch)
                            {
                                Console.WriteLine(((Goldfisch)h1).Streicheln());
                            }
                            Console.WriteLine(h1.Pflege());
                            Console.WriteLine(h1.ToString());
                            
                        }
                    }
                }
            }
            Hausschwein schwein = new Hausschwein("Peppa", "Thorsten");
            Console.WriteLine(((IFleischfresser)schwein).Fressen());
            Console.WriteLine(((IPflanzenfresser)schwein).Fressen());
        }
    }
}
