using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;
using SICM.Entidades;
using SICM.DAO;
using SICM.SubForms;
using MySql.Data.MySqlClient;


namespace SICM.DAO
{
    class CaixaDAO
    {
        public static void InsertNewCaixa(Caixa caixa)
        {
            string query = "insert into tb_caixa (nome, saldo, tipo_Caixa) values(@nome,@saldo,@tipoCaixa)";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@nome", caixa.Nome);
            cmd.Parameters.AddWithValue("@tipoCaixa", (int)caixa.TipoCaixa);
            cmd.Parameters.AddWithValue("@saldo", caixa.Saldo);
            cmd.ExecuteNonQuery();
        }

        public static void InsertNewDizimo(Dizimo dizimo)
        {
      
            string query = "insert into tb_dizimo (membro,valor,ano,mes,igreja, tipo,descricao) values(@membro,@valor,@ano,@mes,@igreja,@tipo,@descricao) ";
          //  string query = "insert into tb_dizimo (membro, )"

            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@membro", dizimo.Membro.Nome);
            cmd.Parameters.AddWithValue("@valor", dizimo.Valor);
            cmd.Parameters.AddWithValue("@ano", dizimo.Ano);
            cmd.Parameters.AddWithValue("@mes", dizimo.Mes);
            cmd.Parameters.AddWithValue("@tipo", (int)dizimo.Tipo);
            cmd.Parameters.AddWithValue("@descricao", dizimo.Descricao);
            cmd.Parameters.AddWithValue("@igreja", dizimo.Igreja.Codigo);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateDizimo(Dizimo diz)
        {
            string query = "update tb_dizimo set valor = @valor, ano =@ano, mes = @mes, igreja = @codigoIgreja, tipo = @tipo, descricao =  @desc " +
                 "where id =@id";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@valor", diz.Valor);
            cmd.Parameters.AddWithValue("@ano", diz.Ano);
            cmd.Parameters.AddWithValue("@mes", diz.Mes);
            cmd.Parameters.AddWithValue("@tipo", (int)diz.Tipo);
            cmd.Parameters.AddWithValue("@desc", diz.Descricao);
            cmd.Parameters.AddWithValue("@codigoIgreja", diz.Igreja.Codigo);
            cmd.Parameters.AddWithValue("@id", diz.Id);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteDizimo(Dizimo diz)
        {
            string query = "delete from tb_dizimo where id = @id";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@id", diz.Id);
            cmd.ExecuteNonQuery();
        }

        public static List<Dizimo> getListaDizimo(Igreja igreja, int ano1, int mes1)
        {
            List<Dizimo> lista = new List<Dizimo>();
            string query = "select d.membro,d.id,d.valor,d.ano,d.mes,d.igreja,d.tipo,d.descricao,i.codigo_igreja,i.nome_igreja " +
                "from tb_dizimo as d " +
                "INNER JOIN tb_igreja as i " +
                "on d.igreja = i.codigo_igreja " +
                "where i.codigo_igreja = @cod and d.ano =@ano and d.mes = @mes";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod", igreja.Codigo);
            cmd.Parameters.AddWithValue("@ano", ano1);
            cmd.Parameters.AddWithValue("@mes", mes1);

            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                //membro
                string codigoMembro = "EXTERNO";
                string nomeMembro = rd.GetString("membro");
                Membro m = new Membro(codigoMembro, nomeMembro);

                int idDiz = rd.GetInt32("id");
                int mes = rd.GetInt32("mes");
                int ano = rd.GetInt32("ano");
                double valor = rd.GetDouble("valor");
                TipoDizimo tipo = (TipoDizimo)rd.GetInt32("tipo");
                string descricao = rd.GetString("descricao");

                Dizimo diz = new Dizimo(idDiz, ano, mes, m, igreja, tipo,valor,descricao);
                lista.Add(diz);
            }
            return lista;
        }


        public static List<Dizimo> getListaDizimo(Igreja igreja, int ano1, int mes1, string nome_Membro)
        {
            List<Dizimo> lista = new List<Dizimo>();
            string query = "select d.membro,d.id,d.valor,d.ano,d.mes,d.tipo,d.descricao,i.codigo_igreja,i.nome_igreja " +
                "from tb_dizimo as d " +
                "INNER join tb_igreja as i " +
                "on d.igreja = i.codigo_igreja " +
                "where i.codigo_igreja = @cod and d.ano = @ano and d.mes =@mes " +
                " and d.membro LIKE '" + nome_Membro + "%' ";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod", igreja.Codigo);
            cmd.Parameters.AddWithValue("@ano", ano1);
            cmd.Parameters.AddWithValue("@mes", mes1);

            MySqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                //membro
                string codigoMembro = "EXTERNO";
                string nomeMembro = rd.GetString("membro");
                Membro m = new Membro(codigoMembro, nomeMembro);

                int idDiz = rd.GetInt32("id");
                int mes = rd.GetInt32("mes");
                int ano = rd.GetInt32("ano");
                double valor = rd.GetDouble("valor");

                TipoDizimo tipo = (TipoDizimo)rd.GetInt32("tipo");
                string descricao = rd.GetString("descricao");

                Dizimo diz = new Dizimo(idDiz, ano, mes, m, igreja, tipo, valor, descricao);
                lista.Add(diz);
            }
            return lista;
            ;
        }

