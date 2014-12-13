using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class OrdenPagoDetalleMap : EntityTypeConfiguration<OrdenPagoDetalle>
    {
        public OrdenPagoDetalleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id_orden_pago, t.cod_despacho_interno });

            // Properties
            this.Property(t => t.id_orden_pago)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cod_despacho_interno)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.observacion)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OrdenPagoDetalles", "Pagos");
            this.Property(t => t.id_orden_pago).HasColumnName("id_orden_pago");
            this.Property(t => t.cod_despacho_interno).HasColumnName("cod_despacho_interno");
            this.Property(t => t.secuencia).HasColumnName("secuencia");
            this.Property(t => t.cod_tipo_pago).HasColumnName("cod_tipo_pago");
            this.Property(t => t.cod_debito).HasColumnName("cod_debito");
            this.Property(t => t.cod_moneda).HasColumnName("cod_moneda");
            this.Property(t => t.cod_proposito).HasColumnName("cod_proposito");
            this.Property(t => t.importe).HasColumnName("importe");
            this.Property(t => t.fecha).HasColumnName("fecha");
            this.Property(t => t.importe_aceptado).HasColumnName("importe_aceptado");
            this.Property(t => t.cod_venta).HasColumnName("cod_venta");
            this.Property(t => t.observacion).HasColumnName("observacion");

            // Relationships
            this.HasOptional(t => t.Moneda)
                .WithMany(t => t.OrdenPagoDetalles)
                .HasForeignKey(d => d.cod_moneda);
            this.HasRequired(t => t.OrdenesPago)
                .WithMany(t => t.OrdenPagoDetalles)
                .HasForeignKey(d => d.id_orden_pago);

        }
    }
}
