namespace ProjetoCallCenter.Domain.Entities
{
    public class Telefone
    {
        public int TelefoneId { get; set; }
        public int DevedorId { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public virtual Devedor Devedor { get; set; }

    }
}