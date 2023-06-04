using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;
using SICM.Entidades;
using SICM.DAO;
using SICM.Servicos;
using SICM.SubForms;
using System.Data;
using System.Windows.Forms;
using SICM.Relatorios;
using SICM.Relatorios.rdlcFiles;

namespace SICM.Controller
{
    class ControlGerenteMembro
    {
        private FrmGerenciaMembros _form;
        private List<Templo> _listaTemplo;
        private List<Congregacao> _listaCongregacao;
        private List<Membro> _listaMembro;
        private List<Membro> _listaFiltrada;

        //filtraCategoria
        private TipoCategoria _CategoriaSelecionada;

        //FiltraStatus
        private StatusMembro _StatusSelecionado;

        //FiltraGenero
        private TipoGenero _GeneroSelecionado;

        //Filtra SubCategoria
        private SubCategoria _SubCategoria;

        //Filtra TipoEscolaridade;
        private TipoEscolaridade _TipoEscolaridade;

        //filtra EstadoCivil
        private TipoEstCivil _EstadoCivil;

        public ControlGerenteMembro(FrmGerenciaMembros form)
        {
            _form = form;
        }

        public void PrintService()
        {
            if (_listaFiltrada == null) throw new DomainsExcpetion("Erro: Nemhum Lista Filtrada no momento !");
            FrmRelMembros rel = new FrmRelMembros(_listaFiltrada);
            rel.ShowDialog();
        }

        public void PrintFichaMembroselecionado()
        {
            Membro m = _listaMembro.Find(GetMembroForCodigo);
            ConexaoDAO.ModifyOperation(VinculoDAO.GetListaVinculosForDepartamento, m);
            FrmRelFichaMembro form = new FrmRelFichaMembro(m);
            form.ShowDialog();
        }

        public void EmitirCartaRecomendacao()
        {
            Membro m = _listaMembro.Find(GetMembroForCodigo);
            FrmCartaMembro carta = new FrmCartaMembro(m);
            carta.ShowDialog();
        }

        public void ControlPreencheListaTemplo()
        {
            _listaTemplo = ConexaoDAO.getLisObjectOperation(IgrejaDAO.GetListaTemplo);

            _form.Cb_TemploSede.Items.Clear();
            _form.Cb_IdTemplo.Items.Clear();

            foreach (Templo sede in _listaTemplo)
            {
                _form.Cb_TemploSede.Items.Add(sede.Nome);
                _form.Cb_IdTemplo.Items.Add(sede.Id);
            }
        }

        public void ControlUpdateMembro()
        {
            Membro membro = _listaMembro.Find(GetMembroForCodigo);
            _form.dgv_TabelMembros.Rows.Clear();
            FrmCadMembro form = new FrmCadMembro(membro);
            form.ShowDialog();
        }

