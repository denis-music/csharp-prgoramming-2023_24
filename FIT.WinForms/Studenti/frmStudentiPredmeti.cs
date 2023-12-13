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

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FIT.WinForms.Studenti
{
    public partial class frmStudentiPredmeti : Form
    {
        private Student? student;
       

        public frmStudentiPredmeti(Student student)
        {
            InitializeComponent();
            this.student = student;
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        private void frmStudentiPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
            UcitajPolozenePredemte();
            UcitajLicnePodatke();
        }

        private void UcitajLicnePodatke()
        {
            lblIndeks.Text = $"{student.Indeks}";
            lblImePrezime.Text = $"{student.Ime} {student.Prezime}";
            pbSlika.Image = student.Slika.ToImage();

        }

        private void UcitajPredmete()
        {
            cmbPredmeti.UcitajPodatke(InMemoryDb.Predmeti);

            //cmbPredmeti.DataSource = InMemoryDb.Predmeti;
            //cmbPredmeti.DisplayMember = "Naziv";
            //cmbPredmeti.ValueMember = "Id";
        }

        private void UcitajPolozenePredemte()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = student.PolozeniPredmeti;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var predmet = cmbPredmeti.SelectedItem as Predmet;//PRI


                var predmetPostoji = student.PolozeniPredmeti.Where(polozeni =>
                                        polozeni.PredmetId == predmet.Id).Count() > 0;

                if (predmetPostoji)
                {
                    MessageBox.Show($"{Resursi.Get(Kljucevi.DuplicatedCourse)}", Resursi.Get(Kljucevi.Info),
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                    return;
                }

                //foreach (var p in student.PolozeniPredmeti)
                //{
                //    if(p.PredmetId == predmet.Id)
                //    {
                //        MessageBox.Show($"{Resursi.Get(Kljucevi.DuplicatedCourse)}", Resursi.Get(Kljucevi.Info),
                //                MessageBoxButtons.OK,
                //                MessageBoxIcon.Information);
                //        return;

                //    }
                //}



                var polozeni = new PolozeniPredmet()
                {
                    Id = student.PolozeniPredmeti.Count + 1,
                    DatumPolaganja = dtpDatumPolaganja.Value,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    Predmet = predmet,
                    PredmetId = predmet.Id
                };
                student.PolozeniPredmeti.Add(polozeni);
                UcitajPolozenePredemte();
            }

        }
        private bool ValidanUnos()
        {
            return
            Validator.ProvjeriUnos(cmbPredmeti, errorProvider1, Kljucevi.ReqiredValue) &&
                Validator.ProvjeriUnos(cmbOcjene, errorProvider1, Kljucevi.ReqiredValue);
        }
    }
}
