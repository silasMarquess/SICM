using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;
using SICM.Entidades;
using SICM.DAO;
using System.Windows.Forms;
using SICM.SubForms;


namespace SICM.Controller
{
    class ControlCadVinculo
    {
        public FrmCadVinculo _form { get; set; }
        private List<Membro> _listaMembro;
        private TipoCategoria _categoriaFiltro;
        private SubCategoria _SubCatFiltro;
        private TipoGenero _Genero;
        private List<Cargo> _listaCargo;

        public ControlCadVinculo(FrmCadVinculo form)
        {
            _form = form;
        }

        public void MostraInforDepart(VinculoFuncional vinc)
        {
            _form.txt_IgrejaVinculada.Text = vinc.Igreja.Nome;
            _form.txt_DepartamentoVinculado.Text = vinc.Depart.Nome;
            _form.txt_CargoVinculado.Text = vinc.Cargo.Nome;
        }

        public void controlListaAnos()
        {
            int anoAtual = DateTime.Now.Year;
            _form.Cb_AnosExercicios.Items.Clear();
            for (int i = anoAtual; i <= (anoAtual + 3); i++)
            {
                _form.Cb_AnosExercicios.Items.Add(i);
            }
        }

        public void SetDataInOutValidaVinculo()
        {
            int ano = int.Parse(_form.Cb_AnosExercicios.SelectedItem.ToString());
            int anoAtual = DateTime.Now.Year;
            _form.Dta_Inicio.MinDate = new DateTime(anoAtual, 01, 01);
            _form.Dta_Inicio.MaxDate = new DateTime(ano, 12, 31);

            _form.dta_Fim.MinDate = new DateTime(anoAtual, 01, 01);
            _form.dta_Fim.MaxDate = new DateTime(ano, 12, 31);
        }

        public void MostraMembroAtual()
        {
            Membro atual = _listaMembro.Find(getMembroForCodigo);
            if (atual is null) throw new DomainsExcpetion("Nemhum Membro selecionado !");
            _form.txt_CodigoMemb.Text = atual.Codigo;
            _form.txt_NomeMembro.Text = atual.Nome;
            _form.txt_telefoneMemb.Text = atual.DadosPessoais.Telefone;
        }

        public void BuscaListaCargos(Departamento dp)
        {
            ConexaoDAO.ModifyOperation(DepartamentoDAO.GetListaCargo, dp);
            _listaCargo = dp.ListaCargos;
        }

        private void ControlValidaInsert()
        {
            if (_form.txt_codigoIgreja.Text == string.Empty) throw new DomainsExcpetion("Igreja nao selecionada");
            if (_form.txt_IdCargo.Text == string.Empty) throw new DomainsExcpetion("Cargo nao selecionado");
            if (_form.txt_IdDepartamento.Text == string.Empty) throw new DomainsExcpetion("Departamento nao selecionado");
            if (_form.txt_CodigoMemb.Text == string.Empty) throw new DomainsExcpetion("Membro Nao selecionado");
            if (_form.Cb_AnosExercicios.SelectedItem == null) throw new DomainsExcpetion("Nemhum Ano de exercicio selecionado");

            if (_form.dta_Fim.Value < _form.Dta_Inicio.Value || _form.dta_Fim.Value == _form.Dta_Inicio.Value)
            {
                throw new DomainsExcpetion("Data do fim do vinculo nao pode ser Menor/Igual do que a data de inicio");
            }
        }

        private void LimpaCamposCadUpdateVinc()
        {
            _form.txt_codigoIgreja.Text = string.Empty;
            _form.txt_IgrejaVinculada.Text = string.Empty;
            _form.txt_IdCargo.Text = string.Empty;
            _form.txt_CargoVinculado.Text = string.Empty;
            _form.txt_IdDepartamento.Text = string.Empty;
            _form.txt_DepartamentoVinculado.Text = string.Empty;
            _form.txt_NomeMembro.Text = string.Empty;
            _form.txt_CodigoMemb.Text = string.Empty;
            _form.txt_telefoneMemb.Text = string.Empty;
            _form.Cb_AnosExercicios.SelectedIndex = -1;
        }

        public void ControlPesqNome(string nomeMembro)
        {
            string nomeIgreja = _form.txt_IgrejaVinculada.Text;
            string codigo = _form.txt_codigoIgreja.Text;
            Igreja i = new Igreja(codigo, nomeIgreja);
            if (_listaMembro != null) _listaMembro = null;

           _listaMembro = ConexaoDAO.getLisObjectOperation(MembroDB.BuscaListaMembros, i, nomeMembro);

            //_listaMembro = i.ListaMembros;

            _form.Lv_MembrosFiltrados.Items.Clear();
            foreach (Membro m in _listaMembro)
            {
                ListViewItem item = new ListViewItem(new string[] { m.Codigo, m.Nome, m.Categoria.ToString(), m.SubCategoria.ToString() });
                _form.Lv_MembrosFiltrados.Items.Add(item);
            }
        }