        public void ControlMostraReuneMembros()
        {
            if (_form.Cb_TemploSede.Text == "") throw new DomainsExcpetion("Nemhum Templo Selecionado!");
            if (_form.Cb_SubDivisao.Text == "") throw new DomainsExcpetion("Erro Nemhuma Subdivisao Selecionada");

            if (_listaMembro != null) _listaMembro.Clear();

            Igreja i = null;
            if (_form.Cb_SubDivisao.Text == "TODAS")
            {
                //buscando membro das congregacoes
                _listaCongregacao.ForEach(GetMembroIgreja);

                //Selecionando Templo sede
                i = _listaTemplo.Find(GetTemploForNome);

                i.ListaMembros.Clear();


                //buscando membros do templo sede selecionado
                ConexaoDAO.ModifyOperation(MembroDB.BuscaListaMembros, i);
                _listaFiltrada = i.ListaMembros;
              
                //juntar todos os membro numa so lista                
                foreach (Congregacao con in _listaCongregacao)
                {
                    con.ListaMembros.Clear();
                    ConexaoDAO.ModifyOperation(MembroDB.BuscaListaMembros, con);
                    i.ListaMembros.AddRange(con.ListaMembros);
                }
            }
            else if (_form.Cb_SubDivisao.Text == "SEDE")
            {
                //Selecionando Templo sede
                i = _listaTemplo.Find(GetTemploForNome);
                i.ListaMembros.Clear();

                //buscando membros do templo sede selecionado
                ConexaoDAO.ModifyOperation(MembroDB.BuscaListaMembros, i);
            }
            else
            {
                i = _listaCongregacao.Find(GetCongregacaoForNome);
                i.ListaMembros.Clear();
                ConexaoDAO.ModifyOperation(MembroDB.BuscaListaMembros, i);
            }

            _listaMembro = i.ListaMembros;
            _StatusSelecionado = StatusMembro.ATIVO;
      
            _listaFiltrada = _listaMembro.FindAll(FiltraForStatus);

            _form.txt_NumRegistros.Text = _listaMembro.Count().ToString();

            _form.dgv_TabelMembros.Rows.Clear();

            for (int j = 0; j < _listaFiltrada.Count; j++)
            {
                DataGridViewRow linha = (DataGridViewRow)_form.dgv_TabelMembros.Rows[j].Clone();
                linha.Cells[0].Value = _listaFiltrada[j].Codigo;
                linha.Cells[1].Value = _listaFiltrada[j].Nome;
                linha.Cells[2].Value = _listaFiltrada[j].DadosPessoais.DataNascimento.ToShortDateString();
                linha.Cells[3].Value = _listaFiltrada[j].Status.ToString();
                linha.Cells[4].Value = _listaFiltrada[j].Categoria.ToString();
                linha.Cells[5].Value = _listaFiltrada[j].SubCategoria.ToString();
                _form.dgv_TabelMembros.Rows.Add(linha);
            }

        }

        public void ControlMostraReuneMembros(string nome)
        {
            if (_form.Cb_TemploSede.Text == "") throw new DomainsExcpetion("Nemhum Templo Selecionado!");
            if (_form.Cb_SubDivisao.Text == "") throw new DomainsExcpetion("Erro Nemhuma Subdivisao Selecionada");

            if (_listaMembro != null) _listaMembro.Clear();

            Igreja i = null;
            if (_form.Cb_SubDivisao.Text == "TODAS")
            {
                //buscando membro das congregacoes
                _listaCongregacao.ForEach(GetMembroIgreja);

                //Selecionando Templo sede
                i = _listaTemplo.Find(GetTemploForNome);
                i.ListaMembros.Clear();


                //buscando membros do templo sede selecionado
                ConexaoDAO.ModifyOperation(MembroDB.BuscaListaMembrosVoid, i, nome);

                //juntar todos os membro numa so lista                
                foreach (Congregacao con in _listaCongregacao)
                {
                    con.ListaMembros.Clear();
                    ConexaoDAO.ModifyOperation(MembroDB.BuscaListaMembrosVoid, con, nome);
                    i.ListaMembros.AddRange(con.ListaMembros);
                }
            }
            else if (_form.Cb_SubDivisao.Text == "SEDE")
            {
                //Selecionando Templo sede
                i = _listaTemplo.Find(GetTemploForNome);
                i.ListaMembros.Clear();

                //buscando membros do templo sede selecionado
                ConexaoDAO.ModifyOperation(MembroDB.BuscaListaMembrosVoid, i, nome);
            }
            else
            {
                i = _listaCongregacao.Find(GetCongregacaoForNome);
                i.ListaMembros.Clear();
                ConexaoDAO.ModifyOperation(MembroDB.BuscaListaMembrosVoid, i, nome);
            }
            _listaMembro = i.ListaMembros;
            _listaFiltrada = i.ListaMembros;

            _StatusSelecionado = StatusMembro.ATIVO;
            _listaFiltrada = _listaFiltrada.FindAll(FiltraForStatus);
            this.PreecheTabelPrincipal(_listaFiltrada);
        }

