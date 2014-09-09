using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PAGARECUOTAMap : EntityTypeConfiguration<PAGARECUOTA>
    {
        public PAGARECUOTAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPAGARE, t.NUMEROCUOTA });

            // Properties
            this.Property(t => t.CODPAGARE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMEROCUOTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PAGARECUOTAS");
            this.Property(t => t.CODPAGARE).HasColumnName("CODPAGARE");
            this.Property(t => t.NUMEROCUOTA).HasColumnName("NUMEROCUOTA");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.SALDO).HasColumnName("SALDO");
            this.Property(t => t.FECVENCIMIENTO).HasColumnName("FECVENCIMIENTO");

            // Relationships
            this.HasRequired(t => t.PAGARE)
                .WithMany(t => t.PAGARECUOTAS)
                .HasForeignKey(d => d.CODPAGARE);

        }
    }
}
