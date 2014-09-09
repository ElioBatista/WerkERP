using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class SIMCARDMap : EntityTypeConfiguration<SIMCARD>
    {
        public SIMCARDMap()
        {
            // Primary Key
            this.HasKey(t => t.CODSIMCARD);

            // Properties
            this.Property(t => t.CODSIMCARD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMSIMCARD)
                .HasMaxLength(25);

            this.Property(t => t.NUMCELULAR)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("SIMCARD");
            this.Property(t => t.CODSIMCARD).HasColumnName("CODSIMCARD");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.NUMSIMCARD).HasColumnName("NUMSIMCARD");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.FECHACOMPRA).HasColumnName("FECHACOMPRA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.NUMCELULAR).HasColumnName("NUMCELULAR");

            // Relationships
            this.HasOptional(t => t.COMPRA)
                .WithMany(t => t.SIMCARDs)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.SIMCARDs)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.SIMCARDs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.SIMCARDs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.VENTA)
                .WithMany(t => t.SIMCARDs)
                .HasForeignKey(d => d.CODVENTA);

        }
    }
}
