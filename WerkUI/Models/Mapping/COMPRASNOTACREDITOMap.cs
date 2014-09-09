using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COMPRASNOTACREDITOMap : EntityTypeConfiguration<COMPRASNOTACREDITO>
    {
        public COMPRASNOTACREDITOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPAGO, t.CODCOMPRA, t.CODCOMPROBANTE, t.NUMNOTACREDITO });

            // Properties
            this.Property(t => t.CODPAGO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOMPROBANTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMNOTACREDITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COMPRASNOTACREDITO");
            this.Property(t => t.CODPAGO).HasColumnName("CODPAGO");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.NUMNOTACREDITO).HasColumnName("NUMNOTACREDITO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");

            // Relationships
            this.HasRequired(t => t.COMPRASFORMAPAGO)
                .WithMany(t => t.COMPRASNOTACREDITOes)
                .HasForeignKey(d => new { d.CODPAGO, d.CODCOMPRA });
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.COMPRASNOTACREDITOes)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasRequired(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.COMPRASNOTACREDITOes)
                .HasForeignKey(d => d.CODCOMPROBANTE);

        }
    }
}