        public void ControlInsertVinculo()
        {
            ControlValidaInsert();
            string nome = _form.txt_IgrejaVinculada.Text;
            string codigo = _form.txt_codigoIgreja.Text;
            Igreja i = new Igreja(codigo, nome);

            int idDeparta = int.Parse(_form.txt_IdDepartamento.Text);
            string nomeDepart = _form.txt_DepartamentoVinculado.Text;
            Departamento dp = new Departamento(idDeparta, nomeDepart);

            string NomeMembro = _form.txt_NomeMembro.Text;
            string codigoMem = _form.txt_CodigoMemb.Text;

            Membro m = new Membro(codigoMem, NomeMembro);

            int idCargo = int.Parse(_form.txt_IdCargo.Text);
            string nomeCargo = _form.txt_CargoVinculado.Text;

            Cargo c = _listaCargo.Find(getCargoForId);

            int ano = int.Parse(_form.Cb_AnosExercicios.Text);
            DateTime dataInicio = _form.Dta_Inicio.Value;
            DateTime dataFim = _form.dta_Fim.Value;


            VinculoFuncional vinc = new VinculoFuncional(0, ano, dataInicio, dataFim, i, dp, c, m, StatusVinculo._ATIVO);
            bool test = ConexaoDAO.ValidateOperation(VinculoDAO.VerifiSeVinculoExis, vinc);
            if (test) throw new DomainsExcpetion("Erro: O vinculo Selecionado ja existe !");

            DialogResult res = MessageBox.Show("CONFIRMA O SEGUINTES DADOS:\n----------------------------" +
                "\n Membro= " + vinc.Membro.Nome + "\n" +
                 "Departamento= " + vinc.Depart.Nome + "\n" +
                 "Cargo= " + vinc.Cargo.Nome + "\n" +
                 "Igreja= " + vinc.Igreja.Nome + " ?\n--------------------------", "CONFIRME ANTES: ", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                ConexaoDAO.ModifyOperation(VinculoDAO.InsertVinculo, vinc);
                c.Status = StatusCargo.OCUPADO;
                ConexaoDAO.ModifyOperation(DepartamentoDAO.UpdateCargo, c);
                MessageBox.Show("Novo Vinculo Criado com sucesso !");
            }
            else
            {
                MessageBox.Show("Corrija os dados Antes");
            }
        }

        public void ControlFiltraVinculoAno()
        {

        }

        public void CalcalaDuracao()
        {
            TimeSpan duracao = _form.dta_Fim.Value.Subtract(_form.Dta_Inicio.Value);
            _form.Lb_Duracao.Text = (duracao.TotalDays / 30).ToString("F2") + " Meses";
        }

        public void ControlFilCat(TipoCategoria cat)
        {
            _categoriaFiltro = cat;
            List<Membro> listaF = _listaMembro.FindAll(FiltraCategoria);
            _form.Lv_MembrosFiltrados.Items.Clear();

            foreach (Membro m in listaF)
            {
                ListViewItem item = new ListViewItem(new string[] { m.Codigo, m.Nome, m.Categoria.ToString(), m.SubCategoria.ToString() });
                _form.Lv_MembrosFiltrados.Items.Add(item);
            }
        }

        public void ControlFiltSubCat(SubCategoria subCat)
        {
            _SubCatFiltro = subCat;
            List<Membro> listaF = _listaMembro.FindAll(FiltraSubCategoria);
            _form.Lv_MembrosFiltrados.Items.Clear();

            foreach (Membro m in listaF)
            {
                ListViewItem item = new ListViewItem(new string[] { m.Codigo, m.Nome, m.Categoria.ToString(), m.SubCategoria.ToString() });
                _form.Lv_MembrosFiltrados.Items.Add(item);
            }
        }

        public void ControlFiltraGenero(TipoGenero gen)
        {
            _Genero = gen;
            List<Membro> listaF = _listaMembro.FindAll(FiltraGenero);
            _form.Lv_MembrosFiltrados.Items.Clear();

            foreach (Membro m in listaF)
            {
                ListViewItem item = new ListViewItem(new string[] { m.Codigo, m.Nome, m.Categoria.ToString(), m.SubCategoria.ToString() });
                _form.Lv_MembrosFiltrados.Items.Add(item);
            }
        }

        //filtros
        public bool FiltraCategoria(Membro m)
        {
            return (m.Categoria == _categoriaFiltro) ? true : false;
        }

        public bool FiltraSubCategoria(Membro m)
        {
            return (m.SubCategoria == _SubCatFiltro) ? true : false;
        }

        public bool FiltraGenero(Membro m)
        {
            return (m.DadosPessoais.Genero == _Genero) ? true : false;
        }

        private bool getMembroForCodigo(Membro m)
        {
            int index = _form.Lv_MembrosFiltrados.SelectedIndices[0];
            string codigo = _form.Lv_MembrosFiltrados.Items[index].SubItems[0].Text;
            return (m.Codigo == codigo) ? true : false;
        }

        private bool getCargoForId(Cargo c)
        {
            int idCargo = int.Parse(_form.txt_IdCargo.Text);
            return (c.Id == idCargo) ? true : false;
        }



    }
}
