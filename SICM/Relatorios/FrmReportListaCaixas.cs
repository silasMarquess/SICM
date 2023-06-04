using SICM.Entidades;
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
    public partial class FrmReportListaCaixas : Form
    {
        public FrmReportListaCaixas(List<Caixa> listaSelecionada, string mes, int ano, double entrada, double saida)
        {
            InitializeComponent();
            PreencheRelatorio(listaSelecionada, mes, ano, entrada, saida);
        }

        private void FrmReportListaCaixas_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Neste Relatorio vc tem acesso ao Resumo Geral dos CAIXAS selecionados !");
            //  this.reportViewer1.RefreshReport();
        }

        public void PreencheRelatorio(List<Caixa> fonte, string mes, int ano,double entrada, double saida)
        {
            DataTable table = new DataTable();
            table.Columns.Add("NomeCaixa", typeof(string));
            table.Columns.Add("Entrada", typeof(double));
            table.Columns.Add("Saida", typeof(double));
            table.Columns.Add("Saldo", typeof(double));

            foreach(Caixa ca in fonte)
            {
                DataRow dr = table.NewRow();
                dr["NomeCaixa"]=ca.Nome;
                dr["Entrada"] = ca.CalculaTotEntrada();
                dr["Saida"]=ca.CalculaTotSaida();
                dr["Saldo"]=ca.CalculaSaldo();
                table.Rows.Add(dr);
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "SICM.Relatorios.rdlcFiles.RelatorioGeralCaixas.rdlc";

            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSet1", table));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("dataHoje", DateTime.Now.ToShortDateString())
                );

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("MES", mes)
                );

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("ANO", ano.ToString()));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("entradaGeral", entrada.ToString("F2")+" R$")
                );

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("saidaGeral",saida.ToString("F2")+" R$"));

            double saldo = entrada - saida;

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("SaldoGeral", saldo.ToString("F2") + " R$"));

            reportViewer1.RefreshReport();

        }
    }
}
