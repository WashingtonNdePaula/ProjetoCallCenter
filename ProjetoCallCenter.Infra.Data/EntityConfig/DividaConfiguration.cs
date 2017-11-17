using ProjetoCallCenter.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoCallCenter.Infra.Data.EntityConfig
{
    public class DividaConfiguration : EntityTypeConfiguration<Divida>
    {
        public DividaConfiguration()
        {

            Property(d => d.CredorId)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_Divida_Credor_Contrato",0) { IsUnique = true }));
            Property(d => d.Contrato)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UN_Divida_Credor_Contrato", 1) { IsUnique = true }))
                .IsRequired();
            Property(d => d.Arquivo).IsRequired();
            Property(d => d.Valor).HasColumnType("money");

        }
    }
}
