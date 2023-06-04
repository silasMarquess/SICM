using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades;
using SICM.Entidades.Enumeracoes;
using SICM.DAO;
using System.Windows.Forms;
using System.Data;
using SICM.SubForms;
using SICM.Relatorios;

namespace SICM.Controller
{
    class ControlGerenteDepart
    {
        private FrmGerenteDepartamento _form;
        private List<Templo> _listaTemplo;
        private List<Departamento> _listaDepart;
        private List<Congregacao> _listaCongregacao;
        private List<Cargo> _listaCargo;
        private List<VinculoFuncional> _listaVinculos;
        private StatusVinculo _statusVincFillter;

        public ControlGerenteDepart(FrmGerenteDepartamento form)
        {
            _form = form;
        }

        public void ControlMostrarListaTemplo()
        {
            _listaTemplo = ConexaoDAO.getLisObjectOperation(IgrejaDAO.GetListaTemplo);
            _form.Cb_listaTemplo.DataSource = _listaTemplo;
            _form.Cb_listaTemplo.DisplayMember = "nome";
            _form.Cb_listaTemplo.ValueMember = "codigo";
        }

        public void ControlDeleteDepartamento()
        {
            Departamento dp = _listaDepart.Find(getDepartamentoForId);
            if (dp is null) throw new DomainsExcpetion("Nemhum Departamento Selecionado para a deleção !");
            DialogResult result = MessageBox.Show("Deseja realmente excluir o seguinte departamento: " + dp.Nome + " ?", "CONFIRME", MessageBoxButtons.YesNo);
            if (!(result == DialogResult.Yes)) throw new DomainsExcpetion("Operação abortada com sucesso !");
            ConexaoDAO.ModifyOperation(DepartamentoDAO.DeleteDepartamento, dp);
            MessageBox.Show("DEPARTAMENTO DELETADO COM SUCESSO !");
        }

        public void MostrarListaDepartamentoConsultCargo()
        {
            _form.Cb_DepartConsultaCargo.Items.Clear();
            foreach (Departamento dp in _listaDepart)
            {
                _form.Cb_DepartConsultaCargo.Items.Add(dp.Nome);
            }
            _form.Cb_DepartConsultaCargo.Text = "";
            _form.Cb_DepartConsultaCargo.SelectedIndex = -1;
        }

        public void ControlMostraListaCargo()
        {
            Departamento dp = _listaDepart.Find(getDepartamentoForNome);
            if (dp == null) throw new DomainsExcpetion("Erro: Departamento não encontrado !");

            if (dp.ListaCargos.Count > 0) dp.ListaCargos.Clear();

            ConexaoDAO.ModifyOperation(DepartamentoDAO.GetListaCargo, dp);

            _listaCargo = dp.ListaCargos;

            _form.Lv_Cargos.Items.Clear();
            foreach (Cargo c in dp.ListaCargos)
            {
                ListViewItem item = new ListViewItem(new string[] { c.Id.ToString(), c.Nome, c.Status.ToString() });
                _form.Lv_Cargos.Items.Add(item);
            }

            if (dp.ListaCargos.Count == 0) throw new DomainsExcpetion("Nada cadastrado ainda !");
            _form.txt_NUmCargos.Text = dp.ListaCargos.Count.ToString() + " Cargos Vinculados";
        }

        public void ControlUpdateCargo()
        {
            Cargo cargoUpdate = _listaCargo.Find(GetCargoForId);

            if (_form.Rb_Congregacao.Checked)
            {
                cargoUpdate.Depart.Igreja = _listaCongregacao.Find(getCongForCodigo);
            }
            FrmCadDepartCargo cad = new FrmCadDepartCargo(cargoUpdate);
            cad.ShowDialog();
        }

        public void ControlDeleteCargo()
        {
            Cargo c = _listaCargo.Find(GetCargoForId);
            DialogResult result = MessageBox.Show("Deseja realmente excluir o seguinte Cargo: " + c.Nome + " ?", "CONFIRME", MessageBoxButtons.YesNo);
            if (!(result == DialogResult.Yes)) throw new DomainsExcpetion("Operação abortada com sucesso !");
            if (c is null) throw new DomainsExcpetion("erro: Nemhum Cargo selecionado !");
            ConexaoDAO.ModifyOperation(DepartamentoDAO.DeleteCargo, c);
            MessageBox.Show("Cargo Deletado com sucesso da Base de Dados !");
        }

