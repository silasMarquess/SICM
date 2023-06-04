using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;
using SICM.Entidades;
using SICM.SubForms;
using SICM.DAO;
using System.Windows.Forms;

namespace SICM.Controller
{
    class ControlCadCaixa
    {
        private FrmCadCaixas _form;
        private List<Templo> _listSedes;
        private List<Congregacao> _listaCong;
        private List<Departamento> _listaDepart;

        public ControlCadCaixa(FrmCadCaixas form)
        {
            _form = form;
        }

        public void MostraListaTemplo()
        {
            _listSedes = ConexaoDAO.getLisObjectOperation(IgrejaDAO.GetListaTemplo);
            _form.CB_ListaSede.DataSource = _listSedes;
            _form.CB_ListaSede.DisplayMember = "nome";
            _form.CB_ListaSede.ValueMember = "id";
            _form.CB_ListaSede.SelectedIndex = 0;

            _form.Cb_ListaSedeDepart.DataSource = _listSedes;
            _form.Cb_ListaSedeDepart.ValueMember ="codigo";
            _form.Cb_ListaSedeDepart.DisplayMember = "nome";
            _form.Cb_ListaSedeDepart.SelectedIndex = 0;
        }

        public void MostraListaCongregacaoCaixaTemplo()
        {
            Templo templo = _listSedes.Find(getTemploForCodigo);
            _listaCong = ConexaoDAO.getLisObjectOperation(IgrejaDAO.getListaCongregacao, templo);
            _form.Cbb_ListaCongregacao.DataSource = _listaCong;
            _form.Cbb_ListaCongregacao.DisplayMember = "nome";
            _form.Cbb_ListaCongregacao.ValueMember = "codigo";
        }


        public void MostraListaCongregacaoCaixaDepart()
        {
            Templo templo = _listSedes.Find(getTemploForCodigoCaixaDepart);
            _listaCong = ConexaoDAO.getLisObjectOperation(IgrejaDAO.getListaCongregacao, templo);
            _form.CB_ListaCoongDepart.DataSource = _listaCong;
            _form.CB_ListaCoongDepart.DisplayMember = "nome";
            _form.CB_ListaCoongDepart.ValueMember = "codigo";
        }

        public void BuscaListaDepartamento()
        {
            Igreja i = null;

            if (_form.Cbox_ListaCongCaixaDepart.Checked)
            {
                string nome = _form.CB_ListaCoongDepart.Text;
                string codigo = _form.CB_ListaCoongDepart.SelectedValue.ToString();
                i = new Congregacao(codigo, nome);
            }
            else
            {
                i = _listSedes.Find(getTemploForCodigoCaixaDepart);
            }

            _listaDepart= ConexaoDAO.getLisObjectOperation(DepartamentoDAO.GetListaDepartamentos, i);
            _form.Cb_Departamento.DataSource = _listaDepart;
            _form.Cb_Departamento.DisplayMember = "nome";
            _form.Cb_Departamento.ValueMember = "id";
        }

        public void ControlInsertCaixa()
        {
            if (_form.txt_NomeCaixa.Text == string.Empty) throw new DomainsExcpetion("Erro: nome do caixa nao pode ser vazio !");
            string nomeCaixa = _form.txt_NomeCaixa.Text;
            double saldo = double.Parse(_form.Nup_SaldoAtual.Value.ToString());
            TipoCaixa tipo = TipoCaixa.DEPARTAMENTO;
            if (_form.Rb_Departamento.Checked) tipo = TipoCaixa.DEPARTAMENTO;
            if (_form.Rb_IgrejaSel.Checked) tipo = TipoCaixa.IGREJA;
            if (_form.Rb_OutroTipo.Checked) tipo = TipoCaixa.OUTRO;

            Caixa c = new Caixa(0, nomeCaixa,saldo, tipo);

            DialogResult res = MessageBox.Show("Confirma os dados: \n" +
                "Nome Caixa->> " + c.Nome.ToUpper() + "\n" +
                "Valor Inicial->> " +c.Saldo+"R$\n"+
                "Tipo Caixa->> " + c.TipoCaixa.ToString() + "\n" +
                "Entidade->> " + c.Nome.Split('-')[1],"CONFIRME OS DADOS:",MessageBoxButtons.YesNo);
            if (res == DialogResult.No) throw new DomainsExcpetion("Revise os dados antes de prosseguir !");

            bool test = ConexaoDAO.ValidateOperation(CaixaDAO.verificaSeCaixaJaExis, c);
            if (test) throw new DomainsExcpetion("erro: Caixa ja existe !");

            ConexaoDAO.ModifyOperation(CaixaDAO.InsertNewCaixa, c);

            MessageBox.Show("Caixa cadastrado com sucesso !");
            _form.txt_NomeCaixa.Text = "";
            _form.Nup_SaldoAtual.Value = 0;
        }
        

        //funções

        private bool getTemploForCodigo(Templo templo)
        {
            int id= int.Parse(_form.CB_ListaSede.SelectedValue.ToString()) ;
            return (templo.Id == id) ? true : false;
        }

        private bool getTemploForCodigoCaixaDepart(Templo templo)
        {
            string codigo = _form.Cb_ListaSedeDepart.SelectedValue.ToString();
            return (templo.Codigo==codigo) ? true : false;
        }
    }
}
