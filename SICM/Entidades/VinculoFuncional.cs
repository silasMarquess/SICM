using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;

namespace SICM.Entidades
{
   public class VinculoFuncional
    {
        public int Id  { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int Ano { get; set; }
        public Cargo Cargo { get; set; }
        public Departamento Depart { get; set; }
        public StatusVinculo Status { get; set; }


        ///COMPOSIÇÃO DE OBJETOS
        public Igreja Igreja { get; set; }
        public Membro Membro { get; set; }

        public List<Departamento> ListaDepart { get; set; } = new List<Departamento>();
        public List<Cargo> ListaCargo { get; set; } = new List<Cargo>();

        public VinculoFuncional(int id,int ano, DateTime dataInicio, DateTime dataFim, Igreja igreja, Departamento departamento, Cargo cargo, Membro membro, StatusVinculo status)
        {
            Id = id;
            Ano = ano;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Igreja = igreja;
            Membro = membro;
            Cargo = cargo;
            Status = status;
            Depart = departamento;
        }

        public VinculoFuncional(Departamento dp,Igreja i, Cargo c)
        {
            Depart = dp;
            Igreja = i;
            Cargo = c;
        }

        public void AddCargo(Cargo c)
        {
            ListaCargo.Add(c);
        }

        public void AddDepartamento(Departamento depart)
        {
            ListaDepart.Add(depart);
        }

        public TimeSpan CalculaDuracao()
        {
            TimeSpan duracao = DataFim.Subtract(DataInicio);
            return duracao;
        }
    }
}
