using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;
using SICM.Servicos;
using MySql.Data.MySqlClient;
using System.Data;
using SICM.Entidades;

namespace SICM.DAO
{
    class MembroDB
    {
        public static void Insert(Membro m)
        {
            string query = "insert into tb_membro(codigo_membro,nome_membro, status,igreja,categoria,sub_categoria) " +
                "values(@codigo_membro,@nome_membro, @status,@igreja,@categoria,@sub_categoria)";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@codigo_membro", m.Codigo);
            cmd.Parameters.AddWithValue("@nome_membro", m.Nome);
            cmd.Parameters.AddWithValue("@status", (int)m.Status);
            cmd.Parameters.AddWithValue("@igreja", m.Igreja.Codigo);
            cmd.Parameters.AddWithValue("@categoria", (int)m.Categoria);
            cmd.Parameters.AddWithValue("@sub_categoria", (int)m.SubCategoria);
            cmd.ExecuteNonQuery();
        }

        public static void InsertDadosEndereco(Membro m)
        {
            string query = "insert into tb_endereco (cod_membro, rua, numero, bairro, cidade, estado) " +
                "values(@cod_membro, @rua, @numero, @bairro, @cidade, @estado)";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod_membro", m.Codigo);
            cmd.Parameters.AddWithValue("@rua", m.Endereco.Rua);
            cmd.Parameters.AddWithValue("@numero", m.Endereco.Numero);
            cmd.Parameters.AddWithValue("@bairro", m.Endereco.Bairro);
            cmd.Parameters.AddWithValue("@cidade", m.Endereco.Cidade);
            cmd.Parameters.AddWithValue("@estado", m.Endereco.Estado);
            cmd.ExecuteNonQuery();
        }

        public static void InsertDadosPessoais(Membro m)
        {
            string query = "insert into tb_dadospessoais(cod_membro,cpf,genero,datanas,nacionalidade,naturalidade,estadocivil,escolaridade,conjuge,telefone) " +
                "values(@cod_membro,@cpf,@genero,@datanas,@nacionalidade,@naturalidade,@estadocivil,@escolaridade,@conjuge,@telefone)";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod_membro", m.Codigo);
            cmd.Parameters.AddWithValue("@cpf", m.DadosPessoais.Cpf);
            cmd.Parameters.AddWithValue("@genero", m.DadosPessoais.Genero);
            cmd.Parameters.AddWithValue("@datanas", m.DadosPessoais.DataNascimento);
            cmd.Parameters.AddWithValue("@nacionalidade", m.DadosPessoais.Nacionalidade);
            cmd.Parameters.AddWithValue("@naturalidade", m.DadosPessoais.Naturalidade);
            cmd.Parameters.AddWithValue("@estadocivil", (int)m.DadosPessoais.EstadoCivil);
            cmd.Parameters.AddWithValue("@escolaridade", m.DadosPessoais.Escolaridade);
            cmd.Parameters.AddWithValue("@conjuge", m.DadosPessoais.Conjuge);
            cmd.Parameters.AddWithValue("@telefone", m.DadosPessoais.Telefone);
            cmd.ExecuteNonQuery();
        }

