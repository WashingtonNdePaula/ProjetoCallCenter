using System.Collections.Generic;

namespace ProjetoCallCenter.Domain.Entities
{
    public class TipoCredencial
    {
        public int TipoCredencialId { get; set; }
        public string Descricao { get; set; }
        public virtual IEnumerable<Credencial> Credenciais { get; set; }

    }
}
