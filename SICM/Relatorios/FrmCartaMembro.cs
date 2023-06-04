using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICM.Entidades;
using SICM.Servicos;
using Microsoft.Reporting.WinForms;

namespace SICM.Relatorios
{
    public partial class FrmCartaMembro : Form
    {
        List<Municipio> _listaMun;
        Membro _membro;
        public FrmCartaMembro(Membro m)
        {
            InitializeComponent();
            _membro = m;
            lb_NomeMembrio.Text = m.Nome;
            lb_status.Text = m.Status.ToString();
            lb_solteiro.Text = m.DadosPessoais.EstadoCivil.ToString();
        }

        private void FrmCartaMembro_Load(object sender, EventArgs e)
        {
            _listaMun = Municipio.GetListaMunicipios();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        public void MostraListaMunicipios()
        {
            try
            {

                if (_listaMun is null) throw new DomainsExcpetion("Erro: Nemhuma lista de Municipio retornada no momento");
                List<Municipio> lista = _listaMun.FindAll(getMunicipioForEstado);
                Cb_Municipio.DataSource = lista;
                Cb_Municipio.DisplayMember = "nome";
                Cb_Municipio.ValueMember = "id";
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PreencheCartaRecomendacao()
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "SICM.Relatorios.rdlcFiles.RelCartaMembro.rdlc";

                if (_membro == null) throw new DomainsExcpetion("Erro: Nemhum membro selecionado volte  no formulario de gerente de Membros");
                if (!(Rb_transicao.Checked))
                {
                    if (CB_Uf.Text == "") throw new DomainsExcpetion("Erro: Nemhum estado selecionado no momento !");
                    if (Cb_Municipio.Text == string.Empty) throw new DomainsExcpetion("Erro: Nemhuma cidade/Municipio selecionado no momento !");
                }


                if (Rb_recomendacao.Checked)
                {
                    reportViewer1.LocalReport.SetParameters(
                        new ReportParameter("cartaRecomendacao", "(X)"));
                    reportViewer1.LocalReport.SetParameters(
                     new ReportParameter("cartamudanca", "")); reportViewer1.LocalReport.SetParameters(
                       new ReportParameter("transicao", ""));
                }
                else if (Rb_Transferencia.Checked)
                {
                    reportViewer1.LocalReport.SetParameters(
                       new ReportParameter("cartaRecomendacao", ""));
                    reportViewer1.LocalReport.SetParameters(
                     new ReportParameter("cartamudanca", "(X)")); reportViewer1.LocalReport.SetParameters(
                       new ReportParameter("transicao", ""));
                }
                else
                {
                    reportViewer1.LocalReport.SetParameters(
                         new ReportParameter("cartaRecomendacao", ""));
                    reportViewer1.LocalReport.SetParameters(

                        new ReportParameter("cartamudanca", ""));

                    reportViewer1.LocalReport.SetParameters(
                       new ReportParameter("transicao", "(X)"));
                }

                reportViewer1.LocalReport.SetParameters(

                    new ReportParameter("nomemembro", _membro.Nome));

                reportViewer1.LocalReport.SetParameters(

                    new ReportParameter("cpf", _membro.DadosPessoais.Cpf));



                if (Rb_transicao.Checked)
                {
                    reportViewer1.LocalReport.SetParameters(
                   new ReportParameter("localigrejadestino", "<Transito>" + " - " + "<Transito>"));

                }
                else
                {
                    reportViewer1.LocalReport.SetParameters(
                   new ReportParameter("localigrejadestino", Cb_Municipio.Text + " - " + CB_Uf.Text));
                }


                reportViewer1.LocalReport.SetParameters(
                    new ReportParameter("categoria", _membro.SubCategoria.ToString()));

                reportViewer1.LocalReport.SetParameters(
                    new ReportParameter("estadocivil", _membro.DadosPessoais.EstadoCivil.ToString() + "(A)"));

                reportViewer1.LocalReport.SetParameters(
                    new ReportParameter("statusmembro", _membro.Status.ToString() + "(A)"));

                if (_membro.Igreja is Congregacao)
                {
                    Congregacao cong = _membro.Igreja as Congregacao;
                    if (cong.Nome == "VALE DE BENÇÃO")
                    {
                        reportViewer1.LocalReport.SetParameters(
                            new ReportParameter("valedebencao", "(X)"));
                    }
                    else if (cong.Nome == "DEUS FORTE")
                    {
                        reportViewer1.LocalReport.SetParameters(
                            new ReportParameter("deusforte", "(X)"));
                    }
                    else
                    {
                        reportViewer1.LocalReport.SetParameters(
                            new ReportParameter("betel", "(X)"));
                    }
                }
                else
                {
                    reportViewer1.LocalReport.SetParameters(
                            new ReportParameter("sede", "(X)"));
                }

                reportViewer1.LocalReport.SetParameters(
                    new ReportParameter("ANOHOJE", DateTime.Now.Year.ToString()));

                reportViewer1.LocalReport.SetParameters(
                 new ReportParameter("datahoje", DateTime.Now.ToShortDateString()));

                reportViewer1.RefreshReport();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool getMunicipioForEstado(Municipio mun)
        {
            string textoEstado = CB_Uf.SelectedItem.ToString();
            string estado = textoEstado[1].ToString() + textoEstado[2].ToString();
            return (mun.Microrregiao.Mesorregiao.Uf.Sigla == estado) ? true : false;
        }

        private void CB_Uf_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MostraListaMunicipios();
        }

        private void btn_EmitirCarta_Click(object sender, EventArgs e)
        {
            this.PreencheCartaRecomendacao();
        }

        private void Rb_transicao_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_transicao.Checked)
            {
                Cb_Municipio.Enabled = false;
                CB_Uf.Enabled = false;
            }
            else
            {
                Cb_Municipio.Enabled = true;
                CB_Uf.Enabled = true;
            }
        }
    }
}
