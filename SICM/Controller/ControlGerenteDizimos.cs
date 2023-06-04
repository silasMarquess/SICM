using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.DAO;
using SICM.Entidades.Enumeracoes;
using SICM.Entidades;
using SICM.Servicos;
using System.Windows.Forms;
using SICM.SubForms;
using SICM.DAO;
using SICM.Relatorios;
using Google.Protobuf.WellKnownTypes;

namespace SICM.Controller
{
    class ControlGerenteDizimos
    {
        private FrmDizimos _form;
        private List<Templo> _listaSede;
        private List<Congregacao> _listaCongs;
        private List<Dizimo> _listaDizimos;

        public ControlGerenteDizimos(FrmDizimos form)
        {
            _form = form;
        }

        public void ControlReportPrestacao()
        {
            double totalDizimo = CalculaTotalDizimo();
            FrmPrestacaoContas form = new FrmPrestacaoContas(totalDizimo);
            form.ShowDialog();  
        }

    

        public void ControlInsetDizimo()
        {
            ValidaInsercaoDizimo();
            string codigo = _form.txt_CodigoMembro.Text;
            string nome = _form.txt_NomeMembro.Text;
            Membro m = new Membro(codigo, nome);

            Igreja i = null;

            if (_form.Rb_Congregacao.Checked)
            {
                i = _listaCongs.Find(getCongregacao);
            }
            else
            {
                i = _listaSede.Find(getTemploForCodigo);
            }
            TipoDizimo tipo = TipoDizimo.MONETARIO;
            string descricao = "NÃO SE APLICA";

            if (_form.Rb_Cereais.Checked) {
                tipo = TipoDizimo.CEREAIS;
                if (_form.txt_descricaoDizimo.Text == string.Empty) throw new DomainsExcpetion("Campo de descrição não pode ser vazio");
                descricao = _form.txt_descricaoDizimo.Text;
            } 
            
            
            int mes = _form.Cb_ListaMeses.SelectedIndex + 1;
            int ano = int.Parse(_form.Cb_Anos.Text);
            double valor = double.Parse(_form.NuP_ValorDizimo.Value.ToString());

            Dizimo diz = new Dizimo(0, ano, mes, m, i,tipo,valor,descricao);

            bool test = ConexaoDAO.ValidateOperation(CaixaDAO.VerificaSeDizimoExiste, diz);
            if (test) throw new DomainsExcpetion("Erro: este dízimo ja está cadastrado !");
            ConexaoDAO.ModifyOperation(CaixaDAO.InsertNewDizimo, diz);
            MessageBox.Show("Dizimo cadastrado com sucesso");
            LimparCampos();
            ControlMostraListaDizimos();
        }

        private void LimparCampos()
        {
            _form.txt_PesquisaNome.Text = string.Empty;
            _form.txt_CodigoMembro.Text = string.Empty;
            _form.txt_NomeMembro.Text = string.Empty;
            _form.txt_DataHoje.Text = string.Empty;
            _form.NuP_ValorDizimo.Value = 0;
        }

        public void LancarDizimposParaEntrada()
        {  
            List<Caixa> listaCaixas = ConexaoDAO.getLisObjectOperation(CaixaDAO.getListaCaixa);
         
            Caixa c = listaCaixas.Find(getCaixaForNome);

            if (c is null) throw new DomainsExcpetion("Erro; nemhum caixa principal associado a essa Entidade criado no momento.\n" +
                "Cadastre um caixa associado primeire neste mesmo módulo e depois tente lançar esse valor novamente !");
           
            string origem = "DIZIMOS DO MÊS ATUAL";
            int ano = int.Parse(_form.Cb_Anos.SelectedItem.ToString());
            int mes = int.Parse((_form.Cb_ListaMeses.SelectedIndex + 1).ToString());
            DateTime data = new DateTime(ano, mes, 01);

            double valor = CalculaTotalDizimo();
            if (valor == 0) throw new DomainsExcpetion("Voçê não pode lançar um Valor igual a: 0.00 R$ ");
            NaturezaMovimentacao nat = NaturezaMovimentacao.DÍZIMO;
            TipoMovimentacao tipo = TipoMovimentacao.DINHEIRO;

            Entrada end = new Entrada(0,origem,data,valor,nat,tipo,c);
            bool teste = ConexaoDAO.ValidateOperation(CaixaDAO.VerificaSeEntradaJaExiste, end);
            if (teste) throw new DomainsExcpetion("Erro: Vc ja lançou uma entrada com esse nome.\n" +
                "Tente Editar a entrada no Modulo de GERENTE DE CAIXAS");

            ConexaoDAO.ModifyOperation(CaixaDAO.InsertEntrada, end);
            MessageBox.Show("Dizimos lançado no caixa Principal da Igreja");

        }

