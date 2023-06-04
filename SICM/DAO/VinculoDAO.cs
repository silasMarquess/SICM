using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades;
using SICM.Entidades.Enumeracoes;
using MySql.Data.MySqlClient;

namespace SICM.DAO
{
    class VinculoDAO
    {
        public static void InsertVinculo(VinculoFuncional vin)
        {
            string query = "insert into tb_vinculo(dataInicio, dataFim,membro,id_cargo, id_departamento," +
                "anoExercicio,cod_igreja,status_vinculo) values(@dataInicio, @dataFim,@membro,@id_cargo, @id_departamento,@anoExercicio,@cod_igreja,@status_vinculo) ";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@dataInicio", vin.DataInicio);
            cmd.Parameters.AddWithValue("@dataFim", vin.DataFim);
            cmd.Parameters.AddWithValue("@membro", vin.Membro.Codigo);
            cmd.Parameters.AddWithValue("@id_cargo", vin.Cargo.Id);
            cmd.Parameters.AddWithValue("@id_departamento", vin.Depart.Id);
            cmd.Parameters.AddWithValue("@anoExercicio", vin.Ano);
            cmd.Parameters.AddWithValue("@cod_igreja", vin.Igreja.Codigo);
            cmd.Parameters.AddWithValue("@status_vinculo", (int)vin.Status);
            cmd.ExecuteNonQuery();
        }


        public static bool VerifiSeVinculoExis(VinculoFuncional vin)
        {
            bool tes = false;
            string query = "select * from tb_vinculo where membro = @membro and id_cargo=@cargo and id_departamento = @departamento and cod_igreja =@igreja and anoExercicio = @ano";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@membro", vin.Membro.Codigo);
            cmd.Parameters.AddWithValue("@cargo", vin.Cargo.Id);
            cmd.Parameters.AddWithValue("@departamento", vin.Depart.Id);
            cmd.Parameters.AddWithValue("@igreja", vin.Igreja.Codigo);
            cmd.Parameters.AddWithValue("@ano", vin.Ano);

            MySqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                tes = true;
            }
            return tes;
        }

        public static void UpdateVinculo(VinculoFuncional vin)
        {
            string query = "update tb_vinculo set status_vinculo = @status, dataFim =@dataFim where id=@id";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@status", (int)vin.Status);
            cmd.Parameters.AddWithValue("@dataFim", vin.DataFim);
            cmd.Parameters.AddWithValue("@id", vin.Id);
            cmd.ExecuteNonQuery();
        }

        public static void DeleteVinculo(VinculoFuncional vin)
        {
            string query = "delete from tb_vinculo where id =@id";
            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@id", vin.Id);
            cmd.ExecuteNonQuery();
        }

