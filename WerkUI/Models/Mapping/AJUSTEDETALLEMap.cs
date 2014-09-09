using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class AJUSTEDETALLEMap : EntityTypeConfiguration<AJUSTEDETALLE>
    {
        public AJUSTEDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODAJUSTE, t.CODPRODUCTO });

            // Properties
            this.Property(t => t.CODAJUSTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AJUSTEDETALLE");
            this.Property(t => t.CODAJUSTE).HasColumnName("CODAJUSTE");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CANTIDADAJUSTE).HasColumnName("CANTIDADAJUSTE");
            this.Property(t => t.COSTOPROMEDIO).HasColumnName("COSTOPROMEDIO");
            this.Property(t => t.COSTOULTIMO).HasColumnName("COSTOULTIMO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.LINEANUMERO).HasColumnName("LINEANUMERO");

            // Relationships
            this.HasRequired(t => t.AJUSTE)
                .WithMany(t => t.AJUSTEDETALLEs)
                .HasForeignKey(d => d.CODAJUSTE);
            this.HasRequired(t => t.PRODUCTO)
                .WithMany(t => t.AJUSTEDETALLEs)
                .HasForeignKey(d => d.CODPRODUCTO);

        }
    }
}
