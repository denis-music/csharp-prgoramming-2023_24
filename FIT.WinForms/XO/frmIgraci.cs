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
    public partial class frmIgraci : Form
    {
        public string ImeIgraca1 { get; set; }
        public string ImeIgraca2 { get; set; }


        public frmIgraci()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtIgrac1.Text != "" && txtIgrac2.Text != "")
            {
                ImeIgraca1 = txtIgrac1.Text;
                ImeIgraca2 = txtIgrac2.Text;
                Close();
            }

        }
    }
}
