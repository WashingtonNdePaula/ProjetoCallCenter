using System.Collections.Generic;

namespace ProjetoCallCenter.Domain.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public virtual Credencial Credencial { get; set; }
        public virtual IEnumerable<Atendimento> Atendimentos { get; set; }
        public virtual IEnumerable<Segmentacao> Segmentacoes { get; set; }
        public virtual IEnumerable<Log> Logs { get; set; }

    }
}