        public static List<VinculoFuncional> GetListaVinculosForDepartamento(Departamento dp)
        {
            List<VinculoFuncional> lista = new List<VinculoFuncional>();
            string query = "select m.codigo_membro, m.nome_membro, c.id_cargo,c.nome_cargo,c.status_cargo," +
                "i.codigo_igreja, i.nome_igreja, v.id, v.dataInicio, v.dataFim, v.anoExercicio, v.status_vinculo " +
                "from tb_vinculo as v " +
                "inner join tb_membro as m " +
                "on v.membro = m.codigo_membro " +
                "inner join tb_cargo as c " +
                "on v.id_cargo = c.id_cargo " +
                "inner join tb_igreja as i " +
                "on v.cod_igreja = i.codigo_igreja " +
                " where v.id_departamento = @idDepart";

            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@idDepart", dp.Id);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                //MEMBRO
                string codigoMembro = rd.GetString("codigo_membro");
                string nomeMembro = rd.GetString("nome_membro");
                Membro m = new Membro(codigoMembro, nomeMembro);


                //IGREJA
                string codigoIgreja = rd.GetString("codigo_igreja");
                string nomeIgreja = rd.GetString("nome_igreja");
                Igreja i = new Igreja(codigoIgreja, nomeIgreja);

                //CARGO
                int idCargo = rd.GetInt32("id_cargo");
                string nomeCargo = rd.GetString("nome_cargo");
                StatusCargo status = (StatusCargo)rd.GetInt32("status_cargo");
                Cargo c = new Cargo(idCargo, nomeCargo, dp, status);

                //VINCULO FUNCIONAL
                int idVinc = rd.GetInt32("id");
                DateTime dataInicio = rd.GetDateTime("dataInicio");
                DateTime dataFim = rd.GetDateTime("dataFim");
                int anoExercicio = rd.GetInt32("anoExercicio");
                StatusVinculo statusVinc = (StatusVinculo)rd.GetInt32("status_vinculo");
                VinculoFuncional vinc = new VinculoFuncional(idVinc, anoExercicio, dataInicio, dataFim, i, dp, c, m, statusVinc);
                lista.Add(vinc);
            }
            return lista;

        }

        public static List<VinculoFuncional> GetListaVinculosForIgreja(Igreja i)
        {
            List<VinculoFuncional> lista = new List<VinculoFuncional>();
            string query = "select m.codigo_membro, m.nome_membro, c.id_cargo,c.nome_cargo,c.status_cargo," +
                "i.codigo_igreja, i.nome_igreja, v.id, v.dataInicio,d.nome_departamento, v.id_departamento, v.dataFim, v.anoExercicio, v.status_vinculo " +
                "from tb_vinculo as v " +
                "inner join tb_membro as m " +
                "on v.membro = m.codigo_membro " +
                "inner join tb_departamento as d " +
                "on v.id_departamento = d.id_departamento " +
                "inner join tb_cargo as c " +
                "on v.id_cargo = c.id_cargo " +
                "inner join tb_igreja as i " +
                "on v.cod_igreja = i.codigo_igreja " +
                " where v.cod_igreja = @codIgreja";

            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@codIgreja", i.Codigo);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                //MEMBRO
                string codigoMembro = rd.GetString("codigo_membro");
                string nomeMembro = rd.GetString("nome_membro");
                Membro m = new Membro(codigoMembro, nomeMembro);


                //IGREJA
                int IdDepartamento = rd.GetInt32("id_departamento");
                string nomeDepartamento = rd.GetString("nome_departamento");
                Departamento depart = new Departamento(IdDepartamento, nomeDepartamento);

                //CARGO
                int idCargo = rd.GetInt32("id_cargo");
                string nomeCargo = rd.GetString("nome_cargo");
                StatusCargo status = (StatusCargo)rd.GetInt32("status_cargo");
                Cargo c = new Cargo(idCargo, nomeCargo, depart, status);

                //VINCULO FUNCIONAL
                int idVinc = rd.GetInt32("id");
                DateTime dataInicio = rd.GetDateTime("dataInicio");
                DateTime dataFim = rd.GetDateTime("dataFim");
                int anoExercicio = rd.GetInt32("anoExercicio");
                StatusVinculo statusVinc = (StatusVinculo)rd.GetInt32("status_vinculo");
                VinculoFuncional vinc = new VinculoFuncional(idVinc, anoExercicio, dataInicio, dataFim, i, depart, c, m, statusVinc);
                lista.Add(vinc);
            }
            return lista;

        }

        public static void GetListaVinculosForDepartamento(Membro m1)
        {
            //  List<VinculoFuncional> lista = new List<VinculoFuncional>();
            string query = "select m.codigo_membro, m.nome_membro, c.id_cargo,c.nome_cargo,c.status_cargo," +
                "i.codigo_igreja, i.nome_igreja, v.id, v.membro, v.dataInicio, v.dataFim, v.anoExercicio, v.status_vinculo,d.id_departamento," +
                "d.nome_departamento " +
                "from tb_vinculo as v " +
                "inner join tb_departamento as d " +
                "on v.id_departamento = d.id_departamento " +
                "inner join tb_membro as m " +
                "on v.membro = m.codigo_membro " +
                "inner join tb_cargo as c " +
                "on v.id_cargo = c.id_cargo " +
                "inner join tb_igreja as i " +
                "on v.cod_igreja = i.codigo_igreja " +
                " where v.membro = @codigoMembro";

            MySqlCommand cmd = new MySqlCommand(query, ConexaoDAO._conexao);
            cmd.Parameters.AddWithValue("@codigoMembro", m1.Codigo);
            MySqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                //MEMBRO
                int idDepartamento = rd.GetInt32("id_departamento");
                string nomeDepartamento = rd.GetString("nome_departamento");
                Departamento dp = new Departamento(idDepartamento, nomeDepartamento);


                //IGREJA
                string codigoIgreja = rd.GetString("codigo_igreja");
                string nomeIgreja = rd.GetString("nome_igreja");
                Igreja i = new Igreja(codigoIgreja, nomeIgreja);

                //CARGO
                int idCargo = rd.GetInt32("id_cargo");
                string nomeCargo = rd.GetString("nome_cargo");
                StatusCargo status = (StatusCargo)rd.GetInt32("status_cargo");
                Cargo c = new Cargo(idCargo, nomeCargo, dp, status);

                //VINCULO FUNCIONAL
                int idVinc = rd.GetInt32("id");
                DateTime dataInicio = rd.GetDateTime("dataInicio");
                DateTime dataFim = rd.GetDateTime("dataFim");
                int anoExercicio = rd.GetInt32("anoExercicio");
                StatusVinculo statusVinc = (StatusVinculo)rd.GetInt32("status_vinculo");
                VinculoFuncional vinc = new VinculoFuncional(idVinc, anoExercicio, dataInicio, dataFim, i, dp, c, m1, statusVinc);
                m1.AddNewVinculo(vinc);
            }

        }
    }
}
