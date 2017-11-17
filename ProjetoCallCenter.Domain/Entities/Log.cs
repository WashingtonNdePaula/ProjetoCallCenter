using System;

namespace ProjetoCallCenter.Domain.Entities
{
    public class Log
    {
        public int LogId { get; set; }
        public int UsuarioId { get; set; }
        public string Acao { get; set; }
        public DateTime Data { get; set; }
        public virtual Usuario Usuario { get; set; }

    }
}