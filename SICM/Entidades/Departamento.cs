using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICM.Entidades
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Igreja Igreja { get; set; }
        public List<Cargo> ListaCargos { get; set; } = new List<Cargo>();
     

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Departamento(int id, string nome, Igreja i) :this(id,nome)
        {
            Igreja = i;
        }

        public void AddCargo(Cargo c)
        {
            ListaCargos.Add(c);
        }

       

    }
}
