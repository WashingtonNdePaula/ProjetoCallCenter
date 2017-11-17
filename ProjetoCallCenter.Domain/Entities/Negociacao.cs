using System;
using System.Collections.Generic;

namespace ProjetoCallCenter.Domain.Entities
{
    public class Negociacao
    {
        public int AtendimentoId { get; set; }
        public decimal ValorCorrigido { get; set; }
        public decimal ValorNegociado { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public virtual Atendimento Atendimento { get; set; }
        public virtual IEnumerable<Parcela> Parcelas { get; set; }
    }
}