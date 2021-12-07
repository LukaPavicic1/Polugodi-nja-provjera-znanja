using System;

namespace PolugodišnjaProvjeraZnanja
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. (6 bodova) Napišite program koji će zatražiti od korisnika da unese tri
            dvoznamenkasta broja te će izračunati i ispisati najveći od tri broja (npr. 12,17,15 ->17).*/





            Console.WriteLine("Upisi 1. dvoznamenkasti broj: ");
            int prviBroj = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Upisi 2. dvoznamenkasti broj: ");
            int drugiBroj = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Upisi 3. dvoznamenkasti broj: ");
            int treciBroj = Convert.ToInt32(Console.ReadLine());


            if (prviBroj>drugiBroj && prviBroj > treciBroj) {

                Console.WriteLine("Najveći je prvi broj");
            }

            if (drugiBroj > prviBroj && drugiBroj > treciBroj)
            {

                Console.WriteLine("Najveći je drugi broj");
            }

            if (treciBroj > prviBroj && treciBroj > drugiBroj)
            {

                Console.WriteLine("Najveći je treci broj");
            }





        }
    }
}
