using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class OrdenesPagoMap : EntityTypeConfiguration<OrdenesPago>
    {
        public OrdenesPagoMap()
        {
            // Primary Key
            this.HasKey(t => t.id_orden_pago);

            // Properties
            this.Property(t => t.id_orden_pago)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.aprobado)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("OrdenesPago", "Pagos");
            this.Property(t => t.id_orden_pago).HasColumnName("id_orden_pago");
            this.Property(t => t.cod_comprobante).HasColumnName("cod_comprobante");
            this.Property(t => t.cod_empresa).HasColumnName("cod_empresa");
            this.Property(t => t.nro_comprobante).HasColumnName("nro_comprobante");
            this.Property(t => t.fecha).HasColumnName("fecha");
            this.Property(t => t.aprobado).HasColumnName("aprobado");
            this.Property(t => t.cod_usuario_aprobado).HasColumnName("cod_usuario_aprobado");
        }
    }
}
