using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.Predavanja
{
    public class Recenzije
    {
        int[] ocjene = new int[] { 6, 8, 9, 6, 8 };
        public IEnumerator GetEnumerator()
        {
            //for (int i = 0; i < ocjene.Length; i++)   //1           
            //    yield return ocjene[i];

            yield return ocjene[0];
            yield return ocjene[1];
            yield return ocjene[2];
            yield return ocjene[3];
            yield return ocjene[4];
        }
    }

    public partial class frmMarketing : Form
    {
        private void Yield()
        {
            
            Recenzije recenzije = new Recenzije();
            foreach (var ocjena in recenzije)
            { } 
        }


        // delegate void marketing(string poruka);


        int Test(int a) {  return 0; }

        bool Filtiraj( int broj) { return broj >= 8; }

        private void button1_Click(object sender, EventArgs e)
        {
            Yield();
            //Func<int, int> func = Test;
            //Func<int, bool> filter = Filtiraj;

            //int[] niz = new int[] { 6, 8, 9, 6, 8 };
            //var rezultat = niz.Where(clanNiza => clanNiza >= 8);//8 9 8 

            //niz.Where(filter);
            ////EVENT ili DOGADJAJ
            ////int(*niz[2])(int);
            //List<Func<int, bool>> dogadjaj = new List<Func<int, bool>>();
            //dogadjaj.Add(Filtiraj);

            //SMSMarketing?.Invoke(txtPoruka.Text);
        }

       




        //DELEGAT
        //int (* potpisFunkcije) (int)
        delegate int potpisFunkcije(int broj);
        delegate void marketing(string poruka);

        //EVENT ili DOGADJAJ
        //int (* niz[2])(int);
        event potpisFunkcije MatOperacija;
        event marketing SMSMarketing;

        int Kvadriraj(int broj)
        {
            var rez = broj * broj;
            MessageBox.Show(rez.ToString());
            return rez;
        }
        int Kubiraj(int broj)
        {
            var rez = broj * broj * broj;
            MessageBox.Show(rez.ToString());
            return rez;
        }

        void BHTelecom(string poruka)
        {
            MessageBox.Show($"BHTelecom -> {poruka}");
        }
        void HTEronet(string poruka)
        {
            MessageBox.Show($"HTEronet -> {poruka}");
        }
        void mTel(string poruka)
        {
            MessageBox.Show($"mTel -> {poruka}");
        }

        public frmMarketing()
        {
            InitializeComponent();

            MatOperacija += Kvadriraj;
            MatOperacija += Kubiraj;

        }

       

        private void cbBHTelecom_CheckedChanged(object sender, EventArgs e)
        {
            PretplatiMetodu(sender, BHTelecom);
        }
        private void PretplatiMetodu(object sender, marketing metoda)
        {
            if ((sender as CheckBox).Checked)
                SMSMarketing += metoda;
            else
                SMSMarketing -= metoda;
        }

        private void cbHTEronet_CheckedChanged(object sender, EventArgs e)
        {
            PretplatiMetodu(sender, HTEronet);
        }

        private void cbMTel_CheckedChanged(object sender, EventArgs e)
        {
            PretplatiMetodu(sender, mTel);
        }
    }
}
