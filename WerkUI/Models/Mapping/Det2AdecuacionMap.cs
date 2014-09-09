using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class Det2AdecuacionMap : EntityTypeConfiguration<Det2Adecuacion>
    {
        public Det2AdecuacionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SubLinea, t.Linea, t.CodAdecuacion, t.ColAdecuacion });

            // Properties
            this.Property(t => t.SubLinea)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Linea)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CodAdecuacion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Cuenta)
                .IsFixedLength()
                .HasMaxLength(13);

            this.Property(t => t.Accion)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Descripcion)
                .IsFixedLength()
                .HasMaxLength(100);

            this.Property(t => t.Simbolo)
                .IsFixedLength()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("Det2Adecuacion");
            this.Property(t => t.SubLinea).HasColumnName("SubLinea");
            this.Property(t => t.Linea).HasColumnName("Linea");
            this.Property(t => t.CodAdecuacion).HasColumnName("CodAdecuacion");
            this.Property(t => t.ColAdecuacion).HasColumnName("ColAdecuacion");
            this.Property(t => t.Cuenta).HasColumnName("Cuenta");
            this.Property(t => t.Accion).HasColumnName("Accion");
            this.Property(t => t.Descripcion).HasColumnName("Descripcion");
            this.Property(t => t.Simbolo).HasColumnName("Simbolo");

            // Relationships
            this.HasRequired(t => t.DetAdecuacion)
                .WithMany(t => t.Det2Adecuacion)
                .HasForeignKey(d => new { d.Linea, d.CodAdecuacion, d.ColAdecuacion });

        }
    }
}
