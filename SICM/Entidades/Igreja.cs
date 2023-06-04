using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICM.Entidades
{
    public class Igreja
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public DateTime DataFund { get; set; }
                                           //    public Endereco Endereco { get; set; }
        public List<Membro> ListaMembros { get; set; } = new List<Membro>();
        public List<Dizimo> ListaDizimo { get; set; } = new List<Dizimo>();
        public List<Departamento> ListaDepartamento = new List<Departamento>();

        public Igreja()
        {

        }

        public Igreja(string codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public Igreja(string codigo, string nome, string rua, string numero, string bairro, string cidade, DateTime dataFund) : this(codigo, nome, rua, numero, bairro, cidade)
        {
            DataFund = dataFund;
        }

        public Igreja(string codigo, string nome, string rua, string numero, string bairro, string cidade) : this(codigo, nome)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
        }

        public void AddDizimo(Dizimo diz)
        {
            ListaDizimo.Add(diz);
        }

        public void AddNewMembro(Membro m)
        {
            ListaMembros.Add(m);
        }

        public void  AddNewDepartamento(Departamento depart)
        {
            ListaDepartamento.Add(depart);
        }
    }
}
