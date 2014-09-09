using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENCOMPRADETALLEMap : EntityTypeConfiguration<ORDENCOMPRADETALLE>
    {
        public ORDENCOMPRADETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODORDENCOMPRA, t.CODPRODUCTO });

            // Properties
            this.Property(t => t.CODORDENCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OBSERVACION)
                .IsFixedLength()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ORDENCOMPRADETALLE");
            this.Property(t => t.CODORDENCOMPRA).HasColumnName("CODORDENCOMPRA");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.COSTO).HasColumnName("COSTO");
            this.Property(t => t.PORCENTAJEIVA).HasColumnName("PORCENTAJEIVA");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
            this.Property(t => t.CANTIDADAUTORI).HasColumnName("CANTIDADAUTORI");
            this.Property(t => t.CODMONEDAPRODUCTO).HasColumnName("CODMONEDAPRODUCTO");
            this.Property(t => t.LINEANUMERO).HasColumnName("LINEANUMERO");

            // Relationships
            this.HasRequired(t => t.ORDENCOMPRA)
                .WithMany(t => t.ORDENCOMPRADETALLEs)
                .HasForeignKey(d => d.CODORDENCOMPRA);
            this.HasRequired(t => t.PRODUCTO)
                .WithMany(t => t.ORDENCOMPRADETALLEs)
                .HasForeignKey(d => d.CODPRODUCTO);

        }
    }
}
