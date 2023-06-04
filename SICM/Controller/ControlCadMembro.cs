using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.DAO;
using SICM.Entidades.Enumeracoes;
using SICM.Entidades;
using SICM.Servicos;
using SICM.SubForms;

namespace SICM.Controller
{
    
    class ControlCadMembro
    {
        private FrmCadMembro _form;
        private List<Templo> _listaTemplo;
        private List<Congregacao> _listaCongregacao;
        private string _codigoTemplo;


        public ControlCadMembro(FrmCadMembro form)
        {
            _form = form;
        }

        public void ControlInsertMembro()
        {
            ValidaInsercao();
            string codigo = _form.txt_codigo.Text;
            string nome = _form.txt_NomeCompleto.Text;
            StatusMembro status = (StatusMembro)_form.Cb_Status.SelectedIndex;
            TipoCategoria cat = (TipoCategoria)_form.Cb_Categoria.SelectedIndex;
            SubCategoria subCat = (SubCategoria)_form.Cb_SubCategoria.SelectedIndex;

            //pegando dados pessoais
            string cpf = _form.txt_cpf.Text;
            if (cpf.Length != 11) throw new DomainsExcpetion("Cpf Invalido informado");
            string textoDataNas = _form.txt_dataNascimento.Text;

            //FORMANTANDO DATA DE NASCIMENTO
            int dia = int.Parse(textoDataNas.Substring(0, 2));
            int mes = int.Parse(textoDataNas.Substring(2, 2));
            int ano = int.Parse(textoDataNas.Substring(4, 4));
            DateTime dataNas = new DateTime(ano, mes, dia);

            TipoGenero gen = (TipoGenero)_form.Cb_genero.SelectedIndex;
            string nacionalidade = _form.txt_Nacionalidade.Text;
            string naturalidade = _form.txt_Naturalidade.Text;
            TipoEstCivil estadoCivil = (TipoEstCivil) _form.Cb_EstadiCivil.SelectedIndex;
            TipoEscolaridade escolariade = (TipoEscolaridade)_form.Cb_Escolaridade.SelectedIndex;
            string conjuge = _form.txt_Conjuge.Text;
            string telefone = _form.txt_telefone.Text;
            System.Drawing.Image img = _form.Pcb_FotoMembro.Image;
           // Byte[] fotoBD = ObjectService.ImgToByte(img);

            DadosPessoais dp = new DadosPessoais(cpf,gen,dataNas,nacionalidade,naturalidade,estadoCivil,escolariade,conjuge,telefone);

            //pegando dado de endereco
            string rua = _form.txt_ruaNome.Text;
            string numero = _form.txt_Numero.Text;
            string bairro = _form.txt_bairro.Text;
            string cidade = _form.Cb_Municipios.Text;
            string estatdo = _form.Cb_Estado.Text;

            Endereco end = new Endereco(rua, numero, bairro, cidade, estatdo);

            //pegando dados espirituais
            string textodataBat = _form.txt_dataBat.Text;

            //FORMANTANDO DATA BATISMO
            int diaBat = int.Parse(textodataBat.Substring(0, 2));
            int MesBat = int.Parse(textodataBat.Substring(2, 2));
            int AnoBat = int.Parse(textodataBat.Substring(4, 4));
            DateTime dataBat = new DateTime(AnoBat, MesBat, diaBat);

            string localBat = _form.txt_LocalBatismo.Text;

            DadosEsp de = new DadosEsp(dataBat, localBat);

            Igreja i = null;

            if (_form.Rb_TemploSede.Checked)
            {
                string codigoTemplo = _form.Cb_TemploSede.SelectedValue.ToString();
                string nomeSede = _form.Cb_TemploSede.Text;
                Templo sede = new Templo(codigoTemplo, 0, nomeSede);
                i = sede;
            }
            else if(_form.Rb_Congregacao.Checked)
            {
                string codCong = _form.Cb_ListaCongregacao.SelectedValue.ToString();
                string nomeCongregacao = _form.Cb_ListaCongregacao.Text;
                i = new Congregacao(codCong, nomeCongregacao);
            }
            Membro m = new Membro(codigo, nome, status, dp, de, end, i, cat, subCat);
            bool test = ConexaoDAO.ValidateOperation(MembroDB.VerificaSeMembroExiste, m);
            if (test) throw new DomainsExcpetion("O membro ja está cadastrado. Voçê não pode prosseguir");

            Action<Membro> insert = MembroDB.Insert;
            insert += MembroDB.InsertDadosPessoais;
            insert += MembroDB.InsertDadosEsp;
            insert += MembroDB.InsertDadosEndereco;

            ConexaoDAO.ModifyOperation(insert, m);

            LimparCamposCad();
            System.Windows.Forms.MessageBox.Show("Membro: "+nome+" Cadastrado com sucesso ! parabens");
        }

