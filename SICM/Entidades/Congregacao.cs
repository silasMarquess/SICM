using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICM.Entidades
{
   public  class Congregacao : Igreja
    {
        public string Dirigente { get; set; }
        public Templo Sede { get; set; }

        public Congregacao(string codigo, string nome, string dirigente, Templo sede,string rua, string numero,string bairro,string cidade,DateTime dataNas) : base(codigo,nome,rua,numero,bairro,cidade,dataNas)
        {
            Dirigente = dirigente;
            Sede = sede;
        }

        public Congregacao(string codigo, string nome) : base(codigo,nome)
        {

        }

    }
}
