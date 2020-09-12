using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administrator.ServiceAdministrator;

namespace Administrator
{
    public partial class Form1 : Form
    {
        ServiceAdministratorClient Client;

        public Form1()
        {
            InitializeComponent();
            Client = new ServiceAdministratorClient();
        }

        private void btnPrikaziKnjige_Click(object sender, EventArgs e)
        {
            listBox1.SelectedValueChanged -= ListBox1_SelectedKnjiga;
            listBox1.SelectedValueChanged -= ListBox1_SelectedKorisnik;
            listBox1.SelectedValueChanged -= ListBox1_SelectedPorudzbina;
            if (listBox1.DataSource != null)
            {
                listBox1.DataSource = null;
            }
            listBox1.DataSource = Client.vratiKnjige();
            listBox1.DisplayMember = "naziv";
            listBox1.ValueMember = "id_knjige";
            listBox1.SelectedValueChanged += ListBox1_SelectedKnjiga;
            ListBox1_SelectedKnjiga(null, null);
        }

        private void ListBox1_SelectedKnjiga(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue != null && listBox1.DataSource != null)
            {
                Knjiga k = Client.vratiKnjigu(int.Parse(listBox1.SelectedValue.ToString()));
                tbKnjigeAutor.Text = k.Autor;
                tbKnjigeNaziv.Text = k.Naziv;
                tbKnjigeCena.Text = k.Cena.ToString();
                tbKnjigePopust.Text = k.Popust.ToString();
                tbKnjigeKolicina.Text = k.Kolicina.ToString();
            }
        }

        private void btnKnjigeIzmeni_Click(object sender, EventArgs e)
        {
            Knjiga k = Client.vratiKnjigu(int.Parse(listBox1.SelectedValue.ToString()));
            k.Autor = tbKnjigeAutor.Text;
            k.Naziv = tbKnjigeNaziv.Text;
            k.Cena = double.Parse(tbKnjigeCena.Text);
            k.Popust = int.Parse(tbKnjigePopust.Text);
            k.Kolicina = int.Parse(tbKnjigeKolicina.Text);
            Client.izmeniKnjigu(k);
            MessageBox.Show("Promenjeni podaci o knjizi");
            tbKnjigeAutor.Clear();
            tbKnjigeNaziv.Clear();
            tbKnjigeCena.Clear();
            tbKnjigePopust.Clear();
            tbKnjigeKolicina.Clear();
        }

        private void btnKnjigeDodaj_Click(object sender, EventArgs e)
        {
            Client.dodajKnjigu(tbKnjigeAutor.Text, tbKnjigeNaziv.Text, double.Parse(tbKnjigeCena.Text), int.Parse(tbKnjigePopust.Text), int.Parse(tbKnjigeKolicina.Text));
            MessageBox.Show("Knjiga dodata");
            tbKnjigeAutor.Clear();
            tbKnjigeNaziv.Clear();
            tbKnjigeCena.Clear();
            tbKnjigePopust.Clear();
            tbKnjigeKolicina.Clear();
        }

        private void btnKnjigeObrisi_Click(object sender, EventArgs e)
        {
            Client.obrisiKnjigu(int.Parse(listBox1.SelectedValue.ToString()));
            MessageBox.Show("Knjiga obrisana");
            tbKnjigeAutor.Clear();
            tbKnjigeNaziv.Clear();
            tbKnjigeCena.Clear();
            tbKnjigePopust.Clear();
            tbKnjigeKolicina.Clear();
        }

        private void btnPrikaziKorisnike_Click(object sender, EventArgs e)
        {
            listBox1.SelectedValueChanged -= ListBox1_SelectedKnjiga;
            listBox1.SelectedValueChanged -= ListBox1_SelectedKorisnik;
            listBox1.SelectedValueChanged -= ListBox1_SelectedPorudzbina;
            if (listBox1.DataSource != null)
            {
                listBox1.DataSource = null;
            }
            listBox1.DataSource = Client.vratiKorisnike();
            listBox1.DisplayMember = "korisnicko_ime";
            listBox1.ValueMember = "id";
            listBox1.SelectedValueChanged += ListBox1_SelectedKorisnik;
            ListBox1_SelectedKorisnik(null, null);
        }

        private void ListBox1_SelectedKorisnik(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue != null && listBox1.DataSource != null)
            {
                Korisnik k = Client.vratiKorisnika(int.Parse(listBox1.SelectedValue.ToString()));
                tbKorisniciUsername.Text = k.Korisnicko_ime;
                tbKorisniciPassword.Text = k.Lozinka;
            }
        }

        private void btnKorisnikIzmeni_Click(object sender, EventArgs e)
        {
            Korisnik k = Client.vratiKorisnika(int.Parse(listBox1.SelectedValue.ToString()));
            k.Korisnicko_ime = tbKorisniciUsername.Text;
            k.Lozinka = tbKorisniciPassword.Text;
            Client.izmeniKorisnika(k);
            MessageBox.Show("Promenjeni podaci o korisniku");
            tbKorisniciUsername.Clear();
            tbKorisniciPassword.Clear();
        }

        private void btnKorisniciDodaj_Click(object sender, EventArgs e)
        {
            Client.dodajKorisnika(tbKorisniciUsername.Text, tbKorisniciPassword.Text);
            MessageBox.Show("Korisnik dodat");
            tbKorisniciUsername.Clear();
            tbKorisniciPassword.Clear();
        }

        private void btnKorisniciObrisi_Click(object sender, EventArgs e)
        {
            Client.obrisiKorisnika(int.Parse(listBox1.SelectedValue.ToString()));
            MessageBox.Show("Korisnik obrisan");
            tbKorisniciUsername.Clear();
            tbKorisniciPassword.Clear();
        }

        private void btnPrikaziPorudzbine_Click(object sender, EventArgs e)
        {
            listBox1.SelectedValueChanged -= ListBox1_SelectedKnjiga;
            listBox1.SelectedValueChanged -= ListBox1_SelectedKorisnik;
            listBox1.SelectedValueChanged -= ListBox1_SelectedPorudzbina;
            if (listBox1.DataSource != null)
            {
                listBox1.DataSource = null;
            }
            listBox1.DataSource = Client.vratiPorudzbine();
            listBox1.DisplayMember = "id_porudzbine";
            listBox1.ValueMember = "id_porudzbine";
            listBox1.SelectedValueChanged += ListBox1_SelectedPorudzbina;
            ListBox1_SelectedPorudzbina(null, null);
        }

        private void ListBox1_SelectedPorudzbina(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue != null && listBox1.DataSource != null)
            {
                Porudzbina p = Client.vratiPorudzbinu(int.Parse(listBox1.SelectedValue.ToString()));
                tbPorudzbineIDKnjige.Text = p.Id_knjige.ToString();
                tbPorudzbineIDKorisnika.Text = p.Id_korisnika.ToString();
                tbPorudzbineKolicina.Text = p.Kolicina.ToString();
            }
        }

        private void btnPorudzbineObrisi_Click(object sender, EventArgs e)
        {
            Client.obrisiPorudzbinu(int.Parse(listBox1.SelectedValue.ToString()));
            MessageBox.Show("Porudzbina obrisana");
            tbPorudzbineIDKnjige.Clear();
            tbPorudzbineIDKorisnika.Clear();
            tbPorudzbineKolicina.Clear();
        }
    }
}
