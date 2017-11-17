using ProjetoCallCenter.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoCallCenter.Infra.Data.EntityConfig
{
    public class TelefoneConfiguration : EntityTypeConfiguration<Telefone>
    {
        public TelefoneConfiguration()
        {
            Property(t => t.Descricao).IsRequired();
            Property(t => t.Tipo).IsRequired();
        }
    }
}
