using EvidencijaUcenika;
using System;
using System.Collections.Generic;

namespace EvidencijaUcenika
{
    public class Ucenik
    {
        string _ime, _prezime;
        List<int> _ocjene = new List<int>();

        public Ucenik()
        {
            Console.Write("Unesi ime učenika: ");
            _ime = Console.ReadLine();

            Console.Write("Unesi prezime učenika: ");
            _prezime = Console.ReadLine();

            Console.Write("Unesi broj ocjena: ");
            int brojOcjena = int.Parse(Console.ReadLine());

            for (int i = 0; i < brojOcjena; i++)
            {
                Console.Write("Unesi ocjenu {0}: ", i + 1);
                int ocjena = int.Parse(Console.ReadLine());
                _ocjene.Add(ocjena);
            }
        }

        public double Prosjek()
        {
            if (_ocjene.Count == 0) return 0;

            double suma = 0;
            foreach (int o in _ocjene)
                suma += o;

            return suma / _ocjene.Count;
        }

        public void Ispis()
        {
            Console.WriteLine("{0} {1} - Prosjek: {2:F2}", _ime, _prezime, Prosjek());
        }

        public string Ime
        {
            get { return _ime; }
        }

        public string Prezime
        {
            get { return _prezime; }
        }
    }
}
