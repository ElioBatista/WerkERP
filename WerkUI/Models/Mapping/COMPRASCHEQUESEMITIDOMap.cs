using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COMPRASCHEQUESEMITIDOMap : EntityTypeConfiguration<COMPRASCHEQUESEMITIDO>
    {
        public COMPRASCHEQUESEMITIDOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPAGO, t.CODCOMPRA, t.CODDEBITO });

            // Properties
            this.Property(t => t.CODPAGO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODDEBITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COMPRASCHEQUESEMITIDOS");
            this.Property(t => t.CODPAGO).HasColumnName("CODPAGO");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODDEBITO).HasColumnName("CODDEBITO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");

            // Relationships
            this.HasRequired(t => t.COMPRASFORMAPAGO)
                .WithMany(t => t.COMPRASCHEQUESEMITIDOS)
                .HasForeignKey(d => new { d.CODPAGO, d.CODCOMPRA });
            this.HasRequired(t => t.DEBITO)
                .WithMany(t => t.COMPRASCHEQUESEMITIDOS)
                .HasForeignKey(d => d.CODDEBITO);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.COMPRASCHEQUESEMITIDOS)
                .HasForeignKey(d => d.CODMONEDA);

        }
    }
}
