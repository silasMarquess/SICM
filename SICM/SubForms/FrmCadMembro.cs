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
using SICM.Entidades;
using SICM.Entidades.Enumeracoes;

namespace SICM.SubForms
{
    public partial class FrmCadMembro : Form
    {
        private ControlCadMembro _control;

        public FrmCadMembro()
        {
            InitializeComponent();
            _control = new ControlCadMembro(this);
            txt_codigo.Text = _control.GenerateCode();
            _control.PreencheListaTemplo();
            btn_SalvarMembro.Enabled = true;
            Cb_Estado.SelectedIndex = 9;
            _control.MostraListaMunicipios();
            Cb_Municipios.Text = "Senador La Rocque";
        }

        public FrmCadMembro(Membro m)
        {
            InitializeComponent();
            _control = new ControlCadMembro(this);
            _control.PreencheListaTemplo();

            //mostrando informções de membro
            _control.controlMostraInfoUpdate(m);
            btn_SalvarMembro.Enabled = false;
            btn_SalvarEdicao.Enabled = true;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Cb_Estado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                // if (Cb_Municipios.Text == "") throw new DomainsExcpetion("Erro Nemhum Estado Selecionado !");
                _control.MostraListaMunicipios();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Cb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cb_TemploSede_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cb_ListaId.SelectedIndex = Cb_TemploSede.SelectedIndex;

            if (Rb_Congregacao.Checked)
            {
                Cb_ListaCongregacao.Enabled = true;
                Cb_ListaCongregacao.DataSource = null;
                _control.PreecheListaCongregacao();
            }
        }

        private void Rb_Congregacao_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Congregacao.Checked)
            {
                Cb_ListaCongregacao.Enabled = true;
                _control.PreecheListaCongregacao();
            }
            else
            {
                Cb_ListaCongregacao.DataSource = null;
                Cb_ListaCongregacao.Enabled = false;
            }
        }

        private void Rb_TemploSede_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_TemploSede.Checked)
            {
                Cb_ListaCongregacao.DataSource = null;
                Cb_TemploSede.Enabled = true;
                Cb_ListaCongregacao.Enabled = false;
            }
        }

        private void btn_SelecionarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*jpg|PNG File(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string url = dialog.FileName;
                txt_CaminhoImagem.Text = url;

                Pcb_FotoMembro.ImageLocation = url;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlInsertMembro();
                txt_codigo.Text = _control.GenerateCode();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void Cb_TemploSede_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void txt_NomeCompleto_Click(object sender, EventArgs e)
        {


        }

        private void txt_Conjuge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Conjuge_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Conjuge.SelectAll();
        }

        private void txt_Nacionalidade_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Nacionalidade.SelectAll();
        }

        private void txt_Naturalidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cb_EstadiCivil.Select();
            }
        }

        private void txt_Numero_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_Naturalidade_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Naturalidade.SelectAll();
        }

        private void txt_Numero_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Numero.SelectAll();
        }

        private void txt_LocalBatismo_MouseDown(object sender, MouseEventArgs e)
        {
            txt_LocalBatismo.SelectAll();
        }

        private void txt_telefone_MouseDown(object sender, MouseEventArgs e)
        {
            txt_telefone.SelectAll();
        }

        private void txt_dataBat_MouseDown(object sender, MouseEventArgs e)
        {
            txt_dataBat.SelectAll();
        }

        private void txt_dataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_cpf.Select();
            }
        }

        private void txt_dataNascimento_MouseDown(object sender, MouseEventArgs e)
        {
            txt_dataNascimento.SelectAll();
        }

        private void FrmCadMembro_Load(object sender, EventArgs e)
        {

        }

        private void btn_SalvarEdicao_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlUpdate();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tab_CadMembro.SelectedTab = Tab_CadMembro.TabPages[1];
        }

        private void txt_NomeCompleto_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txt_NomeCompleto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_dataNascimento.Select();
            }
        }

        private void txt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_cpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cb_genero.Select();
            }
        }

        private void Cb_genero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cb_genero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Nacionalidade.Select();
            }
        }

        private void txt_Nacionalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Nacionalidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Naturalidade.Select();
            }
        }

        private void txt_Naturalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cb_EstadiCivil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cb_Escolaridade.Select();
            }
        }

        private void Cb_Escolaridade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Conjuge.Select();
            }
        }

        private void txt_Conjuge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txt_telefone.Select();
        }

        private void txt_telefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Tab_CadMembro.SelectedTab = tabPage_DadosEndEsp;
                txt_ruaNome.Select();
            }
        }

        private void txt_ruaNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_bairro.Select();
            }
        }

        private void txt_bairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cb_Estado.Select();
            }
        }

        private void Cb_Estado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Cb_Municipios.Select();
            }
        }

        private void Cb_Municipios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Numero.Select();

            }
        }

        private void tabPage_DadosEndEsp_Click(object sender, EventArgs e)
        {

        }
    }
}
