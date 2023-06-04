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

namespace SICM.SubForms
{
    public partial class FrmFinanceiro : Form
    {
        private ControlFrmFinanceiro _control;
        public FrmFinanceiro()
        {
            InitializeComponent();
            _control = new ControlFrmFinanceiro(this);
            _control.MostraCaixa();
            _control.MostraListaAnos();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CB_temploSede_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {


            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ConsultasMovimentacoesCaixa();

            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SalvarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControllancarEntrada();

            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show("erro: " + ex.Message);
            }
        }

        private void btn_lancarSaida_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlLancarSaida();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show("erro: " + ex.Message);
            }
        }

        private void Lv_ListaEntradas_Click(object sender, EventArgs e)
        {
            try
            {
                _control.GetInforUpdateEntrada();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Lv_ListaSaidas_Click(object sender, EventArgs e)
        {
            try
            {
                _control.GetInforUpdateSaida();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_EditarEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlUpdateEntrada();
                _control.ConsultasMovimentacoesCaixa();
            }
            catch(DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_EditarSaida_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlUpdateSaida();
                _control.ConsultasMovimentacoesCaixa();
            }
            catch(DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ExcluirEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlDeleteEntrada();
                _control.ConsultasMovimentacoesCaixa();
            }
            catch(DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ExcluirSaida_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlDeleteSaida();
                _control.ConsultasMovimentacoesCaixa();
            }
            catch(DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_OrigemEntrada_MouseDown(object sender, MouseEventArgs e)
        {
            txt_OrigemEntrada.SelectAll();
        }

        private void txt_OrigemSaida_MouseDown(object sender, MouseEventArgs e)
        {
            txt_OrigemSaida.SelectAll();
        }

        private void Nup_ValorEntrada_MouseDown(object sender, MouseEventArgs e)
        {
            Nup_ValorEntrada.Select();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            _control.ControlPrintInforCaixa();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmListaCaixas _form = new FrmListaCaixas();
            _form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cb_listaCaixa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cb_Ano_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _control.TranportarSaldo();

            }catch(DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
