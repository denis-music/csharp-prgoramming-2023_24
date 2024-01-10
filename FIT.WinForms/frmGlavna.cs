using FIT.WinForms.Helpers;
using FIT.WinForms.Studenti;

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
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {
            PrikaziKorisnika();
        }

        private void PrikaziKorisnika()
        {
            tslImePrezime.Text = Aplikacija.PrijavljeniKorisnik.ToString();
        }

        private void krajRadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void noviStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var forma = new frmStudentiNovi();
            //forma.MdiParent = this;
            //forma.Show();
            PrikaziFormu(new frmStudentiNovi());

        }

        private void pretragaStudenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var forma = new frmStudentiPretraga();
            //forma.MdiParent = this;
            //forma.Show();
            PrikaziFormu(new frmStudentiPretraga());

        }

        private void PrikaziFormu(Form forma)
        {
            forma.MdiParent = this;
            forma.Show();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslDatumVrijeme.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void xOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmXO());
        }

        private void pomoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmOProgramu());
        }
    }
}
