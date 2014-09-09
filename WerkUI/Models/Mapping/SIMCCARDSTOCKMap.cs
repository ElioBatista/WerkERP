using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class SIMCCARDSTOCKMap : EntityTypeConfiguration<SIMCCARDSTOCK>
    {
        public SIMCCARDSTOCKMap()
        {
            // Primary Key
            this.HasKey(t => t.CODSIMCARD);

            // Properties
            this.Property(t => t.CODSIMCARD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMSINCARD)
                .HasMaxLength(25);

            this.Property(t => t.NUMCELULAR)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("SIMCCARDSTOCK");
            this.Property(t => t.CODSIMCARD).HasColumnName("CODSIMCARD");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.NUMSINCARD).HasColumnName("NUMSINCARD");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.CODDEVOLUCION).HasColumnName("CODDEVOLUCION");
            this.Property(t => t.CODAJUSTE).HasColumnName("CODAJUSTE");
            this.Property(t => t.CODTRANSFERENCIA).HasColumnName("CODTRANSFERENCIA");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.FECHAULTIMOMOV).HasColumnName("FECHAULTIMOMOV");
            this.Property(t => t.NUMCELULAR).HasColumnName("NUMCELULAR");

            // Relationships
            this.HasOptional(t => t.AJUSTE)
                .WithMany(t => t.SIMCCARDSTOCKs)
                .HasForeignKey(d => d.CODAJUSTE);
            this.HasOptional(t => t.COMPRA)
                .WithMany(t => t.SIMCCARDSTOCKs)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.SIMCCARDSTOCKs)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.SIMCCARDSTOCKs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TRANFERENCIA)
                .WithMany(t => t.SIMCCARDSTOCKs)
                .HasForeignKey(d => d.CODTRANSFERENCIA);
            this.HasOptional(t => t.VENTA)
                .WithMany(t => t.SIMCCARDSTOCKs)
                .HasForeignKey(d => d.CODVENTA);

        }
    }
}
