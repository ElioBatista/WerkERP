using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class FACTURACOBRARMap : EntityTypeConfiguration<FACTURACOBRAR>
    {
        public FACTURACOBRARMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODNUMEROCUOTA, t.CODVENTA });

            // Properties
            this.Property(t => t.CODNUMEROCUOTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODVENTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FACTURACOBRAR");
            this.Property(t => t.CODNUMEROCUOTA).HasColumnName("CODNUMEROCUOTA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.FECHAVCTO).HasColumnName("FECHAVCTO");
            this.Property(t => t.SALDOCUOTA).HasColumnName("SALDOCUOTA");
            this.Property(t => t.IMPORTECUOTA).HasColumnName("IMPORTECUOTA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.FACTURACOBRARs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasRequired(t => t.VENTA)
                .WithMany(t => t.FACTURACOBRARs)
                .HasForeignKey(d => d.CODVENTA);

        }
    }
}
