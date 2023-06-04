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
using SICM.Entidades;
using SICM.Entidades.Enumeracoes;

namespace SICM.Relatorios
{
    public partial class FrmRelCaixa : Form
    {
        private Caixa _caixaSelecionado;
        public FrmRelCaixa(Caixa c)
        {
            InitializeComponent();
            _caixaSelecionado = c;
            PreencheRelatorio(c);
        }

        private void FrmRelCaixa_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void PreencheRelatorio(Caixa caixa)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource =
                 "SICM.Relatorios.rdlcFiles.RelEntradasSaidas.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();

            //criando table entradas
            DataTable tableEntradas = new DataTable(); ;
            tableEntradas.Columns.Add("id", typeof(int));
            tableEntradas.Columns.Add("origem", typeof(string));
            tableEntradas.Columns.Add("data", typeof(DateTime));
            tableEntradas.Columns.Add("valor", typeof(double));
            tableEntradas.Columns.Add("natureza", typeof(string));
            tableEntradas.Columns.Add("tipo", typeof(string));

            foreach (Entrada end in caixa.ListaEntrada)
            {
                DataRow linha = tableEntradas.NewRow();
                linha["id"] = end.Id;
                linha["origem"] = end.Origem;
                linha["data"] = end.Data.ToShortDateString();
                linha["valor"] = end.Valor.ToString("F2");
                linha["natureza"] = end.Natureza.ToString();
                linha["tipo"] = end.TipoMov.ToString();
                tableEntradas.Rows.Add(linha);
            }

            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSet1", tableEntradas));

            //criando table de Saidas
            DataTable tableSaidas = new DataTable();
            tableSaidas.Columns.Add("id", typeof(int));
            tableSaidas.Columns.Add("origem", typeof(string));
            tableSaidas.Columns.Add("data", typeof(DateTime));
            tableSaidas.Columns.Add("valor", typeof(double));
            tableSaidas.Columns.Add("tipo", typeof(string));
           // tableSaidas.Rows.Add(tableSaidas);

            foreach (Saida end in caixa.ListaSaida)
            {
                DataRow linha = tableSaidas.NewRow();
                linha["id"] = end.Id;
                linha["origem"] = end.Origem.ToUpper();
                linha["data"] = end.Data.ToShortDateString();
                linha["valor"] = end.Valor.ToString("F2");
                linha["tipo"] = end.TipoMovimentacao.ToString();
                tableSaidas.Rows.Add(linha);
            }

            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSet2_saidas", tableSaidas));

            //SETANDO PARAMETROS
            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("nomecaixa", caixa.Nome));

            ListaMeses mes = (ListaMeses)(caixa.ListaEntrada[0].Data.Month - 1 );

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("mes", mes.ToString()));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("Ano", caixa.ListaEntrada[0].Data.Year.ToString()));

            double[] valoresEntrada = caixa.CalculaTotalValoresPixDinCartEntradas();
            double[] valoresSaidas = caixa.CalculaTotalValoresPixDinCartSaidas();

            reportViewer1.LocalReport.SetParameters(
               new ReportParameter("pixentrada", valoresEntrada[1].ToString("F2") + " R$"));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("especieentrada", valoresEntrada[0].ToString("F2") + " R$"));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("totalentrada", caixa.CalculaTotEntrada().ToString("F2") + " R$"));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("especiesaida", valoresSaidas[0].ToString("F2")+" R$"));

            reportViewer1.LocalReport.SetParameters(

                new ReportParameter("pixsaida", valoresSaidas[1].ToString("F2")));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("totalsaida", caixa.CalculaTotSaida().ToString("F2") + " R$"));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("saldo", caixa.CalculaSaldo().ToString("F2")));

            reportViewer1.RefreshReport();
            MessageBox.Show("Dados Carregados com sucesso !");

        }
    }
}
