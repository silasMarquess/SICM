using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;

namespace SICM.Entidades
{
    public class Saida
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public Caixa Caixa { get; set; }
        public TipoMovimentacao TipoMovimentacao { get; set; }

        public Saida(int id, string descricao, DateTime data, double valor,TipoMovimentacao tipo, Caixa caixa)
        {
            Id = id;
            Origem = descricao;
            TipoMovimentacao = tipo;
            Data = data;
            Valor = valor;
            Caixa = caixa;
        }
    }
}
