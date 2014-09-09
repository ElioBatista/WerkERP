using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENPRODUCCIONDETALLEMap : EntityTypeConfiguration<ORDENPRODUCCIONDETALLE>
    {
        public ORDENPRODUCCIONDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODORDENPRODUCCION, t.CODLINEA });

            // Properties
            this.Property(t => t.CODORDENPRODUCCION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODLINEA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ORDENPRODUCCIONDETALLE");
            this.Property(t => t.CODORDENPRODUCCION).HasColumnName("CODORDENPRODUCCION");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODLINEA).HasColumnName("CODLINEA");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.COSTO).HasColumnName("COSTO");

            // Relationships
            this.HasRequired(t => t.ORDENPRODUCCIONCABECERA)
                .WithMany(t => t.ORDENPRODUCCIONDETALLEs)
                .HasForeignKey(d => d.CODORDENPRODUCCION);
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.ORDENPRODUCCIONDETALLEs)
                .HasForeignKey(d => d.CODPRODUCTO);

        }
    }
}
