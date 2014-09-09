using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DETNDEBITOMap : EntityTypeConfiguration<DETNDEBITO>
    {
        public DETNDEBITOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODNOTACONCEPTO, t.NUMNDEBITO, t.CODEMPRESA });

            // Properties
            this.Property(t => t.CODNOTACONCEPTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMNDEBITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DETNDEBITO");
            this.Property(t => t.CODNOTACONCEPTO).HasColumnName("CODNOTACONCEPTO");
            this.Property(t => t.NUMNDEBITO).HasColumnName("NUMNDEBITO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.PORCENTAJEIVA).HasColumnName("PORCENTAJEIVA");
            this.Property(t => t.PORCENDESC).HasColumnName("PORCENDESC");

            // Relationships
            this.HasRequired(t => t.NDEBITO)
                .WithMany(t => t.DETNDEBITOes)
                .HasForeignKey(d => new { d.NUMNDEBITO, d.CODEMPRESA });
            this.HasRequired(t => t.NOTACONCEPTO)
                .WithMany(t => t.DETNDEBITOes)
                .HasForeignKey(d => d.CODNOTACONCEPTO);

        }
    }
}
