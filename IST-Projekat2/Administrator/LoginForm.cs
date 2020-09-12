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
    public partial class LoginForm : Form
    {
        ServiceAdministratorClient Client;

        public LoginForm()
        {
            InitializeComponent();
            Client = new ServiceAdministratorClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "admin") && (textBox2.Text == "admin")){
                if (Client.login(textBox1.Text, textBox2.Text) != null)
                {
                    Form1 forma = new Form1();
                    forma.Show();
                }
                else
                {
                    MessageBox.Show("Ne postoji administrator");
                }
            }
            else
            {
                MessageBox.Show("Neispravan administratorski login");
            }
        }
    }
}
