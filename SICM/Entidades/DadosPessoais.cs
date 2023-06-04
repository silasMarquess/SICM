using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades;
using SICM.Entidades.Enumeracoes;

namespace SICM.Entidades
{
    public class DadosPessoais
    {
        public string Cpf { get; set; }
        public TipoGenero Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nacionalidade  { get; set; }
        public string Naturalidade { get; set; }
        public TipoEstCivil EstadoCivil { get; set; }
        public TipoEscolaridade Escolaridade { get; set; }
        public string Profissao { get; set; }
        public string Conjuge { get; set; }
       // public Byte[] Foto { get; set; }
        public string  Telefone { get; set; }


        public DadosPessoais(string cpf, TipoGenero genero, DateTime dataNascimento, string nacionalidade, string naturalidade, TipoEstCivil estadoCivil, TipoEscolaridade escolaridade, string conjuge, string telefone)
        {
            Cpf = cpf;
            Genero = genero;
            DataNascimento = dataNascimento;
            Nacionalidade = nacionalidade;
            Naturalidade = naturalidade;
            EstadoCivil = estadoCivil;
            Escolaridade = escolaridade;
            Conjuge = conjuge;
            Telefone = telefone;
          //  Foto = imagem ;
        }

    }
}