        public bool getCaixaForNome(Caixa c)
        {
            Igreja i = null;

            if (_form.Rb_Congregacao.Checked)
            {
                i = _listaCongs.Find(getCongregacao);
            }
            else
            {
                i = _listaSede.Find(getTemploForCodigo);
            }

            string nomeEntidade = "CAIXA-" + i.Nome;
            return (c.Nome == nomeEntidade) ? true : false;
        }

        


        public void ControlMostraListaDizimos()
        {
            Igreja i = null;

            if (_form.Rb_Congregacao.Checked)
            {
                i = _listaCongs.Find(getCongregacao);
            }
            else
            {
                i = _listaSede.Find(getTemploForCodigo);
            }

            if (_form.Cb_Anos.Text == string.Empty || _form.Cb_ListaMeses.Text == string.Empty) throw new DomainsExcpetion("erro: memhum ano selecionado !");

            int ano = int.Parse(_form.Cb_Anos.Text);
            int mes = _form.Cb_ListaMeses.SelectedIndex;

            _listaDizimos = ConexaoDAO.getLisObjectOperation(CaixaDAO.getListaDizimo, i,ano,(mes+1));
            _form.Dgv_ListaDizimistas.Rows.Clear();

            for (int j = 0; j < _listaDizimos.Count(); j++)
            {
                DataGridViewRow linha = (DataGridViewRow)_form.Dgv_ListaDizimistas.Rows[j].Clone();
                linha.Cells[0].Value = _listaDizimos[j].Id.ToString();
                linha.Cells[1].Value = _listaDizimos[j].Membro.Nome.ToString();
                linha.Cells[3].Value = _listaDizimos[j].Valor.ToString("F2") + " R$";
                linha.Cells[2].Value = _listaDizimos[j].Descricao.ToUpper() ;
             //  ListaMeses mesAtual = (ListaMeses)(_listaDizimos[j].Mes-1);
                linha.Cells[4].Value = _listaDizimos[j].Tipo.ToString();
                _form.Dgv_ListaDizimistas.Rows.Add(linha);
            }
            _form.lb_NumeroDizimo.Text = _listaDizimos.Count()+" Registrados !";
            _form.lb_total.Text = this.CalculaTotalDizimo().ToString("F2")+" R$";
            double media = this.CalculaTotalDizimo() / _listaDizimos.Count;
            _form.lb_Media.Text = media.ToString("F2") + " R$";
        }

        public void ControlReport()
        {
            if (_listaDizimos.Count == 0) throw new DomainsExcpetion("Erro: nemhuma lista ou membro Filtrado no momento");
            FrmRelDizimistas form = new FrmRelDizimistas(_listaDizimos);
            form.ShowDialog();  
        }

