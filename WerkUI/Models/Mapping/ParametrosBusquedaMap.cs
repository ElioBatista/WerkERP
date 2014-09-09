using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ParametrosBusquedaMap : EntityTypeConfiguration<ParametrosBusqueda>
    {
        public ParametrosBusquedaMap()
        {
            // Primary Key
            this.HasKey(t => t.parametro);

            // Properties
            this.Property(t => t.parametro)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.valor)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("ParametrosBusqueda", "Liquidacion");
            this.Property(t => t.parametro).HasColumnName("parametro");
            this.Property(t => t.valor).HasColumnName("valor");
        }
    }
}
