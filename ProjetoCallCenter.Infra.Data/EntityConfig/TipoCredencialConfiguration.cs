using ProjetoCallCenter.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoCallCenter.Infra.Data.EntityConfig
{
    public class TipoCredencialConfiguration : EntityTypeConfiguration<TipoCredencial>
    {
        public TipoCredencialConfiguration()
        {
            Property(t => t.Descricao).IsRequired();
        }
    }
}
