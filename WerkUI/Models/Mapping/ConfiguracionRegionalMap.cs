using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ConfiguracionRegionalMap : EntityTypeConfiguration<ConfiguracionRegional>
    {
        public ConfiguracionRegionalMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_configuracion);

            // Properties
            // Table & Column Mappings
            this.ToTable("ConfiguracionRegional", "Core");
            this.Property(t => t.cod_configuracion).HasColumnName("cod_configuracion");
            this.Property(t => t.cod_usuario).HasColumnName("cod_usuario");
            this.Property(t => t.cod_pais).HasColumnName("cod_pais");

            // Relationships
            this.HasRequired(t => t.Pais)
                .WithMany(t => t.ConfiguracionRegionals)
                .HasForeignKey(d => d.cod_pais);
            this.HasRequired(t => t.Usuario)
                .WithMany(t => t.ConfiguracionRegionals)
                .HasForeignKey(d => d.cod_usuario);

        }
    }
}
