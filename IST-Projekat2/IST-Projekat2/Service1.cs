using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IST_Projekat2
{
    public class Service1 : IService1, IServiceOperater, IServiceAdministrator
    {
        static List<Knjiga> knjige = new List<Knjiga>();
        static List<Porudzbina> porudzbine = new List<Porudzbina>();
        static List<Korisnik> korisnici = new List<Korisnik>();

        static Korisnik trenutniKorisnik;

        public Service1()
        {
            if (knjige.Count == 0)
            {
                dodajKnjigu("Test Autor 1", "Knjiga 1", 1000.00, 10, 5);
                dodajKnjigu("Test Autor 2", "Knjiga 2", 2000.00, 0, 1);
                dodajKnjigu("Test Autor 3", "Knjiga 3", 3000.00, 5, 19);
                dodajKnjigu("Test Autor 4", "Knjiga 4", 4000.00, 15, 14);
                dodajKnjigu("Test Autor 5", "Knjiga 5", 5000.00, 10, 6);
            }

            if (korisnici.Count == 0) {
                dodajKorisnika("admin", "admin");
                dodajKorisnika("operater", "operater");
                dodajKorisnika("test", "test");
            }

            if(porudzbine.Count == 0)
            {
                Porudzbina p = new Porudzbina { Id_knjige = 0, Id_korisnika = 2, Kolicina = 2 };
                porudzbine.Add(p);
            }
        }

        public void dodajKnjigu(string autor, string naziv, double cena, int popust, int kolicina)
        {
            Knjiga k = new Knjiga { Autor = autor, Naziv = naziv, Cena = cena, Popust = popust, Kolicina = kolicina };
            knjige.Add(k);
        }

        public ListaKnjiga vratiKnjige()
        {
            ListaKnjiga podaci = new ListaKnjiga();
            podaci.AddRange(knjige);
            return podaci;
        }

        public void obrisiKnjigu(int id)
        {
            Knjiga temp = null;
            foreach (Knjiga k in knjige)
            {
                if (k.Id_knjige == id)
                {
                    temp = k;
                }
            }
            knjige.Remove(temp);
        }

        public void izmeniKnjigu(Knjiga knjiga)
        {
            Knjiga temp = null;
            foreach (Knjiga k in knjige)
            {
                if (k.Id_knjige == knjiga.Id_knjige)
                {
                    temp = k;
                }
            }
            knjige.Remove(temp);
            knjige.Add(knjiga);
        }

        public Knjiga vratiKnjigu(int id)
        {
            foreach (Knjiga k in knjige)
                if (k.Id_knjige == id)
                {
                    return k;
                }
            return null;
        }

        public Porudzbina poruciKnjigu(int id, int kolicina)
        {
            Knjiga temp = null;
            Porudzbina p = new Porudzbina();
            bool found = false;
            foreach (Knjiga k in knjige)
            {
                if ((k.Id_knjige == id) && (k.Kolicina >= kolicina))
                {
                    temp = k;
                    temp.Kolicina = (temp.Kolicina - 1);
                    izmeniKnjigu(temp);
                    p.Id_knjige = id;
                    p.Id_korisnika = trenutniKorisnik.Id;
                    p.Kolicina = kolicina;
                    porudzbine.Add(p);
                    found = true;
                }
            }
            if (found)
            {
                return p;
            }
            else
            {
                return null;
            }
        }

        public void dodajKorisnika(string username, string password)
        {
            Korisnik k = new Korisnik { Korisnicko_ime = username, Lozinka = password };
            korisnici.Add(k);
        }

        public ListaKorisnika vratiKorisnike()
        {
            ListaKorisnika podaci = new ListaKorisnika();
            podaci.AddRange(korisnici);
            return podaci;
        }

        public void obrisiKorisnika(int id)
        {
            Korisnik temp = null;
            foreach (Korisnik k in korisnici)
            {
                if (k.Id == id)
                {
                    temp = k;
                }
            }
            korisnici.Remove(temp);
        }

        public void izmeniKorisnika(Korisnik korisnik)
        {
            Korisnik temp = null;
            foreach (Korisnik k in korisnici)
            {
                if (k.Id == korisnik.Id)
                {
                    temp = k;
                }
            }
            korisnici.Remove(temp);
            korisnici.Add(korisnik);
        }

        public Korisnik vratiKorisnika(int id)
        {
            foreach (Korisnik k in korisnici)
                if (k.Id == id)
                {
                    return k;
                }
            return null;
        }

        public Korisnik login(string username, string password)
        {
            bool valid = false;
            foreach (Korisnik k in korisnici)
            {
                if (k.Korisnicko_ime == username && k.Lozinka == password)
                {
                    trenutniKorisnik = k;
                    valid = true;
                }
            }
            if (valid)
            {
                return trenutniKorisnik;
            }
            else
            {
                return null;
            }
        }

        public ListaPorudzbina vratiPorudzbine()
        {
            ListaPorudzbina podaci = new ListaPorudzbina();
            podaci.AddRange(porudzbine);
            return podaci;
        }

        public void obrisiPorudzbinu(int id)
        {
            Porudzbina temp = null;
            foreach (Porudzbina p in porudzbine)
            {
                if (p.Id_porudzbine == id)
                {
                    temp = p;
                }
            }
            porudzbine.Remove(temp);
        }

        public Porudzbina vratiPorudzbinu(int id)
        {
            foreach (Porudzbina p in porudzbine)
                if (p.Id_porudzbine == id)
                {
                    return p;
                }
            return null;
        }
    }
}
