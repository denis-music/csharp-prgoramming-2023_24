using FIT.Data;
using FIT.WinForms.Studenti;

using Microsoft.Reporting.WinForms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private dtoPrint dtoPrint;
       
        public frmIzvjestaji(dtoPrint dtoPrint)
        {
            InitializeComponent();
            this.dtoPrint = dtoPrint;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("pBrojIndeksa", dtoPrint.BrojIndeksa));
            rpc.Add(new ReportParameter("pImePrezime", dtoPrint.ImePrezime));
            rpc.Add(new ReportParameter("pBrojDokumenta", "220-35-8/23"));
            rpc.Add(new ReportParameter("pAkademskaGodina", "2023/24"));
            rpc.Add(new ReportParameter("pStatus", "REDOVAN"));
            rpc.Add(new ReportParameter("pSvrha", "REGULISANJE STIPENDIJE"));


            //var polozeni = new dsDLWMS.PolozeniIspitiDataTable();
            //for (int i = 0; i < 10; i++)
            //{
            //    var red = polozeni.NewPolozeniIspitiRow();
            //    red.Rb = (i + 1).ToString();
            //    red.Naziv = $"Polozeni {i + 1}";
            //    red.DatumPolaganja = DateTime.Now.ToString("dd.MM.yyyy");
            //    red.Ocjena = "6";
            //    polozeni.AddPolozeniIspitiRow(red);
            //}

            var polozeni = new dsDLWMS.PolozeniIspitiDataTable();
            for (int i = 0; i < dtoPrint.PolozeniPredmeti.Count; i++)
            {
                var red = polozeni.NewPolozeniIspitiRow();
                red.Rb = (i + 1).ToString();
                red.Naziv = dtoPrint.PolozeniPredmeti[i].Predmet.Naziv;
                red.DatumPolaganja = dtoPrint.PolozeniPredmeti[i].DatumPolaganja.ToString("dd.MM.yyyy");
                red.Ocjena = dtoPrint.PolozeniPredmeti[i].Ocjena.ToString();
                polozeni.AddPolozeniIspitiRow(red);
            }


            var rds = new ReportDataSource();
            rds.Value = polozeni;
            rds.Name = "dsPolozeni";

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.RefreshReport();
        }
    }
}
