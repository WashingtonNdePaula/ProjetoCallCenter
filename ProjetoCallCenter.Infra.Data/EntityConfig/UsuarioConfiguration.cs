using ProjetoCallCenter.Domain.Entities;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCallCenter.Infra.Data.EntityConfig
{
    class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            HasRequired(u => u.Credencial).WithRequiredPrincipal(c=> c.Usuario);
            Property(u => u.Nome)
                .IsRequired();
            Property(u => u.Email)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute() { IsUnique = true }))
                .IsRequired();
        }
    }
}
