using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DEPOSITOCUPONMap : EntityTypeConfiguration<DEPOSITOCUPON>
    {
        public DEPOSITOCUPONMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODCUPON, t.CODSUCURSAL, t.CODEMPRESA, t.CODEMISORA, t.CODDEPOSITO });

            // Properties
            this.Property(t => t.CODCUPON)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODSUCURSAL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMISORA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODDEPOSITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DEPOSITOCUPON");
            this.Property(t => t.CODCUPON).HasColumnName("CODCUPON");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODEMISORA).HasColumnName("CODEMISORA");
            this.Property(t => t.CODDEPOSITO).HasColumnName("CODDEPOSITO");

            // Relationships
            this.HasRequired(t => t.CUPONE)
                .WithMany(t => t.DEPOSITOCUPONs)
                .HasForeignKey(d => new { d.CODCUPON, d.CODEMPRESA, d.CODEMISORA });
            this.HasRequired(t => t.DEPOSITADO)
                .WithMany(t => t.DEPOSITOCUPONs)
                .HasForeignKey(d => d.CODDEPOSITO);

        }
    }
}