        private void PreecheTabelPrincipal(List<Membro> ListaFonte)
        {
            _form.txt_NumRegistros.Text = ListaFonte.Count().ToString();
            _form.dgv_TabelMembros.Rows.Clear();

            for (int j = 0; j < ListaFonte.Count; j++)
            {
                DataGridViewRow linha = (DataGridViewRow)_form.dgv_TabelMembros.Rows[j].Clone();
                linha.Cells[0].Value = ListaFonte[j].Codigo;
                linha.Cells[1].Value = ListaFonte[j].Nome;
                linha.Cells[2].Value = ListaFonte[j].DadosPessoais.DataNascimento.ToShortDateString();
                linha.Cells[3].Value = ListaFonte[j].Status.ToString();
                linha.Cells[4].Value = ListaFonte[j].Categoria.ToString();
                linha.Cells[5].Value = ListaFonte[j].SubCategoria.ToString();
                _form.dgv_TabelMembros.Rows.Add(linha);
            }
        }

        public void FiltraCategoria(TipoCategoria cat)
        {
            _CategoriaSelecionada = cat;
            _listaFiltrada = _listaMembro.FindAll(FiltraForCategoria);
            _StatusSelecionado = StatusMembro.ATIVO;
            _listaFiltrada = _listaFiltrada.FindAll(FiltraForStatus);
            this.PreecheTabelPrincipal(_listaFiltrada);
        }

        public void FiltraStatus(StatusMembro status)
        {
            _StatusSelecionado = status;
            if (_listaFiltrada != null) _listaFiltrada = null;
            _listaFiltrada = _listaMembro;
            _listaFiltrada = _listaMembro.FindAll(FiltraForStatus);
            this.PreecheTabelPrincipal(_listaFiltrada);
        }

        public void FiltraGenero(TipoGenero gen)
        {
            _GeneroSelecionado = gen;
            if (_listaFiltrada != null) _listaFiltrada = null;
            _listaFiltrada = _listaMembro.FindAll(FiltraForGenero);
            _StatusSelecionado = StatusMembro.ATIVO;
            _listaFiltrada = _listaFiltrada.FindAll(FiltraForStatus);
            this.PreecheTabelPrincipal(_listaFiltrada);
        }

        public void FiltraEscolaridade(TipoEscolaridade escolaridade)
        {
            _TipoEscolaridade = escolaridade;
            if (_listaFiltrada != null) _listaFiltrada = null;
            _listaFiltrada = _listaMembro.FindAll(FiltraForEscolaridade);
            _StatusSelecionado = StatusMembro.ATIVO;

            _listaFiltrada = _listaFiltrada.FindAll(FiltraForStatus);
            this.PreecheTabelPrincipal(_listaFiltrada);
        }

        public void FiltraEstadoCivil(TipoEstCivil estadoCivil)
        {
            _EstadoCivil = estadoCivil;
            if (_listaFiltrada != null) _listaFiltrada = null;
            _listaFiltrada = _listaMembro.FindAll(FiltrarForEstadoCivil);
            _StatusSelecionado = StatusMembro.ATIVO;

            _listaFiltrada = _listaFiltrada.FindAll(FiltraForStatus);
            this.PreecheTabelPrincipal(_listaFiltrada);
        }


        public void FiltraSubCategoria(SubCategoria subCar)
        {
            _SubCategoria = subCar;
            if (_listaFiltrada != null) _listaFiltrada = null;
            _listaFiltrada = _listaMembro.FindAll(FiltrarForSubCategoria);
            _StatusSelecionado = StatusMembro.ATIVO;

            _listaFiltrada = _listaFiltrada.FindAll(FiltraForStatus);
            this.PreecheTabelPrincipal(_listaFiltrada);
        }

