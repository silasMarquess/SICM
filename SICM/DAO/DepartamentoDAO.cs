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
    class DepartamentoDAO

    {
        public static void ControlInsertDepartamento(Departamento depart)
        {
            string query = "insert into tb_departamento (nome_departamento, igreja) " +
                "values(@nome, @igreja)";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@nome", depart.Nome);
            cmd.Parameters.AddWithValue("@igreja", depart.Igreja.Codigo);
            cmd.ExecuteNonQuery();
        }

        public static void ControlUpdateDepartameto(Departamento depart)
        {
            string query = "update tb_departamento set nome_departamento =@nome, igreja =@igreja where id_departamento =@id";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@nome", depart.Nome);
            cmd.Parameters.AddWithValue("@igreja", depart.Igreja.Codigo);
            cmd.Parameters.AddWithValue("@id", depart.Id);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteDepartamento(Departamento depart)
        {
            string query = "delete from tb_departamento where id_departamento =@idDepart and igreja =@cod";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@idDepart", depart.Id);
            cmd.Parameters.AddWithValue("@cod", depart.Igreja.Codigo);
            cmd.ExecuteNonQuery();
        }


        public static bool VerificaExistDepart(Departamento depart)
        {
            bool test = false;
            string query = "select * from tb_departamento where nome_departamento = @nomeDepart and igreja =@igreja";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@nomeDepart", depart.Nome);
            cmd.Parameters.AddWithValue("@igreja", depart.Igreja.Codigo);
            MySqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                test = true;
            }
            return test;
        }

        public static List<Departamento> GetListaDepartamentos(Igreja i)
        {
            List<Departamento> lista = new List<Departamento>();
            string query = "select * from tb_departamento where igreja =@igreja";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@igreja", i.Codigo);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                int id = rd.GetInt32("id_departamento");
                string nome= rd.GetString("nome_departamento");
                Departamento dp = new Departamento(id, nome, i);
                lista.Add(dp);
            }
            return lista;
        }


        public static void insertCargo(Cargo c)
        {
            string query = "insert into tb_cargo (nome_cargo,departamento,status_cargo) " +
                "values(@nome_cargo,@departamento,@status_cargo)";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@nome_cargo", c.Nome);
            cmd.Parameters.AddWithValue("@departamento", c.Depart.Id);
            cmd.Parameters.AddWithValue("@status_cargo", (int)c.Status);
            cmd.ExecuteNonQuery();
        }

        public static void UpdateCargo(Cargo c)
        {
            string query = "update tb_cargo set nome_cargo = @nome, departamento =@depart, status_cargo =@status where id_cargo =@idCargo";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@nome", c.Nome);
            cmd.Parameters.AddWithValue("@depart", c.Depart.Id);
            cmd.Parameters.AddWithValue("@status", (int)c.Status);
            cmd.Parameters.AddWithValue("@idCargo", c.Id);
            cmd.ExecuteNonQuery();
        }

        public static bool VerificaSeCargoExist(Cargo c)
        {
            bool test = false;
            string query = "select nome_cargo, departamento from tb_cargo where departamento = @idDepart and " +
                " nome_cargo =@nome";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@nome", c.Nome);
            cmd.Parameters.AddWithValue("@idDepart", c.Depart.Id);
            MySqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                test = true;
            }
            return test;
        }

        public static void GetListaCargo(Departamento depart)
        {
            string query = "select * from tb_cargo where departamento = @depart";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@depart", depart.Id);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                int id = rd.GetInt32("id_cargo");
                string nome = rd.GetString("nome_cargo");
                StatusCargo status = (StatusCargo)rd.GetInt32("status_cargo");
                Cargo c = new Cargo(id, nome, depart, status);
                depart.AddCargo(c);
            }
        }

        public static void DeleteCargo(Cargo c)
        {
            string query = "delete from tb_cargo where id_cargo =@idCargo";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@idCargo", c.Id);
            cmd.ExecuteNonQuery();
        }

    }
}