        public void ControlMostraListaDizimos(string nomeMembro)
        {
            Igreja i = null;

            if (_form.Rb_Congregacao.Checked)
            {
                i = _listaCongs.Find(getCongregacao);
            }
            else
            {
                i = _listaSede.Find(getTemploForCodigo);
            }

            if (_form.Cb_Anos.Text == string.Empty || _form.Cb_ListaMeses.Text == string.Empty) throw new DomainsExcpetion("erro: memhum ano selecionado !");

            int ano = int.Parse(_form.Cb_Anos.Text);
            int mes = _form.Cb_ListaMeses.SelectedIndex;

            _listaDizimos = ConexaoDAO.getLisObjectOperation(CaixaDAO.getListaDizimo, i, ano, (mes + 1),nomeMembro);
            _form.Dgv_ListaDizimistas.Rows.Clear();

            for (int j = 0; j < _listaDizimos.Count(); j++)
            {
                DataGridViewRow linha = (DataGridViewRow)_form.Dgv_ListaDizimistas.Rows[j].Clone();
                linha.Cells[0].Value = _listaDizimos[j].Id.ToString();
                linha.Cells[1].Value = _listaDizimos[j].Membro.Nome.ToString();
                linha.Cells[3].Value = _listaDizimos[j].Valor.ToString("F2") + " R$";
                linha.Cells[2].Value = _listaDizimos[j].Descricao.ToUpper();
                //  ListaMeses mesAtual = (ListaMeses)(_listaDizimos[j].Mes-1);
                linha.Cells[4].Value = _listaDizimos[j].Tipo.ToString();
                _form.Dgv_ListaDizimistas.Rows.Add(linha);
            }
            _form.lb_NumeroDizimo.Text = _listaDizimos.Count() + " Registrados !";
            _form.lb_total.Text = this.CalculaTotalDizimo().ToString("F2") + " R$";
            double media = this.CalculaTotalDizimo() / _listaDizimos.Count;
            _form.lb_Media.Text = media.ToString("F2") + " R$";
        }

        public void FiltraDizimos()
        {
            Igreja i = null;

            if (_form.Rb_Congregacao.Checked)
            {
                i = _listaCongs.Find(getCongregacao);
            }
            else
            {
                i = _listaSede.Find(getTemploForCodigo);
            }
            int ano = int.Parse(_form.Cb_Anos.Text);
            int mes = _form.Cb_ListaMeses.SelectedIndex;

            _listaDizimos = ConexaoDAO.getLisObjectOperation(CaixaDAO.getListaDizimo, i, ano, (mes + 1));

            if (_listaDizimos is null) throw new DomainsExcpetion("erro: Nemhuma Lista de Dizimistas Filtrada. Selecione uma Igreja, mes e Ano e Filtre os Dizimistas");
            _listaDizimos = _listaDizimos.FindAll(GetDizimoPorTipo);

            _form.Dgv_ListaDizimistas.Rows.Clear();
            for (int j = 0; j < _listaDizimos.Count(); j++)
            {
                DataGridViewRow linha = (DataGridViewRow)_form.Dgv_ListaDizimistas.Rows[j].Clone();
                linha.Cells[0].Value = _listaDizimos[j].Id.ToString();
                linha.Cells[1].Value = _listaDizimos[j].Membro.Nome.ToString();
                linha.Cells[3].Value = _listaDizimos[j].Valor.ToString("F2") + " R$";
                linha.Cells[2].Value = _listaDizimos[j].Descricao.ToUpper();
                //  ListaMeses mesAtual = (ListaMeses)(_listaDizimos[j].Mes-1);
                linha.Cells[4].Value = _listaDizimos[j].Tipo.ToString();
                _form.Dgv_ListaDizimistas.Rows.Add(linha);
            }
            _form.lb_NumeroDizimo.Text = _listaDizimos.Count() + " Registrados !";
            _form.lb_total.Text = this.CalculaTotalDizimo().ToString("F2") + " R$";
            double media = this.CalculaTotalDizimo() / _listaDizimos.Count;
            _form.lb_Media.Text = media.ToString("F2") + " R$";

        }

        private double CalculaTotalDizimo()
        {
            double total = 0;
            if (_listaDizimos is null) throw new DomainsExcpetion("erro: Nemhuma lista filtrada no momento !");
            foreach(Dizimo diz in _listaDizimos)
            {
                total += diz.Valor;
            }
            return total;
        }

