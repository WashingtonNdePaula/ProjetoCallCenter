using ProjetoCallCenter.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoCallCenter.Infra.Data.EntityConfig
{
    class CredencialConfiguration : EntityTypeConfiguration<Credencial>
    {
        public CredencialConfiguration()
        {
            HasKey(c => c.UsuarioId);
            Property(c => c.NomeUsuario)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute() { IsUnique = true }))
                .IsRequired();
            Property(c => c.Senha).IsRequired();
        }
    }
}
