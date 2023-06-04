using SICM.Entidades.Enumeracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SICM.Entidades
{
   public  class Dizimo
    {
        public int Id { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public Membro Membro { get; set; }
        public Igreja Igreja { get; set; }
        public TipoDizimo  Tipo { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }



        public Dizimo(int id, int ano, int mes, Membro membro, Igreja igreja,TipoDizimo tipo, double valor, string descricao)
        {
            Id = id;
            Ano = ano;
            Mes = mes;
            Membro = membro;
            Igreja = igreja;
            Tipo = tipo;
            Valor = valor;
            Descricao = descricao;
        }
    }
}
