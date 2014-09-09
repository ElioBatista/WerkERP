using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PAGAREFACTURAMap : EntityTypeConfiguration<PAGAREFACTURA>
    {
        public PAGAREFACTURAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPAGARE, t.NUMEROCUOTAPAGARE, t.CODNUMEROCUOTA, t.CODVENTA, t.CODEMPRESA });

            // Properties
            this.Property(t => t.CODPAGARE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMEROCUOTAPAGARE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODNUMEROCUOTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODVENTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PAGAREFACTURA");
            this.Property(t => t.CODPAGARE).HasColumnName("CODPAGARE");
            this.Property(t => t.NUMEROCUOTAPAGARE).HasColumnName("NUMEROCUOTAPAGARE");
            this.Property(t => t.CODNUMEROCUOTA).HasColumnName("CODNUMEROCUOTA");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.FACTURACOBRAR)
                .WithMany(t => t.PAGAREFACTURAs)
                .HasForeignKey(d => new { d.CODNUMEROCUOTA, d.CODVENTA });
            this.HasRequired(t => t.PAGARECUOTA)
                .WithMany(t => t.PAGAREFACTURAs)
                .HasForeignKey(d => new { d.CODPAGARE, d.NUMEROCUOTAPAGARE });
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PAGAREFACTURAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