        public void ControlDeleteMembroSelecionado()
        {
            Membro m = _listaMembro.Find(GetMembroForCodigo);
            DialogResult result = MessageBox.Show("Deseja realmente excluir o membro: " + m.Nome + " ?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);

            if (result == DialogResult.No) throw new DomainsExcpetion("Operação cancelada com sucesso !");
            ConexaoDAO.ModifyOperation(MembroDB.DeleteMembro, m);
            MessageBox.Show("Membro Deleteado com sucesso");
        }

        public void ControlMostraInfoMembroSelecionado()
        {
            if (_form.dgv_TabelMembros.SelectedRows.Count == 0) throw new DomainsExcpetion("Erro: Nemhum Membro selecionado");
            Membro selecionado = _listaMembro.Find(GetMembroForCodigo);
            _form.Gb_InforMembro.Text = selecionado.Nome.ToUpper();
            _form.txt_Cpf.Text = selecionado.DadosPessoais.Cpf;
            _form.txt_Sexo.Text = selecionado.DadosPessoais.Genero.ToString();
            _form.txt_Nacionalidade.Text = selecionado.DadosPessoais.Nacionalidade;
            _form.txt_Naturalidade.Text = selecionado.DadosPessoais.Naturalidade;
            _form.txt_EstadoCivil.Text = selecionado.DadosPessoais.EstadoCivil.ToString();
            _form.txt_Escolaridade.Text = selecionado.DadosPessoais.Escolaridade.ToString();
            _form.txt_Conjuge.Text = selecionado.DadosPessoais.Conjuge;

            _form.txt_Rua.Text = selecionado.Endereco.Rua;
            _form.txt_Numero.Text = selecionado.Endereco.Numero;
            _form.txt_Bairro.Text = selecionado.Endereco.Bairro;
            _form.txt_Cidade.Text = selecionado.Endereco.Cidade;
            _form.txt_UnidadeFederativa.Text = selecionado.Endereco.Estado;

            _form.txt_DataBat.Text = selecionado.DadosEsp.DataBatismal.ToShortDateString();
            _form.txt_LocalBatismo.Text = selecionado.DadosEsp.LocalBatismo;

        }



        public void ControlPreencheListaCong()
        {
            Templo temploSel = _listaTemplo.Find(GetTemploForNome);
            if (temploSel == null) throw new DomainsExcpetion("Erro: Templo Não encontrado. Recarregue o Formulário");
            _listaCongregacao = ConexaoDAO.getLisObjectOperation(IgrejaDAO.getListaCongregacao, temploSel);

            _form.Cb_SubDivisao.Items.Clear();
            _form.Cb_SubDivisao.Items.Add("SEDE");
            _form.Cb_SubDivisao.Items.Add("TODAS");

            foreach (Congregacao cong in _listaCongregacao)
            {
                _form.Cb_SubDivisao.Items.Add(cong.Nome);
            }
            _form.Cb_SubDivisao.Text = "";
        }


        //DELEGATE
        public bool GetMembroForCodigo(Membro m)
        {
            bool test = false;
            string codigo = _form.dgv_TabelMembros.CurrentRow.Cells[0].Value.ToString();
            if (m.Codigo == codigo)
            {
                test = true;
            }
            return test;
        }
        private bool GetTemploForNome(Templo t)
        {
            string nome = _form.Cb_TemploSede.SelectedItem.ToString();
            bool test = false;

            if (t.Nome == nome)
            {
                test = true;
            }
            return test;
        }
        public bool GetCongregacaoForNome(Congregacao cong)
        {
            bool test = false;
            string nome = _form.Cb_SubDivisao.SelectedItem.ToString();
            if (nome == cong.Nome)
            {
                test = true;
            }
            return test;
        }
        public void GetMembroIgreja(Igreja i)
        {
            ConexaoDAO.ModifyOperation(MembroDB.BuscaListaMembros, i);
        }

        //ROTINAS DE FILTROS

        public bool FiltraForCategoria(Membro m)
        {
            return (m.Categoria == _CategoriaSelecionada) ? true : false;
        }

        public bool FiltrarForSubCategoria(Membro m)
        {
            return (m.SubCategoria == _SubCategoria) ? true : false;
        }

        public bool FiltrarForEstadoCivil(Membro m)
        {
            return (m.DadosPessoais.EstadoCivil == _EstadoCivil) ? true : false;
        }

        public bool FiltraForStatus(Membro m)
        {
            return (m.Status == _StatusSelecionado) ? true : false;
        }

        public bool FiltraForEscolaridade(Membro m)
        {
            return (m.DadosPessoais.Escolaridade == _TipoEscolaridade) ? true : false;
        }

        public bool FiltraForGenero(Membro m)
        {
            return (_GeneroSelecionado == m.DadosPessoais.Genero) ? true : false;
        }

       


    }
}
