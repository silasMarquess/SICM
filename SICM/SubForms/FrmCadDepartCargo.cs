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
    public partial class FrmCadDepartCargo : Form
    {
        private ControlCadDepartamento _control;

        public FrmCadDepartCargo()
        {
            InitializeComponent();
            _control = new ControlCadDepartamento(this);
            _control.ControlMostraListaTemplo();
            _control.ControlMostraListaDepartamentos();
            Cb_Departamento.Enabled = false;
            btn_Cadastrar.Enabled = true;
        }

        public FrmCadDepartCargo(Departamento depart)
        {
            InitializeComponent();
            _control = new ControlCadDepartamento(this);
            Rb_Cargo.Enabled = false;
            // Rb_Congregacao.Checked = true;
            _control.ControlMostraListaTemplo();
            // _control.ControlMostraListaDepartamentos();
            _control.ControlMostraInfoUpdateDepart(depart);
            Cb_Departamento.Enabled = false;
            btn_SalvarAlterações.Enabled = true;
        }

        public FrmCadDepartCargo(Cargo c)
        {
            InitializeComponent();
            _control = new ControlCadDepartamento(this);
            Rb_Departamento.Enabled = false;
            Cb_Departamento.Enabled = true;
            // Rb_Congregacao.Checked = true;
            _control.ControlMostraListaTemplo();
            _control.ControlMostraInfoUpdateCarg(c);
            Cb_Departamento.Enabled = false;
            btn_SalvarAlterações.Enabled = true;
        }

        private void Rb_Departamento_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Departamento.Checked)
            {
                Cb_Departamento.Enabled = false;
                Cb_Departamento.DataSource = null;
            }
            else
            {
                Cb_Departamento.Enabled = true;
                _control.ControlMostraListaDepartamentos();
            }
        }

        private void Rb_Cargo_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Cargo.Checked)
            {
                Cb_Departamento.Enabled = true;
                _control.ControlMostraListaDepartamentos();
            }
            else
            {
                Cb_Departamento.Enabled = false;
                Cb_Departamento.DataSource = null;
            }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Rb_Departamento.Checked)
                {
                    _control.controlInserdDepartamento();
                }
                else
                {
                    _control.ControlInsertCargo();
                }
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCadDepartCargo_Load(object sender, EventArgs e)
        {

        }

        private void Cb_TemploSede_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cb_TemploSede_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                _control.ControlMostraListaDepartamentos();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cb_Departamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_Id.Text = (Cb_Departamento.SelectedValue.ToString());
        }

        private void Rb_TemploSede_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_TemploSede.Checked)
            {
                Cb_ListaCongregacao.Enabled = false;
                Cb_ListaCongregacao.DataSource = null;
                Cb_Departamento.DataSource = null;
                Cb_TemploSede.SelectedIndex = -1;
            }
            else
            {
                Cb_ListaCongregacao.Enabled = true;
                _control.controlGetListaCongregacao();
                Cb_Departamento.DataSource = null;
                //Cb_TemploSede.SelectedIndex = -1;
            }
        }

        private void Cb_ListaCongregacao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _control.ControlMostraListaDepartamentos();
        }

        private void Cb_TemploSede_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            _control.ControlMostraListaDepartamentos();
        }

        private void Rb_Congregacao_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Congregacao.Checked)
            {
                Cb_ListaCongregacao.SelectedIndex = -1;
            }
        }

        private void btn_SalvarAlterações_Click(object sender, EventArgs e)
        {
            try
            {
                if (Rb_Departamento.Checked)
                {
                    _control.ControlUpdateDepartamento();
                }
                else
                {
                    _control.ControlUPdateCargo();
                }
                this.Close();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cb_TemploSede_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
