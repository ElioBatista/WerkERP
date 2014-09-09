using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class VENTASCIERREMap : EntityTypeConfiguration<VENTASCIERRE>
    {
        public VENTASCIERREMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODVENTA, t.CODCIERRE });

            // Properties
            this.Property(t => t.CODVENTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCIERRE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VENTASCIERRE");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.CODCIERRE).HasColumnName("CODCIERRE");
        }
    }
}
