using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms
{
    public partial class frmXO : Form
    {
        public frmXO()
        {
            InitializeComponent();
        }

        public int Brojac { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);
        }

        private void RegistrujPotez(object sender)
        {
            if (sender is Button)
            {
                var button = sender as Button;
                if (button.Text == "")
                {
                    button.Text = (Brojac % 2 == 0) ? "X" : "O";

                    if (KrajIgre())
                    {
                        MessageBox.Show("Pobjeda :)");
                        PostaviStanjeDugmica(false);
                    }
                    Brojac++;
                    lblNaredniIGrac.Text = (Brojac % 2 == 0) ? ImeIgraca1 : ImeIgraca2;
                }
                else
                    SystemSounds.Beep.Play();
            }
        }

        private void PostaviStanjeDugmica(bool omogucen, bool promijeniTekst = false, bool promijeniPozadinu = false)
        {
            foreach (var kontrola in Controls)
            {
                if (kontrola is Button && kontrola != btnNovaIgra)
                {
                    var button = kontrola as Button;
                    button.Enabled = omogucen;
                    if (promijeniPozadinu)
                        button.UseVisualStyleBackColor = true;
                    if (promijeniTekst)
                        button.Text = "";
                }
            }
            Brojac = 0;
        }

        private bool KrajIgre()
        {
            return ProvjeriRedove() || ProvjeriKolone() || ProvjeriDijagonale();
        }

        private bool ProvjeriDijagonale()
        {
            return ProvjeriPobjedu(button1, button5, button9) ||
                    ProvjeriPobjedu(button3, button5, button7);
        }

        private bool ProvjeriKolone()
        {
            return ProvjeriPobjedu(button1, button4, button7) ||
                   ProvjeriPobjedu(button2, button5, button8) ||
                   ProvjeriPobjedu(button3, button6, button9);
        }

        private bool ProvjeriRedove()
        {
            return ProvjeriPobjedu(button1, button2, button3) ||
                    ProvjeriPobjedu(button4, button5, button6) ||
                    ProvjeriPobjedu(button7, button8, button9);
        }

        private bool ProvjeriPobjedu(Button btn1, Button btn2, Button btn3)
        {
            var pobjeda = btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text;
            if (pobjeda)
                btn1.BackColor = btn2.BackColor = btn3.BackColor = Color.BlueViolet;
            return pobjeda;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }
        public string ImeIgraca1 { get; set; }
        public string ImeIgraca2 { get; set; }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {

            PripremiIgru();
        }

        private void PripremiIgru()
        {
            PostaviStanjeDugmica(true, true, true);
            var igraci = new frmIgraci();
            igraci.ShowDialog();
            ImeIgraca1 = igraci.ImeIgraca1;
            ImeIgraca2 = igraci.ImeIgraca2;
        }

        private void frmXO_Load(object sender, EventArgs e)
        {
            PripremiIgru();
        }
    }
}
