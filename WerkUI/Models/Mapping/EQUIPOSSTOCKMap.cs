using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class EQUIPOSSTOCKMap : EntityTypeConfiguration<EQUIPOSSTOCK>
    {
        public EQUIPOSSTOCKMap()
        {
            // Primary Key
            this.HasKey(t => t.CODEQUIPO);

            // Properties
            this.Property(t => t.CODEQUIPO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ESN)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("EQUIPOSSTOCK");
            this.Property(t => t.CODEQUIPO).HasColumnName("CODEQUIPO");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.ESN).HasColumnName("ESN");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.CODDEVOLUCION).HasColumnName("CODDEVOLUCION");
            this.Property(t => t.CODAJUSTE).HasColumnName("CODAJUSTE");
            this.Property(t => t.CODTRANSFERENCIA).HasColumnName("CODTRANSFERENCIA");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.FECHAULTIMOMOV).HasColumnName("FECHAULTIMOMOV");

            // Relationships
            this.HasOptional(t => t.AJUSTE)
                .WithMany(t => t.EQUIPOSSTOCKs)
                .HasForeignKey(d => d.CODAJUSTE);
            this.HasOptional(t => t.COMPRA)
                .WithMany(t => t.EQUIPOSSTOCKs)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.EQUIPOSSTOCKs)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.EQUIPOSSTOCKs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TRANFERENCIA)
                .WithMany(t => t.EQUIPOSSTOCKs)
                .HasForeignKey(d => d.CODTRANSFERENCIA);
            this.HasOptional(t => t.VENTA)
                .WithMany(t => t.EQUIPOSSTOCKs)
                .HasForeignKey(d => d.CODVENTA);

        }
    }
}
