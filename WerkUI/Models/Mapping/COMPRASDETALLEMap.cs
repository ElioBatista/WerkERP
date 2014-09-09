using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COMPRASDETALLEMap : EntityTypeConfiguration<COMPRASDETALLE>
    {
        public COMPRASDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPRODUCTO, t.CODCOMPRA });

            // Properties
            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ORDENFABRICACION)
                .IsFixedLength()
                .HasMaxLength(13);

            // Table & Column Mappings
            this.ToTable("COMPRASDETALLE");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CANTIDADCOMPRA).HasColumnName("CANTIDADCOMPRA");
            this.Property(t => t.COSTOPROMEDIO).HasColumnName("COSTOPROMEDIO");
            this.Property(t => t.COSTOUNITARIO).HasColumnName("COSTOUNITARIO");
            this.Property(t => t.IVA).HasColumnName("IVA");
            this.Property(t => t.FACTORPROMEDIO).HasColumnName("FACTORPROMEDIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.COSTOBRUTO).HasColumnName("COSTOBRUTO");
            this.Property(t => t.ORDENFABRICACION).HasColumnName("ORDENFABRICACION");
            this.Property(t => t.COSTOPROMEDIOMAESTRO).HasColumnName("COSTOPROMEDIOMAESTRO");
            this.Property(t => t.COSTOPPMAESTRO).HasColumnName("COSTOPPMAESTRO");
            this.Property(t => t.PRECIOMAY).HasColumnName("PRECIOMAY");
            this.Property(t => t.PRECIOMIN).HasColumnName("PRECIOMIN");
            this.Property(t => t.LINEANUMERO).HasColumnName("LINEANUMERO");

            // Relationships
            this.HasRequired(t => t.COMPRA)
                .WithMany(t => t.COMPRASDETALLEs)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasRequired(t => t.PRODUCTO)
                .WithMany(t => t.COMPRASDETALLEs)
                .HasForeignKey(d => d.CODPRODUCTO);

        }
    }
}
