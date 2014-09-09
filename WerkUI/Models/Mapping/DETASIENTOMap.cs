using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DETASIENTOMap : EntityTypeConfiguration<DETASIENTO>
    {
        public DETASIENTOMap()
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
            this.ToTable("DETASIENTO");
            this.Property(t => t.CODDETASIENTO).HasColumnName("CODDETASIENTO");
            this.Property(t => t.CODASIENTO).HasColumnName("CODASIENTO");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.COMENTARIO).HasColumnName("COMENTARIO");
            this.Property(t => t.IMPORTED).HasColumnName("IMPORTED");
            this.Property(t => t.IMPORTEH).HasColumnName("IMPORTEH");
            this.Property(t => t.ELIMINADO).HasColumnName("ELIMINADO");

            // Relationships
            this.HasRequired(t => t.ASIENTO)
                .WithMany(t => t.DETASIENTOes)
                .HasForeignKey(d => d.CODASIENTO);
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.DETASIENTOes)
                .HasForeignKey(d => d.CODPLANCUENTA);

        }
    }
}
