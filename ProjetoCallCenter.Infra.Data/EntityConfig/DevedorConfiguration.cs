using ProjetoCallCenter.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoCallCenter.Infra.Data.EntityConfig
{
    public class DevedorConfiguration : EntityTypeConfiguration<Devedor>
    {
        public DevedorConfiguration()
        {
            Property(d => d.CPF)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute() { IsUnique = true }))
            .IsRequired();

            Property(d => d.Nome).IsRequired();
            Property(d => d.Logradouro).IsRequired();
            Property(d => d.Bairro).IsRequired();
            Property(d => d.Cidade).IsRequired();
            Property(d => d.CEP).IsRequired();
            Property(d => d.UF).IsRequired();

        }
    }
}
