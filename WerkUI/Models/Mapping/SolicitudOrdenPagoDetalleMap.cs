using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class SolicitudOrdenPagoDetalleMap : EntityTypeConfiguration<SolicitudOrdenPagoDetalle>
    {
        public SolicitudOrdenPagoDetalleMap()
        {
            // Primary Key
            this.HasKey(t => t.id_solicitud_orden_pago_detalle);

            // Properties
            this.Property(t => t.observacion)
                .HasMaxLength(50);

            this.Property(t => t.nro_concepto)
                .IsRequired()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("SolicitudOrdenPagoDetalles", "Pagos");
            this.Property(t => t.id_solicitud_orden_pago_detalle).HasColumnName("id_solicitud_orden_pago_detalle");
            this.Property(t => t.id_solicitud_orden_pago).HasColumnName("id_solicitud_orden_pago");
            this.Property(t => t.nro_despacho_interno).HasColumnName("nro_despacho_interno");
            this.Property(t => t.importe).HasColumnName("importe");
            this.Property(t => t.observacion).HasColumnName("observacion");
            this.Property(t => t.nro_concepto).HasColumnName("nro_concepto");
            this.Property(t => t.cod_moneda).HasColumnName("cod_moneda");
            this.Property(t => t.importe_aprobado).HasColumnName("importe_aprobado");
            this.Property(t => t.id_cheque).HasColumnName("id_cheque");

            // Relationships
            this.HasRequired(t => t.Moneda)
                .WithMany(t => t.SolicitudOrdenPagoDetalles)
                .HasForeignKey(d => d.cod_moneda);
            this.HasOptional(t => t.Cheque)
                .WithMany(t => t.SolicitudOrdenPagoDetalles)
                .HasForeignKey(d => d.id_cheque);
            this.HasRequired(t => t.ConceptosLiquidacion)
                .WithMany(t => t.SolicitudOrdenPagoDetalles)
                .HasForeignKey(d => d.nro_concepto);
            this.HasRequired(t => t.SolicitudOrdenPago)
                .WithMany(t => t.SolicitudOrdenPagoDetalles)
                .HasForeignKey(d => d.id_solicitud_orden_pago);

        }
    }
}
