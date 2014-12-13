using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ProveedoreMap : EntityTypeConfiguration<Proveedore>
    {
        public ProveedoreMap()
        {
            // Primary Key
            this.HasKey(t => t.id_proveedor);

            // Properties
            this.Property(t => t.proveedor)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.ruc)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Proveedores", "Core");
            this.Property(t => t.id_proveedor).HasColumnName("id_proveedor");
            this.Property(t => t.proveedor).HasColumnName("proveedor");
            this.Property(t => t.ruc).HasColumnName("ruc");
        }
    }
}
