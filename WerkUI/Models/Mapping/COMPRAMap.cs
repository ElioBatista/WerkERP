using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COMPRAMap : EntityTypeConfiguration<COMPRA>
    {
        public COMPRAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCOMPRA);

            // Properties
            this.Property(t => t.CODCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMRESPONSABLE)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.NUMCOMPRA)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("COMPRAS");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.NUMRESPONSABLE).HasColumnName("NUMRESPONSABLE");
            this.Property(t => t.RES_CODEMPRESA).HasColumnName("RES_CODEMPRESA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.NUMCOMPRA).HasColumnName("NUMCOMPRA");
            this.Property(t => t.FECHACOMPRA).HasColumnName("FECHACOMPRA");
            this.Property(t => t.TOTALEXENTA).HasColumnName("TOTALEXENTA");
            this.Property(t => t.TOTALGRAVADA).HasColumnName("TOTALGRAVADA");
            this.Property(t => t.TOTALIVA).HasColumnName("TOTALIVA");
            this.Property(t => t.TOTALCOMPRA).HasColumnName("TOTALCOMPRA");
            this.Property(t => t.TOTALDESCUENTO).HasColumnName("TOTALDESCUENTO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.CODCONCOMPRA).HasColumnName("CODCONCOMPRA");
            this.Property(t => t.CODTIPOGASTODET).HasColumnName("CODTIPOGASTODET");
            this.Property(t => t.MODALIDADPAGO).HasColumnName("MODALIDADPAGO");
            this.Property(t => t.CODCENTRO).HasColumnName("CODCENTRO");
            this.Property(t => t.BASEIMPONIBLE).HasColumnName("BASEIMPONIBLE");
            this.Property(t => t.CODPLANCUENTADEBE).HasColumnName("CODPLANCUENTADEBE");
            this.Property(t => t.CODPLANCUENTAHABER).HasColumnName("CODPLANCUENTAHABER");

            // Relationships
            this.HasOptional(t => t.CENTROCOSTO)
                .WithMany(t => t.COMPRAS)
                .HasForeignKey(d => d.CODCENTRO);
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.COMPRAS)
                .HasForeignKey(d => d.CODPLANCUENTADEBE);
            this.HasOptional(t => t.PLANCUENTA1)
                .WithMany(t => t.COMPRAS1)
                .HasForeignKey(d => d.CODPLANCUENTAHABER);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.COMPRAS)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.PROVEEDOR)
                .WithMany(t => t.COMPRAS)
                .HasForeignKey(d => d.CODPROVEEDOR);
            this.HasOptional(t => t.RESPONSABLE)
                .WithMany(t => t.COMPRAS)
                .HasForeignKey(d => new { d.NUMRESPONSABLE, d.RES_CODEMPRESA });
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.COMPRAS)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.COMPRAS1)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.COMPRAS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.TIPOGASTODET)
                .WithMany(t => t.COMPRAS)
                .HasForeignKey(d => d.CODTIPOGASTODET);
            this.HasOptional(t => t.CONCOMPRA)
                .WithMany(t => t.COMPRAS)
                .HasForeignKey(d => d.CODCONCOMPRA);

        }
    }
}
