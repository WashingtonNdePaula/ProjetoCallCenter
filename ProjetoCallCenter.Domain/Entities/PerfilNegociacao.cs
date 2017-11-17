namespace ProjetoCallCenter.Domain.Entities
{
    public class PerfilNegociacao
    {
        public int PerfilNegociacaoId { get; set; }
        public int CredorId { get; set; }
        public int AtrasoDe { get; set; }
        public int AtrasoAte { get; set; }
        public int MaximoParcela { get; set; }
        public decimal Juros { get; set; }
        public decimal Multa { get; set; }
        public decimal JurosPorParcela { get; set; }
        public decimal DescontoValorPrincipal { get; set; }
        public decimal DescontoEncargos { get; set; }
        public decimal ValorMinimoEntrada { get; set; }
        public decimal ValorMinimoParcela { get; set; }
        public string Tipo { get; set; }
        public virtual Credor Credor { get; set; }
    }
}