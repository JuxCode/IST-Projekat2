namespace Administrator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPrikaziKnjige = new System.Windows.Forms.Button();
            this.btnPrikaziKorisnike = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbKorisniciUsername = new System.Windows.Forms.TextBox();
            this.tbKorisniciPassword = new System.Windows.Forms.TextBox();
            this.btnKorisnikIzmeni = new System.Windows.Forms.Button();
            this.btnKorisniciDodaj = new System.Windows.Forms.Button();
            this.btnKorisniciObrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKnjigeObrisi = new System.Windows.Forms.Button();
            this.btnKnjigeDodaj = new System.Windows.Forms.Button();
            this.btnKnjigeIzmeni = new System.Windows.Forms.Button();
            this.tbKnjigeNaziv = new System.Windows.Forms.TextBox();
            this.tbKnjigeAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKnjigePopust = new System.Windows.Forms.TextBox();
            this.tbKnjigeCena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKnjigeKolicina = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPorudzbineObrisi = new System.Windows.Forms.Button();
            this.tbPorudzbineIDKorisnika = new System.Windows.Forms.TextBox();
            this.tbPorudzbineIDKnjige = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPorudzbineKolicina = new System.Windows.Forms.TextBox();
            this.btnPrikaziPorudzbine = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 277);
            this.listBox1.TabIndex = 0;
            // 
            // btnPrikaziKnjige
            // 
            this.btnPrikaziKnjige.Location = new System.Drawing.Point(12, 300);
            this.btnPrikaziKnjige.Name = "btnPrikaziKnjige";
            this.btnPrikaziKnjige.Size = new System.Drawing.Size(140, 40);
            this.btnPrikaziKnjige.TabIndex = 1;
            this.btnPrikaziKnjige.Text = "Prikazi knjige";
            this.btnPrikaziKnjige.UseVisualStyleBackColor = true;
            this.btnPrikaziKnjige.Click += new System.EventHandler(this.btnPrikaziKnjige_Click);
            // 
            // btnPrikaziKorisnike
            // 
            this.btnPrikaziKorisnike.Location = new System.Drawing.Point(12, 346);
            this.btnPrikaziKorisnike.Name = "btnPrikaziKorisnike";
            this.btnPrikaziKorisnike.Size = new System.Drawing.Size(140, 40);
            this.btnPrikaziKorisnike.TabIndex = 2;
            this.btnPrikaziKorisnike.Text = "Prikazi korisnike";
            this.btnPrikaziKorisnike.UseVisualStyleBackColor = true;
            this.btnPrikaziKorisnike.Click += new System.EventHandler(this.btnPrikaziKorisnike_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnKorisniciObrisi);
            this.groupBox1.Controls.Add(this.btnKorisniciDodaj);
            this.groupBox1.Controls.Add(this.btnKorisnikIzmeni);
            this.groupBox1.Controls.Add(this.tbKorisniciPassword);
            this.groupBox1.Controls.Add(this.tbKorisniciUsername);
            this.groupBox1.Location = new System.Drawing.Point(481, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnici";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbKnjigeKolicina);
            this.groupBox2.Controls.Add(this.tbKnjigeNaziv);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbKnjigeAutor);
            this.groupBox2.Controls.Add(this.tbKnjigePopust);
            this.groupBox2.Controls.Add(this.btnKnjigeObrisi);
            this.groupBox2.Controls.Add(this.tbKnjigeCena);
            this.groupBox2.Controls.Add(this.btnKnjigeIzmeni);
            this.groupBox2.Controls.Add(this.btnKnjigeDodaj);
            this.groupBox2.Location = new System.Drawing.Point(239, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 426);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Knjige";
            // 
            // tbKorisniciUsername
            // 
            this.tbKorisniciUsername.Location = new System.Drawing.Point(6, 47);
            this.tbKorisniciUsername.Name = "tbKorisniciUsername";
            this.tbKorisniciUsername.Size = new System.Drawing.Size(159, 20);
            this.tbKorisniciUsername.TabIndex = 0;
            // 
            // tbKorisniciPassword
            // 
            this.tbKorisniciPassword.Location = new System.Drawing.Point(6, 98);
            this.tbKorisniciPassword.Name = "tbKorisniciPassword";
            this.tbKorisniciPassword.Size = new System.Drawing.Size(159, 20);
            this.tbKorisniciPassword.TabIndex = 1;
            // 
            // btnKorisnikIzmeni
            // 
            this.btnKorisnikIzmeni.Location = new System.Drawing.Point(6, 306);
            this.btnKorisnikIzmeni.Name = "btnKorisnikIzmeni";
            this.btnKorisnikIzmeni.Size = new System.Drawing.Size(112, 34);
            this.btnKorisnikIzmeni.TabIndex = 3;
            this.btnKorisnikIzmeni.Text = "Izmeni";
            this.btnKorisnikIzmeni.UseVisualStyleBackColor = true;
            this.btnKorisnikIzmeni.Click += new System.EventHandler(this.btnKorisnikIzmeni_Click);
            // 
            // btnKorisniciDodaj
            // 
            this.btnKorisniciDodaj.Location = new System.Drawing.Point(6, 346);
            this.btnKorisniciDodaj.Name = "btnKorisniciDodaj";
            this.btnKorisniciDodaj.Size = new System.Drawing.Size(112, 34);
            this.btnKorisniciDodaj.TabIndex = 4;
            this.btnKorisniciDodaj.Text = "Dodaj";
            this.btnKorisniciDodaj.UseVisualStyleBackColor = true;
            this.btnKorisniciDodaj.Click += new System.EventHandler(this.btnKorisniciDodaj_Click);
            // 
            // btnKorisniciObrisi
            // 
            this.btnKorisniciObrisi.Location = new System.Drawing.Point(6, 386);
            this.btnKorisniciObrisi.Name = "btnKorisniciObrisi";
            this.btnKorisniciObrisi.Size = new System.Drawing.Size(112, 34);
            this.btnKorisniciObrisi.TabIndex = 5;
            this.btnKorisniciObrisi.Text = "Obrisi";
            this.btnKorisniciObrisi.UseVisualStyleBackColor = true;
            this.btnKorisniciObrisi.Click += new System.EventHandler(this.btnKorisniciObrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Korisnicko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Naziv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Autor";
            // 
            // btnKnjigeObrisi
            // 
            this.btnKnjigeObrisi.Location = new System.Drawing.Point(6, 386);
            this.btnKnjigeObrisi.Name = "btnKnjigeObrisi";
            this.btnKnjigeObrisi.Size = new System.Drawing.Size(112, 34);
            this.btnKnjigeObrisi.TabIndex = 12;
            this.btnKnjigeObrisi.Text = "Obrisi";
            this.btnKnjigeObrisi.UseVisualStyleBackColor = true;
            this.btnKnjigeObrisi.Click += new System.EventHandler(this.btnKnjigeObrisi_Click);
            // 
            // btnKnjigeDodaj
            // 
            this.btnKnjigeDodaj.Location = new System.Drawing.Point(6, 346);
            this.btnKnjigeDodaj.Name = "btnKnjigeDodaj";
            this.btnKnjigeDodaj.Size = new System.Drawing.Size(112, 34);
            this.btnKnjigeDodaj.TabIndex = 11;
            this.btnKnjigeDodaj.Text = "Dodaj";
            this.btnKnjigeDodaj.UseVisualStyleBackColor = true;
            this.btnKnjigeDodaj.Click += new System.EventHandler(this.btnKnjigeDodaj_Click);
            // 
            // btnKnjigeIzmeni
            // 
            this.btnKnjigeIzmeni.Location = new System.Drawing.Point(6, 306);
            this.btnKnjigeIzmeni.Name = "btnKnjigeIzmeni";
            this.btnKnjigeIzmeni.Size = new System.Drawing.Size(112, 34);
            this.btnKnjigeIzmeni.TabIndex = 10;
            this.btnKnjigeIzmeni.Text = "Izmeni";
            this.btnKnjigeIzmeni.UseVisualStyleBackColor = true;
            this.btnKnjigeIzmeni.Click += new System.EventHandler(this.btnKnjigeIzmeni_Click);
            // 
            // tbKnjigeNaziv
            // 
            this.tbKnjigeNaziv.Location = new System.Drawing.Point(6, 98);
            this.tbKnjigeNaziv.Name = "tbKnjigeNaziv";
            this.tbKnjigeNaziv.Size = new System.Drawing.Size(159, 20);
            this.tbKnjigeNaziv.TabIndex = 9;
            // 
            // tbKnjigeAutor
            // 
            this.tbKnjigeAutor.Location = new System.Drawing.Point(6, 47);
            this.tbKnjigeAutor.Name = "tbKnjigeAutor";
            this.tbKnjigeAutor.Size = new System.Drawing.Size(159, 20);
            this.tbKnjigeAutor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Popust";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cena";
            // 
            // tbKnjigePopust
            // 
            this.tbKnjigePopust.Location = new System.Drawing.Point(6, 196);
            this.tbKnjigePopust.Name = "tbKnjigePopust";
            this.tbKnjigePopust.Size = new System.Drawing.Size(159, 20);
            this.tbKnjigePopust.TabIndex = 9;
            // 
            // tbKnjigeCena
            // 
            this.tbKnjigeCena.Location = new System.Drawing.Point(6, 145);
            this.tbKnjigeCena.Name = "tbKnjigeCena";
            this.tbKnjigeCena.Size = new System.Drawing.Size(159, 20);
            this.tbKnjigeCena.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kolicina";
            // 
            // tbKnjigeKolicina
            // 
            this.tbKnjigeKolicina.Location = new System.Drawing.Point(6, 245);
            this.tbKnjigeKolicina.Name = "tbKnjigeKolicina";
            this.tbKnjigeKolicina.Size = new System.Drawing.Size(159, 20);
            this.tbKnjigeKolicina.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbPorudzbineKolicina);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnPorudzbineObrisi);
            this.groupBox3.Controls.Add(this.tbPorudzbineIDKorisnika);
            this.groupBox3.Controls.Add(this.tbPorudzbineIDKnjige);
            this.groupBox3.Location = new System.Drawing.Point(725, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 426);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Porudzbine";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "ID Korisnika";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "ID Knjige";
            // 
            // btnPorudzbineObrisi
            // 
            this.btnPorudzbineObrisi.Location = new System.Drawing.Point(6, 386);
            this.btnPorudzbineObrisi.Name = "btnPorudzbineObrisi";
            this.btnPorudzbineObrisi.Size = new System.Drawing.Size(112, 34);
            this.btnPorudzbineObrisi.TabIndex = 5;
            this.btnPorudzbineObrisi.Text = "Obrisi";
            this.btnPorudzbineObrisi.UseVisualStyleBackColor = true;
            this.btnPorudzbineObrisi.Click += new System.EventHandler(this.btnPorudzbineObrisi_Click);
            // 
            // tbPorudzbineIDKorisnika
            // 
            this.tbPorudzbineIDKorisnika.Location = new System.Drawing.Point(6, 98);
            this.tbPorudzbineIDKorisnika.Name = "tbPorudzbineIDKorisnika";
            this.tbPorudzbineIDKorisnika.Size = new System.Drawing.Size(159, 20);
            this.tbPorudzbineIDKorisnika.TabIndex = 1;
            // 
            // tbPorudzbineIDKnjige
            // 
            this.tbPorudzbineIDKnjige.Location = new System.Drawing.Point(6, 47);
            this.tbPorudzbineIDKnjige.Name = "tbPorudzbineIDKnjige";
            this.tbPorudzbineIDKnjige.Size = new System.Drawing.Size(159, 20);
            this.tbPorudzbineIDKnjige.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Kolicina";
            // 
            // tbPorudzbineKolicina
            // 
            this.tbPorudzbineKolicina.Location = new System.Drawing.Point(6, 145);
            this.tbPorudzbineKolicina.Name = "tbPorudzbineKolicina";
            this.tbPorudzbineKolicina.Size = new System.Drawing.Size(159, 20);
            this.tbPorudzbineKolicina.TabIndex = 8;
            // 
            // btnPrikaziPorudzbine
            // 
            this.btnPrikaziPorudzbine.Location = new System.Drawing.Point(12, 392);
            this.btnPrikaziPorudzbine.Name = "btnPrikaziPorudzbine";
            this.btnPrikaziPorudzbine.Size = new System.Drawing.Size(140, 40);
            this.btnPrikaziPorudzbine.TabIndex = 9;
            this.btnPrikaziPorudzbine.Text = "Prikazi porudzbine";
            this.btnPrikaziPorudzbine.UseVisualStyleBackColor = true;
            this.btnPrikaziPorudzbine.Click += new System.EventHandler(this.btnPrikaziPorudzbine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.btnPrikaziPorudzbine);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrikaziKorisnike);
            this.Controls.Add(this.btnPrikaziKnjige);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPrikaziKnjige;
        private System.Windows.Forms.Button btnPrikaziKorisnike;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKorisniciObrisi;
        private System.Windows.Forms.Button btnKorisniciDodaj;
        private System.Windows.Forms.Button btnKorisnikIzmeni;
        private System.Windows.Forms.TextBox tbKorisniciPassword;
        private System.Windows.Forms.TextBox tbKorisniciUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKnjigeNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKnjigeAutor;
        private System.Windows.Forms.Button btnKnjigeObrisi;
        private System.Windows.Forms.Button btnKnjigeIzmeni;
        private System.Windows.Forms.Button btnKnjigeDodaj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbKnjigeKolicina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbKnjigePopust;
        private System.Windows.Forms.TextBox tbKnjigeCena;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPorudzbineObrisi;
        private System.Windows.Forms.TextBox tbPorudzbineIDKorisnika;
        private System.Windows.Forms.TextBox tbPorudzbineIDKnjige;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPorudzbineKolicina;
        private System.Windows.Forms.Button btnPrikaziPorudzbine;
    }
}

