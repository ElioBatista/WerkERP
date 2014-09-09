using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TipoFacturaMap : EntityTypeConfiguration<TipoFactura>
    {
        public TipoFacturaMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_tipo_factura);

            // Properties
            this.Property(t => t.cod_tipo_factura)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.tipo)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TipoFactura", "Facturacion");
            this.Property(t => t.cod_tipo_factura).HasColumnName("cod_tipo_factura");
            this.Property(t => t.tipo).HasColumnName("tipo");
        }
    }
}
