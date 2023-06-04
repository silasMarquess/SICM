using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;

namespace SICM.Entidades
{
   public class Entrada
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public DateTime Data { get; set; }
        public NaturezaMovimentacao Natureza { get; set; }
        public TipoMovimentacao TipoMov { get; set; }
        public double Valor { get; set; }
        public Caixa Caixa { get; set; }

        public Entrada(int id, string descricao, DateTime data, double valor,NaturezaMovimentacao natMov,TipoMovimentacao tipoMov, Caixa caixa)
        {
            Id = id;
            Origem = descricao;
            Natureza = natMov;
            TipoMov = tipoMov;
            Data = data;
            Valor = valor;
            Caixa = caixa;
        }
    }
}
