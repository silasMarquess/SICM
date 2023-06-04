using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;
using SICM.Entidades;
using SICM.DAO;
using SICM.SubForms;
using System.Windows.Forms;
using SICM.Relatorios;

namespace SICM.Controller
{
    class ControlFrmFinanceiro
    {
        private FrmFinanceiro _form;
        private List<Caixa> _listaCaixas;
        private Caixa _caixaAtual;

       
        public ControlFrmFinanceiro(FrmFinanceiro form)
        {
            _form = form;
        }

        public void MostraCaixa()
        {
            _listaCaixas = ConexaoDAO.getLisObjectOperation(CaixaDAO.getListaCaixa);
            _form.Cb_listaCaixa.DataSource = _listaCaixas;
            _form.Cb_listaCaixa.DisplayMember = "nome";
            _form.Cb_listaCaixa.ValueMember = "id";
        }
        public void ControlPrintInforCaixa()
        {
            Caixa selecionado = _listaCaixas.Find(getCaixaForId);
            FrmRelCaixa rel = new FrmRelCaixa(selecionado);
            rel.ShowDialog();
        }

        public void TranportarSaldo()
        {
            double saldo = _caixaAtual.CalculaSaldo();
            int mesAtual = _form.Cb_SelectMes.SelectedIndex;
            int mesQueVem = mesAtual + 1;
            ListaMeses mesPosterior = (ListaMeses)(mesQueVem);
            DialogResult res = MessageBox.Show("Deseja Realmente Fazer o Transporte de: " + saldo + "R$, Para o mes de: " + mesPosterior.ToString(),"CONFIRME",MessageBoxButtons.YesNo);
           
            if (res == DialogResult.No) throw new DomainsExcpetion("Operações abortada !");

            if (_caixaAtual == null) ConsultasMovimentacoesCaixa();
            string Origem = "SALDO MÓVEL DO MÊS ANTERIOR";
            NaturezaMovimentacao NAT = NaturezaMovimentacao.OUTRA;
            TipoMovimentacao TIPO = TipoMovimentacao.DINHEIRO;
            int ano = int.Parse(_form.Cb_Ano.SelectedItem.ToString());
            DateTime now = new DateTime(ano, mesQueVem+1, 1);
            
            Entrada end = new Entrada(0, Origem, now, saldo, NAT, TIPO, _caixaAtual);
            bool test = ConexaoDAO.ValidateOperation(CaixaDAO.VerificaSeEntradaJaExiste, end);
            if (test == true) throw new DomainsExcpetion("Erro: Voçê ja fez o transporte do Saldo do mês Atual para o proximo Mês!");
            ConexaoDAO.ModifyOperation(CaixaDAO.InsertEntrada, end);
            MessageBox.Show("OK, tudo certo o Saldo foi Transportado com sucesso !");
        }

    
        public void ConsultasMovimentacoesCaixa()
        {
            _caixaAtual = null;
            _listaCaixas = ConexaoDAO.getLisObjectOperation(CaixaDAO.getListaCaixa);

            _caixaAtual = _listaCaixas.Find(getCaixaForId);

            _caixaAtual.ListaEntrada.Clear();
            _caixaAtual.ListaSaida.Clear();

            if (_caixaAtual is null) throw new DomainsExcpetion("erro: nemhum caixa selecionado");


            if (_form.Cb_Ano.Text=="") throw new DomainsExcpetion("Ano não selecionado !");
            if (_form.Cb_SelectMes.Text=="") throw new DomainsExcpetion("Mês não selecionado !");

            int ano = int.Parse(_form.Cb_Ano.SelectedItem.ToString());
            int mes = int.Parse(_form.Cb_SelectMes.SelectedIndex.ToString());

            ConexaoDAO.ModifyOperation(CaixaDAO.getListEntradaForCaixa, _caixaAtual,(mes+1),ano);
            ConexaoDAO.ModifyOperation(CaixaDAO.getListSaidasForCaixa, _caixaAtual,(mes+1),ano);

            MostraListaMovimentacao();

            _form.txt_ResEntDinheiro.Text = _caixaAtual.CalculaTotalValoresPixDinCartEntradas()[0].ToString("F2");
            _form.txt_ResEntPix.Text = _caixaAtual.CalculaTotalValoresPixDinCartEntradas()[1].ToString("F2");
            _form.txt_TotalEntCartao.Text = _caixaAtual.CalculaTotalValoresPixDinCartEntradas()[2].ToString("F2");
            _form.txt_ResEntTotal.Text = _caixaAtual.CalculaTotEntrada().ToString("F2");

            _form.txt_ResSaidDinheiro.Text = _caixaAtual.CalculaTotalValoresPixDinCartSaidas()[0].ToString("F2");
            _form.txt_ResSaidPix.Text = _caixaAtual.CalculaTotalValoresPixDinCartSaidas()[1].ToString("F2");
            _form.txt_TotalCartSaida.Text = _caixaAtual.CalculaTotalValoresPixDinCartSaidas()[2].ToString("F2");
            _form.txt_ResSaidTotal.Text = _caixaAtual.CalculaTotSaida().ToString("F2");

            _form.txt_Saldo.Text = _caixaAtual.CalculaSaldo().ToString("F2");

            _form.lb_NumEntradas.Text = _caixaAtual.ListaEntrada.Count.ToString() +" Entradas";
            _form.Lb_NumSaidas.Text =_caixaAtual.ListaSaida.Count.ToString() + " Saidas";
        }

