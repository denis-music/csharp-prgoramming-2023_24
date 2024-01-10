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

namespace FIT.WinForms
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            var korisnickoIme = txtKorisnickoIme.Text;
            var lozinka = txtLozinka.Text;

            if (ValidanUnos())
            {
                foreach (var korisnik in InMemoryDb.Korisnici)
                {
                    if (korisnickoIme == korisnik.KorisnickoIme && lozinka == korisnik.Lozinka)
                    {
                        if (korisnik.Aktivan)
                        {
                            //MessageBox.Show($"" +
                            //    $"{Resursi.Get(Kljucevi.Welcome)} {korisnik}",
                            //    Resursi.Get(Kljucevi.Info),
                            //    MessageBoxButtons.OKCancel,
                            //    MessageBoxIcon.Information);

                            Aplikacija.PrijavljeniKorisnik = korisnik;
                            this.Hide();
                            var glavnaForma = new frmGlavna();
                            if (glavnaForma.ShowDialog() == DialogResult.OK)
                                this.Show();

                        }
                        else
                            MessageBox.Show($"{korisnik}, {Resursi.Get(Kljucevi.AccountNotActive)}  ");
                        return;
                    }
                }
                MessageBox.Show($"" +
                             $"{Resursi.Get(Kljucevi.UsernameOrPasswordNotValid)}",
                             Resursi.Get(Kljucevi.Warning),
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning);
            }
        }
        private bool ValidanUnos()
        {
            return Validator.ProvjeriUnos(txtKorisnickoIme, err, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(txtLozinka, err, Kljucevi.ReqiredValue);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registracija = new frmRegistracija();
            registracija.ShowDialog();
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {

        }
    }
}
