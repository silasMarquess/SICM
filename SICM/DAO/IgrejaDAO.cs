using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;
using SICM.Entidades;
using MySql.Data.MySqlClient;


namespace SICM.DAO
{
    class IgrejaDAO
    {
        public static void InsertDadosIgreja(Igreja i)
        {
            string query = "insert into tb_igreja (codigo_igreja,nome_igreja,rua, dataFund, cidade,bairro, numero) " +
                "values(@codigo,@nome,@rua, @dataFund, @cidade,@bairro, @numero)";

            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);

            cmd.Parameters.AddWithValue("@codigo", i.Codigo);
            cmd.Parameters.AddWithValue("@nome", i.Nome);
            cmd.Parameters.AddWithValue("@rua", i.Rua);
            cmd.Parameters.AddWithValue("@dataFund", i.DataFund);
            cmd.Parameters.AddWithValue("@cidade", i.Cidade);
            cmd.Parameters.AddWithValue("@bairro", i.Bairro);
            cmd.Parameters.AddWithValue("@numero", i.Numero);
            cmd.ExecuteNonQuery();
        }

        public static void InsertDadosTemplo(Igreja i)
        {
            Templo t = (Templo)i;
            string query = "insert into tb_templo(cnpj,igreja) " +
                "values(@cnpj,@codigo)";

            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);

            cmd.Parameters.AddWithValue("@cnpj",t.Cnpj);
            cmd.Parameters.AddWithValue("@codigo", t.Codigo);
            cmd.ExecuteNonQuery();        
        }

        public static void InsertDadosCong(Igreja cong)
        {
            Congregacao congregacao = cong as Congregacao;
            string query = "insert into tb_cong (dirigente,id_templo,codigo_igreja) " +
                "values(@dirigente,@id_templo,@codigo)";

            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);

            cmd.Parameters.AddWithValue("@dirigente",congregacao.Dirigente);
            cmd.Parameters.AddWithValue("@id_templo", congregacao.Sede.Id);
            cmd.Parameters.AddWithValue("@codigo", congregacao.Codigo);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateInforIgreja(Igreja i)
        {
            string query = "update tb_igreja set nome_igreja =@nome, rua = @rua, numero =@numero,bairro =@bairro," +
                "cidade =@cidade,dataFund =@dataFund where codigo_igreja =@codigo";

            MySqlCommand cmd = new MySqlCommand(query,ConexaoDAO._conexao);

            cmd.Parameters.AddWithValue("@cidade", i.Cidade);
            cmd.Parameters.AddWithValue("@dataFund", i.DataFund);
            cmd.Parameters.AddWithValue("@nome", i.Nome);
            cmd.Parameters.AddWithValue("@rua",i.Rua);
            cmd.Parameters.AddWithValue("@numero",i.Numero);
            cmd.Parameters.AddWithValue("@bairro",i.Bairro);
            cmd.Parameters.AddWithValue("@codigo", i.Codigo);
            cmd.ExecuteNonQuery();
        }


        public static void UpdateInfoTemplo(Igreja i )
        {
            Templo tem = i as Templo;
            string query = "update tb_templo set cnpj =@cnpj where id_templo =@idTemplo";

            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);

            cmd.Parameters.AddWithValue("@cnpj", tem.Cnpj);
            cmd.Parameters.AddWithValue("@idTemplo", tem.Id);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateInforCongregacao(Igreja i)
        {
            Congregacao cong = i as Congregacao;
            String query = "update tb_cong set dirigente =@dirigente , id_templo =@idTemploSede where codigo_igreja = @codigo";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@dirigente", cong.Dirigente);
            cmd.Parameters.AddWithValue("@idTemploSede", cong.Sede.Id);
            cmd.Parameters.AddWithValue("@codigo", cong.Codigo);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteIgreja(Igreja i)
        {
            string query = "delete from tb_igreja where codigo_igreja = @codigo";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@codigo", i.Codigo);
            cmd.ExecuteNonQuery();         
        }

        public static List<Templo> GetListaTemplo()
        {
            List<Templo> lista = new List<Templo>();
            string query = "select i.codigo_igreja, i.nome_igreja,i.rua,i.numero,i.bairro,i.cidade,i.dataFund," +
                "t.id_templo,t.cnpj from tb_templo as t " +
                "INNER JOIN tb_igreja as i " +
                "ON t.igreja = i.codigo_igreja";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                ///criando igreja
                string nomeIgreja = rd.GetString("nome_igreja");
                string codigo = rd.GetString("codigo_igreja");
                string rua = rd.GetString("rua");
                string numero = rd.GetString("numero");
                string bairro = rd.GetString("bairro");
                string cidade = rd.GetString("cidade");
                DateTime dataFund = rd.GetDateTime("dataFund");

                ///criando templo
                int idTemplo = rd.GetInt32("id_templo");
                string cnpj = rd.GetString("cnpj");

                Templo templo = new Templo(idTemplo, codigo, nomeIgreja, cnpj, rua, numero, bairro, cidade, dataFund);
                lista.Add(templo);
            }
            return lista;
        }


        public static List<Congregacao> getListaCongregacao(Templo sede)
        {
            List<Congregacao> lista = new List<Congregacao>();
            string query = "select i.codigo_igreja, i.nome_igreja,i.rua,i.numero,i.bairro,i.cidade,i.dataFund," +
                "c.dirigente from tb_cong as c " +
                "INNER JOIN tb_igreja as i " +
                "ON c.codigo_igreja = i.codigo_igreja " +
                "WHERE c.id_templo = @idTemplo";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@idTemplo", sede.Id);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string nomeIgreja = rd.GetString("nome_igreja");
                string codigo = rd.GetString("codigo_igreja");
                string rua = rd.GetString("rua");
                string numero = rd.GetString("numero");
                string bairro = rd.GetString("bairro");
                string cidade = rd.GetString("cidade");
                DateTime dataFund = rd.GetDateTime("dataFund");

                string dirigente = rd.GetString("dirigente");
                Congregacao cong = new Congregacao(codigo, nomeIgreja, dirigente, sede,rua,numero,bairro,cidade,dataFund);
                lista.Add(cong);             
            }
            return lista;
        }


        public static bool TestCodeIgrejaExist(string codigo)
        {
            bool test = false;

            string query = "select codigo_igreja from tb_igreja where codigo_igreja = @cod";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@cod", codigo);
            MySqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                test = true;
            }
            return test;
        }

        public static bool VerificaSeIgrejaExis(Igreja i)
        {
            bool test = false;
            string query = "select * from tb_igreja where nome_igreja = @nome";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@nome", i.Nome);

            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                test = true;

            }
            return test;
        }
    }

}
