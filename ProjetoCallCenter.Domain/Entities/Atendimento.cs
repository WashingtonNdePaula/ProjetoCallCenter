using System;
using System.Collections.Generic;

namespace ProjetoCallCenter.Domain.Entities
{
    public class Atendimento
    {
        public int AtendimentoId { get; set; }
        public int UsuarioId { get; set; }
        public int StatusId { get; set; }
        public int DividaId { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Divida Divida { get; set; }
        public virtual Status Status { get; set; }
        public virtual Negociacao Negociacao { get; set; }
        public IEnumerable<OpcaoNegociacao> OpcoesNegociacao { get; set; }

    }
}