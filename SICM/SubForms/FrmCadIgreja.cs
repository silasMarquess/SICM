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
    public partial class FrmCadIgreja : Form
    {
        private ControlIgreja _control;

        public FrmCadIgreja()
        {
            InitializeComponent();
            _control = new ControlIgreja(this);
            _control.MostrarCodigoIgreja();
            txt_cnpj.Enabled = true;
            CB_ListaSede.Enabled = false;
            txt_dirigentes.Enabled = false;
            MessageBox.Show("Bem  Vindo a tela de cadastro e edição de membros");
        }

        public FrmCadIgreja(Igreja igreja)
        {
            InitializeComponent();
            _control = new ControlIgreja(this);
            Rb_CadCongregacao.Enabled = false;
            Rb_TemploSede.Enabled = false;
            btn_SalvarDados.Enabled = false;
            btn_CancelarDados.Enabled = true;

            if (igreja is Templo)
            {
                _control.getUPdateInforTemplo(igreja as Templo);

            }
            else
            {
                _control.MostrarListaTemplo();
                Rb_CadCongregacao.Checked = true;
                _control.getUpdateInfoCong(igreja as Congregacao);
            }

            //txt_cnpj.Enabled = true;
            // CB_ListaSede.Enabled = false;
            // txt_dirigentes.Enabled = false;

            MessageBox.Show("Bem  Vindo a tela de cadastro e edição de membros");
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadIgreja_Load(object sender, EventArgs e)
        {

        }

        private void Rb_TemploSede_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_TemploSede.Checked)
            {
                _control.LimpaCampos();
                _control.PreparaCampoTemplo();
                _control.MostrarCodigoIgreja();
            }
        }

        private void Rb_CadCongregacao_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                _control.LimpaCampos();
                _control.PreparaCampoCongregacao();
                _control.MostrarListaTemplo();
                _control.MostrarCodigoIgreja();
            }
            catch (DomainsExcpetion ex)
            {
                Rb_CadCongregacao.Checked = false;
                Rb_TemploSede.Checked = true;
                txt_cnpj.Enabled = true;
                CB_ListaSede.Enabled = false;
                txt_dirigentes.Enabled = false;

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_CancelarDados_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlUpdateIgreja();
                this.Close();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SalvarDados_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlInsertIgreja();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
