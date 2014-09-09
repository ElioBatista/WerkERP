using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PRESUPUESTOVENTASDETALLEMap : EntityTypeConfiguration<PRESUPUESTOVENTASDETALLE>
    {
        public PRESUPUESTOVENTASDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPRODUCTO, t.CODPRESUPUESTO, t.LINEANUMERO });

            // Properties
            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPRESUPUESTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LINEANUMERO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PRESUPUESTOVENTASDETALLE");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODPRESUPUESTO).HasColumnName("CODPRESUPUESTO");
            this.Property(t => t.LINEANUMERO).HasColumnName("LINEANUMERO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.PRECIOVENTABRUTO).HasColumnName("PRECIOVENTABRUTO");
            this.Property(t => t.PRECIOVENTANETO).HasColumnName("PRECIOVENTANETO");
            this.Property(t => t.PRECIOVENTALISTA).HasColumnName("PRECIOVENTALISTA");
            this.Property(t => t.COSTOULTIMO).HasColumnName("COSTOULTIMO");
            this.Property(t => t.IVA).HasColumnName("IVA");
            this.Property(t => t.DESCUENTO).HasColumnName("DESCUENTO");
            this.Property(t => t.PORCENCOMI).HasColumnName("PORCENCOMI");

            // Relationships
            this.HasRequired(t => t.PRESUPUESTOVENTA)
                .WithMany(t => t.PRESUPUESTOVENTASDETALLEs)
                .HasForeignKey(d => d.CODPRESUPUESTO);
            this.HasRequired(t => t.PRODUCTO)
                .WithMany(t => t.PRESUPUESTOVENTASDETALLEs)
                .HasForeignKey(d => d.CODPRODUCTO);

        }
    }
}
