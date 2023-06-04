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
using SICM.Controller;


namespace SICM.SubForms
{
    public partial class FrmCadCaixas : Form
    {
        private ControlCadCaixa _control;
        public FrmCadCaixas()
        {
            InitializeComponent();
            _control = new ControlCadCaixa(this);
            _control.MostraListaTemplo();

            //teste logico---------------------------------------------------------------

            if (Rb_IgrejaSel.Checked)
            {
                Gb_CaixaDepartamento.Enabled = false;
                if (!(Gb_CaixaIgreja.Enabled)) Gb_CaixaIgreja.Enabled = true;
                txt_NomeCaixa.Enabled = false;
            }
            else if (Rb_Departamento.Checked)
            {
                Gb_CaixaIgreja.Enabled = false;
                if (!(Gb_CaixaDepartamento.Enabled)) Gb_CaixaDepartamento.Enabled = true;
                txt_NomeCaixa.Enabled = false;
            }
            else
            {
                Gb_CaixaDepartamento.Enabled = false;
                Gb_CaixaIgreja.Enabled = false;
                txt_NomeCaixa.Enabled = true;
            }
            //----------------------------------------------------------------------
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_IgrejaSel.Checked)
            {
                Gb_CaixaDepartamento.Enabled = false;
                if (!(Gb_CaixaIgreja.Enabled)) Gb_CaixaIgreja.Enabled = true;
                txt_NomeCaixa.Enabled = false;
            }
            else if (Rb_Departamento.Checked)
            {
                Gb_CaixaIgreja.Enabled = false;
                if (!(Gb_CaixaDepartamento.Enabled)) Gb_CaixaDepartamento.Enabled = true;
                txt_NomeCaixa.Enabled = false;
            }
            else
            {
                Gb_CaixaDepartamento.Enabled = false;
                Gb_CaixaIgreja.Enabled = false;
                txt_NomeCaixa.Enabled = true;
            }
        }

        private void Rb_IgrejaSel_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_IgrejaSel.Checked)
            {
                Gb_CaixaDepartamento.Enabled = false;
                if (!(Gb_CaixaIgreja.Enabled)) Gb_CaixaIgreja.Enabled = true;
                txt_NomeCaixa.Enabled = false;
                string nomeCaixa = "CAIXA-" + CB_ListaSede.Text;
                txt_NomeCaixa.Text = nomeCaixa;
            }
            else if (Rb_Departamento.Checked)
            {
                Gb_CaixaIgreja.Enabled = false;
                if (!(Gb_CaixaDepartamento.Enabled)) Gb_CaixaDepartamento.Enabled = true;
                txt_NomeCaixa.Enabled = false;
            }
            else
            {
                Gb_CaixaDepartamento.Enabled = false;
                Gb_CaixaIgreja.Enabled = false;
                txt_NomeCaixa.Enabled = true;
            }
        }

        private void Rb_ListaCongregacao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CB_ListaSede_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _control.MostraListaCongregacaoCaixaTemplo();
            if (!(Rb_ListaCongregacao.Checked))
            {
                string nomeCaixa = "CAIXA-" + CB_ListaSede.Text;
                txt_NomeCaixa.Text = nomeCaixa;
            }
        }

        private void Rb_ListaCongregacao_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Rb_ListaCongregacao.Checked)
            {
                Cbb_ListaCongregacao.Enabled = true;
                _control.MostraListaCongregacaoCaixaTemplo();
                string nome = "CAIXA-" + Cbb_ListaCongregacao.Text;
                txt_NomeCaixa.Text = nome;
            }
            else
            {
                Cbb_ListaCongregacao.Enabled = false;
                Cbb_ListaCongregacao.DataSource = null;
            }
        }

        private void Cb_ListaSedeDepart_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Cbox_ListaCongCaixaDepart.Checked)
            {
                Cb_Departamento.DataSource = null;
                CB_ListaCoongDepart.Enabled = true;
                _control.MostraListaCongregacaoCaixaDepart();
                if (!(Cb_Departamento.Text == string.Empty))
                {
                    string nomeCaixa = "CAIXA-" + Cb_Departamento.Text;
                    txt_NomeCaixa.Text = nomeCaixa;
                }
            }
            else
            {
                CB_ListaCoongDepart.Enabled = false;
                CB_ListaCoongDepart.DataSource = null;
                Cb_Departamento.DataSource = null;
                _control.BuscaListaDepartamento();
                if (!(Cb_Departamento.Text == string.Empty))
                {
                    string nomeCaixa = "CAIXA-" + Cb_Departamento.Text;
                    txt_NomeCaixa.Text = nomeCaixa;
                }
            }
        }

        private void CB_ListaCoongDepart_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _control.BuscaListaDepartamento();
        }

        private void Cbox_ListaCongCaixaDepart_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbox_ListaCongCaixaDepart.Checked)
            {
                Cb_Departamento.DataSource = null;
                CB_ListaCoongDepart.Enabled = true;
                _control.MostraListaCongregacaoCaixaDepart();
            }
            else
            {
                CB_ListaCoongDepart.Enabled = false;
                CB_ListaCoongDepart.DataSource = null;
                _control.BuscaListaDepartamento();
            }
        }

        private void Cb_Departamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!(Cb_Departamento.Text == string.Empty))
            {
                string nomeCaixa = "CAIXA-" + Cb_Departamento.Text;
                txt_NomeCaixa.Text = nomeCaixa;
            }
        }

        private void btn_CadCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlInsertCaixa();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cb_Departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(Cb_Departamento.Text == string.Empty))
            {
                string nomeCaixa = "CAIXA-" + Cb_Departamento.Text;
                txt_NomeCaixa.Text = nomeCaixa;
            }
        }

        private void Cbb_ListaCongregacao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nome = "CAIXA-" + Cbb_ListaCongregacao.Text;
            txt_NomeCaixa.Text = "";
            txt_NomeCaixa.Text = nome;
        }

        private void Cbb_ListaCongregacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = "CAIXA-" + Cbb_ListaCongregacao.Text;
            txt_NomeCaixa.Text = "";
            txt_NomeCaixa.Text = nome;
        }

        private void Rb_OutroTipo_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_NomeCaixa_MouseDown(object sender, MouseEventArgs e)
        {
            txt_NomeCaixa.SelectAll();  
        }
    }
}
