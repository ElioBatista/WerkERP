using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TPYSTOCKMap : EntityTypeConfiguration<TPYSTOCK>
    {
        public TPYSTOCKMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTPY);

            // Properties
            this.Property(t => t.CODTPY)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMPTY)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("TPYSTOCK");
            this.Property(t => t.CODTPY).HasColumnName("CODTPY");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.NUMPTY).HasColumnName("NUMPTY");
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
                .WithMany(t => t.TPYSTOCKs)
                .HasForeignKey(d => d.CODAJUSTE);
            this.HasOptional(t => t.COMPRA)
                .WithMany(t => t.TPYSTOCKs)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.TPYSTOCKs)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.TPYSTOCKs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TRANFERENCIA)
                .WithMany(t => t.TPYSTOCKs)
                .HasForeignKey(d => d.CODTRANSFERENCIA);
            this.HasOptional(t => t.VENTA)
                .WithMany(t => t.TPYSTOCKs)
                .HasForeignKey(d => d.CODVENTA);

        }
    }
}