        public void ControlMostraListaCongregacao()
        {
            Templo sede = _listaTemplo.Find(getTemploForCodigo);
            _listaCongregacao = ConexaoDAO.getLisObjectOperation(IgrejaDAO.getListaCongregacao, sede);
            _form.Cb_ListaCongregacao.DataSource = _listaCongregacao;
            _form.Cb_ListaCongregacao.DisplayMember = "nome";
            _form.Cb_ListaCongregacao.ValueMember = "codigo";
        }

        public void ControlMostraListaDepartamento()
        {
            Igreja i = null;

            if (_form.Rb_Congregacao.Checked)
            {
                string nomeCong = _form.Cb_ListaCongregacao.Text;
                string codigoCong = _form.Cb_ListaCongregacao.SelectedValue.ToString();
                i = new Congregacao(codigoCong, nomeCong);
                if (_form.Cb_ListaCongregacao.Text == string.Empty) throw new DomainsExcpetion("Congregação nao selecionada !");
            }
            else
            {
                string nome = _form.Cb_listaTemplo.Text;
                string codigo = _form.Cb_listaTemplo.SelectedValue.ToString();
                i = new Templo(codigo, 0, nome);
                if (_form.Cb_listaTemplo.Text == string.Empty) throw new DomainsExcpetion("Templo sede nao selecionado !");
            }
            _listaDepart = null;
            _listaDepart = ConexaoDAO.getLisObjectOperation(DepartamentoDAO.GetListaDepartamentos, i);
            _form.Lv_Departamentos.Items.Clear();
            foreach (Departamento dp in _listaDepart)
            {
                ListViewItem item = new ListViewItem(new string[] { dp.Id.ToString(), dp.Nome });
                _form.Lv_Departamentos.Items.Add(item);
            }
        }

        public void ControlUpdateDepartamento()
        {
            Departamento departUpdate = _listaDepart.Find(getDepartamentoForId);
            if (_form.Rb_Congregacao.Checked)
            {
                Congregacao cong = _listaCongregacao.Find(getCongForCodigo);
                departUpdate.Igreja = null;
                departUpdate.Igreja = cong;
            }
            FrmCadDepartCargo depart = new FrmCadDepartCargo(departUpdate);
            depart.ShowDialog();
        }

        public void ControlNewVinculo()
        {
            //igreja
            Igreja i = null;
            if (_form.Rb_Congregacao.Checked)
            {
                string nome = _form.Cb_ListaCongregacao.Text;
                string codigo = _form.Cb_ListaCongregacao.SelectedValue.ToString();
                i = new Congregacao(codigo, nome);
            }
            else
            {
                string codigo = _form.Cb_listaTemplo.SelectedValue.ToString();
                string nomeIgreja = _form.Cb_listaTemplo.Text;
                i = new Templo(codigo, 0, nomeIgreja);
            }

            Departamento dp = _listaDepart.Find(getDepartamentoForNome);
            Cargo c = _listaCargo.Find(GetCargoForId);
            if (c is null) throw new DomainsExcpetion("erro> Nemhum Cargo Foi Selecionado !");
            if (c.Status == StatusCargo.OCUPADO) throw new DomainsExcpetion("erro: Este cargo nao esta disponivel no momento ");
            VinculoFuncional vinc = new VinculoFuncional(dp, i, c);
            FrmCadVinculo form = new FrmCadVinculo(vinc);
            form.ShowDialog();

        }


        public void ControlDeleteVinculo()
        {
            VinculoFuncional vinc = _listaVinculos.Find(GetVinculoForId);
            DialogResult res = MessageBox.Show("Deseja realmente deletar o vinculo de: " + vinc.Membro.Nome + " ?", "confirme", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) throw new DomainsExcpetion("Operação cancelada !");

            ConexaoDAO.ModifyOperation(VinculoDAO.DeleteVinculo, vinc);
            vinc.Cargo.Status = StatusCargo.DISPONIVEL;
            ConexaoDAO.ModifyOperation(DepartamentoDAO.UpdateCargo, vinc.Cargo);
            MessageBox.Show("Vinculo Deletado com sucesso !");
        }

