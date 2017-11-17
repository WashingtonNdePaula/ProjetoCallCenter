using System;

namespace ProjetoCallCenter.Domain.Entities
{
    public class Parcela
    {
        public int AtendimentoId { get; set; }
        public int Numero { get; set; }
        public double Valor { get; set; }
        public DateTime Vencimento { get; set; }
        public double? ValorPagamento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public virtual Negociacao Negociacao { get; set; }
    }
}