        public void ControlUpdate()
        {
            ValidaInsercao();
            string codigo = _form.txt_codigo.Text;
            string nome = _form.txt_NomeCompleto.Text;
            StatusMembro status = (StatusMembro)_form.Cb_Status.SelectedIndex;
            TipoCategoria cat = (TipoCategoria)_form.Cb_Categoria.SelectedIndex;
            SubCategoria subCat = (SubCategoria)_form.Cb_SubCategoria.SelectedIndex;

            //pegando dados pessoais
            string cpf = _form.txt_cpf.Text;

            if (cpf.Length != 11) throw new DomainsExcpetion("Cpf Invalido informado");
            string textoDataNas = _form.txt_dataNascimento.Text;

            //FORMANTANDO DATA DE NASCIMENTO
            int dia = int.Parse(textoDataNas.Substring(0, 2));
            int mes = int.Parse(textoDataNas.Substring(2, 2));
            int ano = int.Parse(textoDataNas.Substring(4, 4));
            DateTime dataNas = new DateTime(ano, mes, dia);

            TipoGenero gen = (TipoGenero)_form.Cb_genero.SelectedIndex;
            string nacionalidade = _form.txt_Nacionalidade.Text;
            string naturalidade = _form.txt_Naturalidade.Text;
            TipoEstCivil estadoCivil = (TipoEstCivil)_form.Cb_EstadiCivil.SelectedIndex;
            TipoEscolaridade escolariade = (TipoEscolaridade)_form.Cb_Escolaridade.SelectedIndex;
            string conjuge = _form.txt_Conjuge.Text;
            string telefone = _form.txt_telefone.Text;
            System.Drawing.Image img = _form.Pcb_FotoMembro.Image;
           // Byte[] fotoBD = ObjectService.ImgToByte(img);

            DadosPessoais dp = new DadosPessoais(cpf, gen, dataNas, nacionalidade, naturalidade, estadoCivil, escolariade, conjuge, telefone);

            //pegando dado de endereco
            string rua = _form.txt_ruaNome.Text;
            string numero = _form.txt_Numero.Text;
            string bairro = _form.txt_bairro.Text;
            string cidade = _form.Cb_Municipios.Text;
            string estatdo = _form.Cb_Estado.Text;

            Endereco end = new Endereco(rua, numero, bairro, cidade, estatdo);

            //pegando dados espirituais
            string textodataBat = _form.txt_dataBat.Text;

            //FORMANTANDO DATA BATISMO
            int diaBat = int.Parse(textodataBat.Substring(0, 2));
            int MesBat = int.Parse(textodataBat.Substring(2, 2));
            int AnoBat = int.Parse(textodataBat.Substring(4, 4));

            DateTime dataBat = new DateTime(AnoBat, MesBat, diaBat);

            string localBat = _form.txt_LocalBatismo.Text;

            DadosEsp de = new DadosEsp(dataBat, localBat);

            Igreja i = null;

            if (_form.Rb_TemploSede.Checked)
            {
                string codigoTemplo = _form.Cb_TemploSede.SelectedValue.ToString();
                string nomeSede = _form.Cb_TemploSede.Text;
                Templo sede = new Templo(codigoTemplo, 0, nomeSede);
                i = sede;
            }
            else if (_form.Rb_Congregacao.Checked)
            {
                string codCong = _form.Cb_ListaCongregacao.SelectedValue.ToString();
                string nomeCongregacao = _form.Cb_ListaCongregacao.Text;
                i = new Congregacao(codCong, nomeCongregacao);
            }
            Membro m = new Membro(codigo, nome, status, dp, de, end, i, cat, subCat);
           
            Action<Membro> update = MembroDB.UpdateInfoMembro;
            update += MembroDB.UpdateInforPessoais;
            update += MembroDB.UpdateInfoEndereco;
            update += MembroDB.UpdateInfoEsps;

            ConexaoDAO.ModifyOperation(update, m);

            LimparCamposCad();
            System.Windows.Forms.MessageBox.Show("Membro: " + nome + " Atualizado com sucesso ! parabens");
        }


