namespace ProjetoCallCenter.Domain.Entities
{
    public class Credencial
    {
        public int UsuarioId { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public int TipoCredencialId { get; set; }
        public int StatusId { get; set; }
        public virtual TipoCredencial TipoCredencial { get; set; }
        public virtual Status Status { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
