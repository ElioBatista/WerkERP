using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COBRODIMap : EntityTypeConfiguration<COBRODI>
    {
        public COBRODIMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDESPACHOINTERNO, t.CODCOBRANZA });

            // Properties
            this.Property(t => t.CODDESPACHOINTERNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOBRANZA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COBRODI");
            this.Property(t => t.CODDESPACHOINTERNO).HasColumnName("CODDESPACHOINTERNO");
            this.Property(t => t.CODCOBRANZA).HasColumnName("CODCOBRANZA");
            this.Property(t => t.MON_CODMONEDA).HasColumnName("MON_CODMONEDA");
            this.Property(t => t.CODFORCOBRO).HasColumnName("CODFORCOBRO");
            this.Property(t => t.IMPORTEDI).HasColumnName("IMPORTEDI");

            // Relationships
            this.HasRequired(t => t.COBRANZA)
                .WithMany(t => t.COBRODIs)
                .HasForeignKey(d => new { d.CODCOBRANZA, d.MON_CODMONEDA, d.CODFORCOBRO });
            this.HasRequired(t => t.DESPACHOINTERNO)
                .WithMany(t => t.COBRODIs)
                .HasForeignKey(d => d.CODDESPACHOINTERNO);

        }
    }
}