        private void MostraListaMovimentacao()
        {
            _form.Lv_ListaEntradas.Items.Clear();

            foreach(Entrada end in _caixaAtual.ListaEntrada)
            {
                ListViewItem item = new
                    ListViewItem(new string[] {end.Id.ToString(),end.Origem,end.Data.ToShortDateString(),end.Valor.ToString("F2"),end.Natureza.ToString(),
                    end.TipoMov.ToString()});
                _form.Lv_ListaEntradas.Items.Add(item);
            }

            _form.Lv_ListaSaidas.Items.Clear();
            foreach (Saida said in _caixaAtual.ListaSaida)
            {
                ListViewItem item = new
                    ListViewItem(new string[] {said.Id.ToString(),said.Origem,said.Data.ToShortDateString(),said.Valor.ToString("F2"),
                    said.TipoMovimentacao.ToString()});
                _form.Lv_ListaSaidas.Items.Add(item);
            }
        }


        public void MostraListaAnos()
        {
            int anoAtual = DateTime.Now.Year;
            _form.Cb_Ano.Items.Clear();

            for (int i = anoAtual; i >= (anoAtual - 20); i--)
            {
                _form.Cb_Ano.Items.Add(i);
            }
            _form.Cb_Ano.SelectedItem = DateTime.Now.Year;
            int mesAtual = DateTime.Now.Month;
            _form.Cb_SelectMes.SelectedIndex = mesAtual - 1;
        }

        public void ControlLancarSaida()
        {
            ValidaInsercaoSaida();
            Caixa c = _listaCaixas.Find(getCaixaForId);
            string Origem = _form.txt_OrigemSaida.Text;
            double valor = double.Parse(_form.Nup_ValorSaida.Value.ToString());
            TipoMovimentacao tipo = (TipoMovimentacao)_form.Cb_TipoSaida.SelectedIndex;

            int ano = int.Parse(_form.Cb_Ano.SelectedItem.ToString());
            int mes = int.Parse(_form.Cb_SelectMes.SelectedIndex.ToString());

            DateTime data = new DateTime(ano, (mes + 1), DateTime.Now.Day);

            Saida said = new Saida(0, Origem, data, valor, tipo, c);
            bool teste = ConexaoDAO.ValidateOperation(CaixaDAO.VerificaSeSaidaJaExiste,said);
            if (teste) throw new DomainsExcpetion("Erro: Vc ja lançou uma Saída com esse nome.\n" +
                "Tente Editar a entrada no Modulo de GERENTE DE CAIXAS");

            ConexaoDAO.ModifyOperation(CaixaDAO.InsertSaida, said);
            MessageBox.Show("_Movimentação de saída registrada com sucesso !");

           // ConexaoDAO.ModifyOperation(CaixaDAO.UpdateSaldoCaixa, _caixaAtual);
            ConsultasMovimentacoesCaixa();

            _form.txt_idSaida.Text = string.Empty;
            _form.txt_OrigemSaida.Text = string.Empty;
            _form.Nup_ValorSaida.Value = 0;
            _form.Cb_TipoEntrada.SelectedIndex = -1;
        }

        public void ControlUpdateSaida()
        {
            ValidaInsercaoSaida();
            Caixa c = _listaCaixas.Find(getCaixaForId);
            string Origem = _form.txt_OrigemSaida.Text;
            double valor = double.Parse(_form.Nup_ValorSaida.Value.ToString());
            TipoMovimentacao tipo = (TipoMovimentacao)_form.Cb_TipoSaida.SelectedIndex;

            int ano = int.Parse(_form.Cb_Ano.SelectedItem.ToString());
            int mes = int.Parse(_form.Cb_SelectMes.SelectedIndex.ToString());

            DateTime data = new DateTime(ano, (mes + 1), DateTime.Now.Day);

            if (_form.txt_idSaida.Text == string.Empty) throw new DomainsExcpetion("erro. nemhum saida selecionada no momento !");
            int idSaida = int.Parse(_form.txt_idSaida.Text);
            
            Saida said = new Saida(idSaida, Origem, data, valor, tipo, c);
            ConexaoDAO.ModifyOperation(CaixaDAO.UpdataSaida, said);

            MessageBox.Show("Atualização de Saida realizada com sucesso !");
            _form.txt_idSaida.Text = string.Empty;
            _form.txt_OrigemSaida.Text = string.Empty;
            _form.Nup_ValorSaida.Value = 0;
            _form.Cb_TipoEntrada.SelectedIndex = -1;
        }

