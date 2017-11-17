using ProjetoCallCenter.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoCallCenter.Infra.Data.EntityConfig
{
    public class StatusConfiguration : EntityTypeConfiguration<Status>
    {
        public StatusConfiguration()
        {
            Property(s => s.Descricao).IsRequired();
            Property(s => s.Tipo).IsRequired();
        }
    }
}
