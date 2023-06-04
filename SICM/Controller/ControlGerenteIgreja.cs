using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.DAO;
using SICM.Entidades;
using SICM.Entidades.Enumeracoes;
using System.Windows.Forms;
using SICM.SubForms;

namespace SICM.Controller
{
    class ControlGerenteIgreja
    {
        private FrmGerenteIgrejas _form;
        private List<Templo> _listaTemplo;
        private List<Congregacao> _listaCong;
        private int _IdTemploSelecionado;
        private string _codigoCongSel;

        public ControlGerenteIgreja(FrmGerenteIgrejas form)
        {
            _form = form;
        }

        public void getInfoTemploSelecionado()
        {
            _IdTemploSelecionado = int.Parse(_form.dgv_ListaTemplos.CurrentRow.Cells[0].Value.ToString());
            Templo selecionado = _listaTemplo.Find(getInfoTemploForId);
            _listaCong = ConexaoDAO.getLisObjectOperation(IgrejaDAO.getListaCongregacao,selecionado);
            ControlLimpaCamposTemplo();
            _form.txt_cnpjTemplo.Text = selecionado.Cnpj;
            _form.txt_codigo.Text = selecionado.Codigo;

            _form.Lv_ListaCongregacoes.Items.Clear();

            foreach(Congregacao c in _listaCong)
            {
                ListViewItem item = new ListViewItem(new string[] {c.Codigo,c.Nome });
                _form.Lv_ListaCongregacoes.Items.Add(item);
            }      
        }

        public void ControlUpdateInformacoes()
        {
            _IdTemploSelecionado  = int.Parse(_form.dgv_ListaTemplos.CurrentRow.Cells[0].Value.ToString());
            Templo temploEdit = _listaTemplo.Find(getInfoTemploForId);

            FrmCadIgreja _cad = new FrmCadIgreja(temploEdit);
            _cad.ShowDialog();
        }

        public void ControlUpdateInfoCong()
        {
            int index = _form.Lv_ListaCongregacoes.SelectedIndices[0];

            _codigoCongSel = _form.Lv_ListaCongregacoes.Items[index].SubItems[0].Text;

            Congregacao cong = _listaCong.Find(getInfoCongForCod);
            FrmCadIgreja cad = new FrmCadIgreja(cong);
            cad.ShowDialog();
        }

        public void GetInforCongSelecionada()
        {
            int indexLvSel = _form.Lv_ListaCongregacoes.SelectedIndices[0];
            _codigoCongSel = _form.Lv_ListaCongregacoes.Items[indexLvSel].SubItems[0].Text;

            Congregacao congSelecionada = _listaCong.Find(getInfoCongForCod);

            this.LimparCamposCongs();
            _form.txt_dirigente.Text = congSelecionada.Dirigente;
            _form.txt_RuaCong.Text = congSelecionada.Rua;
            _form.txt_num2.Text = congSelecionada.Numero;
            _form.txt_BairroCong.Text = congSelecionada.Bairro;
            _form.txt_CidadeCong.Text = congSelecionada.Cidade;
            _form.txt_DataFund.Text = congSelecionada.DataFund.ToShortDateString(); 
            
        }

        public void ControlDeleteTemplo()
        {
            if (_form.dgv_ListaTemplos.SelectedRows.Count ==0) throw new DomainsExcpetion("Erro nada selecionado !");
            _IdTemploSelecionado = int.Parse(_form.dgv_ListaTemplos.CurrentRow.Cells[0].Value.ToString());

            Templo templo = _listaTemplo.Find(getInfoTemploForId);
            _listaCong = ConexaoDAO.getLisObjectOperation(IgrejaDAO.getListaCongregacao, templo);
            _listaCong.ForEach(DeleteCongsVinculadas);


            ConexaoDAO.ModifyOperation(IgrejaDAO.DeleteIgreja, templo);
            MessageBox.Show("Operação realizada com sucesso !");

        }

        public void ControlDeleteCongregacao()
        {
            if (_form.Lv_ListaCongregacoes.SelectedItems.Count == 0) throw new DomainsExcpetion("Nada selecionado !");
            int index = _form.Lv_ListaCongregacoes.SelectedIndices[0];
           
            _codigoCongSel = _form.Lv_ListaCongregacoes.Items[index].SubItems[0].Text;
            Congregacao cong = _listaCong.Find(getInfoCongForCod);
            ConexaoDAO.ModifyOperation(IgrejaDAO.DeleteIgreja, cong);
            MessageBox.Show("Operação realizada com sucesso !");
        }

        public void ControlLimpaCamposTemplo()
        {
            _form.txt_codigo.Text = string.Empty;
            _form.txt_cnpjTemplo.Text = string.Empty;
            _form.txt_CapMedio.Text = string.Empty;
            _form.txt_NumDepart.Text = string.Empty;
            _form.txt_NumMembros.Text = string.Empty;
        }

        public void LimparCamposCongs()
        {
            _form.txt_dirigente.Text = string.Empty;
            _form.txt_CapMediCong.Text = string.Empty;
            _form.txt_NumCong.Text = string.Empty;
            _form.txt_RuaCong.Text = string.Empty;
            _form.txt_BairroCong.Text = string.Empty;
            _form.txt_CidadeCong.Text = string.Empty;
            _form.txt_DataFund.Text = string.Empty;
        }

        public void MostraListaTemplo()
        {
            _listaTemplo = ConexaoDAO.getLisObjectOperation(IgrejaDAO.GetListaTemplo);

            _form.dgv_ListaTemplos.Rows.Clear();
            for (int i = 0; i < _listaTemplo.Count; i++)
            {
                DataGridViewRow linha = (DataGridViewRow)_form.dgv_ListaTemplos.Rows[i].Clone();
                linha.Cells[0].Value = _listaTemplo[i].Id;
                linha.Cells[1].Value = _listaTemplo[i].Nome;
                linha.Cells[2].Value = _listaTemplo[i].Rua;
                linha.Cells[3].Value = _listaTemplo[i].Bairro;
                linha.Cells[4].Value = _listaTemplo[i].Cidade;
                linha.Cells[5].Value = _listaTemplo[i].DataFund.ToShortDateString();
                _form.dgv_ListaTemplos.Rows.Add(linha);
            }
        }

        //DELEGATES
        private bool getInfoTemploForId(Templo t)
        {
            bool test = false;
            if (t.Id == _IdTemploSelecionado)
            {
                test = true;
            }
            return test;
        }

        private void DeleteCongsVinculadas(Congregacao cong)
        {
            if (cong.Sede.Id==_IdTemploSelecionado)
            {
                ConexaoDAO.ModifyOperation(IgrejaDAO.DeleteIgreja, cong);
            }
        }


        private bool getInfoCongForCod(Congregacao cong)
        {
            bool test = false;
            if (cong.Codigo == _codigoCongSel)
            {
                test = true;
            }
            return test;
        }
    }
}
