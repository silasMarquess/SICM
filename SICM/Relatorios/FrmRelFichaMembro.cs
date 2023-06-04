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
using SICM.Relatorios;
using Microsoft.Reporting.WinForms;

namespace SICM.Relatorios.rdlcFiles
{
    public partial class FrmRelFichaMembro : Form
    {
        public FrmRelFichaMembro(Membro m)
        {
            InitializeComponent();
            MostraInformacoes(m);
        }

        private void FrmRelFichaMembro_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        public void MostraInformacoes(Membro m)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "SICM.Relatorios.rdlcFiles.FichaMembro.rdlc";

            //SETANDO PARÂMETROS
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("codigo", m.Codigo));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("nome", m.Nome));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("status", m.Status.ToString()));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("categoria", m.Categoria.ToString()));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter(
                    "subcategoria", m.SubCategoria.ToString()));

            reportViewer1.LocalReport.SetParameters(new ReportParameter(
                "cpf", m.DadosPessoais.Cpf));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("genero", m.DadosPessoais.Genero.ToString()));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter(
                    "datanascimento", m.DadosPessoais.DataNascimento.ToShortDateString())
              );

            reportViewer1.LocalReport.SetParameters(

                new ReportParameter("nacionalidade", m.DadosPessoais.Nacionalidade));
            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("naturalidade", m.DadosPessoais.Naturalidade));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("estadocivil", m.DadosPessoais.EstadoCivil.ToString()));
            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("escolaridade", m.DadosPessoais.Escolaridade.ToString()));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("conjuge", m.DadosPessoais.Conjuge));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("telefone", m.DadosPessoais.Telefone));

            reportViewer1.LocalReport.SetParameters(

                new ReportParameter("rua", m.Endereco.Rua));

            reportViewer1.LocalReport.SetParameters(

                new ReportParameter("numero", m.Endereco.Numero.ToString()));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("bairro", m.Endereco.Bairro));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("cidade", m.Endereco.Cidade));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("estado", m.Endereco.Estado));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("databatismo", m.DadosEsp.DataBatismal.ToShortDateString()));

            reportViewer1.LocalReport.SetParameters(

                new ReportParameter("localbatismo", m.DadosEsp.LocalBatismo));



            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("cargo", typeof(string));
            table.Columns.Add("departamento", typeof(string));
            table.Columns.Add("igreja", typeof(string));
            table.Columns.Add("ano", typeof(int));
            table.Columns.Add("datainicio", typeof(string));
            table.Columns.Add("dataFim", typeof(string));
            table.Columns.Add("status", typeof(string));

            if (m.ListaVinculos.Count == 0)
            {
                reportViewer1.LocalReport.SetParameters(
                    new ReportParameter("numerovinculos", "Nemhum Historio de Vinculo Encontrado"));
            }
            
                foreach (VinculoFuncional vinc in m.ListaVinculos)
                {
                    DataRow linha = table.NewRow();
                    linha["id"] = vinc.Id;
                    linha["cargo"] = vinc.Cargo.Nome;
                    linha["departamento"] = vinc.Depart.Nome;
                    linha["igreja"] = vinc.Igreja.Nome;
                    linha["ano"] = vinc.Ano;
                    linha["datainicio"] = vinc.DataInicio.ToShortDateString();
                    linha["datafim"] = vinc.DataFim.ToShortDateString();
                    linha["status"] = vinc.Status.ToString();
                    table.Rows.Add(linha);
                }
                reportViewer1.LocalReport.SetParameters(
                    new ReportParameter("numerovinculos", m.ListaVinculos.Count.ToString() + " Encontrados"));

               
                reportViewer1.LocalReport.DataSources.Add(
                  new ReportDataSource("DataSet1", table));
            

            //ATUALIZANDO RELATORIO
            this.reportViewer1.RefreshReport();
        }
    }
}
