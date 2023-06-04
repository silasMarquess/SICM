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
    public partial class FrmCadVinculo : Form
    {
        private ControlCadVinculo _control;
        public FrmCadVinculo()
        {
            InitializeComponent();
            _control = new ControlCadVinculo(this);
           // _control.BuscaListaCargos();
        }

        public FrmCadVinculo(VinculoFuncional vincProvisorio)
        {
            InitializeComponent();
            _control = new ControlCadVinculo(this);

            if (!(vincProvisorio is null))
            {
                _control.BuscaListaCargos(vincProvisorio.Depart);
                txt_codigoIgreja.Text = vincProvisorio.Igreja.Codigo;
                txt_IgrejaVinculada.Text = vincProvisorio.Igreja.Nome;
                txt_IdDepartamento.Text = vincProvisorio.Depart.Id.ToString();
                txt_DepartamentoVinculado.Text = vincProvisorio.Depart.Nome;
                txt_IdCargo.Text = vincProvisorio.Cargo.Id.ToString();
                txt_CargoVinculado.Text = vincProvisorio.Cargo.Nome;
            }
            else
            {
                MessageBox.Show("Nemhum Cargo selecionado Antes !");
            }

        }

        private void txt_PesquisaForNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _control.ControlPesqNome(txt_PesquisaForNome.Text);
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_PesquisaForNome_MouseDown(object sender, MouseEventArgs e)
        {
            // txt_PesquisaForNome.SelectAll();
        }

        private void Lv_MembrosFiltrados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lv_MembrosFiltrados_Click(object sender, EventArgs e)
        {
            try
            {
                _control.MostraMembroAtual();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCadVinculo_Load(object sender, EventArgs e)
        {
            _control.ControlPesqNome(txt_PesquisaForNome.Text);
            _control.controlListaAnos();
        }

        private void aMasculinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_PesquisaForNome.Text = string.Empty;
            _control.ControlFiltraGenero(TipoGenero.MASCULINO);
        }

        private void bFemininoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_PesquisaForNome.Text = string.Empty;
            _control.ControlFiltraGenero(TipoGenero.FEMININO);
        }

        private void membroComunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_PesquisaForNome.Text = string.Empty;
            _control.ControlFilCat(TipoCategoria.JUVENTUDE);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            txt_PesquisaForNome.Text = string.Empty;
            _control.ControlFilCat(TipoCategoria.OBREIROS);
        }

        private void cCÍRCULOORAÇÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_PesquisaForNome.Text = string.Empty;
            _control.ControlFilCat(TipoCategoria.CIRCULO_ORACAO);
        }

        private void dOUTRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_PesquisaForNome.Text = string.Empty;
            _control.ControlFilCat(TipoCategoria.OUTRA);
        }

        private void aMembComunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_PesquisaForNome.Text = string.Empty;
            _control.ControlFiltSubCat(SubCategoria.MEMBRO_COMUM);
        }

        private void bOBREIROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_PesquisaForNome.Text = string.Empty;
            _control.ControlFiltSubCat(SubCategoria.DIACONO);
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_PesquisaForNome.Text = string.Empty;
            _control.ControlFiltSubCat(SubCategoria.PRESBITERO);
        }

        private void dAuxiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_PesquisaForNome.Text = string.Empty;
            _control.ControlFiltSubCat(SubCategoria.AUXILIAR);
        }

        private void Cb_AnosExercicios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cb_AnosExercicios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dta_Fim.Enabled = true;
            Dta_Inicio.Enabled = true;
        }

        private void Dta_Inicio_DropDown(object sender, EventArgs e)
        {
            try
            {
                if (Cb_AnosExercicios.SelectedItem.ToString() == string.Empty) throw new DomainsExcpetion("Selecione primeiro um Ano !");
                _control.SetDataInOutValidaVinculo();
                _control.CalcalaDuracao();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Test");
            }
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            try
            {
                _control.ControlInsertVinculo();
            }
            catch (DomainsExcpetion ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dta_Fim_ValueChanged(object sender, EventArgs e)
        {
            _control.CalcalaDuracao();
        }

        private void Dta_Inicio_ValueChanged(object sender, EventArgs e)
        {
            _control.CalcalaDuracao();
        }
    }
}
