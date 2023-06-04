using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;

namespace SICM.Entidades
{
    public class Membro
    {
        internal string DadosPessoai;

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public StatusMembro Status { get; set; }
        public DadosPessoais DadosPessoais { get; set; }
        public DadosEsp DadosEsp { get; set; }
        public Endereco Endereco { get; set; }
        public Igreja Igreja { get; set; }
        public TipoCategoria Categoria { get; set; }
        public SubCategoria SubCategoria { get; set; }

        public List<VinculoFuncional> ListaVinculos { get; private set; } = new List<VinculoFuncional>();


        public Membro(string codigo, string nome, StatusMembro status, DadosPessoais dadosPessoais, DadosEsp dadosEsp, Endereco endereco, Igreja igreja, TipoCategoria cat, SubCategoria subCat)
        {
            Codigo = codigo;
            Nome = nome;
            Status = status;
            DadosPessoais = dadosPessoais;
            DadosEsp = dadosEsp;
            Endereco = endereco;
            Igreja = igreja;
            Categoria = cat;
            SubCategoria = subCat;       
        }

        public Membro(string codigo , string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public void AddNewVinculo(VinculoFuncional vinc)
        {
            ListaVinculos.Add(vinc);
        }
    }
}
