using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class IdiomaMap : EntityTypeConfiguration<Idioma>
    {
        public IdiomaMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_idioma);

            // Properties
            this.Property(t => t.idioma1)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.simbolo)
                .IsRequired()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("Idiomas", "Core");
            this.Property(t => t.cod_idioma).HasColumnName("cod_idioma");
            this.Property(t => t.idioma1).HasColumnName("idioma");
            this.Property(t => t.simbolo).HasColumnName("simbolo");
            this.Property(t => t.cod_pais).HasColumnName("cod_pais");

            // Relationships
            this.HasRequired(t => t.Pais)
                .WithMany(t => t.Idiomas)
                .HasForeignKey(d => d.cod_pais);

        }
    }
}
