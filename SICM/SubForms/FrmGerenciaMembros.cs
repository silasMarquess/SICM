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
    public partial class FrmGerenciaMembros : Form
    {
        private ControlGerenteMembro _control;
        public FrmGerenciaMembros()
        {
            InitializeComponent();
            _control = new ControlGerenteMembro(this);
            _control.ControlPreencheListaTemplo();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_Conjuge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_Nacionalidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_Sexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_EstadoCivil_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Escolaridade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_Cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void pRESBITEROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraSubCategoria(SubCategoria.DIACONO);
        }

        private void Cb_TemploSede_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                _control.ControlPreencheListaCong();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }catch(NullReferenceException ex)
            {
                MessageBox.Show("Erro: Nemhum Templo sede selecionado !");
            }
        }

        private void btn_BuscarMembrosIgreja_Click(object sender, EventArgs e)
        {
            _control.ControlMostraReuneMembros();
        }

        private void vERINFORMAÇÕESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _control.PrintService();
            }catch(DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_TabelMembros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _control.ControlMostraInfoMembroSelecionado();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eDITARREGISTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlUpdateMembro();

            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eXCLUIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlDeleteMembroSelecionado();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cb_TemploSede_MouseEnter(object sender, EventArgs e)
        {
            Cb_TemploSede.DroppedDown = true;
        }

        private void Cb_SubDivisao_MouseEnter(object sender, EventArgs e)
        {
            Cb_SubDivisao.DroppedDown = true;
        }

        private void txt_PesquisaMembroNome_TextChanged(object sender, EventArgs e)
        {
            _control.ControlMostraReuneMembros(txt_PesquisaMembroNome.Text);
        }

        private void Cb_SubDivisao_Click(object sender, EventArgs e)
        {

        }

        private void juventuddeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraCategoria(Entidades.Enumeracoes.TipoCategoria.JUVENTUDE);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            _control.ControlMostraReuneMembros();
        }

        private void obreirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraCategoria(TipoCategoria.OBREIROS);
        }

        private void circuloDeOraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraCategoria(TipoCategoria.CIRCULO_ORACAO);
        }

        private void outraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraCategoria(TipoCategoria.OUTRA);
        }

        private void dIACONOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraSubCategoria(SubCategoria.MEMBRO_COMUM);
        }

        private void aUXILIARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraSubCategoria(SubCategoria.PRESBITERO);
        }

        private void auxiliaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraSubCategoria(SubCategoria.AUXILIAR);
        }

        private void aTIVOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraStatus(StatusMembro.ATIVO);
        }

        private void dESATIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraStatus(StatusMembro.DESATIVO);
        }

        private void tRANSFERIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraStatus(StatusMembro.TRANSFERIDO);
        }

        private void fundCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraEscolaridade(TipoEscolaridade.FUND_COMPLETO);
        }

        private void fundIncompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraEscolaridade(TipoEscolaridade.FUND_INCOMPLETO);
        }

        private void medCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraEscolaridade(TipoEscolaridade.MED_COMPLETO);
        }

        private void medIncompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraEscolaridade(TipoEscolaridade.MED_INCOMPLETO);
        }

        private void supCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraEscolaridade(TipoEscolaridade.SUP_COMPLETO);
        }

        private void supIncompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraEscolaridade(TipoEscolaridade.SUP_INCOMPLETO);
        }

        private void masculinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraGenero(TipoGenero.MASCULINO);
        }

        private void femininoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraGenero(TipoGenero.FEMININO);
        }

        private void solteiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraEstadoCivil(TipoEstCivil.SOLTEIRO);
        }

        private void casadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.FiltraEstadoCivil(TipoEstCivil.CASADO);
        }

        private void eMITIRFICHAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _control.PrintFichaMembroselecionado();
        }

        private void eMITIRCARTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _control.EmitirCartaRecomendacao(); 
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
