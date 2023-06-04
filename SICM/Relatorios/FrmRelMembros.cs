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
using SICM.Relatorios;


namespace SICM.Relatorios
{
    public partial class FrmRelMembros : Form
    {
        public FrmRelMembros(List<Membro> lista)
        {
            InitializeComponent();         
            MostraDados(lista);
        }

        private void FrmRelMembros_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        public void MostraDados(List<Membro> lista)
        {
            DataTable table = new DataTable();
            table.Columns.Add("codigo");
            table.Columns.Add("nome");
            table.Columns.Add("dataNas");
            table.Columns.Add("Status");
            table.Columns.Add("Categoria");
            table.Columns.Add("SubCategoria");

            foreach (Membro m in lista)
            {
                DataRow linha = table.NewRow();
                linha["codigo"] = m.Codigo;
                linha["nome"] = m.Nome;
                linha["dataNas"] = m.DadosPessoais.DataNascimento.ToShortDateString();
                linha["Status"] = m.Status.ToString();
                linha["Categoria"] = m.Categoria.ToString();
                linha["SubCategoria"] = m.SubCategoria.ToString();
                table.Rows.Add(linha);
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "SICM.Relatorios.rdlcFiles.RelListaMembros.rdlc";
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("DataSet1", table));

            //SETANDO VALORES PARA OS PARAMENTROS
            reportViewer1.LocalReport.SetParameters(new
               ReportParameter("ParamNumMembro", lista.Count.ToString()+" Membros Filtrados"));
            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("ParamDataHoje", DateTime.Now.ToShortDateString()+" - "+DateTime.Now.ToShortTimeString()));

            //ATUALIZANDO O RELATORIO
            reportViewer1.RefreshReport();


        }

        
    }
}
