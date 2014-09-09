using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CREDITORECIBIDOMap : EntityTypeConfiguration<CREDITORECIBIDO>
    {
        public CREDITORECIBIDOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODCREDITO, t.NUMCHEQUE });

            // Properties
            this.Property(t => t.CODCREDITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCHEQUE)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("CREDITORECIBIDO");
            this.Property(t => t.CODCREDITO).HasColumnName("CODCREDITO");
            this.Property(t => t.NUMCHEQUE).HasColumnName("NUMCHEQUE");

            // Relationships
            this.HasRequired(t => t.CREDITO)
                .WithMany(t => t.CREDITORECIBIDOes)
                .HasForeignKey(d => d.CODCREDITO);

        }
    }
}
