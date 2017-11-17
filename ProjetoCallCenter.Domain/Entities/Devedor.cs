using System.Collections.Generic;

namespace ProjetoCallCenter.Domain.Entities
{
    public class Devedor : Endereco
    {
        public int DevedorId { get; set; }
        public long CPF { get; set; }
        public string Nome { get; set; }
        public virtual IEnumerable<Telefone> Telefones { get; set; }
        public virtual IEnumerable<Divida> Dividas { get; set; }
    }
}