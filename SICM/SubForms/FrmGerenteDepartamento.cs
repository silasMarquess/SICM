using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICM.Controller;
using SICM.Entidades.Enumeracoes;
using SICM.Entidades;

namespace SICM.SubForms
{
    public partial class FrmGerenteDepartamento : Form
    {
        private ControlGerenteDepart _control;
        public FrmGerenteDepartamento()
        {
            InitializeComponent();
            _control = new ControlGerenteDepart(this);
            _control.ControlMostrarListaTemplo();
            _control.MostraListaAnosFiltraVinculo();
            Cb_FiltrarStatusVinc.SelectedIndex = 0;
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlMostraListaDepartamento();

                _control.MostrarListDepartVinc();

                _control.MostrarListaDepartamentoConsultCargo();

            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Lv_Departamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rb_Congregacao_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Rb_Congregacao.Checked)
                {
                    Cb_ListaCongregacao.Enabled = true;
                    _control.ControlMostraListaCongregacao();
                }
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cb_listaTemplo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Rb_Congregacao.Checked)
            {
                _control.ControlMostraListaCongregacao();
            }
        }

        private void Cb_ListaCongregacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cb_listaTemplo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rb_Congregacao_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Rb_Congregacao.Checked)
            {
                Cb_ListaCongregacao.Enabled = true;
                _control.ControlMostraListaCongregacao();
            }
            else
            {
                Cb_ListaCongregacao.Enabled = false;
                Cb_ListaCongregacao.DataSource = null;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _control.ControlUpdateDepartamento();
        }

        private void novo_Click(object sender, EventArgs e)
        {
            FrmCadDepartCargo cad = new FrmCadDepartCargo();
            cad.ShowDialog();
        }

        private void Cb_DepartConsultaCargo_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                _control.ControlMostraListaCargo();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Nemhum departamento Selecionado no momento !");
            }
        }

        private void toolStripMenuItem3_NovoCargo_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_NovoCargo_Click(object sender, EventArgs e)
        {
            FrmCadDepartCargo cad = new FrmCadDepartCargo();
            cad.ShowDialog();
        }

        private void eToolStripMenuItem_EditarCargo_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlUpdateCargo();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletarSelecionadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlDeleteCargo();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletarSelecionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlDeleteDepartamento();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem1_NovoVinculo_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlNewVinculo();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cb_ListDepartVinc_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void Lv_ListaVinculos_Click(object sender, EventArgs e)
        {
            try
            {
                _control.GetInforVincuSelect();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cb_DepartConsultaCargo_Click(object sender, EventArgs e)
        {

        }

        private void FrmGerenteDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void Cb_AnoFiltrar_DropDownClosed(object sender, EventArgs e)
        {
            Lb_AnoSelecionado.Text = Cb_AnoFiltrar.SelectedItem.ToString();
        }

        private void Cb_FiltrarStatusVinc_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                if (Cb_FiltrarStatusVinc.SelectedIndex == 2)
                {
                    Lb_FiltroStatusVinc.Text = "TODOS";
                }
                else
                {

                    StatusVinculo status = (StatusVinculo)Cb_FiltrarStatusVinc.SelectedIndex;
                    Lb_FiltroStatusVinc.Text = status.ToString();
                }
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem3_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlDeleteVinculo();
                Lv_ListaVinculos.Items.Clear();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aRQUIVARVINCULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlArquivaVinculo();
                Lv_ListaVinculos.Items.Clear();

            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlMostraListaVinculo();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Nada selecionado. Atualize a lista no butao 'CARREGAR DADOS' ");
            }
        }

        private void btn_ReportGeral_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlReporteEsquema();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                _control.ControlReportGeral();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
