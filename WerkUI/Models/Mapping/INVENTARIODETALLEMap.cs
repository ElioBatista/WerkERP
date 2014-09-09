using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class INVENTARIODETALLEMap : EntityTypeConfiguration<INVENTARIODETALLE>
    {
        public INVENTARIODETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPRODUCTO, t.CODINVENTARIO });

            // Properties
            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODINVENTARIO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("INVENTARIODETALLE");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODINVENTARIO).HasColumnName("CODINVENTARIO");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.COSTOPP).HasColumnName("COSTOPP");
            this.Property(t => t.COSTOULTIMO).HasColumnName("COSTOULTIMO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.LINEANUMERO).HasColumnName("LINEANUMERO");

            // Relationships
            this.HasRequired(t => t.INVENTARIO)
                .WithMany(t => t.INVENTARIODETALLEs)
                .HasForeignKey(d => d.CODINVENTARIO);
            this.HasRequired(t => t.PRODUCTO)
                .WithMany(t => t.INVENTARIODETALLEs)
                .HasForeignKey(d => d.CODPRODUCTO);

        }
    }
}
