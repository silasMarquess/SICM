using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICM.Entidades
{
   public class Templo : Igreja
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }

        public List<Congregacao> ListCongregacao { get; set; }

        public Templo(int id, string codigo, string nome,string cnpj,string rua,string numero, string bairro, string cidade,DateTime dataFund) : base(codigo, nome,rua,numero,bairro,cidade,dataFund)
        {
            Id = id;
            Cnpj = cnpj;
        }

        public Templo(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Templo(string codigo, int id, string nome): this(id,nome)
        {
            Codigo = codigo;
        }

        public Templo()
        {

        }

        public void AddNewCongregacao(Congregacao cong)
        {
            ListCongregacao.Add(cong);
        }


    }
}
