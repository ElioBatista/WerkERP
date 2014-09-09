using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DetAdecuacionMap : EntityTypeConfiguration<DetAdecuacion>
    {
        public DetAdecuacionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Linea, t.CodAdecuacion, t.ColAdecuacion });

            // Properties
            this.Property(t => t.Linea)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CodAdecuacion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Descripcion)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.Simbolo)
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("DetAdecuacion");
            this.Property(t => t.Linea).HasColumnName("Linea");
            this.Property(t => t.CodAdecuacion).HasColumnName("CodAdecuacion");
            this.Property(t => t.ColAdecuacion).HasColumnName("ColAdecuacion");
            this.Property(t => t.Descripcion).HasColumnName("Descripcion");
            this.Property(t => t.Simbolo).HasColumnName("Simbolo");

            // Relationships
            this.HasRequired(t => t.Adecuacion)
                .WithMany(t => t.DetAdecuacions)
                .HasForeignKey(d => new { d.CodAdecuacion, d.ColAdecuacion });

        }
    }
}
