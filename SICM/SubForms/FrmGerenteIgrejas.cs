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
    public partial class FrmGerenteIgrejas : Form
    {
        private ControlGerenteIgreja _control;
        public FrmGerenteIgrejas()
        {
            InitializeComponent();
            _control = new ControlGerenteIgreja(this);
            _control.MostraListaTemplo();
        }

        private void dgv_ListaTemplos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _control.LimparCamposCongs();
                _control.getInfoTemploSelecionado();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                _control.ControlLimpaCamposTemplo();
                _control.LimparCamposCongs();
                MessageBox.Show("Erro: Nada selecionado ! ");
            }
        }

        private void Lv_ListaCongregacoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lv_ListaCongregacoes_Click(object sender, EventArgs e)
        {
            try
            {
                _control.GetInforCongSelecionada();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Erro: Nada seleciondao no momento !");
            }
        }

        private void dgv_ListaTemplos_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            MessageBox.Show("Evento de edição");
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.ControlUpdateInformacoes();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlUpdateInfoCong();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dELETARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Atenção: Todos os Departamento, congregações e membros serão excluidos deseja continuar ?", "Confirme", MessageBoxButtons.YesNo);
                if (res == DialogResult.No) throw new DomainsExcpetion("Operação concelada");
                _control.ControlDeleteTemplo();
                _control.MostraListaTemplo();
                _control.LimparCamposCongs();
                _control.ControlLimpaCamposTemplo();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Atenção: Todos os membros serão excluidos deseja continuar ?", "Confirme", MessageBoxButtons.YesNo);
                if (res == DialogResult.No) throw new DomainsExcpetion("Operação concelada");
                _control.ControlDeleteCongregacao();
                _control.LimparCamposCongs();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void vERINFORMAÇÕESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadIgreja cad = new FrmCadIgreja();
            cad.ShowDialog();
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadIgreja cad = new FrmCadIgreja();
            cad.ShowDialog();
        }

        private void aTUALIZARTABELAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.MostraListaTemplo();
        }

        private void aTUALIZARLISTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.LimparCamposCongs();
            _control.getInfoTemploSelecionado();
        }
    }
}
