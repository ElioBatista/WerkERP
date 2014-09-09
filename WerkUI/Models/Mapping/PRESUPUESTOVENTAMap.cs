using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PRESUPUESTOVENTAMap : EntityTypeConfiguration<PRESUPUESTOVENTA>
    {
        public PRESUPUESTOVENTAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODPRESUPUESTO);

            // Properties
            this.Property(t => t.CODPRESUPUESTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DIRENVIO)
                .IsFixedLength()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("PRESUPUESTOVENTAS");
            this.Property(t => t.CODPRESUPUESTO).HasColumnName("CODPRESUPUESTO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");
            this.Property(t => t.CODVENDEDOR).HasColumnName("CODVENDEDOR");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMPRESUPUESTO).HasColumnName("NUMPRESUPUESTO");
            this.Property(t => t.FECHAPRESUPUESTO).HasColumnName("FECHAPRESUPUESTO");
            this.Property(t => t.PORCENTAJEDESCUENTO).HasColumnName("PORCENTAJEDESCUENTO");
            this.Property(t => t.TOTALEXENTA).HasColumnName("TOTALEXENTA");
            this.Property(t => t.TOTALGRAVADA).HasColumnName("TOTALGRAVADA");
            this.Property(t => t.TOTALIVA).HasColumnName("TOTALIVA");
            this.Property(t => t.TOTALDESCUENTO).HasColumnName("TOTALDESCUENTO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.MODALIDADPAGO).HasColumnName("MODALIDADPAGO");
            this.Property(t => t.TIPOVENTA).HasColumnName("TIPOVENTA");
            this.Property(t => t.TIPOPRECIO).HasColumnName("TIPOPRECIO");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.FECHAAUTORI).HasColumnName("FECHAAUTORI");
            this.Property(t => t.USUAUTORI).HasColumnName("USUAUTORI");
            this.Property(t => t.DIRENVIO).HasColumnName("DIRENVIO");

            // Relationships
            this.HasMany(t => t.VENTAS)
                .WithMany(t => t.PRESUPUESTOVENTAS)
                .Map(m =>
                    {
                        m.ToTable("VENTASPRESUPUESTO");
                        m.MapLeftKey("CODPRESUPUESTO");
                        m.MapRightKey("CODVENTA");
                    });

            this.HasOptional(t => t.CLIENTE)
                .WithMany(t => t.PRESUPUESTOVENTAS)
                .HasForeignKey(d => d.CODCLIENTE);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.PRESUPUESTOVENTAS)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.PRESUPUESTOVENTAS)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.PRESUPUESTOVENTAS)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PRESUPUESTOVENTAS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.VENDEDOR)
                .WithMany(t => t.PRESUPUESTOVENTAS)
                .HasForeignKey(d => d.CODVENDEDOR);

        }
    }
}
