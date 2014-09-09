using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class VENTASDETALLELIQUIDACIONMap : EntityTypeConfiguration<VENTASDETALLELIQUIDACION>
    {
        public VENTASDETALLELIQUIDACIONMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODCONLIQUIDACION, t.CODVENTA, t.LINEANUMERO });

            // Properties
            this.Property(t => t.CODCONLIQUIDACION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODVENTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LINEANUMERO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VENTASDETALLELIQUIDACION");
            this.Property(t => t.CODCONLIQUIDACION).HasColumnName("CODCONLIQUIDACION");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.CANTIDADVENTA).HasColumnName("CANTIDADVENTA");
            this.Property(t => t.PRECIOVENTABRUTO).HasColumnName("PRECIOVENTABRUTO");
            this.Property(t => t.PRECIOVENTANETO).HasColumnName("PRECIOVENTANETO");
            this.Property(t => t.PRECIOVENTALISTA).HasColumnName("PRECIOVENTALISTA");
            this.Property(t => t.COSTOPROMEDIO).HasColumnName("COSTOPROMEDIO");
            this.Property(t => t.COSTOULTIMO).HasColumnName("COSTOULTIMO");
            this.Property(t => t.IVA).HasColumnName("IVA");
            this.Property(t => t.DESC).HasColumnName("DESC");
            this.Property(t => t.LINEANUMERO).HasColumnName("LINEANUMERO");

            // Relationships
            this.HasRequired(t => t.CONCEPTOSLIQUIDACION)
                .WithMany(t => t.VENTASDETALLELIQUIDACIONs)
                .HasForeignKey(d => d.CODCONLIQUIDACION);
            this.HasRequired(t => t.VENTA)
                .WithMany(t => t.VENTASDETALLELIQUIDACIONs)
                .HasForeignKey(d => d.CODVENTA);

        }
    }
}
