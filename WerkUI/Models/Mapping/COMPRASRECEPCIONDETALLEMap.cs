using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COMPRASRECEPCIONDETALLEMap : EntityTypeConfiguration<COMPRASRECEPCIONDETALLE>
    {
        public COMPRASRECEPCIONDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDETRECEPCION, t.CODRECEPCION });

            // Properties
            this.Property(t => t.CODDETRECEPCION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODRECEPCION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OBSERVACION)
                .IsFixedLength()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("COMPRASRECEPCIONDETALLE");
            this.Property(t => t.CODDETRECEPCION).HasColumnName("CODDETRECEPCION");
            this.Property(t => t.CODRECEPCION).HasColumnName("CODRECEPCION");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");

            // Relationships
            this.HasOptional(t => t.COMPRA)
                .WithMany(t => t.COMPRASRECEPCIONDETALLEs)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.COMPRASRECEPCIONDETALLEs)
                .HasForeignKey(d => d.CODPRODUCTO);

        }
    }
}
