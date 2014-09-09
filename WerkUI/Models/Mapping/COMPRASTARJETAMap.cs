using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COMPRASTARJETAMap : EntityTypeConfiguration<COMPRASTARJETA>
    {
        public COMPRASTARJETAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPAGO, t.CODCOMPRA, t.CODTARJETA, t.NUMTARJETA });

            // Properties
            this.Property(t => t.CODPAGO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODTARJETA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTARJETA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COMPRASTARJETAS");
            this.Property(t => t.CODPAGO).HasColumnName("CODPAGO");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODTARJETA).HasColumnName("CODTARJETA");
            this.Property(t => t.NUMTARJETA).HasColumnName("NUMTARJETA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");

            // Relationships
            this.HasRequired(t => t.COMPRASFORMAPAGO)
                .WithMany(t => t.COMPRASTARJETAS)
                .HasForeignKey(d => new { d.CODPAGO, d.CODCOMPRA });
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.COMPRASTARJETAS)
                .HasForeignKey(d => d.CODMONEDA);

        }
    }
}
