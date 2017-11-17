using ProjetoCallCenter.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoCallCenter.Infra.Data.EntityConfig
{
    public class AtendimentoConfiguration : EntityTypeConfiguration<Atendimento>
    {
        public AtendimentoConfiguration()
        {
            HasOptional(a => a.Negociacao).WithRequired(n=> n.Atendimento);
            Property(a => a.Descricao).IsRequired();
        }
    }
}
