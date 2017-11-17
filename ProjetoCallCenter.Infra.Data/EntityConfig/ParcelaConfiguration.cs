using ProjetoCallCenter.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCallCenter.Infra.Data.EntityConfig
{
    public class ParcelaConfiguration : EntityTypeConfiguration<Parcela>
    {
        public ParcelaConfiguration()
        {
            HasKey(p => new { p.AtendimentoId, p.Numero });
            Property(p => p.Numero).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
