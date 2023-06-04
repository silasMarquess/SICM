using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Relatorios;
using SICM.Entidades.Enumeracoes;
using SICM.DAO;
using System.Windows.Forms;
using SICM.SubForms;
using SICM.Entidades;

namespace SICM.Controller
{
    internal class ControlFrmListaCaixas
    {
        private FrmListaCaixas _form;
        private List<Caixa> _listaCaixas;

        public ControlFrmListaCaixas(FrmListaCaixas formControl)
        {
            _form = formControl;
        }

        public void ControlMostraListaCaixas()
        {
            if (_form.Cb_ListaMeses.Text == string.Empty || _form.cb_ListaAnos.SelectedItem.ToString() == string.Empty) throw new DomainsExcpetion("erro: Selecione o Mes e Ano primeiro !");
            _listaCaixas = ConexaoDAO.getLisObjectOperation(CaixaDAO.getListaCaixa);
            if (_listaCaixas == null) throw new DomainsExcpetion("Erro: Nemhum Caixa Encontrado no momento !");
            _listaCaixas.ForEach(GetListaMovimentacoes);
            _form.Clb_CaixasSelecionados.Items.Clear();

            foreach(Caixa c in _listaCaixas) {
                _form.Clb_CaixasSelecionados.Items.Add(c);
            }
        }

        public void ControlCalcularTotEntradas()
        {
            List<Caixa> listaGeralCaixa = _form.Clb_CaixasSelecionados.CheckedItems.Cast<Caixa>().ToList();
            double ValorEntradaGeral = 0;
            double ValorSaidaGeraç = 0;

            foreach(Caixa c in listaGeralCaixa)
            {
                ValorEntradaGeral += c.CalculaTotEntrada();
                ValorSaidaGeraç += c.CalculaTotSaida();         
            }
            double saldo = ValorEntradaGeral - ValorSaidaGeraç;
            _form.txt_TotalSaldoGeral.Text = saldo.ToString("F2");
            _form.txt_TotalEntrdasGeral.Text = ValorEntradaGeral.ToString("F2");
            _form.txt_TotalSaidasGeral.Text = ValorSaidaGeraç.ToString("F2");
            
        }

        public void ControlDeleteCaixa()
        {
            List<Caixa> listaSelecionada = _form.Clb_CaixasSelecionados.CheckedItems.Cast<Caixa>().ToList();
            string texto = "";
         
            for(int i =0; i<listaSelecionada.Count;i++)
            {
                texto += "\n" + listaSelecionada[i].Nome;
            }

            DialogResult result = MessageBox.Show("Deseja Realmente Deletar os Caixas a seguir:\n" +texto,"CONFIRME",MessageBoxButtons.YesNo);
            if (result == DialogResult.No) throw new DomainsExcpetion("Operação Cancelada com sucesso !");
            foreach(Caixa c in listaSelecionada )
            {
                ConexaoDAO.ModifyOperation(CaixaDAO.DeleteCaixa, c);
            }

            MessageBox.Show("O(s) Departamento(s) Selecionado(s) Deletado(s) com Sucesso !");
        }

        public void ControlPrintResumo()
        {

            List<Caixa> listaGeralCaixa = _form.Clb_CaixasSelecionados.CheckedItems.Cast<Caixa>().ToList();
            if (listaGeralCaixa.Count == 0) throw new DomainsExcpetion("Nemhum caixa Selecionado no Momento!");
            double ValorEntradaGeral = 0;
            double ValorSaidaGeraç = 0;
            ListaMeses mesSelecioando = (ListaMeses)(_form.Cb_ListaMeses.SelectedIndex - 1);
            int ano = int.Parse(_form.cb_ListaAnos.SelectedItem.ToString());

            foreach (Caixa c in listaGeralCaixa)
            {
                ValorEntradaGeral += c.CalculaTotEntrada();
                ValorSaidaGeraç += c.CalculaTotSaida();
            }
            double saldo = ValorEntradaGeral - ValorSaidaGeraç;

            FrmReportListaCaixas form = new FrmReportListaCaixas(listaGeralCaixa,mesSelecioando.ToString(),ano,ValorEntradaGeral,ValorSaidaGeraç);
            form.ShowDialog();
        }
        public void GetListaMovimentacoes(Caixa c)
        {
            int mes = (_form.Cb_ListaMeses.SelectedIndex+1);
            int ano =int.Parse(_form.cb_ListaAnos.SelectedItem.ToString());
            ConexaoDAO.ModifyOperation(CaixaDAO.getListEntradaForCaixa, c,mes,ano);
            ConexaoDAO.ModifyOperation(CaixaDAO.getListSaidasForCaixa, c, mes, ano);
        }
    }
}
