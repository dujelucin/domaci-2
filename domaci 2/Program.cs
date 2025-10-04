using System;
using System.Collections.Generic;

namespace EvidencijaUcenika
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> lstUcenici = new List<Ucenik>();

            RadSUcenicima.Unos(lstUcenici);

            Console.WriteLine("\n--- Svi učenici ---");
            RadSUcenicima.Ispis(lstUcenici);

            double prosjek = RadSUcenicima.ProsjekRazreda(lstUcenici);
            Console.WriteLine("\nProsjek razreda: {0:F2}", prosjek);

            Console.WriteLine("\n--- Brisanje učenika ---");
            RadSUcenicima.Brisanje(lstUcenici);

            Console.WriteLine("\n--- Lista nakon brisanja ---");
            RadSUcenicima.Ispis(lstUcenici);

            RadSUcenicima.IznadProsjeka(lstUcenici);

            Console.ReadKey();
        }
    }
}