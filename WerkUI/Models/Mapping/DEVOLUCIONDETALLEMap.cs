using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DEVOLUCIONDETALLEMap : EntityTypeConfiguration<DEVOLUCIONDETALLE>
    {
        public DEVOLUCIONDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDEVOLUCION, t.CODPRODUCTO, t.LINEANUMERO });

            // Properties
            this.Property(t => t.CODDEVOLUCION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LINEANUMERO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DEVOLUCIONDETALLE");
            this.Property(t => t.CODDEVOLUCION).HasColumnName("CODDEVOLUCION");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CANTIDADDEVUELTA).HasColumnName("CANTIDADDEVUELTA");
            this.Property(t => t.PRECIOBRUTO).HasColumnName("PRECIOBRUTO");
            this.Property(t => t.PRECIONETO).HasColumnName("PRECIONETO");
            this.Property(t => t.COSTOPROMEDIO).HasColumnName("COSTOPROMEDIO");
            this.Property(t => t.COSTOULTIMO).HasColumnName("COSTOULTIMO");
            this.Property(t => t.IVA).HasColumnName("IVA");
            this.Property(t => t.DESC).HasColumnName("DESC");
            this.Property(t => t.LINEANUMERO).HasColumnName("LINEANUMERO");

            // Relationships
            this.HasRequired(t => t.DEVOLUCION)
                .WithMany(t => t.DEVOLUCIONDETALLEs)
                .HasForeignKey(d => d.CODDEVOLUCION);
            this.HasRequired(t => t.PRODUCTO)
                .WithMany(t => t.DEVOLUCIONDETALLEs)
                .HasForeignKey(d => d.CODPRODUCTO);

        }
    }
}