        public void ControlDeleteEntrada()
        {
            Entrada end = _caixaAtual.ListaEntrada.Find(getEntradaForId);
            DialogResult res = MessageBox.Show("Deseja realmente deletar essa entrada da lista ?","CONFIRME",MessageBoxButtons.YesNo);
            if (!(res == DialogResult.Yes)) throw new DomainsExcpetion("Operação cancelada com sucesso !");
            
            ConexaoDAO.ModifyOperation(CaixaDAO.DeleteEntrada, end);
            MessageBox.Show("Entrada deletada com sucesso !");
        }

        public void ControlDeleteSaida()
        {
            Saida sai = _caixaAtual.ListaSaida.Find(getSaidaForId);
            DialogResult res = MessageBox.Show("Deseja realmente deletar essa entrada da lista ?", "CONFIRME", MessageBoxButtons.YesNo);
            if (!(res == DialogResult.Yes)) throw new DomainsExcpetion("Operação cancelada com sucesso !");

            ConexaoDAO.ModifyOperation(CaixaDAO.DeleteSaida, sai);
            MessageBox.Show("Saida selecionada deletada com sucesso !");
        }


        private void ValidaInsecaoEntrada()
        {
            if (_form.Cb_listaCaixa.Text == string.Empty) throw new DomainsExcpetion("O Caixa não foi selecionado");
            if (_form.Cb_Ano.Text == string.Empty) throw new DomainsExcpetion("Ano não selecionado !");
            if (_form.Cb_SelectMes.Text == string.Empty) throw new DomainsExcpetion("Mês não selecionado !");
            if (_form.txt_OrigemEntrada.Text == string.Empty) throw new DomainsExcpetion("Campo de Origem nao pode ser vazia");
            if (_form.Cb_Natureza.Text== string.Empty) throw new DomainsExcpetion("A natureza é obrigatorio");
            if (_form.Cb_TipoEntrada.Text  == string.Empty) throw new DomainsExcpetion("O tipo de entrada é um dados obrigatório");
        }

        private void ValidaInsercaoSaida()
        {
            if (_form.Cb_listaCaixa.Text == string.Empty) throw new DomainsExcpetion("O Caixa não foi selecionado");
            if (_form.Cb_Ano.Text == string.Empty) throw new DomainsExcpetion("Ano não selecionado !");
            if (_form.Cb_SelectMes.Text == string.Empty) throw new DomainsExcpetion("Mês não selecionado !");
            if (_form.txt_OrigemSaida.Text == string.Empty) throw new DomainsExcpetion("A origem da saida é um dados obrigatório");
            if (_form.Cb_TipoSaida.Text == string.Empty) throw new DomainsExcpetion("O tipo de Saida é um dados obrigatório");
        }

        public void ControllancarEntrada()
        {
            ValidaInsecaoEntrada();
            Caixa c = _listaCaixas.Find(getCaixaForId);
            string nome = _form.txt_OrigemEntrada.Text;
            double valor = double.Parse(_form.Nup_ValorEntrada.Value.ToString());
            NaturezaMovimentacao nat = (NaturezaMovimentacao)_form.Cb_Natureza.SelectedIndex;
            TipoMovimentacao tipo = (TipoMovimentacao)_form.Cb_TipoEntrada.SelectedIndex;

            int ano = int.Parse(_form.Cb_Ano.SelectedItem.ToString());
            int mes = int.Parse(_form.Cb_SelectMes.SelectedIndex.ToString());

            DateTime data = new DateTime(ano, (mes+1), DateTime.Now.Day);

            Entrada end = new Entrada(0, nome, data, valor, nat, tipo, c);

            bool teste = ConexaoDAO.ValidateOperation(CaixaDAO.VerificaSeEntradaJaExiste, end);
            if (teste) throw new DomainsExcpetion("Erro: Vc ja lançou uma entrada com esse nome.\n" +
                "Tente Editar a entrada no Modulo de GERENTE DE CAIXAS");

            ConexaoDAO.ModifyOperation(CaixaDAO.InsertEntrada, end);
            MessageBox.Show("_Movimentação de Entrada registrada com sucesso !");

            // ConexaoDAO.ModifyOperation(CaixaDAO.UpdateSaldoCaixa, _caixaAtual);
            ConsultasMovimentacoesCaixa();
            _form.txt_idSaida.Text = string.Empty;
            _form.txt_OrigemEntrada.Text = string.Empty;
            _form.Nup_ValorEntrada.Value = 0;
            _form.Cb_TipoEntrada.SelectedIndex = -1;
            _form.Cb_Natureza.SelectedIndex = -1;
        }

