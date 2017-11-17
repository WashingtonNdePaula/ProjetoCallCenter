using System;
using System.Collections.Generic;

namespace ProjetoCallCenter.Domain.Entities
{
    public class Divida
    {
        public int DividaId { get; set; }
        public int DevedorId { get; set; }
        public int CredorId { get; set; }
        public string Contrato { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public string Arquivo { get; set; }
        public DateTime DataImportacao { get; set; }
        public int StatusId { get; set; }
        public DateTime? DataAtendimento { get; set; }
        public int? OperadorAtendimento { get; set; }
        public virtual Devedor Devedor { get; set; }
        public virtual Credor Credor { get; set; }
        public virtual Status Status { get; set; }
        public virtual IEnumerable<Negociacao> Negociacoes { get; set; }
        public virtual IEnumerable<Atendimento> Atendimentos { get; set; }

    }
}