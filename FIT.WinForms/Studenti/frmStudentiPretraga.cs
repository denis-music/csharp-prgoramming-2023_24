using FIT.Data;
using FIT.Infrastructure;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.Studenti
{
    public partial class frmStudentiPretraga : Form
    {
        DLWMSDbContext baza = new DLWMSDbContext();

        public frmStudentiPretraga()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudentiPretraga_Load(object sender, EventArgs e)
        {
            UcitajStudente();
            //VarObj();
            //Dynamic();
            //AnonimniTipovi();
            Linq();
        }

        private void Linq()
        {
            /*
                FROM Customers
                WHERE PostalCode = postalCode             
                SELECT CustomerName, 
             */
            var ocjene = new List<int>() { 6, 8, 9, 10, 6, 8, 7 };

            var rez1 = from o in ocjene
                       where o >= 9
                       select o;

            var rez2 = from semesetar in InMemoryDb.Semestri
                       where semesetar.Aktivan == false
                       select new
                       {
                           Id = semesetar.Id,
                           Naziv = semesetar.Oznaka
                       };

            var rez3 = ocjene.Where(ocjena => ocjena >= 9).ToList();
            var rez4 = ocjene.Where(FilterOcjena1).ToList();
            var rez5 = ocjene.Where(FilterOcjena2).ToList();
        }

        public bool FilterOcjena1(int ocjena) { return ocjena >= 9; }
        public bool FilterOcjena2(int ocjena) => ocjena >= 9;



        private void AnonimniTipovi()
        {
            //var student = (Id: 1, Indeks: "IB190091", Ime: "Denis", Prezime: "Music", Semestar:2);
            var student = new dtoStudent()
            {
                Id = 1,
                Indeks = "IB190091",
                Ime = "Denis",
                Prezime = "Music",
                DatumPosljednjegPristupa = DateTime.Now,
                Semestar = 2
            };

            //var student = (1, "IB190091", "Denis", "Music");
            student.Id = 2;
            PrikaziObj(student);

            var denis = new { Id = 1, Indeks = "IB190091", Ime = "Denis", Prezime = "Music" };

        }

        private dtoStudent PrikaziObj(dtoStudent student)
        {
            return student;
        }

        private void Dynamic()
        {
            dynamic obj;
            obj = "IB190091";
            obj = new List<int>() { 6, 9, 8, 7, 5 };
            obj = 28.5;
            obj = GetObjekatSaNepostojecomMetodom();
            //PrikaziDynamic(obj);

            var expObj1 = new ExpandoObject();

            dynamic expObj = new ExpandoObject();
            expObj.Id = 1;
            expObj.Indeks = "IB190091";
            expObj.Ime = "Denis";
            expObj.Prosjek = 6.7;
            expObj.Ocjene = new List<int>() { 6, 9, 8, 5, 6, 9 };

            //IDictionary<string, object?>
            //expObj.Add("Id", 1);
            //expObj.Add("Indeks", "IB190091");
            //expObj.Add("Ime", "Denis");
            //expObj.Add("Prosjek", 6.7);
            //expObj.Add("Ocjene", new List<int>() { 6, 9, 8, 5, 6, 9 });

            foreach (var par in expObj)
            {
                MessageBox.Show($"{par.Key} -> {par.Value}");
            }




            //Kolekcija<string, int> * ocjene = new Kolekcija<string, int>();
            Dictionary<string, int> ocjene = new Dictionary<string, int>();
            ocjene.Add("IB190091", 8);
            ocjene.Add("IB190092", 6);
            ocjene.Add("IB190093", 5);

            foreach (var par in ocjene)
            {
                MessageBox.Show($"{par.Key} -> {par.Value}");
            }







        }

        private dynamic GetObjekatSaNepostojecomMetodom()
        {
            return new EksterniTip();
        }

        private void PrikaziDynamic(dynamic obj)
        {
            obj.NepostojecaMetoda();
        }

        private void VarObj()
        {
            var indeks1 = "IB190091";

            object indeks2 = "IB190091";//box
            //((string)indeks2).is//unbox

            //Osoba* osoba = new Student();
            //osoba->
            PrikaziInfo(indeks2);

        }
        private object PrikaziInfo(object obj)
        {
            throw new NotImplementedException();
        }


        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            frmStudentiNovi frmStudentiNovi = new frmStudentiNovi();
            if (frmStudentiNovi.ShowDialog() == DialogResult.OK)
                UcitajStudente();
            // frmStudentiNovi.Show();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Text = $"red -> {e.RowIndex} kolona -> {e.ColumnIndex}";
            var odabraniStudent = dgvStudenti.SelectedRows[0].DataBoundItem as Student;

            Form forma = null;

            if (dgvStudenti.CurrentCell is DataGridViewButtonCell)            
                forma = new frmStudentiPredmeti(odabraniStudent);            
            else            
                forma = new frmStudentiNovi(odabraniStudent);
            
            forma.ShowDialog();
        }
        private void UcitajStudente(List<Student> studenti = null)
        {
            var lista = baza.Studenti.Include(s => s.Semestar).Include(s=>s.Uloga).ToList();

            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti ?? lista;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            //var filter = txtFilter.Text.ToLower();

            //var rezultat = InMemoryDb.Studenti.Where(student =>
            //    student.Ime.ToLower().Contains(filter) ||
            //    student.Prezime.ToLower().Contains(filter) ||
            //    student.Indeks.ToLower().Contains(filter)).ToList();

            var rezultat = baza.Studenti.Where(FiltrirajStudente).ToList();
            UcitajStudente(rezultat);

            //var rezultat = InMemoryDb.Studenti.Where(FiltrirajStudente).ToList();
            //UcitajStudente(InMemoryDb.Studenti.Where(FiltrirajStudente).ToList());

        }
        private bool FiltrirajStudente(Student student)
        {
            var filter = txtFilter.Text.ToLower();
            return
            student.Ime.ToLower().Contains(filter) ||
            student.Prezime.ToLower().Contains(filter) ||
            student.Indeks.ToLower().Contains(filter);
        }
    }

    public class EksterniTip
    {
        public void NepostojecaMetoda()
        {
            MessageBox.Show("Hello from NepostojecaMetoda");
        }
    }
    public class dtoStudent
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Semestar { get; set; }
        public DateTime DatumPosljednjegPristupa { get; set; }
    }
}
