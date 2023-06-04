using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SICM.Relatorios
{
    public partial class FrmPrestacaoContas : Form
    {
        public FrmPrestacaoContas(double valorTotalDizimo)
        {
            InitializeComponent();
            PreencheInformacoes(valorTotalDizimo);
        }

        private void FrmPrestacaoContas_Load(object sender, EventArgs e)
        {
           // this.reportViewer1.RefreshReport();
        }

        private void PreencheInformacoes(double valor)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "SICM.Relatorios.rdlcFiles.Prestacao.rdlc";

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("valorTotalDízimo", valor.ToString("F2"))
                ) ;

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("dataHoje", DateTime.Now.ToShortDateString())); 
            reportViewer1.RefreshReport() ; 
        }
    }
}
