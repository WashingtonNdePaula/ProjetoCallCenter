using ProjetoCallCenter.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoCallCenter.Infra.Data.EntityConfig
{
    public class NegociacaoConfiguration : EntityTypeConfiguration<Negociacao>
    {
        public NegociacaoConfiguration()
        {
            HasKey(n=> n.AtendimentoId);
            Property(n => n.ValorCorrigido).HasColumnType("money");
            Property(n => n.ValorNegociado).HasColumnType("money");
        }
    }
}
