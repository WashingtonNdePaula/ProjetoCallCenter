using ProjetoCallCenter.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoCallCenter.Infra.Data.EntityConfig
{
    public class CredorConfiguration : EntityTypeConfiguration<Credor>
    {
        public CredorConfiguration()
        {
            Property(c => c.CNPJ)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute() { IsUnique = true }))
                .IsRequired();

            Property(c => c.RazaoSocial).IsRequired();
            Property(c => c.NomeFantasia).IsRequired();
            Property(c => c.Responsavel).IsRequired();
            Property(c => c.Telefone).IsRequired();
            Property(c => c.Email).IsRequired();
            Property(c => c.Logradouro).IsRequired();
            Property(c => c.Bairro).IsRequired();
            Property(c => c.Cidade).IsRequired();
            Property(c => c.CEP).IsRequired();
            Property(c => c.UF).IsRequired();
        }
    }
}
