using FIT.Data;
using FIT.Infrastructure;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.Predmeti
{
    public partial class frmPredmeti : Form
    {

        DLWMSDbContext baza = new DLWMSDbContext();

        public frmPredmeti()
        {
            InitializeComponent();
            dgvPredmeti.AutoGenerateColumns = false;
        }

        private void frmPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            dgvPredmeti.DataSource = null;
            dgvPredmeti.DataSource = baza.Predmeti.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var noviPredmet = new Predmet()
            {
                Naziv = txtNaziv.Text,
                Semestar = int.Parse(cmbSemestar.Text)
            };
            baza.Predmeti.Add(noviPredmet);
            baza.SaveChanges();
            UcitajPredmete();
        }
    }
}