        private void ValidaInsercaoDizimo()
        {
            if (_form.txt_CodigoMembro.Text == string.Empty || _form.txt_NomeMembro.Text == string.Empty) throw new DomainsExcpetion("Erro: nemhum membro selecionado !");
            //if (_form.NuP_ValorDizimo.Value == 0) throw new DomainsExcpetion("Erro: Não é possivel adicionar um dizimo com valor zerado !");

            if (_form.Rb_Congregacao.Checked)
            {
                if (_form.Cb_ListaCongregacao.Text == string.Empty) throw new DomainsExcpetion("Erro: nemhuma congregação selecionada");
            }
            else
            {
                if (_form.Cb_ListaTemplos.Text == string.Empty) throw new DomainsExcpetion("erro: nemhum templo sede selecionado momento");
            }
            if (_form.Cb_Anos.Text == string.Empty) throw new DomainsExcpetion("erro> nemhum ano selecionado !");
            if (_form.Cb_ListaMeses.Text == string.Empty) throw new DomainsExcpetion("erro: nemhum mes selecionado no momento !");
        }

        public void ControlMostraSedes()
        {
            _listaSede = ConexaoDAO.getLisObjectOperation(IgrejaDAO.GetListaTemplo);
            _form.Cb_ListaTemplos.DataSource = _listaSede;
            _form.Cb_ListaTemplos.ValueMember = "codigo";
            _form.Cb_ListaTemplos.DisplayMember = "nome";
        }

        public void GetInfoUpdateDizimo()
        {
             Dizimo diz = _listaDizimos.Find(getDizimoForId);
             _form.txt_CodigoMembro.Text = diz.Membro.Codigo;
            _form.txt_NomeMembro.Text = diz.Membro.Nome;
            _form.txt_DataHoje.Text = DateTime.Now.ToShortDateString();
            _form.NuP_ValorDizimo.Value = decimal.Parse(diz.Valor.ToString());
            _form.txt_Iddizimo.Text = _form.Dgv_ListaDizimistas.CurrentRow.Cells[0].Value.ToString();
        }

        public void ControlUpdateDizimo()
        {
          //  ValidaInsercaoDizimo();
            string codigo = _form.txt_CodigoMembro.Text;
            string nome = _form.txt_NomeMembro.Text;
            Membro m = new Membro(codigo, nome);

            Igreja i = null;

            if (_form.Rb_Congregacao.Checked)
            {
                i = _listaCongs.Find(getCongregacao);
            }
            else
            {
                i = _listaSede.Find(getTemploForCodigo);
            }

            TipoDizimo tipo = TipoDizimo.MONETARIO;
            string descricao = "NÃO SE APLICA";

            if (_form.Rb_Cereais.Checked)
            {
                tipo = TipoDizimo.CEREAIS;
                if (_form.txt_descricaoDizimo.Text == string.Empty) throw new DomainsExcpetion("Campo de descrição noa pode ser vazio");
                descricao = _form.txt_descricaoDizimo.Text;
            }

            int mes = _form.Cb_ListaMeses.SelectedIndex + 1;
            int ano = int.Parse(_form.Cb_Anos.Text);
            double valor = double.Parse(_form.NuP_ValorDizimo.Value.ToString());
            if (_form.txt_Iddizimo.Text == string.Empty) throw new DomainsExcpetion("Erro: Nemhum dizimo selecionado !");
            int idDizimo = int.Parse(_form.txt_Iddizimo.Text); 

            Dizimo diz = new Dizimo(idDizimo, ano, mes, m, i,tipo,valor,descricao);

            ConexaoDAO.ModifyOperation(CaixaDAO.UpdateDizimo, diz);
            MessageBox.Show("Dados dos dizimo atualizado com sucesso");
            LimparCampos();
            ControlMostraListaDizimos();
        }