        public void ControlReportGeral()
        {

            Igreja i;

            if (_form.Rb_Congregacao.Checked)
            {
                string codigp =_form.Cb_ListaCongregacao.SelectedValue.ToString();
                string nomeIgreja = _form.Cb_ListaCongregacao.Text.ToString();
                i = new Congregacao(codigp,nomeIgreja);

            }
            else
            {
                string codigo = _form.Cb_listaTemplo.SelectedValue.ToString();
                string nomeTemplo = _form.Cb_listaTemplo.Text;
                i = new Templo(codigo,0,nomeTemplo);
            }


            List<VinculoFuncional> listaGeral = ConexaoDAO.getLisObjectOperation(VinculoDAO.GetListaVinculosForIgreja, i);
            if (listaGeral.Count == 0) throw new DomainsExcpetion("Erro: Selecione Primeiro um Igreja e Click em Carregar Dados ");
            FrmRelVinculos reportForm = new FrmRelVinculos(listaGeral);
            reportForm.ShowDialog();    
        }

        public void ControlReporteEsquema()
        {
           // List<VinculoFuncional> listaGeral = ConexaoDAO.getLisObjectOperation(VinculoDAO.GetListaVinculosForIgreja, i);
            if (_listaVinculos.Count == 0) throw new DomainsExcpetion("Erro: Selecione Primeiro um Igreja e Click em Carregar Dados ");
            FrmRelVinculos reportForm = new FrmRelVinculos(_listaVinculos);
            reportForm.ShowDialog();
        }

        public void ControlMostraListaVinculo()
        {
            Departamento dp = _listaDepart.Find(getDepartamentoForNome2);
            _listaVinculos = ConexaoDAO.getLisObjectOperation(VinculoDAO.GetListaVinculosForDepartamento, dp);

            _form.Lv_ListaVinculos.Items.Clear();
            List<VinculoFuncional> lista = null;
            int index = _form.Cb_FiltrarStatusVinc.SelectedIndex;

            if (index == 2)
            {
                lista = _listaVinculos;
                _form.Lb_FiltroStatusVinc.Text = "TODAS";
            }
            else
            {
                 lista = _listaVinculos.FindAll(getVinculoForAno).FindAll(getVinculoForStatus);
                 StatusVinculo status = (StatusVinculo)_form.Cb_FiltrarStatusVinc.SelectedIndex;
                _form.Lb_FiltroStatusVinc.Text = status.ToString();
            }

            foreach (VinculoFuncional vinc in lista)
            {
                ListViewItem item = new ListViewItem(new string[] { vinc.Id.ToString(), vinc.Cargo.Nome, vinc.Membro.Nome });
                _form.Lv_ListaVinculos.Items.Add(item);
            }
            _form.Lb_AnoSelecionado.Text = _form.Cb_AnoFiltrar.SelectedItem.ToString();
        }

        public void MostraListaAnosFiltraVinculo()
        {
            int anoAtual = DateTime.Now.Year;
            for (int i = anoAtual; i >= (anoAtual - 20); i--)
            {
                _form.Cb_AnoFiltrar.Items.Add(i);
            }
            _form.Cb_AnoFiltrar.SelectedIndex = 0;
        }

        public void MostrarListDepartVinc()
        {
            _form.Cb_ListDepartVinc.Items.Clear();
            foreach (Departamento d in _listaDepart)
            {
                _form.Cb_ListDepartVinc.Items.Add(d.Nome);
            }
        }

        public void GetInforVincuSelect()
        {
            VinculoFuncional vinc = _listaVinculos.Find(GetVinculoForId);
            if (vinc is null) throw new DomainsExcpetion("Erro: Nemhum departamento Selecionado no momento. Atualize a lista por favor");
            _form.txt_AnoVinculo.Text = vinc.Ano.ToString();
            _form.txt_DataFim.Text = vinc.DataFim.ToShortDateString();
            _form.txt_dataInicio.Text = vinc.DataInicio.ToShortDateString();
            _form.txt_Duracao.Text = vinc.CalculaDuracao().ToString();
            _form.txt_StatusVinculo.Text = vinc.Status.ToString();
        }

        public void FiltraVinculoAno()
        {
            List<VinculoFuncional> lista = _listaVinculos.FindAll(getVinculoForAno);

            _form.Lv_ListaVinculos.Items.Clear();
            foreach (VinculoFuncional vinc in lista)
            {
                ListViewItem item = new ListViewItem(new string[] { vinc.Id.ToString(), vinc.Cargo.Nome, vinc.Membro.Nome });
                _form.Lv_ListaVinculos.Items.Add(item);
            }
            _form.Lb_AnoSelecionado.Text = _form.Cb_AnoFiltrar.SelectedItem.ToString();
        }