        public static void InsertDadosEsp(Membro m)
        {
            string query = "insert into tb_dadosesp (cod_membro,dataBat,localBat) values (@cod_membro,@dataBat,@localBat)";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod_membro", m.Codigo);
            cmd.Parameters.AddWithValue("@dataBat", m.DadosEsp.DataBatismal);
            cmd.Parameters.AddWithValue("@localBat", m.DadosEsp.LocalBatismo);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteMembro(Membro m)
        {
            string query = "delete from tb_membro where codigo_membro= @cod";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod", m.Codigo);
            cmd.ExecuteNonQuery();
        }

        public static void BuscaListaMembros(Igreja i)
        {
            List<Membro> lista = new List<Membro>();
            string query = "select i.codigo_igreja, m.codigo_membro,m.nome_membro,m.status,m.categoria,m.sub_categoria," +
                "end.rua,end.numero,end.bairro,end.cidade,end.estado,dp.cpf,dp.genero,dp.datanas," +
                "dp.nacionalidade,dp.naturalidade,dp.estadocivil,dp.escolaridade,dp.conjuge, dp.telefone," +
                "ds.databat,ds.localbat " +
                "FROM tb_membro as m " +
                "INNER join tb_igreja as i " +
                "ON m.igreja = i.codigo_igreja " +
                "INNER JOIN tb_endereco as end " +
                "ON end.cod_membro = m.codigo_membro " +
                "INNER JOIN tb_dadospessoais as dp " +
                "ON dp.cod_membro = m.codigo_membro " +
                "INNER JOIN tb_dadosesp as ds " +
                "ON ds.cod_membro = codigo_membro " +
                "WHERE i.codigo_igreja = @codigoIgreja ";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@codigoIgreja", i.Codigo);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string nomeMembro = rd.GetString("nome_membro");
                string codigo = rd.GetString("codigo_membro");
                StatusMembro status = (StatusMembro)rd.GetInt16("status");
                TipoCategoria cat = (TipoCategoria)rd.GetInt16("categoria");
                SubCategoria subCat = (SubCategoria)rd.GetInt16("sub_categoria");

                //buscando dados pessoais
                string cpf = rd.GetString("cpf");
                TipoGenero gen = (TipoGenero)rd.GetInt16("genero");
                DateTime dataNas = rd.GetDateTime("dataNas");
                string nacionalidade = rd.GetString("nacionalidade");
                string naturalidade = rd.GetString("naturalidade");
                TipoEscolaridade escolaridade = (TipoEscolaridade)rd.GetInt16("escolaridade");
                TipoEstCivil estadoCivil = (TipoEstCivil)rd.GetInt16("estadoCivil");
                string conjuge = rd.GetString("conjuge");
                string telefone = rd.GetString("telefone");
               // byte[] img = (byte[])rd["foto"];
                DadosPessoais dp = new DadosPessoais(cpf, gen, dataNas, nacionalidade, naturalidade, estadoCivil, escolaridade, conjuge,telefone);


                //buscando dados de endereço
                string rua = rd.GetString("rua");
                string numero = rd.GetString("numero");
                string bairro = rd.GetString("bairro");
                string cidade = rd.GetString("cidade");
                string estado = rd.GetString("estado");
                Endereco end = new Endereco(rua, numero, bairro, cidade, estado);

                //buscando dados espirituais
                DateTime dataBat = rd.GetDateTime("dataBat");
                string localBat = rd.GetString("localBat");
                DadosEsp ds = new DadosEsp(dataBat, localBat);

                //criando objeto final
                Membro membro = new Membro(codigo, nomeMembro, status, dp, ds, end, i, cat, subCat);
                i.AddNewMembro(membro);
            }

        }


        public static List<Membro> BuscaListaMembros(Igreja i, string nomeMembroChave)
        {
            List<Membro> lista = new List<Membro>();
            string query = "select i.codigo_igreja, m.codigo_membro,m.nome_membro,m.status,m.categoria,m.sub_categoria," +
                "end.rua,end.numero,end.bairro,end.cidade,end.estado,dp.cpf,dp.genero,dp.datanas," +
                "dp.nacionalidade,dp.naturalidade,dp.estadocivil,dp.escolaridade,dp.conjuge, dp.telefone," +
                "ds.databat,ds.localbat " +
                "FROM tb_membro as m " +
                "INNER join tb_igreja as i " +
                "ON m.igreja = i.codigo_igreja " +
                "INNER JOIN tb_endereco as end " +
                "ON end.cod_membro = m.codigo_membro " +
                "INNER JOIN tb_dadospessoais as dp " +
                "ON dp.cod_membro = m.codigo_membro " +
                "INNER JOIN tb_dadosesp as ds " +
                "ON ds.cod_membro = codigo_membro " +
                "WHERE i.codigo_igreja = @codigoIgreja and m.nome_membro LIKE '"+nomeMembroChave+"%' ";

            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@codigoIgreja", i.Codigo);
            cmd.Parameters.AddWithValue("@nome", nomeMembroChave);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string nomeMembro = rd.GetString("nome_membro");
                string codigo = rd.GetString("codigo_membro");
                StatusMembro status = (StatusMembro)rd.GetInt16("status");
                TipoCategoria cat = (TipoCategoria)rd.GetInt16("categoria");
                SubCategoria subCat = (SubCategoria)rd.GetInt16("sub_categoria");

                //buscando dados pessoais
                string cpf = rd.GetString("cpf");
                TipoGenero gen = (TipoGenero)rd.GetInt16("genero");
                DateTime dataNas = rd.GetDateTime("dataNas");
                string nacionalidade = rd.GetString("nacionalidade");
                string naturalidade = rd.GetString("naturalidade");
                TipoEscolaridade escolaridade = (TipoEscolaridade)rd.GetInt16("escolaridade");
                TipoEstCivil estadoCivil = (TipoEstCivil)rd.GetInt16("estadoCivil");
                string conjuge = rd.GetString("conjuge");
                string telefone = rd.GetString("telefone");
               // byte[] img = (byte[])rd["foto"];
                DadosPessoais dp = new DadosPessoais(cpf, gen, dataNas, nacionalidade, naturalidade, estadoCivil, escolaridade, conjuge, telefone);


                //buscando dados de endereço
                string rua = rd.GetString("rua");
                string numero = rd.GetString("numero");
                string bairro = rd.GetString("bairro");
                string cidade = rd.GetString("cidade");
                string estado = rd.GetString("estado");
                Endereco end = new Endereco(rua, numero, bairro, cidade, estado);

                //buscando dados espirituais
                DateTime dataBat = rd.GetDateTime("dataBat");
                string localBat = rd.GetString("localBat");
                DadosEsp ds = new DadosEsp(dataBat, localBat);

                //criando objeto final
                Membro membro = new Membro(codigo, nomeMembro, status, dp, ds, end, i, cat, subCat);
                lista.Add(membro);
            }
            return lista;

        }


