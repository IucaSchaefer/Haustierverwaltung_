using Haustier;
using System.Security.Cryptography;
namespace Haustierverwaltung_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fisch[] aquarium = new Fisch[99];

            aquarium[5] = new Guppy("Günther");
            aquarium[12] = new Guppy("Harald");
            aquarium[14] = new Goldfisch("Bob");
            aquarium[15] = new Guppy("Reinhard");
            aquarium[17] = new Goldfisch("Jessica");
            aquarium[18] = new Goldfisch("Goldi");
            aquarium[30] = new Guppy("Rupert");
            aquarium[32] = new Guppy("Robert");


            foreach (Fisch f in aquarium)
            {
                if (f != null)
                {
                    Console.WriteLine(f.Pflege());
                    Console.WriteLine(f.Schwimmen());
                }
            }

            Saeuger[] garten = new Saeuger[10];

            garten[1] = new Kaninchen("Fred");
            garten[2] = new Katze("Herbert");
            garten[3] = new Kaninchen("Klaus");
            garten[4] = new Katze("Fridolin");
            garten[5] = new Kaninchen("Horst");
            garten[6] = new Katze("Pascal");
            garten[7] = new Katze("Karl-Heinz");
            garten[8] = new Kaninchen("Victor");

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
                            Console.WriteLine(h1.Pflege());
                            if (h1 is Saeuger)
                            {
                                Console.WriteLine(((Saeuger)h1).Fortbewegen());
                            }
                        }
                    }
                }
            }
        }
    }
}
