using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ProFormaFacturaDetalleMap : EntityTypeConfiguration<ProFormaFacturaDetalle>
    {
        public ProFormaFacturaDetalleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cod_proFormaFactura, t.secuencia_interna });

            // Properties
            this.Property(t => t.cod_proFormaFactura)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.secuencia_interna)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.comentario)
                .HasMaxLength(50);

            this.Property(t => t.descripcion)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("ProFormaFacturaDetalles", "Facturacion");
            this.Property(t => t.cod_proFormaFactura).HasColumnName("cod_proFormaFactura");
            this.Property(t => t.secuencia_interna).HasColumnName("secuencia_interna");
            this.Property(t => t.comentario).HasColumnName("comentario");
            this.Property(t => t.cod_con_liquidacion).HasColumnName("cod_con_liquidacion");
            this.Property(t => t.descripcion).HasColumnName("descripcion");
            this.Property(t => t.grupo_impresion).HasColumnName("grupo_impresion");
            this.Property(t => t.importe).HasColumnName("importe");
            this.Property(t => t.Facturado).HasColumnName("Facturado");

            // Relationships
            /*
            this.HasRequired(t => t.Factura)
                .WithMany(t => t.ProFormaFacturaDetalles)
                .HasForeignKey(d => d.cod_proFormaFactura);
            */
        }
    }
}
