using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class VENTAMap : EntityTypeConfiguration<VENTA>
    {
        public VENTAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODVENTA);

            // Properties
            this.Property(t => t.CODVENTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMVENTA)
                .HasMaxLength(20);

            this.Property(t => t.DIRENVIO)
                .IsFixedLength()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("VENTAS");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODVENDEDOR).HasColumnName("CODVENDEDOR");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMVENTA).HasColumnName("NUMVENTA");
            this.Property(t => t.FECHAVENTA).HasColumnName("FECHAVENTA");
            this.Property(t => t.PORCENTAJEDESCUENTO).HasColumnName("PORCENTAJEDESCUENTO");
            this.Property(t => t.TOTALEXENTA).HasColumnName("TOTALEXENTA");
            this.Property(t => t.TOTALGRAVADA).HasColumnName("TOTALGRAVADA");
            this.Property(t => t.TOTALIVA).HasColumnName("TOTALIVA");
            this.Property(t => t.TOTALDESCUENTO).HasColumnName("TOTALDESCUENTO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.MODALIDADPAGO).HasColumnName("MODALIDADPAGO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.TIPOVENTA).HasColumnName("TIPOVENTA");
            this.Property(t => t.CODPRIORIDAD).HasColumnName("CODPRIORIDAD");
            this.Property(t => t.DIRENVIO).HasColumnName("DIRENVIO");
            this.Property(t => t.TIPOPRECIO).HasColumnName("TIPOPRECIO");
            this.Property(t => t.CODCONVENTAS).HasColumnName("CODCONVENTAS");
            this.Property(t => t.NUMVENTATIMBRADO).HasColumnName("NUMVENTATIMBRADO");
            this.Property(t => t.CODDESPACHOINTERNO).HasColumnName("CODDESPACHOINTERNO");

            // Relationships
            this.HasOptional(t => t.CLIENTE)
                .WithMany(t => t.VENTAS)
                .HasForeignKey(d => d.CODCLIENTE);
            this.HasOptional(t => t.CONVENTA)
                .WithMany(t => t.VENTAS)
                .HasForeignKey(d => d.CODCONVENTAS);
            this.HasOptional(t => t.DESPACHOINTERNO)
                .WithMany(t => t.VENTAS)
                .HasForeignKey(d => d.CODDESPACHOINTERNO);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.VENTAS)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.PRECIOPRIORIDAD)
                .WithMany(t => t.VENTAS)
                .HasForeignKey(d => d.CODPRIORIDAD);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.VENTAS)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.VENTAS1)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.VENTAS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.VENDEDOR)
                .WithMany(t => t.VENTAS)
                .HasForeignKey(d => d.CODVENDEDOR);

        }
    }
}