        public static void DeleteCaixa(Caixa c)
        {
            string query = "delete from tb_caixa where id_caixa=@id";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.ExecuteNonQuery();
        }

        public static List<Caixa> getListaCaixa()
        {
            List<Caixa> lista = new List<Caixa>();
            string sql = "select * from tb_caixa";
            MySqlCommand cmd = new MySqlCommand(sql, ConexaoDAO._conexao);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                int id = rd.GetInt32("id_caixa");
                string nome = rd.GetString("nome");
                double saldo = rd.GetDouble("saldo");
                TipoCaixa tipo = (TipoCaixa)rd.GetInt32("tipo_Caixa");
                Caixa c = new Caixa(id, nome,saldo, tipo);
                lista.Add(c);
            }
            return lista;
        }

        public static void InsertEntrada(Entrada end)
        {
            string query = "insert into tb_entrada (origem, natureza,tipo_entrada,data,valor,caixa) " +
                "values(@origem, @natureza,@tipo_entrada,@data,@valor, @caixa)";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@origem", end.Origem);
            cmd.Parameters.AddWithValue("@natureza", (int)end.Natureza);
            cmd.Parameters.AddWithValue("@tipo_entrada", (int)end.TipoMov);
            cmd.Parameters.AddWithValue("@data", end.Data);
            cmd.Parameters.AddWithValue("@valor", end.Valor);
            cmd.Parameters.AddWithValue("@caixa", end.Caixa.Id);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteEntrada(Entrada end)
        {
            string query = "delete from tb_entrada where id_entrada =@id";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@id", end.Id);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateEntrada(Entrada end)
        {
            string query = "update tb_entrada set Origem =@origem, natureza = @nat,tipo_entrada =@tipoEntrada,data=@dta,valor =@valor, caixa =@idCaixa " +
                "where id_entrada = @id";

            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@origem", end.Origem);
            cmd.Parameters.AddWithValue("@nat", (int)end.Natureza);
            cmd.Parameters.AddWithValue("@tipoEntrada", (int)end.TipoMov);
            cmd.Parameters.AddWithValue("@dta", end.Data);
            cmd.Parameters.AddWithValue("@valor", end.Valor);
            cmd.Parameters.AddWithValue("@Idcaixa", end.Caixa.Id);
            cmd.Parameters.AddWithValue("@id", end.Id);
            cmd.ExecuteNonQuery();

        }

        public static void InsertSaida(Saida said)
        {
            string query = "insert into tb_saida (origem,data,valor, tipo_saida, caixa) " +
               "values(@origem,@data,@valor,@tipo_saida,@caixa)";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@origem", said.Origem);
            cmd.Parameters.AddWithValue("@tipo_saida", (int)said.TipoMovimentacao);
            cmd.Parameters.AddWithValue("@data", said.Data);
            cmd.Parameters.AddWithValue("@valor", said.Valor);
            cmd.Parameters.AddWithValue("@caixa", said.Caixa.Id);
            cmd.ExecuteNonQuery();
        }

        public static void UpdataSaida(Saida said)
        {
            string query = "update tb_saida set Origem =@origem,tipo_saida =@tipoSaida,data=@dta,valor =@valor, caixa =@idCaixa " +
                "where id_saida =@id";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@origem", said.Origem);
            cmd.Parameters.AddWithValue("@tipoSaida", (int)said.TipoMovimentacao);
            cmd.Parameters.AddWithValue("@dta", said.Data);
            cmd.Parameters.AddWithValue("@valor", said.Valor);
            cmd.Parameters.AddWithValue("@Idcaixa", said.Caixa.Id);
            cmd.Parameters.AddWithValue("@id", said.Id);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteSaida(Saida said)
        {
            string query = "delete from tb_saida where id_saida =@id";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@id", said.Id);
            cmd.ExecuteNonQuery();
        }

        public static void getListEntradaForCaixa(Caixa c, int mes, int ano)
        {
            string query = "select * from tb_entrada where caixa =@idCaixa";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@idCaixa", c.Id);

            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                int idEntrada = rd.GetInt32("id_entrada");
                string origem = rd.GetString("origem");
                NaturezaMovimentacao nat = (NaturezaMovimentacao)rd.GetInt32("natureza");
                TipoMovimentacao tipo = (TipoMovimentacao)rd.GetInt32("tipo_entrada");
                DateTime data = rd.GetDateTime("data");
                double valor = rd.GetDouble("valor");
                Entrada end = new Entrada(idEntrada, origem, data, valor, nat, tipo, c);
                if (data.Month == mes && data.Year == ano) c.AddNewEntrada(end);
            }
        }

        public static void getListSaidasForCaixa(Caixa c, int mes, int ano)
        {
            string query = "select * from tb_saida where caixa =@idCaixa";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@idCaixa", c.Id);

            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                int idEntrada = rd.GetInt32("id_saida");
                string origem = rd.GetString("origem");
                TipoMovimentacao tipo = (TipoMovimentacao)rd.GetInt32("tipo_saida");
                DateTime data = rd.GetDateTime("data");
                double valor = rd.GetDouble("valor");
                Saida said = new Saida(idEntrada, origem, data, valor, tipo, c);
               if(data.Month==mes && data.Year==ano) c.AddNewSaida(said);
            }
        }

        public static bool verificaSeCaixaJaExis(Caixa c)
        {
            string query = "select * from tb_caixa where nome =@nome";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@nome", c.Nome);
            MySqlDataReader rd = cmd.ExecuteReader();
            return (rd.Read()) ? true : false;
        }

        public static bool VerificaSeDizimoExiste(Dizimo diz)
        {
            string query = "select d.mes,d.ano,d.valor,d.igreja, m.nome_membro, i.codigo_igreja, i.nome_igreja " +
                "from tb_dizimo as d " +
                "INNER JOIN tb_membro as m " +
                "ON d.membro =m.codigo_membro " +
                "INNER JOIN tb_igreja as i " +
                "on d.igreja = i.codigo_igreja " +
                "where m.nome_membro =@nomeMembro and i.codigo_igreja = @codigoIgreja " +
                " and d.ano =@ano and d.mes = @mes ";

            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@codigoIgreja", diz.Igreja.Codigo);
            cmd.Parameters.AddWithValue("@ano", diz.Ano);
            cmd.Parameters.AddWithValue("@mes", diz.Mes);
            cmd.Parameters.AddWithValue("@nomeMembro", diz.Membro.Nome);

            MySqlDataReader rd = cmd.ExecuteReader();
            return (rd.Read()) ? true : false;
        }

        public static void UpdateSaldoCaixa(Caixa c)
        {
            string query = "update tb_caixa set saldo = @saldo where id_caixa = @id";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@id", c.Id);
            cmd.Parameters.AddWithValue("@saldo", c.CalculaSaldo());
            cmd.ExecuteNonQuery();
        }

        public static bool VerificaSeEntradaJaExiste(Entrada end)
        {
            string query = "select * from tb_entrada where origem =@origem and caixa =@idCaixa";
            MySqlCommand cmd = new MySqlCommand(query,ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@origem", end.Origem);
            cmd.Parameters.AddWithValue("@idCaixa", end.Caixa.Id);
            MySqlDataReader rd = cmd.ExecuteReader();   
            return ( rd.Read()) ? true : false; 
        }

        public static bool VerificaSeSaidaJaExiste(Saida said)
        {
            string query = "select * from tb_entrada where origem =@origem and caixa =@idCaixa";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@origem", said.Origem);
            cmd.Parameters.AddWithValue("@idCaixa", said.Caixa.Id);
            MySqlDataReader rd = cmd.ExecuteReader();
            return (rd.Read()) ? true : false;
        }


    }
}
