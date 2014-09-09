using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class VENTASDETALLEMap : EntityTypeConfiguration<VENTASDETALLE>
    {
        public VENTASDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPRODUCTO, t.CODVENTA, t.LINEANUMERO });

            // Properties
            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODVENTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCELULAR)
                .HasMaxLength(10);

            this.Property(t => t.LINEANUMERO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VENTASDETALLE");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CANTIDADVENTA).HasColumnName("CANTIDADVENTA");
            this.Property(t => t.PRECIOVENTABRUTO).HasColumnName("PRECIOVENTABRUTO");
            this.Property(t => t.PRECIOVENTANETO).HasColumnName("PRECIOVENTANETO");
            this.Property(t => t.PRECIOVENTALISTA).HasColumnName("PRECIOVENTALISTA");
            this.Property(t => t.COSTOPROMEDIO).HasColumnName("COSTOPROMEDIO");
            this.Property(t => t.COSTOULTIMO).HasColumnName("COSTOULTIMO");
            this.Property(t => t.IVA).HasColumnName("IVA");
            this.Property(t => t.DESC).HasColumnName("DESC");
            this.Property(t => t.PORCENCOMI).HasColumnName("PORCENCOMI");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODPRIORIDAD).HasColumnName("CODPRIORIDAD");
            this.Property(t => t.NUMCELULAR).HasColumnName("NUMCELULAR");
            this.Property(t => t.LINEANUMERO).HasColumnName("LINEANUMERO");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.VENTASDETALLEs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.PRECIOPRIORIDAD)
                .WithMany(t => t.VENTASDETALLEs)
                .HasForeignKey(d => d.CODPRIORIDAD);
            this.HasRequired(t => t.PRODUCTO)
                .WithMany(t => t.VENTASDETALLEs)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.VENTASDETALLEs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasRequired(t => t.VENTA)
                .WithMany(t => t.VENTASDETALLEs)
                .HasForeignKey(d => d.CODVENTA);

        }
    }
}