        public void FiltraVinculoForStatus(StatusVinculo status)
        {
            _statusVincFillter = status;
            List<VinculoFuncional> lista = _listaVinculos.FindAll(getVinculoForStatus);
            _form.Lv_ListaVinculos.Items.Clear();
            foreach (VinculoFuncional vinc in lista)
            {
                ListViewItem item = new ListViewItem(new string[] { vinc.Id.ToString(), vinc.Cargo.Nome, vinc.Membro.Nome });
                _form.Lv_ListaVinculos.Items.Add(item);
            }
            _form.Lb_FiltroStatusVinc.Text = status.ToString();
        }

        public void FiltraVinculoForStatus()
        {
            List<VinculoFuncional> lista = _listaVinculos;

            _form.Lv_ListaVinculos.Items.Clear();
            foreach (VinculoFuncional vinc in lista)
            {
                ListViewItem item = new ListViewItem(new string[] { vinc.Id.ToString(), vinc.Cargo.Nome, vinc.Membro.Nome });
                _form.Lv_ListaVinculos.Items.Add(item);
            }
            _form.Lb_FiltroStatusVinc.Text = "TODOS";
        }

        public void ControlArquivaVinculo()
        {
            VinculoFuncional vinc = _listaVinculos.Find(GetVinculoForId);
            vinc.DataFim = DateTime.Now;
            vinc.Status = StatusVinculo._ARQUIVADO;
            DialogResult res = MessageBox.Show("Deseja realmente delete o vinculo relacionado a: " + vinc.Membro.Nome, "OBS: A ARQUIVAÇÃO NÃO PODE SER DESFEITA !", MessageBoxButtons.YesNo);
            if (!(res == DialogResult.Yes)) throw new DomainsExcpetion("Operação cancelada com sucesso !");

            ConexaoDAO.ModifyOperation(VinculoDAO.UpdateVinculo, vinc);
            vinc.Cargo.Status = StatusCargo.DISPONIVEL;
            ConexaoDAO.ModifyOperation(DepartamentoDAO.UpdateCargo, vinc.Cargo);
            MessageBox.Show("Vinculo Arquivado com sucesso !");
        }

        //delegates

        public bool getTemploForCodigo(Templo t)
        {
            string codigo = _form.Cb_listaTemplo.SelectedValue.ToString();
            return (t.Codigo == codigo) ? true : false;
        }

        public bool getCongForCodigo(Congregacao cong)
        {
            string codigoCong = _form.Cb_ListaCongregacao.SelectedValue.ToString();
            return (cong.Codigo == codigoCong) ? true : false;
        }

        public bool getDepartamentoForId(Departamento depart)
        {
            int index = _form.Lv_Departamentos.SelectedIndices[0];
            int id_departa = int.Parse(_form.Lv_Departamentos.Items[index].SubItems[0].Text);
            return (depart.Id == id_departa) ? true : false;
        }

        public bool getDepartamentoForNome(Departamento depart)
        {
            string nomeDepart = _form.Cb_DepartConsultaCargo.SelectedItem.ToString();
            return (depart.Nome == nomeDepart) ? true : false;
        }

        public bool getDepartamentoForNome2(Departamento depart)
        {
            string nomeDepart = _form.Cb_ListDepartVinc.SelectedItem.ToString();
            return (depart.Nome == nomeDepart) ? true : false;
        }

        private bool GetVinculoForId(VinculoFuncional vinc)
        {
            int index = _form.Lv_ListaVinculos.SelectedIndices[0];
            int idVinc = int.Parse(_form.Lv_ListaVinculos.Items[index].SubItems[0].Text);
            return (vinc.Id == idVinc) ? true : false;
        }

        private bool GetCargoForId(Cargo c)
        {
            int indeces = _form.Lv_Cargos.SelectedIndices[0];
            int idCargp = int.Parse(_form.Lv_Cargos.Items[indeces].SubItems[0].Text);
            return (c.Id == idCargp) ? true : false;
        }

        private bool getVinculoForAno(VinculoFuncional vinc)
        {
            int anoSelecionado = int.Parse(_form.Cb_AnoFiltrar.SelectedItem.ToString());
            return (vinc.Ano == anoSelecionado) ? true : false;
        }

        private bool getVinculoForStatus(VinculoFuncional vinc)
        {
            StatusVinculo statusSelect = (StatusVinculo)_form.Cb_FiltrarStatusVinc.SelectedIndex;
            return (vinc.Status == statusSelect) ? true : false;
        }
    }
}
