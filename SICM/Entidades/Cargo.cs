using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;


namespace SICM.Entidades
{
   public  class Cargo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Departamento Depart { get; set; }
        public StatusCargo Status { get; set; }
        


        public Cargo(int id , string nome,Departamento depart, StatusCargo status)
        {
            Id = id;
            Nome = nome;
            Depart = depart;
            Status = status;
        }

        public Cargo(Departamento depart)
        {
            Depart = depart;
        }
    }
}
