using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DETNCREDITOMap : EntityTypeConfiguration<DETNCREDITO>
    {
        public DETNCREDITOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NUMNCREDITO, t.CODEMPRESA, t.CODNOTACONCEPTO });

            // Properties
            this.Property(t => t.NUMNCREDITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODNOTACONCEPTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DETNCREDITO");
            this.Property(t => t.NUMNCREDITO).HasColumnName("NUMNCREDITO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODNOTACONCEPTO).HasColumnName("CODNOTACONCEPTO");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.PORCENTAJEIVA).HasColumnName("PORCENTAJEIVA");
            this.Property(t => t.PORCENDESC).HasColumnName("PORCENDESC");

            // Relationships
            this.HasRequired(t => t.NCREDITO)
                .WithMany(t => t.DETNCREDITOes)
                .HasForeignKey(d => new { d.NUMNCREDITO, d.CODEMPRESA });
            this.HasRequired(t => t.NOTACONCEPTO)
                .WithMany(t => t.DETNCREDITOes)
                .HasForeignKey(d => d.CODNOTACONCEPTO);

        }
    }
}
