using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Servicos;
using SICM.Entidades.Enumeracoes;
using SICM.Entidades;
using SICM.DAO;
using SICM.SubForms;
using System.Windows.Forms;


namespace SICM.Controller
{
    class ControlIgreja
    {

        private FrmCadIgreja _cad;
        private List<Templo> _listaTemplo;


        public ControlIgreja(FrmCadIgreja _form)
        {
            _cad = _form;

        }

        public void getUPdateInforTemplo(Templo _temploAtual)
        {
            if (_temploAtual != null)
            {
                PreparaCampoTemplo();
                _cad.Rb_TemploSede.Checked = true;
                _cad.txt_Nome.Text = _temploAtual.Nome;
                _cad.txt_cnpj.Text = _temploAtual.Cnpj;
                _cad.txt_rua.Text = _temploAtual.Rua;
                _cad.txt_CodigoIgreja.Text = _temploAtual.Codigo;
                _cad.Nup_Numero.Value = decimal.Parse(_temploAtual.Numero);
                _cad.txt_bairro.Text = _temploAtual.Bairro;
                _cad.txt_Cidade.Text = _temploAtual.Cidade;
                _cad.txt_DataFund.Text = _temploAtual.DataFund.ToShortDateString();             
            }
        }

        public void getUpdateInfoCong(Congregacao cong)
        {
            PreparaCampoCongregacao();
            _cad.txt_CodigoIgreja.Text = cong.Codigo;
            _cad.CB_ListaSede.Text = cong.Sede.Nome;
            _cad.txt_Nome.Text = cong.Nome;
            _cad.txt_dirigentes.Text = cong.Dirigente;
            _cad.txt_rua.Text = cong.Rua;
            _cad.Nup_Numero.Value = decimal.Parse(cong.Numero);
            _cad.txt_bairro.Text = cong.Bairro;
            _cad.txt_Cidade.Text = cong.Cidade;
            _cad.txt_DataFund.Text = cong.DataFund.ToShortDateString();
        }

        public void PreparaCampoTemplo()
        {
            _cad.txt_cnpj.Enabled = true;
            _cad.CB_ListaSede.Enabled = false;
            _cad.txt_dirigentes.Enabled = false;
        }

        public void PreparaCampoCongregacao()
        {
            _cad.CB_ListaSede.Enabled = true;
            _cad.txt_dirigentes.Enabled = true;
            _cad.txt_cnpj.Enabled = false;
        }

        public void ControlUpdateIgreja()
        {
            ValidaCamposInsercao();
            //Capiturar Dados Gerais
            string codigo = _cad.txt_CodigoIgreja.Text;
            string nome = _cad.txt_Nome.Text.Trim();
            string rua = _cad.txt_rua.Text;
            string bairro = _cad.txt_bairro.Text;
            string numero = _cad.Nup_Numero.Value.ToString();
            string cidade = _cad.txt_Cidade.Text;
            int dia = int.Parse(_cad.txt_DataFund.Text.Substring(0, 2));
            int mes = int.Parse(_cad.txt_DataFund.Text.Substring(2, 2));
            int ano = int.Parse(_cad.txt_DataFund.Text.Substring(4, 4));
            DateTime dataFund = new DateTime(ano, mes, dia);

            Igreja i = null;
            Action<Igreja> acao;
            acao = IgrejaDAO.UpdateInforIgreja;

            if (_cad.Rb_TemploSede.Checked)
            {
                string cnpj = _cad.txt_cnpj.Text;
                i = new Templo(0, codigo, nome, cnpj, rua, numero, bairro, cidade, dataFund);
                acao += IgrejaDAO.UpdateInfoTemplo;
            }
            else
            {

                int id = int.Parse(_cad.CB_ListaSede.SelectedValue.ToString());
                string nomeSede = _cad.CB_ListaSede.Text;

                Templo sede = new Templo(id, nomeSede);
                string dirigente = _cad.txt_dirigentes.Text;
                i = new Congregacao(codigo, nome, dirigente, sede, rua, numero, bairro, cidade, dataFund);
                acao += IgrejaDAO.UpdateInforCongregacao;
            }

            //execultar acao
            ConexaoDAO.ModifyOperation(acao, i);

            //mostrar messagem
            MessageBox.Show("Operação Realizada com sucesso !");
            this.LimpaCampos();
        }