        public void ControlDeleteDizimo()
        {
            Dizimo diz = _listaDizimos.Find(getDizimoForId);
            DialogResult res = MessageBox.Show("Deseja realmente deletar o dizimo de: " + diz.Membro.Nome + " ?", "CONFIRME:", MessageBoxButtons.YesNo);
             if (res == DialogResult.No) throw new DomainsExcpetion("Operação cancelada. Tome mais cuidado a sair apertando em qualquer butão");
            ConexaoDAO.ModifyOperation(CaixaDAO.DeleteDizimo, diz);
            MessageBox.Show("Dizimo selecionado deletado com sucesso !");
        }

        public void FiltraMembroForNome(string nome)
        {
            Igreja i = null;

            if (_form.Rb_Congregacao.Checked)
            {
                i = _listaCongs.Find(getCongregacao);
            }
            else
            {
                i = _listaSede.Find(getTemploForCodigo);
            }
            List<Membro> lista = ConexaoDAO.getLisObjectOperation(MembroDB.BuscaListaMembros, i, nome);

            //mostrando lista
            _form.Lv_ListaMembroFiltrados.Items.Clear();
            foreach (Membro m in lista)
            {
                if (m.Categoria == TipoCategoria.OBREIROS)
                {
                    SubCategoria subCat = m.SubCategoria;
                    switch (subCat)
                    {
                        case SubCategoria.AUXILIAR:
                            m.Nome = "AUX." + m.Nome;
                            break;

                        case SubCategoria.DIACONO:
                            m.Nome = "DC." + m.Nome;
                            break;

                        case SubCategoria.PRESBITERO:
                            m.Nome = "PB." + m.Nome;
                            break;

                        case SubCategoria.PASTOR:
                            m.Nome = "PR." + m.Nome;
                            break;
                    }
                }
                ListViewItem item = new ListViewItem(new string[] { m.Codigo, m.Nome });
                _form.Lv_ListaMembroFiltrados.Items.Add(item);
            }

        }

        public void MostraListaAnos()
        {
            int anoAtual = DateTime.Now.Year;
            _form.Cb_Anos.Items.Clear();

            for (int i = anoAtual; i >= (anoAtual - 10); i--)
            {
                _form.Cb_Anos.Items.Add(i);
            }
            _form.Cb_Anos.SelectedIndex = 0;
            ListaMeses mes =(ListaMeses) DateTime.Now.Month - 1;
            _form.Cb_ListaMeses.SelectedItem = mes.ToString();
        }





        public void MostraListaCongs()
        {
            Templo sede = _listaSede.Find(getTemploForCodigo);
            _listaCongs = ConexaoDAO.getLisObjectOperation(IgrejaDAO.getListaCongregacao, sede);
            _form.Cb_ListaCongregacao.DataSource = _listaCongs;
            _form.Cb_ListaCongregacao.DisplayMember = "nome";
            _form.Cb_ListaCongregacao.ValueMember = "codigo";
        }


        //delegates

        public bool getTemploForCodigo(Templo t)
        {
            string codigoTemplo = _form.Cb_ListaTemplos.SelectedValue.ToString();
            return (codigoTemplo == t.Codigo) ? true : false;
        }

        public bool getCongregacao(Congregacao cong)
        {
            string codigo = _form.Cb_ListaCongregacao.SelectedValue.ToString();
            return (cong.Codigo == codigo) ? true : false;
        }

        public bool GetDizimoPorTipo(Dizimo diz)
        {
            TipoDizimo tipo = (TipoDizimo)_form.Cb_tipoDizimo.SelectedIndex;
            return (diz.Tipo==tipo)?true:false;
        }

        public bool getDizimoForId(Dizimo diz)
        {
            int id = int.Parse(_form.Dgv_ListaDizimistas.CurrentRow.Cells[0].Value.ToString());
            return (diz.Id == id) ? true : false;
        }
    }
}
