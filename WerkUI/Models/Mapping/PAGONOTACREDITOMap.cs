using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PAGONOTACREDITOMap : EntityTypeConfiguration<PAGONOTACREDITO>
    {
        public PAGONOTACREDITOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODNCREDITO);

            // Properties
            this.Property(t => t.CODNCREDITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCOMPROBANTE)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.OBSERVACION)
                .IsFixedLength()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("PAGONOTACREDITO");
            this.Property(t => t.CODNCREDITO).HasColumnName("CODNCREDITO");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.NUMCOMPROBANTE).HasColumnName("NUMCOMPROBANTE");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.CODCONCEPTO).HasColumnName("CODCONCEPTO");
            this.Property(t => t.TOTALEXENTA).HasColumnName("TOTALEXENTA");
            this.Property(t => t.TOTALGRAVADA).HasColumnName("TOTALGRAVADA");
            this.Property(t => t.TOTALDESCUENTO).HasColumnName("TOTALDESCUENTO");
            this.Property(t => t.TOTALIVA).HasColumnName("TOTALIVA");
            this.Property(t => t.TOTALCOMPROBANTE).HasColumnName("TOTALCOMPROBANTE");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODDEVOLUCION).HasColumnName("CODDEVOLUCION");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
            this.Property(t => t.CODPAGANZAS).HasColumnName("CODPAGANZAS");
            this.Property(t => t.CODTIPOPAGO).HasColumnName("CODTIPOPAGO");
            this.Property(t => t.MON_CODMONEDA).HasColumnName("MON_CODMONEDA");
            this.Property(t => t.FECHACOMPROBANTE).HasColumnName("FECHACOMPROBANTE");

            // Relationships
            this.HasOptional(t => t.COMPRA)
                .WithMany(t => t.PAGONOTACREDITOes)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.PAGONOTACREDITOes)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.PAGANZA)
                .WithMany(t => t.PAGONOTACREDITOes)
                .HasForeignKey(d => new { d.CODPAGANZAS, d.CODTIPOPAGO, d.MON_CODMONEDA });
            this.HasOptional(t => t.PAGONCCONCEPTO)
                .WithMany(t => t.PAGONOTACREDITOes)
                .HasForeignKey(d => d.CODCONCEPTO);
            this.HasOptional(t => t.PROVEEDOR)
                .WithMany(t => t.PAGONOTACREDITOes)
                .HasForeignKey(d => d.CODPROVEEDOR);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.PAGONOTACREDITOes)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.PAGONOTACREDITOes)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PAGONOTACREDITOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
