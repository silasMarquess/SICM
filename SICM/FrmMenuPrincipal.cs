using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SICM.SubForms;
using SICM.DAO;
using SICM.Entidades;
using SICM.DAO;






namespace SICM
{
    public partial class FrmMenuPrincipal : Form
    {
        private static ControlFrmPrincipla _control;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            _control = new ControlFrmPrincipla(this); 
           // ConexaoDAO.TestaConexaoRemota();
        }

        public void testeConexao(string chave)
        {

        }

        private void cADASTRARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadIgreja _cad = new FrmCadIgreja();
            _cad.ShowDialog();
        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.GetPainel(new FrmGerenteIgrejas());
            
        }

        private void gERENCIARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.GetPainel(new FrmGerenteDepartamento());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void departamentoCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadDepartCargo form = new FrmCadDepartCargo();
            form.ShowDialog();
        }

        private void vinculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadVinculo form = new FrmCadVinculo();
            form.ShowDialog();
        }

        private void nOVOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadMembro form = new FrmCadMembro();
            form.ShowDialog();
        }

        private void gERENCIARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _control.GetPainel(new FrmGerenciaMembros());
        }

        private void mEMBROCADASTRADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gERENCIARCAIXASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.GetPainel(new FrmFinanceiro());
        }

        private void nOVOCAIXAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadCaixas form = new FrmCadCaixas();
            form.ShowDialog();
        }

        private void dIZIMOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.GetPainel(new FrmDizimos());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void fINANCEIROToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
