using ProjetoCallCenter.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoCallCenter.Infra.Data.EntityConfig
{
    class PerfilNegociacaoConfiguration : EntityTypeConfiguration<PerfilNegociacao>
    {
        public PerfilNegociacaoConfiguration()
        {
            Property(p => p.ValorMinimoEntrada).HasColumnType("money");
            Property(p => p.ValorMinimoParcela).HasColumnType("money");
        }
    }
}