        public void ControlInsertIgreja()
        {
            ValidaCamposInsercao();
            //Capiturar Dados Gerais
            string codigo = _cad.txt_CodigoIgreja.Text;
            string nome = _cad.txt_Nome.Text.Trim();
            string rua = _cad.txt_rua.Text;
            string bairro = _cad.txt_bairro.Text;
            string numero = _cad.Nup_Numero.Value.ToString();
            string cidade = _cad.txt_Cidade.Text;
            int dia = int.Parse(_cad.txt_DataFund.Text.Substring(0, 2));
            int mes = int.Parse(_cad.txt_DataFund.Text.Substring(2, 2));
            int ano = int.Parse(_cad.txt_DataFund.Text.Substring(4, 4));
            DateTime dataFund = new DateTime(ano, mes, dia);

            Igreja i = null;
            Action<Igreja> acao;
            acao = IgrejaDAO.InsertDadosIgreja;

            if (_cad.Rb_TemploSede.Checked)
            {
                string cnpj = _cad.txt_cnpj.Text;
                i = new Templo(0, codigo, nome, cnpj, rua, numero, bairro, cidade, dataFund);
                acao += IgrejaDAO.InsertDadosTemplo;
            }
            else
            {

                int id = int.Parse(_cad.CB_ListaSede.SelectedValue.ToString());
                string nomeSede = _cad.CB_ListaSede.Text;

                Templo sede = new Templo(id, nomeSede);
                string dirigente = _cad.txt_dirigentes.Text;
                i = new Congregacao(codigo, nome, dirigente, sede, rua, numero, bairro, cidade, dataFund);
                acao += IgrejaDAO.InsertDadosCong;
            }

            //execultar acao
            bool test = ConexaoDAO.ValidateOperation(IgrejaDAO.VerificaSeIgrejaExis, i);
            if (test) throw new DomainsExcpetion("Erro: Igreja ja está cadastrada !");
            ConexaoDAO.ModifyOperation(acao, i);

            //mostrar messagem
            MessageBox.Show("Operação Realizada com sucesso !");
            this.LimpaCampos();
        }

        public void MostrarListaTemplo()
        {
            _listaTemplo = ConexaoDAO.getLisObjectOperation(IgrejaDAO.GetListaTemplo);

            if (_listaTemplo.Count == 0) throw new DomainsExcpetion("Nemhuma sede cadastrada ainda no sistema");

            _cad.CB_ListaSede.DisplayMember = "Nome";
            _cad.CB_ListaSede.ValueMember = "Id";
            _cad.CB_ListaSede.DataSource = _listaTemplo;
        }

        public void MostrarCodigoIgreja()
        {
            _cad.txt_CodigoIgreja.Text = ObjectService.GenerateCodeObject(new Templo());
        }

        public void ValidaCamposInsercao()
        {
            if (_cad.txt_CodigoIgreja.Text == string.Empty) throw new DomainsExcpetion("Campo de codigo nao pode ser vazio !");
            if (_cad.txt_Nome.Text == string.Empty) throw new DomainsExcpetion("Campo de nome não pode ser vazio");
            if (_cad.txt_rua.Text == string.Empty) throw new DomainsExcpetion("Campo de rua nao pode ser vazio");
            if (_cad.txt_bairro.Text == string.Empty) throw new DomainsExcpetion("Campo de bairro não pode ser vazio");
            if (_cad.txt_Cidade.Text == string.Empty) throw new DomainsExcpetion("Campo de cidade não pode ser vazio !");
            if (_cad.txt_DataFund.Text == string.Empty) throw new DomainsExcpetion("Campo de Data Não pode ser vazio");

            if (_cad.Rb_TemploSede.Checked)
            {
                if (_cad.txt_cnpj.Text == string.Empty) throw new DomainsExcpetion("Campo de cnpj não pode ser vazio");
            }
            else
            {
                if (_cad.CB_ListaSede.Text == string.Empty) throw new DomainsExcpetion("Erro: templo sede não selecionada");
                if (_cad.txt_dirigentes.Text == string.Empty) throw new DomainsExcpetion("Erro: Campo de Dirigente não pode ser vazio");
            }
        }

        public void LimpaCampos()
        {
            _cad.txt_CodigoIgreja.Text = string.Empty;
            _cad.txt_Nome.Text = string.Empty;
            _cad.txt_rua.Text = string.Empty;
            _cad.txt_cnpj.Text = string.Empty;
            _cad.txt_dirigentes.Text = string.Empty;
            _cad.txt_bairro.Text = string.Empty;
            _cad.txt_Cidade.Text = string.Empty;
            _cad.txt_DataFund.Text = string.Empty;
            _cad.CB_ListaSede.SelectedIndex = -1;
            MostrarCodigoIgreja();
        }
    }
}
