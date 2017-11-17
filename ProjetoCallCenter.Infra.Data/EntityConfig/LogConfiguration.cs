using ProjetoCallCenter.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoCallCenter.Infra.Data.EntityConfig
{
    public class LogConfiguration : EntityTypeConfiguration<Log>
    {
        public LogConfiguration()
        {
            Property(l => l.Acao).IsRequired();
        }
    }
}
