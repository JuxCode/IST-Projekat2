using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operater.ServiceOperater;

namespace Operater
{
    public partial class LoginForm : Form
    {
        ServiceOperaterClient Client;

        public LoginForm()
        {
            InitializeComponent();
            Client = new ServiceOperaterClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "operater") && (textBox2.Text == "operater")){
                if (Client.login(textBox1.Text, textBox2.Text) != null)
                {
                    Form1 forma = new Form1();
                    forma.Show();
                }
                else
                {
                    MessageBox.Show("Ne postoji operater");
                }
            }
            else
            {
                MessageBox.Show("Neispravan operaterski login");
            }
        }
    }
}
