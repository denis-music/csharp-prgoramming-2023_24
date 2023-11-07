using FIT.Data;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FIT.WinForms
{
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }

        private void GenerisiPodatke()
        {
            var ime = txtIme.Text.ToLower();//Denis
            var prezime = txtPrezime.Text.ToLower();//music
            //de.music@edu.fit.ba
            txtEmail.Text = $"{ime}.{prezime}{Resursi.Get(Kljucevi.EmailDomain)}";
            txtKorisnickoIme.Text = $"{ime}.{prezime}";
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var noviKorisnik = new Korisnik()
                {
                    Id = InMemoryDb.Korisnici.Count + 1,
                    Aktivan = cbAktivan.Checked,
                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text
                };
                InMemoryDb.Korisnici.Add(noviKorisnik);
                Close();
            }
        }

        private bool ValidanUnos()
        {
            return 
                Validator.ProvjeriUnos(txtIme, errorProvider1, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(txtPrezime, errorProvider1, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(txtEmail, errorProvider1, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(txtKorisnickoIme, errorProvider1, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(txtLozinka, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}
