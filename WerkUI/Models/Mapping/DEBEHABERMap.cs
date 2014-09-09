using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DEBEHABERMap : EntityTypeConfiguration<DEBEHABER>
    {
        public DEBEHABERMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPLANCUENTA, t.CODTIPOASIENTO });

            // Properties
            this.Property(t => t.CODPLANCUENTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODTIPOASIENTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DEBEHABER");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.CODTIPOASIENTO).HasColumnName("CODTIPOASIENTO");
            this.Property(t => t.LADO).HasColumnName("LADO");

            // Relationships
            this.HasRequired(t => t.PLANCUENTA)
                .WithMany(t => t.DEBEHABERs)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasRequired(t => t.TIPOASIENTO)
                .WithMany(t => t.DEBEHABERs)
                .HasForeignKey(d => d.CODTIPOASIENTO);

        }
    }
}
