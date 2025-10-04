using System;
using System.Collections.Generic;

namespace EvidencijaUcenika
{
    public static class RadSUcenicima
    {
        public static void Unos(List<Ucenik> lstUcenici)
        {
            Console.Write("Unesi broj učenika: ");
            int br = int.Parse(Console.ReadLine());

            for (int i = 0; i < br; i++)
            {
                Ucenik u = new Ucenik();
                lstUcenici.Add(u);
            }
        }

        public static void Ispis(List<Ucenik> lstUcenici)
        {
            foreach (Ucenik u in lstUcenici)
                u.Ispis();
        }

        public static void Brisanje(List<Ucenik> lstUcenici)
        {
            Console.Write("Unesi ime učenika za brisanje: ");
            string ime = Console.ReadLine();
            Console.Write("Unesi prezime učenika za brisanje: ");
            string prezime = Console.ReadLine();

            Ucenik trazeni = null;

            foreach (Ucenik u in lstUcenici)
            {
                if (u.Ime == ime && u.Prezime == prezime)
                {
                    trazeni = u;
                    break;
                }
            }

            if (trazeni == null)
                Console.WriteLine("Učenik nije pronađen.");
            else
            {
                lstUcenici.Remove(trazeni);
                Console.WriteLine("Učenik uspješno obrisan.");
            }
        }

        public static double ProsjekRazreda(List<Ucenik> lstUcenici)
        {
            if (lstUcenici.Count == 0) return 0;

            double suma = 0;
            foreach (Ucenik u in lstUcenici)
                suma += u.Prosjek();

            return suma / lstUcenici.Count;
        }

        public static void IznadProsjeka(List<Ucenik> lstUcenici)
        {
            double prosjekRazreda = ProsjekRazreda(lstUcenici);

            Console.WriteLine("\nUčenici iznad prosjeka ({0:F2}):", prosjekRazreda);
            foreach (Ucenik u in lstUcenici)
            {
                if (u.Prosjek() > prosjekRazreda)
                    u.Ispis();
            }
        }
    }
}