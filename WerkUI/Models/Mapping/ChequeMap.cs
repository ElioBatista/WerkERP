using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ChequeMap : EntityTypeConfiguration<Cheque>
    {
        public ChequeMap()
        {
            // Primary Key
            this.HasKey(t => t.id_cheque);

            // Properties
            this.Property(t => t.motivo_anulacion)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("Cheques", "Finanzas");
            this.Property(t => t.id_cheque).HasColumnName("id_cheque");
            this.Property(t => t.id_proveedor).HasColumnName("id_proveedor");
            this.Property(t => t.id_chequera).HasColumnName("id_chequera");
            this.Property(t => t.nro_cheque).HasColumnName("nro_cheque");
            this.Property(t => t.fecha_emision).HasColumnName("fecha_emision");
            this.Property(t => t.anulado).HasColumnName("anulado");
            this.Property(t => t.fecha_anulacion).HasColumnName("fecha_anulacion");
            this.Property(t => t.motivo_anulacion).HasColumnName("motivo_anulacion");
            this.Property(t => t.monto).HasColumnName("monto");
            this.Property(t => t.cod_moneda).HasColumnName("cod_moneda");
            this.Property(t => t.id_orden_pago).HasColumnName("id_orden_pago");

            // Relationships
            this.HasOptional(t => t.Moneda)
                .WithMany(t => t.Cheques)
                .HasForeignKey(d => d.cod_moneda);
            this.HasOptional(t => t.Proveedore)
                .WithMany(t => t.Cheques)
                .HasForeignKey(d => d.id_proveedor);
            this.HasOptional(t => t.Proveedore1)
                .WithMany(t => t.Cheques1)
                .HasForeignKey(d => d.id_proveedor);
            this.HasRequired(t => t.Chequera)
                .WithMany(t => t.Cheques)
                .HasForeignKey(d => d.id_chequera);
            this.HasRequired(t => t.Chequera1)
                .WithMany(t => t.Cheques1)
                .HasForeignKey(d => d.id_chequera);
            this.HasOptional(t => t.SolicitudOrdenPago)
                .WithMany(t => t.Cheques)
                .HasForeignKey(d => d.id_orden_pago);

        }
    }
}
