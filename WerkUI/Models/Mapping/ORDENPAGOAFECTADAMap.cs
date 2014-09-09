using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENPAGOAFECTADAMap : EntityTypeConfiguration<ORDENPAGOAFECTADA>
    {
        public ORDENPAGOAFECTADAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NROORDEN, t.CODEMPRESA, t.CODPAGANZAS });

            // Properties
            this.Property(t => t.NROORDEN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPAGANZAS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ORDENPAGOAFECTADAS");
            this.Property(t => t.NROORDEN).HasColumnName("NROORDEN");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODPAGANZAS).HasColumnName("CODPAGANZAS");
        }
    }
}
