using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class MagicIVAMap : EntityTypeConfiguration<MagicIVA>
    {
        public MagicIVAMap()
        {
            // Primary Key
            this.HasKey(t => t.codmagiciva);

            // Properties
            // Table & Column Mappings
            this.ToTable("MagicIVA");
            this.Property(t => t.codmagiciva).HasColumnName("codmagiciva");
            this.Property(t => t.codiva).HasColumnName("codiva");
            this.Property(t => t.importe).HasColumnName("importe");
            this.Property(t => t.codconcompra).HasColumnName("codconcompra");
            this.Property(t => t.codconventas).HasColumnName("codconventas");
            this.Property(t => t.IMPUESTO).HasColumnName("IMPUESTO");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.CODNCREDITO).HasColumnName("CODNCREDITO");

            // Relationships
            this.HasOptional(t => t.COMPRA)
                .WithMany(t => t.MagicIVAs)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.CONCOMPRA)
                .WithMany(t => t.MagicIVAs)
                .HasForeignKey(d => d.codconcompra);
            this.HasOptional(t => t.CONVENTA)
                .WithMany(t => t.MagicIVAs)
                .HasForeignKey(d => d.codconventas);
            this.HasOptional(t => t.IVA)
                .WithMany(t => t.MagicIVAs)
                .HasForeignKey(d => d.codiva);
            this.HasOptional(t => t.PAGONOTACREDITO)
                .WithMany(t => t.MagicIVAs)
                .HasForeignKey(d => d.CODNCREDITO);
            this.HasOptional(t => t.VENTA)
                .WithMany(t => t.MagicIVAs)
                .HasForeignKey(d => d.CODVENTA);

        }
    }
}