        public void controlMostraInfoUpdate(Membro m)
        {
            _form.txt_codigo.Text = m.Codigo;
            _form.txt_NomeCompleto.Text = m.Nome;
            _form.txt_cpf.Text = m.DadosPessoais.Cpf;
            _form.txt_dataNascimento.Text = m.DadosPessoais.DataNascimento.ToShortDateString() ;
            _form.Cb_genero.SelectedIndex = (int)m.DadosPessoais.Genero;
            _form.txt_Nacionalidade.Text = m.DadosPessoais.Nacionalidade;
            _form.txt_Naturalidade.Text = m.DadosPessoais.Naturalidade;
            _form.Cb_EstadiCivil.SelectedIndex = (int)m.DadosPessoais.EstadoCivil;
            _form.Cb_Escolaridade.SelectedIndex = (int)m.DadosPessoais.Escolaridade;

            _form.txt_ruaNome.Text = m.Endereco.Rua;
            _form.txt_Numero.Text = m.Endereco.Numero;
            _form.txt_bairro.Text = m.Endereco.Bairro;
            _form.Cb_Estado.Text = m.Endereco.Estado;
            _form.txt_Conjuge.Text = m.DadosPessoais.Conjuge;

             MostraListaMunicipios();
            _form.Cb_Municipios.Text = m.Endereco.Cidade;
            _form.txt_dataBat.Text = m.DadosEsp.DataBatismal.ToShortDateString();
            _form.txt_LocalBatismo.Text = m.DadosEsp.LocalBatismo;


            if (m.Igreja is Congregacao)
            {
                Congregacao cong = m.Igreja as Congregacao;
                _form.Cb_TemploSede.Text = cong.Sede.Nome;
                _form.Rb_Congregacao.Checked = true;
                _form.Rb_TemploSede.Checked = false;
                this.PreecheListaCongregacao();
                _form.Cb_ListaCongregacao.Text = cong.Nome;
            }
            else
            {
                Templo sede = m.Igreja as Templo;
                _form.Cb_TemploSede.Text = sede.Nome;
                _form.Rb_TemploSede.Checked = true;
            }

            _form.Cb_Status.SelectedIndex = (int)m.Status;
            _form.Cb_Categoria.SelectedIndex = (int)m.Categoria;
            _form.Cb_SubCategoria.SelectedIndex = (int)m.SubCategoria;
 

        }

        private  void LimparCamposCad()
        {
            _form.txt_NomeCompleto.Text = "";
            _form.Cb_Status.SelectedIndex = 0;
            _form.Cb_TemploSede.SelectedIndex = 0;
            _form.Cb_Categoria.SelectedIndex = -1;
            _form.Cb_SubCategoria.SelectedIndex = -1;
            _form.txt_cpf.Text = "";
            _form.txt_dataBat.Text = "";
            _form.Cb_genero.SelectedIndex = -1;
            _form.txt_Nacionalidade.Text = "Brasileiro";
            _form.txt_Naturalidade.Text = "Imperatriz";
            _form.Cb_EstadiCivil.SelectedIndex = -1;
            _form.Cb_Escolaridade.SelectedIndex = -1;
            _form.txt_Conjuge.Text = "Conjuge";
            _form.txt_telefone.Text = "00000000000";
            _form.Pcb_FotoMembro.Image = SICM.Properties.Resources.ImagemMembro;
            _form.txt_ruaNome.Text = "";
            _form.txt_Numero.Text = "S/N";
            _form.txt_bairro.Text = "";
            _form.Cb_Municipios.SelectedIndex = -1;
            _form.Cb_Estado.SelectedIndex = 9;
            _form.Cb_Municipios.Text = "Senador La Rocque";
            _form.txt_dataBat.Text = "01011000";
            _form.txt_LocalBatismo.Text = "local Batismo";
        }

        public void PreencheListaTemplo()
        {
            _listaTemplo = ConexaoDAO.getLisObjectOperation(IgrejaDAO.GetListaTemplo);
            _form.Cb_TemploSede.DataSource = _listaTemplo;
            _form.Cb_TemploSede.DisplayMember = "nome";
            _form.Cb_TemploSede.ValueMember = "codigo";
           // _form.Cb_TemploSede.SelectedIndex = 0;

            _form.Cb_ListaId.DataSource = _listaTemplo;
            _form.Cb_ListaId.DisplayMember = "id";
            _form.Cb_ListaId.ValueMember = "id";
        }