        public static void BuscaListaMembrosVoid(Igreja i, string nomeMembroChave)
        {
          //  List<Membro> lista = new List<Membro>();
            string query = "select i.codigo_igreja, m.codigo_membro,m.nome_membro,m.status,m.categoria,m.sub_categoria," +
                "end.rua,end.numero,end.bairro,end.cidade,end.estado,dp.cpf,dp.genero,dp.datanas," +
                "dp.nacionalidade,dp.naturalidade,dp.estadocivil,dp.escolaridade,dp.conjuge, dp.telefone," +
                "ds.databat,ds.localbat " +
                "FROM tb_membro as m " +
                "INNER join tb_igreja as i " +
                "ON m.igreja = i.codigo_igreja " +
                "INNER JOIN tb_endereco as end " +
                "ON end.cod_membro = m.codigo_membro " +
                "INNER JOIN tb_dadospessoais as dp " +
                "ON dp.cod_membro = m.codigo_membro " +
                "INNER JOIN tb_dadosesp as ds " +
                "ON ds.cod_membro = codigo_membro " +
                "WHERE i.codigo_igreja = @codigoIgreja and m.nome_membro LIKE '" + nomeMembroChave + "%' ";

            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@codigoIgreja", i.Codigo);
            cmd.Parameters.AddWithValue("@nome", nomeMembroChave);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string nomeMembro = rd.GetString("nome_membro");
                string codigo = rd.GetString("codigo_membro");
                StatusMembro status = (StatusMembro)rd.GetInt16("status");
                TipoCategoria cat = (TipoCategoria)rd.GetInt16("categoria");
                SubCategoria subCat = (SubCategoria)rd.GetInt16("sub_categoria");

                //buscando dados pessoais
                string cpf = rd.GetString("cpf");
                TipoGenero gen = (TipoGenero)rd.GetInt16("genero");
                DateTime dataNas = rd.GetDateTime("dataNas");
                string nacionalidade = rd.GetString("nacionalidade");
                string naturalidade = rd.GetString("naturalidade");
                TipoEscolaridade escolaridade = (TipoEscolaridade)rd.GetInt16("escolaridade");
                TipoEstCivil estadoCivil = (TipoEstCivil)rd.GetInt16("estadoCivil");
                string conjuge = rd.GetString("conjuge");
                string telefone = rd.GetString("telefone");
                // byte[] img = (byte[])rd["foto"];
                DadosPessoais dp = new DadosPessoais(cpf, gen, dataNas, nacionalidade, naturalidade, estadoCivil, escolaridade, conjuge, telefone);


                //buscando dados de endereço
                string rua = rd.GetString("rua");
                string numero = rd.GetString("numero");
                string bairro = rd.GetString("bairro");
                string cidade = rd.GetString("cidade");
                string estado = rd.GetString("estado");
                Endereco end = new Endereco(rua, numero, bairro, cidade, estado);

                //buscando dados espirituais
                DateTime dataBat = rd.GetDateTime("dataBat");
                string localBat = rd.GetString("localBat");
                DadosEsp ds = new DadosEsp(dataBat, localBat);

                //criando objeto final
                Membro membro = new Membro(codigo, nomeMembro, status, dp, ds, end, i, cat, subCat);
                i.AddNewMembro(membro);
            }

        }

        public static void UpdateInfoMembro(Membro m)
        {
            string query = "update tb_membro set nome_membro = @nome_membro, status = @status,igreja = @igreja, categoria = @cat, sub_categoria = @subCat " +
                 "where codigo_membro = @codigo";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@nome_membro", m.Nome);
            cmd.Parameters.AddWithValue("@status", (int)m.Status);
            cmd.Parameters.AddWithValue("@igreja", m.Igreja.Codigo);
            cmd.Parameters.AddWithValue("@cat", (int)m.Categoria);
            cmd.Parameters.AddWithValue("@SubCat", (int)m.SubCategoria);
            cmd.Parameters.AddWithValue("@codigo", m.Codigo);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateInforPessoais(Membro m)
        {
            string query = "update tb_dadospessoais set cpf =@cpf, genero =@genero,dataNas = @datanas, nacionalidade = @nacionalidade," +
                "naturalidade = @naturalidade, estadocivil =@estadoCivil, escolaridade =@escolaridade, conjuge = @conjuge, telefone =@telefone  " +
                " where cod_membro = @cod_membro";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod_membro", m.Codigo);
            cmd.Parameters.AddWithValue("@cpf", m.DadosPessoais.Cpf);
            cmd.Parameters.AddWithValue("@genero",(int) m.DadosPessoais.Genero);
            cmd.Parameters.AddWithValue("@datanas", m.DadosPessoais.DataNascimento);
            cmd.Parameters.AddWithValue("@nacionalidade", m.DadosPessoais.Nacionalidade);
            cmd.Parameters.AddWithValue("@naturalidade", m.DadosPessoais.Naturalidade);
            cmd.Parameters.AddWithValue("@estadocivil", (int)m.DadosPessoais.EstadoCivil);
            cmd.Parameters.AddWithValue("@escolaridade", (int)m.DadosPessoais.Escolaridade);
            cmd.Parameters.AddWithValue("@conjuge", m.DadosPessoais.Conjuge);
            cmd.Parameters.AddWithValue("@telefone", m.DadosPessoais.Telefone);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateInfoEsps(Membro m)
        {
            string query = "update tb_dadosesp set dataBat =@dataBat, localBat =@localBat " +
                " where cod_membro = @cod_membro";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod_membro", m.Codigo);
            cmd.Parameters.AddWithValue("@dataBat", m.DadosEsp.DataBatismal);
            cmd.Parameters.AddWithValue("@localBat", m.DadosEsp.LocalBatismo);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateInfoEndereco(Membro m)
        {
            string query = "update tb_endereco set rua =@rua, numero =@numero, bairro =@bairro, cidade =@cidade, estado =@estado " +
                "where cod_membro =@codMembro";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@codMembro", m.Codigo);
            cmd.Parameters.AddWithValue("@rua", m.Endereco.Rua);
            cmd.Parameters.AddWithValue("@bairro", m.Endereco.Bairro);
            cmd.Parameters.AddWithValue("@cidade", m.Endereco.Cidade);
            cmd.Parameters.AddWithValue("@estado", m.Endereco.Estado);
            cmd.Parameters.AddWithValue("@numero", m.Endereco.Numero);
            cmd.ExecuteNonQuery();
        }

        public static bool VerificaSeCodExis(string codigo)
        {
            bool test = false;
            string query = "select codigo_membro from tb_membro where codigo_membro =@cod";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod", codigo);
            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                test = true;
            }
            return test;
        }

        public static bool VerificaSeMembroExiste(Membro m)
        {
            bool test = false;
            string query = "select m.igreja, dp.cpf " +
                "from tb_membro as m " +
                "INNER JOIN tb_dadospessoais as dp " +
                "ON dp.cod_membro = m.codigo_membro " +
                "WHERE m.igreja = @CodIgreja and m.nome_membro =@nomeMembro or dp.cpf =@cpf";

            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cpf", m.DadosPessoais.Cpf);
            cmd.Parameters.AddWithValue("@nomeMembro", m.Nome);
            cmd.Parameters.AddWithValue("@CodIgreja", m.Igreja.Codigo);
            MySqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                test = true;
            }
            return test;
        }

    }
}
