using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class MOVIASIENTODETMap : EntityTypeConfiguration<MOVIASIENTODET>
    {
        public MOVIASIENTODETMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDETASIENTO, t.CODASIENTO });

            // Properties
            this.Property(t => t.CODDETASIENTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODASIENTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.COMENTARIO)
                .IsFixedLength()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("MOVIASIENTODET");
            this.Property(t => t.CODDETASIENTO).HasColumnName("CODDETASIENTO");
            this.Property(t => t.CODASIENTO).HasColumnName("CODASIENTO");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.COMENTARIO).HasColumnName("COMENTARIO");
            this.Property(t => t.IMPORTEDEBE).HasColumnName("IMPORTEDEBE");
            this.Property(t => t.IMPORTEHABER).HasColumnName("IMPORTEHABER");

            // Relationships
            this.HasRequired(t => t.MOVIASIENTO)
                .WithMany(t => t.MOVIASIENTODETs)
                .HasForeignKey(d => d.CODASIENTO);
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.MOVIASIENTODETs)
                .HasForeignKey(d => d.CODPLANCUENTA);

        }
    }
}
