using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class SolicitudOrdenPagoMap : EntityTypeConfiguration<SolicitudOrdenPago>
    {
        public SolicitudOrdenPagoMap()
        {
            // Primary Key
            this.HasKey(t => t.id_solicitud_orden_pago);

            // Properties
            // Table & Column Mappings
            this.ToTable("SolicitudOrdenPago", "Pagos");
            this.Property(t => t.id_solicitud_orden_pago).HasColumnName("id_solicitud_orden_pago");
            this.Property(t => t.nro_comprobante).HasColumnName("nro_comprobante");
            this.Property(t => t.fecha_solicitud).HasColumnName("fecha_solicitud");
            this.Property(t => t.id_estado).HasColumnName("id_estado");
            this.Property(t => t.cod_usuario).HasColumnName("cod_usuario");

            // Relationships
            this.HasRequired(t => t.EstadoSolicitud)
                .WithMany(t => t.SolicitudOrdenPagoes)
                .HasForeignKey(d => d.id_estado);
            this.HasOptional(t => t.Usuario)
                .WithMany(t => t.SolicitudOrdenPagoes)
                .HasForeignKey(d => d.cod_usuario);

        }
    }
}
