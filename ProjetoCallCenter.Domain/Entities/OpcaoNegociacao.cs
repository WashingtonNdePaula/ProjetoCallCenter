using System;

namespace ProjetoCallCenter.Domain.Entities
{
    public class OpcaoNegociacao
    {
        public decimal ValorEntrada { get; set; }
        public decimal ValorParcela { get; set; }
        public decimal ValorCorrecao { get; set; }
        public decimal ValorCorrigido { get; set; }
        public decimal MaximoDesconto { get; set; }
        public decimal ValorNegociacao { get; set; }
        public int Parcelamento { get; set; }
        public DateTime Data { get; set; }

    }
}