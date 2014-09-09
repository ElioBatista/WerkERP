using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class FACTURAAFECTADAMap : EntityTypeConfiguration<FACTURAAFECTADA>
    {
        public FACTURAAFECTADAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODAFECTADA);

            // Properties
            this.Property(t => t.CODAFECTADA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FACTURAAFECTADA");
            this.Property(t => t.CODAFECTADA).HasColumnName("CODAFECTADA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODCOBRANZA).HasColumnName("CODCOBRANZA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODFORCOBRO).HasColumnName("CODFORCOBRO");
            this.Property(t => t.CODNUMEROCUOTA).HasColumnName("CODNUMEROCUOTA");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.COBRANZA)
                .WithMany(t => t.FACTURAAFECTADAs)
                .HasForeignKey(d => new { d.CODCOBRANZA, d.CODMONEDA, d.CODFORCOBRO });
            this.HasOptional(t => t.FACTURACOBRAR)
                .WithMany(t => t.FACTURAAFECTADAs)
                .HasForeignKey(d => new { d.CODNUMEROCUOTA, d.CODVENTA });
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.FACTURAAFECTADAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
