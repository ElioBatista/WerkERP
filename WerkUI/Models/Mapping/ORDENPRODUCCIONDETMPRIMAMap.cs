using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENPRODUCCIONDETMPRIMAMap : EntityTypeConfiguration<ORDENPRODUCCIONDETMPRIMA>
    {
        public ORDENPRODUCCIONDETMPRIMAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODORDENPRODUCCION, t.CODLINEA, t.CODPRODUCTO });

            // Properties
            this.Property(t => t.CODORDENPRODUCCION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODLINEA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ORDENPRODUCCIONDETMPRIMA");
            this.Property(t => t.CODORDENPRODUCCION).HasColumnName("CODORDENPRODUCCION");
            this.Property(t => t.CODLINEA).HasColumnName("CODLINEA");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.COSTO).HasColumnName("COSTO");
            this.Property(t => t.CODMEDIDA).HasColumnName("CODMEDIDA");

            // Relationships
            this.HasRequired(t => t.ORDENPRODUCCIONDETALLE)
                .WithMany(t => t.ORDENPRODUCCIONDETMPRIMAs)
                .HasForeignKey(d => new { d.CODORDENPRODUCCION, d.CODLINEA });
            this.HasRequired(t => t.PRODUCTO)
                .WithMany(t => t.ORDENPRODUCCIONDETMPRIMAs)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasOptional(t => t.UNIDADMEDIDA)
                .WithMany(t => t.ORDENPRODUCCIONDETMPRIMAs)
                .HasForeignKey(d => d.CODMEDIDA);

        }
    }
}
