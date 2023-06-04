using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICM.Entidades.Enumeracoes;
using SICM.Entidades;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace SICM.Relatorios
{
    public partial class FrmRelDizimistas : Form
    {
        public FrmRelDizimistas(List<Dizimo> listaFomntes)
        {
            InitializeComponent();
            PreencheRelatorio(listaFomntes);
        }

        private void FrmRelDizimistas_Load(object sender, EventArgs e)
        {
           // this.reportViewer1.RefreshReport();
        }

        public void PreencheRelatorio(List<Dizimo>  listaFontes)
        {
            double totalValor = 0;
            DataTable table = new DataTable();

            table.Columns.Add("id",typeof(int));    
            table.Columns.Add("membro",typeof(string)); 
            table.Columns.Add("valor",typeof (double));
            table.Columns.Add("mes", typeof(string));
            table.Columns.Add("ano", typeof(int));

            foreach(Dizimo diz in listaFontes)
            {
                totalValor += diz.Valor;
                DataRow linha = table.NewRow();
                linha["id"] = diz.Id;
                linha["membro"] = diz.Membro.Nome;
                linha["valor"] = diz.Valor;
                ListaMeses mes1 = (ListaMeses)((diz.Mes)-1); 
                linha["mes"] = mes1.ToString();
                linha["ano"] = diz.Ano;
                table.Rows.Add(linha);  
            }

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.ReportEmbeddedResource =
                "SICM.Relatorios.rdlcFiles.RelListaDizimistas.rdlc";

            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSet1",table));

            //SETANDO PARâMETROS
            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("IGREJA", listaFontes[0].Igreja.Nome));

            ListaMeses mes = (ListaMeses)((listaFontes[0].Mes)-1);

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("MES", mes.ToString()));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("ANO", listaFontes[0].Ano.ToString()));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("NUMERO", listaFontes.Count+" Dizimistas Filtrados !"));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("TOTAL", totalValor.ToString("F2")+" R$"));

            reportViewer1.LocalReport.SetParameters(
               new ReportParameter("PERCAPITA", (totalValor/(listaFontes.Count)).ToString("F2")+" R$"));

            double dezPorCento = totalValor * 0.1;

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("DEZPORCENTO", dezPorCento.ToString("F2")+" R$"));

            this.reportViewer1.RefreshReport();              
        }
    }
}
