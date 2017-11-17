using ProjetoCallCenter.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoCallCenter.Infra.Data.EntityConfig
{
    class SegmentacaoConfiguration : EntityTypeConfiguration<Segmentacao>
    {
        public SegmentacaoConfiguration()
        {
            Property(s => s.ValorDividaDe).HasColumnType("money");
            Property(s => s.ValorDividaAte).HasColumnType("money");
        }
    }
}
