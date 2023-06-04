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
using MySqlX.XDevAPI.Relational;

namespace SICM.Relatorios
{
    public partial class FrmRelVinculos : Form
    {
        public FrmRelVinculos(List<VinculoFuncional> listaRelacionamentos)
        {
            InitializeComponent();
            this.PreencheTabelaPrincipal(listaRelacionamentos);
        }

        private void FrmRelVinculos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void PreencheTabelaPrincipal(List<VinculoFuncional> fonte)
        {
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("cargo",typeof(string));
            table.Columns.Add("departamento", typeof(string));
            table.Columns.Add("membro",typeof (string));
            table.Columns.Add("dataInicio", typeof(DateTime));
            table.Columns.Add("dataFim",typeof(DateTime));
            table.Columns.Add("status", typeof(string));

            foreach (VinculoFuncional VINC in fonte )
            {
                DataRow line = table.NewRow();
                line["id"] = VINC.Id;
                line["cargo"] = VINC.Cargo.Nome;
                line["departamento"] = VINC.Depart.Nome;
                line["membro"] = VINC.Membro.Nome;
                line["dataInicio"] = VINC.DataInicio;
                line["dataFim"] = VINC.DataFim;
                line["status"]=VINC.Status.ToString();   
                table.Rows.Add(line);   
            }

            reportViewer1.LocalReport.ReportEmbeddedResource =
                "SICM.Relatorios.rdlcFiles.RelVinculos.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(
               new ReportDataSource("DataSet1", table));

            //ADICIONANDO PARAMETROS

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("IGREJA", fonte[0].Igreja.Nome));

            reportViewer1.LocalReport.SetParameters(
                new ReportParameter("ANO", fonte[0].Ano.ToString()));

            reportViewer1.RefreshReport();

        }
    }
}
