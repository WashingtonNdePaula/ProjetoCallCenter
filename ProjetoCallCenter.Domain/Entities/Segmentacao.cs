namespace ProjetoCallCenter.Domain.Entities
{
    public class Segmentacao
    {
        public int SegmentacaoId { get; set; }
        public int UsuarioId { get; set; }
        public int CredorId { get; set; }
        public int DiaEmAtrasoDe { get; set; }
        public int DiaEmAtrasoAte { get; set; }
        public decimal ValorDividaDe { get; set; }
        public decimal ValorDividaAte { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Credor Credor { get; set; }

    }
}