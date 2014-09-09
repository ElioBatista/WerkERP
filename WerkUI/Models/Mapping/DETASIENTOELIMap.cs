using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DETASIENTOELIMap : EntityTypeConfiguration<DETASIENTOELI>
    {
        public DETASIENTOELIMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDETASIENTOELI, t.CODASIENTOELI, t.CODASIENTO });

            // Properties
            this.Property(t => t.CODDETASIENTOELI)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODASIENTOELI)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODASIENTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.COMENTARIO)
                .IsFixedLength()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("DETASIENTOELI");
            this.Property(t => t.CODDETASIENTOELI).HasColumnName("CODDETASIENTOELI");
            this.Property(t => t.CODASIENTOELI).HasColumnName("CODASIENTOELI");
            this.Property(t => t.CODASIENTO).HasColumnName("CODASIENTO");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.IMPORTED).HasColumnName("IMPORTED");
            this.Property(t => t.IMPORTEH).HasColumnName("IMPORTEH");
            this.Property(t => t.COMENTARIO).HasColumnName("COMENTARIO");

            // Relationships
            this.HasRequired(t => t.ASIENTOSELI)
                .WithMany(t => t.DETASIENTOELIs)
                .HasForeignKey(d => new { d.CODASIENTOELI, d.CODASIENTO });
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.DETASIENTOELIs)
                .HasForeignKey(d => d.CODPLANCUENTA);

        }
    }
}
