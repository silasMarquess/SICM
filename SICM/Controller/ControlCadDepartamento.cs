using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;
using SICM.SubForms;
using SICM.DAO;
using SICM.Servicos;
using System.Windows.Forms;
using SICM.Entidades;

namespace SICM.Controller
{
    class ControlCadDepartamento
    {
        private FrmCadDepartCargo _form;
        private List<Departamento> _listaDepart;
        private List<Templo> _listaTemplo;

        public ControlCadDepartamento(FrmCadDepartCargo depart)
        {
            _form = depart;
        }
        public void ControlMostraListaTemplo()
        {
            _listaTemplo = ConexaoDAO.getLisObjectOperation(IgrejaDAO.GetListaTemplo);
            _form.Cb_TemploSede.DataSource = _listaTemplo;
            _form.Cb_TemploSede.DisplayMember = "Nome";
            _form.Cb_TemploSede.ValueMember = "Codigo";
        }

        public void ControlMostraInfoUpdateDepart(Departamento depart)
        {
            _form.Rb_Departamento.Checked = true;
            if (depart.Igreja is Congregacao)
            {
                Congregacao filha = depart.Igreja as Congregacao;
                _form.Cb_TemploSede.Text = filha.Sede.Nome;
                _form.Rb_Congregacao.Checked = true;
                List<Congregacao> listaCong = ConexaoDAO.getLisObjectOperation(IgrejaDAO.getListaCongregacao,filha.Sede);
                _form.Cb_ListaCongregacao.DataSource = listaCong;
                _form.Cb_ListaCongregacao.DisplayMember = "Nome";
                _form.Cb_ListaCongregacao.ValueMember = "Codigo";
                _form.Cb_ListaCongregacao.Text = filha.Nome;

            }
            _form.txt_NomeDepartCargo.Text = depart.Nome;
            _form.txt_Id.Text = depart.Id.ToString();
        }

        public void ControlMostraInfoUpdateCarg(Cargo c)
        {
            _form.Rb_Cargo.Checked = true;
            if (c.Depart.Igreja is Congregacao)
            {
                Congregacao filha = c.Depart.Igreja as Congregacao;
                _form.Cb_TemploSede.Text = filha.Sede.Nome;
                _form.Rb_Congregacao.Checked = true;
                List<Congregacao> listaCong = ConexaoDAO.getLisObjectOperation(IgrejaDAO.getListaCongregacao, filha.Sede);
                _form.Cb_ListaCongregacao.DataSource = listaCong;
                _form.Cb_ListaCongregacao.DisplayMember = "Nome";
                _form.Cb_ListaCongregacao.ValueMember = "Codigo";
                _form.Cb_ListaCongregacao.Text = filha.Nome;
            }
             ControlMostraListaDepartamentos();
            _form.Cb_Departamento.Text = c.Depart.Nome;
            _form.txt_NomeDepartCargo.Text = c.Nome;
            _form.txt_Id.Text = c.Id.ToString();
        }

        public void ControlMostraListaDepartamentos()
        {
            Igreja i = null;
            _form.Cb_Departamento.DataSource = null;

            if (_form.Rb_TemploSede.Checked)
            {
                string nome = _form.Cb_TemploSede.Text;
                string codigo = _form.Cb_TemploSede.SelectedValue.ToString();
                i = new Templo(codigo, 0, nome);
            }
            else if (_form.Rb_Congregacao.Checked)
            {
                string nomeIgreja = _form.Cb_ListaCongregacao.Text;
                string codigoCong = _form.Cb_ListaCongregacao.SelectedValue.ToString();
                i = new Congregacao(codigoCong, nomeIgreja);
            }

            _listaDepart = ConexaoDAO.getLisObjectOperation(DepartamentoDAO.GetListaDepartamentos, i);
            _form.Cb_Departamento.DataSource = _listaDepart;
            _form.Cb_Departamento.ValueMember = "id";
            _form.Cb_Departamento.DisplayMember = "nome";
        }

        public void controlInserdDepartamento()
        {
            ValidaInsercao();
            Igreja i = null;

            if (_form.Rb_TemploSede.Checked)
            {
                string nomeIgreja = _form.Cb_TemploSede.Text;
                string codigoIgreja = _form.Cb_TemploSede.SelectedValue.ToString();
                i = new Templo(codigoIgreja, 0, nomeIgreja);
            }
            else
            {
                string nomeComg = _form.Cb_ListaCongregacao.Text;
                string codigo = _form.Cb_ListaCongregacao.SelectedValue.ToString();
                i = new Congregacao(codigo, nomeComg);
            }

            string nomeDepart = _form.txt_NomeDepartCargo.Text;

            Departamento dp = new Departamento(0, nomeDepart, i);

            DialogResult dialog = MessageBox.Show("CONFIRME OS DADOS:\n\nDepartamento: "+dp.Nome+"\nIgreja Destino: "+dp.Igreja.Nome+"\n","CONFIRME",MessageBoxButtons.YesNo);

            if (dialog == DialogResult.No) throw new DomainsExcpetion("Operação Abordada !");

            if (ConexaoDAO.ValidateOperation(DepartamentoDAO.VerificaExistDepart, dp)) throw new DomainsExcpetion("Erro: Departamento com esse nome ja existe na igreja selecionada !");
            ConexaoDAO.ModifyOperation(DepartamentoDAO.ControlInsertDepartamento, dp);
            MessageBox.Show("Depatamento Cadastrado com sucesso !");
            LimpaCampos();
        }

