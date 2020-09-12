using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klijent.ServiceReference1;

namespace Klijent
{
    public partial class Form1 : Form
    {
        Service1Client Client;

        public Form1()
        {
            InitializeComponent();
            Client = new Service1Client();
        }

        private void btnPrikaziKnjige_Click(object sender, EventArgs e)
        {
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
            }
        }

        private void btnPoruci_Click(object sender, EventArgs e)
        {
            Knjiga k = Client.vratiKnjigu(int.Parse(listBox1.SelectedValue.ToString()));
            if(Client.poruciKnjigu(k.Id_knjige, int.Parse(tbPorudzbinaKolicina.Text)) != null)
            {
                MessageBox.Show("Porudzbina kreirana");
            }
            else
            {
                MessageBox.Show("Pogresan unos");
            }
        }
    }
}
