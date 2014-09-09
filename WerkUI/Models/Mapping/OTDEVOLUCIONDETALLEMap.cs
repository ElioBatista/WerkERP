using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class OTDEVOLUCIONDETALLEMap : EntityTypeConfiguration<OTDEVOLUCIONDETALLE>
    {
        public OTDEVOLUCIONDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDETALLE, t.CODOTDEVOLUCION });

            // Properties
            this.Property(t => t.CODDETALLE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODOTDEVOLUCION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OTDEVOLUCIONDETALLE");
            this.Property(t => t.CODDETALLE).HasColumnName("CODDETALLE");
            this.Property(t => t.CODOTDEVOLUCION).HasColumnName("CODOTDEVOLUCION");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.PRECIO).HasColumnName("PRECIO");
            this.Property(t => t.COSTOULTIMO).HasColumnName("COSTOULTIMO");
            this.Property(t => t.COSTOPP).HasColumnName("COSTOPP");
            this.Property(t => t.CODMONEDAPRODUCTO).HasColumnName("CODMONEDAPRODUCTO");
            this.Property(t => t.PORCENTAJEIVA).HasColumnName("PORCENTAJEIVA");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.OTDEVOLUCIONDETALLEs)
                .HasForeignKey(d => d.CODMONEDAPRODUCTO);
            this.HasRequired(t => t.OTDEVOLUCIONCABECERA)
                .WithMany(t => t.OTDEVOLUCIONDETALLEs)
                .HasForeignKey(d => d.CODOTDEVOLUCION);
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.OTDEVOLUCIONDETALLEs)
                .HasForeignKey(d => d.CODPRODUCTO);

        }
    }
}
