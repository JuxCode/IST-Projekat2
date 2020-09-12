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
    public partial class LoginForm : Form
    {
        Service1Client Client;

        public LoginForm()
        {
            InitializeComponent();
            Client = new Service1Client();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((textBox1.Text == "admin") && (textBox2.Text == "admin")) || ((textBox1.Text == "operater") && (textBox2.Text == "operater")))
            {
                MessageBox.Show("Nedozvoljen pristup");
            }
            else
            {
                if (Client.login(textBox1.Text, textBox2.Text) != null)
                {
                    Form1 forma = new Form1();
                    forma.Show();
                }
                else
                {
                    MessageBox.Show("Nepoznat korisnik");
                }
            }
        }
    }
}