        public void ControlUpdateEntrada()
        {
            ValidaInsecaoEntrada();
            Caixa c = _listaCaixas.Find(getCaixaForId);
            string nome = _form.txt_OrigemEntrada.Text;
            double valor = double.Parse(_form.Nup_ValorEntrada.Value.ToString());
            NaturezaMovimentacao nat = (NaturezaMovimentacao)_form.Cb_Natureza.SelectedIndex;
            TipoMovimentacao tipo = (TipoMovimentacao)_form.Cb_TipoEntrada.SelectedIndex;

            int ano = int.Parse(_form.Cb_Ano.SelectedItem.ToString());
            int mes = int.Parse(_form.Cb_SelectMes.SelectedIndex.ToString());

            DateTime data = new DateTime(ano, (mes + 1), DateTime.Now.Day);
            int idEntrada = int.Parse(_form.txt_idCadEntrada.Text);
            if (_form.txt_idCadEntrada.Text == string.Empty) throw new DomainsExcpetion("Nemhuma entrada selecionada no momento");

            Entrada end = new Entrada(idEntrada, nome, data, valor, nat, tipo, c);
            ConexaoDAO.ModifyOperation(CaixaDAO.UpdateEntrada, end);
            MessageBox.Show("_Atualização de entrada concluida com sucesso !");

            _form.txt_idSaida.Text = string.Empty;
            _form.txt_OrigemEntrada.Text = string.Empty;
            _form.Nup_ValorEntrada.Value = 0;
            _form.Cb_TipoEntrada.SelectedIndex = -1;
            _form.Cb_Natureza.SelectedIndex = -1;
        }


        public void GetInforUpdateEntrada()
        {
            Entrada end = _caixaAtual.ListaEntrada.Find(getEntradaForId);
            _form.txt_idCadEntrada.Text = end.Id.ToString();
            _form.txt_OrigemEntrada.Text = end.Origem.ToString();
            _form.Nup_ValorEntrada.Value = decimal.Parse(end.Valor.ToString());
            _form.Cb_TipoEntrada.SelectedIndex = (int)end.TipoMov;
            _form.Cb_Natureza.SelectedIndex = (int)end.Natureza;               
        }

        public void GetInforUpdateSaida()
        {
            Saida said = _caixaAtual.ListaSaida.Find(getSaidaForId);
            _form.txt_idSaida.Text = said.Id.ToString();
            _form.txt_OrigemSaida.Text = said.Origem;
            _form.Nup_ValorSaida.Value =decimal.Parse(said.Valor.ToString());
            _form.Cb_TipoSaida.SelectedIndex = (int)said.TipoMovimentacao;
        }



        //delegates

        public bool getListaEntradasForAnoMes(Entrada mov)
        {
            int ano = int.Parse(_form.Cb_Ano.SelectedItem.ToString());
            int mes = int.Parse(_form.Cb_SelectMes.SelectedIndex.ToString());
            return (mov.Data.Year == ano && mov.Data.Month == (mes + 1)) ? true : false;
        }

        public bool getListaSaidasForAnoMes(Saida mov)
        {
            int ano = int.Parse(_form.Cb_Ano.SelectedItem.ToString());
            int mes = int.Parse(_form.Cb_SelectMes.SelectedIndex.ToString());
            return (mov.Data.Year == ano && mov.Data.Month == (mes + 1)) ? true : false;
        }

        public bool getCaixaForId(Caixa c)
        {
            int id = int.Parse(_form.Cb_listaCaixa.SelectedValue.ToString());
            return (c.Id == id) ? true : false;
        }

        private bool getEntradaForId(Entrada end)
        {
            int index = _form.Lv_ListaEntradas.SelectedIndices[0];
            int id_entrada = int.Parse
                (_form.Lv_ListaEntradas.Items[index].SubItems[0].Text);
            return (end.Id == id_entrada) ? true : false;
        }

        public bool getSaidaForId(Saida said)
        {
            int index = _form.Lv_ListaSaidas.SelectedIndices[0];
            int idSaida = int.Parse(_form.Lv_ListaSaidas.Items[index].SubItems[0].Text);
            return (said.Id == idSaida) ? true : false;
        }

     


    }
}
