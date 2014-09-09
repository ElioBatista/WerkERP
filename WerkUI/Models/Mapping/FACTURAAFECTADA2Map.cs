using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class FACTURAAFECTADA2Map : EntityTypeConfiguration<FACTURAAFECTADA2>
    {
        public FACTURAAFECTADA2Map()
        {
            // Primary Key
            this.HasKey(t => t.CODAFECTADA2);

            // Properties
            this.Property(t => t.CODAFECTADA2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FACTURAAFECTADA2");
            this.Property(t => t.CODAFECTADA2).HasColumnName("CODAFECTADA2");
            this.Property(t => t.NUMEROCUOTA).HasColumnName("NUMEROCUOTA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODPAGARE).HasColumnName("CODPAGARE");
            this.Property(t => t.CODCOBRANZA).HasColumnName("CODCOBRANZA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODFORCOBRO).HasColumnName("CODFORCOBRO");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.COBRANZA)
                .WithMany(t => t.FACTURAAFECTADA2)
                .HasForeignKey(d => new { d.CODCOBRANZA, d.CODMONEDA, d.CODFORCOBRO });
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.FACTURAAFECTADA2)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.PAGARECUOTA)
                .WithMany(t => t.FACTURAAFECTADA2)
                .HasForeignKey(d => new { d.CODPAGARE, d.NUMEROCUOTA });

        }
    }
}
