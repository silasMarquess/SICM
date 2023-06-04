using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.Entidades.Enumeracoes;

namespace SICM.Entidades
{
    public class Caixa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public TipoCaixa TipoCaixa { get; set; }

        //OUTRAS VARIAVEIS
        private double _TotalEntrada;
        private double _TotalSaida;

        public List<Entrada> ListaEntrada { get; set; } = new List<Entrada>();
        public List<Saida> ListaSaida { get; set; } = new List<Saida>();

        public Caixa(int id , string nome,double saldo, TipoCaixa tipo)
        {
            Id = id;
            Nome = nome;
            Saldo = saldo;
            TipoCaixa = tipo;
        }

        public override string ToString()
        {
            return Nome.ToUpper()+" - Entrada: "+ CalculaTotEntrada().ToString("F2")+" R$ - Saida: "+CalculaTotSaida().ToString("F2")+" R$ - Saldo: "+CalculaSaldo().ToString("F2")+" R$";
        }

        public void AddNewEntrada(Entrada end)
        {
            ListaEntrada.Add(end);
        }

        public void AddNewSaida(Saida said)
        {
            ListaSaida.Add(said);
        }

        public double CalculaSaldo()
        {
            return CalculaTotEntrada() - CalculaTotSaida();
        }

        public double[] CalculaTotalValoresPixDinCartEntradas()
        {
            double[] valores = new double[3];

            foreach (Entrada end in ListaEntrada)
            {
                if (end.TipoMov == TipoMovimentacao.DINHEIRO)
                {
                    valores[0] += end.Valor;
                }
                else if(end.TipoMov==TipoMovimentacao.PIX)
                {
                    valores[1] += end.Valor;
                }
                else
                {
                    valores[2] += end.Valor;
                }

            }
            return valores;
        }

        public double[] CalculaTotalValoresPixDinCartSaidas()
        {
            double[] valores = new double[3];

            foreach (Saida said in ListaSaida)
            {
                if (said.TipoMovimentacao == TipoMovimentacao.DINHEIRO)
                {
                    valores[0] += said.Valor;
                }
                else if (said.TipoMovimentacao == TipoMovimentacao.PIX)
                {
                    valores[1] += said.Valor;
                }
                else
                {
                    valores[2] += said.Valor;
                }

            }
            return valores;
        }

        public double CalculaTotEntrada()
        {
            double totalGeral = 0;
            foreach(double valor in CalculaTotalValoresPixDinCartEntradas())
            {
                totalGeral += valor;
            }
            return totalGeral;
        }

        public double CalculaTotSaida()
        {
            double totalGeral = 0;
            foreach (double valor in CalculaTotalValoresPixDinCartSaidas())
            {
                totalGeral += valor;
            }
            return totalGeral;
        }



        private void CalculaTotSaida(Saida saida)
        {
            _TotalSaida += saida.Valor;
        }
    }
}
