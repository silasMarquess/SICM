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
    public partial class FrmListaCaixas : Form
    {
        private ControlFrmListaCaixas _control;
        public FrmListaCaixas()
        {
            InitializeComponent();
            _control = new ControlFrmListaCaixas(this);
            MostraListaAnos();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlPrintResumo();
            }catch(DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmListaCaixas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlMostraListaCaixas();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void MostraListaAnos()
        {
            int anoAtual = DateTime.Now.Year;
            cb_ListaAnos.Items.Clear();
            for (int i = anoAtual; i >= (anoAtual - 10); i--)
            {
                cb_ListaAnos.Items.Add(i);
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            _control.ControlCalcularTotEntradas();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlDeleteCaixa();
            }catch(DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
