using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DEVOLUCIONMap : EntityTypeConfiguration<DEVOLUCION>
    {
        public DEVOLUCIONMap()
        {
            // Primary Key
            this.HasKey(t => t.CODDEVOLUCION);

            // Properties
            this.Property(t => t.CODDEVOLUCION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMDEVOLUCION)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("DEVOLUCION");
            this.Property(t => t.CODDEVOLUCION).HasColumnName("CODDEVOLUCION");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.NUMDEVOLUCION).HasColumnName("NUMDEVOLUCION");
            this.Property(t => t.FECHADEVOLUCION).HasColumnName("FECHADEVOLUCION");
            this.Property(t => t.TOTALEXENTA).HasColumnName("TOTALEXENTA");
            this.Property(t => t.TOTALGRAVADA).HasColumnName("TOTALGRAVADA");
            this.Property(t => t.TOTALIVA).HasColumnName("TOTALIVA");
            this.Property(t => t.TOTALDESCUENTO).HasColumnName("TOTALDESCUENTO");
            this.Property(t => t.PORCENTAJEDESCUENTO).HasColumnName("PORCENTAJEDESCUENTO");
            this.Property(t => t.TOTALDEVOLUCION).HasColumnName("TOTALDEVOLUCION");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODVENDEDOR).HasColumnName("CODVENDEDOR");

            // Relationships
            this.HasOptional(t => t.CLIENTE)
                .WithMany(t => t.DEVOLUCIONs)
                .HasForeignKey(d => d.CODCLIENTE);
            this.HasOptional(t => t.VENDEDOR)
                .WithMany(t => t.DEVOLUCIONs)
                .HasForeignKey(d => d.CODVENDEDOR);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.DEVOLUCIONs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.DEVOLUCIONs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.DEVOLUCIONs)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DEVOLUCIONs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.VENTA)
                .WithMany(t => t.DEVOLUCIONs)
                .HasForeignKey(d => d.CODVENTA);

        }
    }
}
