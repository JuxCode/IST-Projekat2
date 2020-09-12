using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IST_Projekat2
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        ListaKnjiga vratiKnjige();

        [OperationContract]
        Knjiga vratiKnjigu(int id);

        [OperationContract]
        Porudzbina poruciKnjigu(int id, int kolicina);

        [OperationContract]
        Korisnik login(string username, string password);
    }

    [ServiceContract]
    public interface IServiceOperater : IService1
    {
        [OperationContract]
        void dodajKnjigu(string autor, string naziv, double cena, int popust, int kolicina);

        [OperationContract]
        void izmeniKnjigu(Knjiga knjiga);

        [OperationContract]
        void dodajKorisnika(string username, string password);

        [OperationContract]
        ListaKorisnika vratiKorisnike();

        [OperationContract]
        void izmeniKorisnika(Korisnik korisnik);

        [OperationContract]
        Korisnik vratiKorisnika(int id);

        [OperationContract]
        ListaPorudzbina vratiPorudzbine();

        [OperationContract]
        Porudzbina vratiPorudzbinu(int id);
    }

    [ServiceContract]
    public interface IServiceAdministrator : IServiceOperater
    {
        [OperationContract]
        void obrisiKnjigu(int id);

        [OperationContract]
        void obrisiKorisnika(int id);

        [OperationContract]
        void obrisiPorudzbinu(int id);
    }

    [DataContract]
    public class Korisnik
    {
        static int id_korisnik = 0;
        private int id;
        private string korisnicko_ime;
        private string lozinka;

        public Korisnik()
        {
            id = id_korisnik++;
        }

        [DataMember]
        public int Id { get { return id; } set { id = value; } }
        [DataMember]
        public string Korisnicko_ime { get { return korisnicko_ime; } set { korisnicko_ime = value; } }
        [DataMember]
        public string Lozinka { get { return lozinka; } set { lozinka = value; } }
    }

    [DataContract]
    public class Knjiga
    {
        static int id_knjiga = 0;
        private int id_knjige;
        private string autor;
        private string naziv;
        private double cena;
        private int popust;
        private int kolicina;

        public Knjiga()
        {
            id_knjige = id_knjiga++;
        }

        [DataMember]
        public int Id_knjige { get { return id_knjige; } set { id_knjige = value; } }
        [DataMember]
        public string Autor { get { return autor; } set { autor = value; } }
        [DataMember]
        public string Naziv { get { return naziv; } set { naziv = value; } }
        [DataMember]
        public double Cena { get { return cena; } set { cena = value; } }
        [DataMember]
        public int Popust { get { return popust; } set { popust = value; } }
        [DataMember]
        public int Kolicina { get { return kolicina; } set { kolicina = value; } }
    }

    [DataContract]
    public class Porudzbina
    {
        static int id_porudzbina = 0;
        private int id_porudzbine;
        private int id_knjige;
        private int id_korisnika;
        private int kolicina;

        public Porudzbina()
        {
            id_porudzbine = id_porudzbina++;
        }

        [DataMember]
        public int Id_porudzbine { get { return id_porudzbine; } set { id_porudzbine = value; } }
        [DataMember]
        public int Id_knjige { get { return id_knjige; } set { id_knjige = value; } }
        [DataMember]
        public int Id_korisnika { get { return id_korisnika; } set { id_korisnika = value; } }
        [DataMember]
        public int Kolicina { get { return kolicina; } set { kolicina = value; } }
    }

    [CollectionDataContract]
    public class ListaKnjiga : List<Knjiga> { }

    [CollectionDataContract]
    public class ListaPorudzbina : List<Porudzbina> { }

    [CollectionDataContract]
    public class ListaKorisnika : List<Korisnik> { }
}
