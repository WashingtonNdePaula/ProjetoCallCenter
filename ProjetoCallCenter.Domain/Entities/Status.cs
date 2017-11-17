using System.Collections.Generic;

namespace ProjetoCallCenter.Domain.Entities
{
    public class Status
    {
        public int StatusId { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public virtual IEnumerable<Atendimento> Atendimentos { get; set; }
        public virtual IEnumerable<Divida> Dividas { get; set; }
        public virtual IEnumerable<Credencial> Credenciais { get; set; }
    }
}