        public void PreecheListaCongregacao()
        {
            int id = int.Parse(_form.Cb_ListaId.SelectedValue.ToString());
            string nomeSede = _form.Cb_TemploSede.Text;
            Templo sede = new Templo(id, nomeSede);

            _listaCongregacao = ConexaoDAO.getLisObjectOperation(IgrejaDAO.getListaCongregacao, sede);
            _form.Cb_ListaCongregacao.DataSource = _listaCongregacao;
            _form.Cb_ListaCongregacao.DisplayMember = "nome";
            _form.Cb_ListaCongregacao.ValueMember = "codigo";
        }

       

        private void ValidaInsercao()
        {
            if (_form.txt_NomeCompleto.Text == string.Empty) throw new DomainsExcpetion("Campo de Nome vazio");
            if (_form.txt_cpf.Text == string.Empty) throw new DomainsExcpetion("Campo de CPF não pode ser vazio");
            if (_form.Cb_genero.Text == string.Empty) throw new DomainsExcpetion("Campo de Genero nao pode ser vazio");
            if (_form.Cb_Status.Text.ToString() == string.Empty) throw new DomainsExcpetion("Campo de Status nao pode ser vazio !");
            if (_form.Cb_Categoria.Text.ToString() == string.Empty) throw new DomainsExcpetion("Categoria nao pode ser vazio");
            if (_form.Cb_SubCategoria.Text.ToString() == string.Empty) throw new DomainsExcpetion("Subcategoria nao pode ser vazia");
            if (_form.txt_dataNascimento.Text == string.Empty) throw new DomainsExcpetion("Campo de data de nascimento não pode ser vazia");
            if (_form.txt_Nacionalidade.Text == string.Empty) throw new DomainsExcpetion("Campo de Nacionalidade nao pode ser vazia");
            if (_form.txt_Naturalidade.Text == string.Empty) throw new DomainsExcpetion("Campo de naturalidade nao pode ser vazia");
            if (_form.Cb_EstadiCivil.Text.ToString() == string.Empty) throw new DomainsExcpetion("Estado civil nao pode ser vazio");
            if (_form.txt_Conjuge.Text == string.Empty) throw new DomainsExcpetion("Campo de Conjuge nao pode ser vazio");
            if (_form.txt_ruaNome.Text == string.Empty) throw new DomainsExcpetion("Campo de rua nao pode ser vazio");
            if (_form.txt_Numero.Text == string.Empty) throw new DomainsExcpetion("Campo de numero nao pode ser vazio");
            if (_form.txt_bairro.Text == string.Empty) throw new DomainsExcpetion("Campo de bairro nao pode ser vazia");
            if (_form.Cb_Municipios.Text == string.Empty) throw new DomainsExcpetion("Campo de Municipio nao pode ser vazia");
            if (_form.Cb_Estado.Text == string.Empty) throw new DomainsExcpetion("Campo de Estado nao pode ser vazio");
            if (_form.txt_dataBat.Text == string.Empty) throw new DomainsExcpetion("Data de nascimento nao pode ser vazia");
            if (_form.txt_LocalBatismo.Text == string.Empty) throw new DomainsExcpetion("campo do Local do Batismo nao pode ser vazio");

        }

        public void MostraListaMunicipios()
        {
            List<Municipio> listaPrincipal = Servicos.Municipio.GetListaMunicipios();
            _form.Cb_Municipios.DataSource = listaPrincipal.FindAll(TestaEstado);
            _form.Cb_Municipios.DisplayMember = "nome";
            _form.Cb_Municipios.ValueMember = "id";      
        }



        public string GenerateCode()
        {
            string codigoInicial = "ME0001";
            Random rd = new Random();
            bool test = ConexaoDAO.ValidateOperation(MembroDB.VerificaSeCodExis, codigoInicial);

            while (test)
            {
                string numeros = rd.Next().ToString().Substring(0, 4);
                codigoInicial = "ME" + numeros;
                test = ConexaoDAO.ValidateOperation(MembroDB.VerificaSeCodExis, codigoInicial);
            }
            return codigoInicial;
        }

        ///metodos auxiliares
        
        public bool TestaEstado(Municipio mun)
        {
            bool test = false;
            string textoEstado = _form.Cb_Estado.SelectedItem.ToString();
            string estado = textoEstado[1].ToString() + textoEstado[2].ToString();

            if (mun.Microrregiao.Mesorregiao.Uf.Sigla == estado)
            {
                test = true;
            }
            return test;
        }
    }
}
