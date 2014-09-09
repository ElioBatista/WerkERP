using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DEFINIDOMap : EntityTypeConfiguration<DEFINIDO>
    {
        public DEFINIDOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDEFINIDO, t.CODCOBRANZA, t.CODMONEDA, t.CODFORCOBRO });

            // Properties
            this.Property(t => t.CODDEFINIDO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOBRANZA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODMONEDA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODFORCOBRO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESDEFINIDO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("DEFINIDOS");
            this.Property(t => t.CODDEFINIDO).HasColumnName("CODDEFINIDO");
            this.Property(t => t.CODCOBRANZA).HasColumnName("CODCOBRANZA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODFORCOBRO).HasColumnName("CODFORCOBRO");
            this.Property(t => t.DESDEFINIDO).HasColumnName("DESDEFINIDO");

            // Relationships
            this.HasRequired(t => t.COBRANZA)
                .WithMany(t => t.DEFINIDOS)
                .HasForeignKey(d => new { d.CODCOBRANZA, d.CODMONEDA, d.CODFORCOBRO });

        }
    }
}