        public void ControlUpdateDepartamento()
        {
            ValidaInsercao();
            Igreja i = null;

            if (_form.Rb_TemploSede.Checked)
            {
                string nomeIgreja = _form.Cb_TemploSede.Text;
                string codigoIgreja = _form.Cb_TemploSede.SelectedValue.ToString();
                i = new Templo(codigoIgreja, 0, nomeIgreja);
            }
            else
            {
                string nomeComg = _form.Cb_ListaCongregacao.Text;
                string codigo = _form.Cb_ListaCongregacao.SelectedValue.ToString();
                i = new Congregacao(codigo, nomeComg);
            }

            string nomeDepart = _form.txt_NomeDepartCargo.Text;
            int idDepartamento = int.Parse(_form.txt_Id.Text);

            Departamento dp = new Departamento(idDepartamento, nomeDepart, i);
            ConexaoDAO.ModifyOperation(DepartamentoDAO.ControlUpdateDepartameto, dp);
            MessageBox.Show("Departamento Atualizado com sucesso !");
            LimpaCampos();
        }

        public void ControlInsertCargo()
        {
            ValidaInsercao();
            string nomeDepartamento = _form.Cb_Departamento.Text;
            int idDepatamento = int.Parse(_form.Cb_Departamento.SelectedValue.ToString());

            Igreja i = null;

            if (_form.Rb_TemploSede.Checked)
            {
                string nomeIgreja = _form.Cb_TemploSede.Text;
                string codigoIgreja = _form.Cb_TemploSede.SelectedValue.ToString();
                i = new Templo(codigoIgreja, 0, nomeIgreja);
            }
            else
            {
                string nomeComg = _form.Cb_ListaCongregacao.Text;
                string codigo = _form.Cb_ListaCongregacao.SelectedValue.ToString();
                i = new Congregacao(codigo, nomeComg);
            }

            Departamento dp = new Departamento(idDepatamento, nomeDepartamento,i);

            string Cargo = _form.txt_NomeDepartCargo.Text;
            Cargo c = new Cargo(0, Cargo, dp, StatusCargo.DISPONIVEL);
            bool test = ConexaoDAO.ValidateOperation(DepartamentoDAO.VerificaSeCargoExist, c);

            if (test) throw new DomainsExcpetion("O Cargo: " + c.Nome + ", ja está cadastrado no departamento informado !");

            DialogResult dialog = MessageBox.Show("CONFIRME OS DADOS:\n\nCargo: "+c.Nome+"\nDepartamento: " + c.Depart.Nome + "\nIgreja Destino: " + c.Depart.Igreja.Nome + "\n", "CONFIRME", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.No) throw new DomainsExcpetion("Operação Abordada !");

            ConexaoDAO.ModifyOperation(DepartamentoDAO.insertCargo, c);
            MessageBox.Show("Cargo Inserido com sucesso !");
            LimpaCampos();
        }

        public void controlGetListaCongregacao()
        {
            Templo sede = _listaTemplo.Find(getTemploForCodigo);
            List<Congregacao> listaCong = ConexaoDAO.getLisObjectOperation(IgrejaDAO.getListaCongregacao, sede);
            _form.Cb_ListaCongregacao.DataSource = listaCong;
            _form.Cb_ListaCongregacao.DisplayMember = "nome";
            _form.Cb_ListaCongregacao.ValueMember = "codigo";
        }

        public void ControlUPdateCargo()
        {
            ValidaInsercao();
            string nomeDepartamento = _form.Cb_Departamento.Text;
            int idDepatamento = int.Parse(_form.Cb_Departamento.SelectedValue.ToString());
            Departamento dp = new Departamento(idDepatamento, nomeDepartamento);

            string Cargo = _form.txt_NomeDepartCargo.Text;
            Cargo c = new Cargo(int.Parse(_form.txt_Id.Text), Cargo, dp, StatusCargo.DISPONIVEL);
            ConexaoDAO.ModifyOperation(DepartamentoDAO.UpdateCargo, c);
            MessageBox.Show("Cargo Atualizado com sucesso !");
            LimpaCampos();
        }

        public void LimpaCampos()
        {
            _form.Cb_TemploSede.SelectedIndex = -1;
            _form.Cb_Departamento.SelectedIndex = -1;
            _form.txt_NomeDepartCargo.Text = "";
            _form.txt_Id.Text = "";
        }

        public void ValidaInsercao()
        {
            if (_form.Rb_TemploSede.Checked)
            {
                if (_form.Cb_TemploSede.Text == "") throw new DomainsExcpetion("Erro: Campo de templo nao pode ser vazio");
            }
            else if(_form.Rb_Congregacao.Checked)
            {
                if (_form.Cb_ListaCongregacao.Text == "") throw new DomainsExcpetion("Erro: Campo de Congregação nao pode ser vazio");
            }

            if (_form.Rb_Cargo.Checked)
            {
                if (_form.Cb_Departamento.Text == "") throw new DomainsExcpetion("Erro: Campo de departamento nao pode ser vazio");
            }
            if (_form.txt_NomeDepartCargo.Text == "") throw new DomainsExcpetion("Erro: Campo do Nome não pode ser vazio");
        }

        ///delegates
        public bool getTemploForCodigo(Igreja i)
        {
            string codigoTemplo = _form.Cb_TemploSede.SelectedValue.ToString();
            return (i.Codigo == codigoTemplo) ? true : false;
        }
    }
}
