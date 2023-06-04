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
using SICM.Entidades.Enumeracoes;
using SICM.Controller;


namespace SICM.SubForms
{
    public partial class FrmDizimos : Form
    {
        private ControlGerenteDizimos _control;

        public FrmDizimos()
        {
            InitializeComponent();
            _control = new ControlGerenteDizimos(this);
            _control.ControlMostraSedes();
            _control.MostraListaAnos();
            // Cb_ListaMeses.SelectedIndex = 0;
        }

        private void Rb_Congregacao_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Congregacao.Checked)
            {
                Cb_ListaCongregacao.Enabled = true;
                _control.MostraListaCongs();
            }
            else
            {
                Cb_ListaCongregacao.DataSource = null;
                Cb_ListaCongregacao.Enabled = false;
            }
        }

        private void btn_atualizarTabela_Click(object sender, EventArgs e)
        {
            try
            {
                Cb_tipoDizimo.SelectedIndex = 0;
                _control.ControlMostraListaDizimos();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_LançarDizimos_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlInsetDizimo();
                Gb_CadDizimo.Enabled = false;
                btn_LançarDizimos.Enabled = false;
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_PesquisaNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_DataHoje.Text = DateTime.Now.ToShortDateString();
                _control.FiltraMembroForNome(txt_PesquisaNome.Text);
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NuP_ValorDizimo_ValueChanged(object sender, EventArgs e)
        {
            double valorDizimo = double.Parse(NuP_ValorDizimo.Value.ToString());
            double valorSalario = valorDizimo / 0.10;
            txt_SalarioEstimado.Text = valorSalario.ToString("F2");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                int index = Lv_ListaMembroFiltrados.SelectedIndices[0];
                string codigo = Lv_ListaMembroFiltrados.Items[index].SubItems[0].Text;
                string nome = Lv_ListaMembroFiltrados.Items[index].SubItems[1].Text;

                if (nome == string.Empty || codigo == string.Empty) throw new DomainsExcpetion("Erro: nemhum membro selecionado !");
                txt_NomeMembro.Text = nome;
                txt_CodigoMembro.Text = codigo;
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Gb_CadDizimo.Enabled = true;
                _control.GetInfoUpdateDizimo();
                if (btn_LançarDizimos.Enabled == true) btn_LançarDizimos.Enabled = false;
                btn_SalvarAlterações.Enabled = true;
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_PesquisaNome_MouseDown(object sender, MouseEventArgs e)
        {
            txt_PesquisaNome.SelectAll();
        }

        private void Rb_Congregacao_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Rb_Congregacao.Checked)
            {
                Cb_ListaCongregacao.Enabled = true;
                _control.MostraListaCongs();
            }
            else
            {
                Cb_ListaCongregacao.Enabled = false;
                Cb_ListaCongregacao.DataSource = null;
            }
        }

        private void btn_SalvarAlterações_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlUpdateDizimo();
                
                if (btn_LançarDizimos.Enabled == true) btn_LançarDizimos.Enabled = false;
                btn_SalvarAlterações.Enabled = false;
                _control.ControlMostraListaDizimos();
                Gb_CadDizimo.Enabled = false;
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_exlcuir_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlDeleteDizimo();
                _control.ControlMostraListaDizimos();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_PesquisarNaTabelaForNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _control.ControlMostraListaDizimos(txt_PesquisarNaTabelaForNome.Text);

            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_PesquisarNaTabelaForNome_MouseDown(object sender, MouseEventArgs e)
        {
            txt_PesquisarNaTabelaForNome.SelectAll();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btn_LançarDizimos.Enabled = true;
            Gb_CadDizimo.Enabled = true;
            if (btn_SalvarAlterações.Enabled == true) btn_SalvarAlterações.Enabled = false;
            if (Rb_DizExterno.Checked)
            {
                Lv_ListaMembroFiltrados.Enabled = false;
                txt_PesquisaNome.Enabled = false;
                LinkLancarMembro.Enabled = false;
                txt_NomeMembro.ReadOnly = false;
                MessageBox.Show("Para Dizimista Externo digite o nome diretamente !");
                txt_NomeMembro.Select();
                txt_CodigoMembro.Text = "EXTERNO";

            }
            else
            {
                Lv_ListaMembroFiltrados.Enabled = true;
                txt_PesquisaNome.Enabled = true;
                LinkLancarMembro.Enabled = true;
                txt_NomeMembro.ReadOnly = true;
            }
        }

        private void btn_PrintReport_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlReport();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lb_total_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlReportPrestacao();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_MemCad.Checked)
            {
                Lv_ListaMembroFiltrados.Enabled = true;
                txt_PesquisaNome.Enabled = true;
                LinkLancarMembro.Enabled = true;
                txt_NomeMembro.ReadOnly = true;
            }
            else
            {
                Lv_ListaMembroFiltrados.Enabled = false;
                txt_PesquisaNome.Enabled = false;
                LinkLancarMembro.Enabled = false;
                txt_NomeMembro.ReadOnly = false;
                txt_CodigoMembro.Text = "EXTERNO";
                txt_NomeMembro.Select();
            }
        }

        private void Rb_DizExterno_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_DizExterno.Checked)
            {
                Lv_ListaMembroFiltrados.Enabled = false;
                txt_PesquisaNome.Enabled = false;
                LinkLancarMembro.Enabled = false;
                txt_NomeMembro.ReadOnly = false;
                MessageBox.Show("Para Dizimista Externo digite o nome diretamente !");
                txt_NomeMembro.Select();
                txt_CodigoMembro.Text = "EXTERNO";

            }
            else
            {
                Lv_ListaMembroFiltrados.Enabled = true;
                txt_PesquisaNome.Enabled = true;
                LinkLancarMembro.Enabled = true;
                txt_NomeMembro.ReadOnly = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                _control.LancarDizimposParaEntrada();

            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Gb_CadDizimo_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Rb_Monetario_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Monetario.Checked)
            {
                txt_descricaoDizimo.Text = "";
                txt_descricaoDizimo.Enabled = false;
            }
        }

        private void Rb_Cereais_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Cereais.Checked)
            {
                txt_descricaoDizimo.Enabled = true;
                MessageBox.Show("Informe a Descrição do Dizimo de CEREAIS");
            }
        }

        private void Cb_tipoDizimo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                if (Cb_tipoDizimo.SelectedIndex == 2)
                {
                    _control.ControlMostraListaDizimos();
                }
                else
                {
                    _control.FiltraDizimos();
                }
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
