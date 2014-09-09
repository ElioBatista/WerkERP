using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class FacturaDetalleMap : EntityTypeConfiguration<FacturaDetalle>
    {
        public FacturaDetalleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cod_factura, t.Cod__Concepto });

            // Properties
            this.Property(t => t.cod_factura)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comentario)
                .HasMaxLength(128);

            this.Property(t => t.Cod__Concepto)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Concepto)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("FacturaDetalles", "Facturacion");
            this.Property(t => t.cod_factura).HasColumnName("cod_factura");
            this.Property(t => t.Cod__Liquidación).HasColumnName("Cod. Liquidación");
            this.Property(t => t.Secuencia).HasColumnName("Secuencia");
            this.Property(t => t.Comentario).HasColumnName("Comentario");
            this.Property(t => t.Cod__Concepto).HasColumnName("Cod. Concepto");
            this.Property(t => t.Concepto).HasColumnName("Concepto");
            this.Property(t => t.Grupo).HasColumnName("Grupo");
            this.Property(t => t.Importe).HasColumnName("Importe");

            // Relationships
            this.HasRequired(t => t.Factura)
                .WithMany(t => t.FacturaDetalles)
                .HasForeignKey(d => d.cod_factura);

        }
    }
}
