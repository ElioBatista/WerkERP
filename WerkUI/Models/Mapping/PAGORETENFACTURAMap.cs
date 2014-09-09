using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PAGORETENFACTURAMap : EntityTypeConfiguration<PAGORETENFACTURA>
    {
        public PAGORETENFACTURAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODRETEN, t.CODTIPORETEN, t.CODCOMPRA });

            // Properties
            this.Property(t => t.CODRETEN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODTIPORETEN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PAGORETENFACTURA");
            this.Property(t => t.CODRETEN).HasColumnName("CODRETEN");
            this.Property(t => t.CODTIPORETEN).HasColumnName("CODTIPORETEN");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.IMPMONEDACOMPRA).HasColumnName("IMPMONEDACOMPRA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");

            // Relationships
            this.HasRequired(t => t.COMPRA)
                .WithMany(t => t.PAGORETENFACTURAs)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasRequired(t => t.PAGOTIPORETEN)
                .WithMany(t => t.PAGORETENFACTURAs)
                .HasForeignKey(d => new { d.CODRETEN, d.CODTIPORETEN });

        }
    }
}
