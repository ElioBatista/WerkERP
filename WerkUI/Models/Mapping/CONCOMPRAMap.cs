using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CONCOMPRAMap : EntityTypeConfiguration<CONCOMPRA>
    {
        public CONCOMPRAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCONCOMPRA);

            // Properties
            this.Property(t => t.CODCONCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCOMPRA)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.COMENTARIOD)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.COMENTARIOH)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.NUMCOMPROBANTE)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("CONCOMPRAS");
            this.Property(t => t.CODCONCOMPRA).HasColumnName("CODCONCOMPRA");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODIVA).HasColumnName("CODIVA");
            this.Property(t => t.CODCENTRO).HasColumnName("CODCENTRO");
            this.Property(t => t.CODASIENTO).HasColumnName("CODASIENTO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.NUMCOMPRA).HasColumnName("NUMCOMPRA");
            this.Property(t => t.CUENTAH).HasColumnName("CUENTAH");
            this.Property(t => t.CUENTAD).HasColumnName("CUENTAD");
            this.Property(t => t.CUENTAI).HasColumnName("CUENTAI");
            this.Property(t => t.COMENTARIOD).HasColumnName("COMENTARIOD");
            this.Property(t => t.COMENTARIOH).HasColumnName("COMENTARIOH");
            this.Property(t => t.NUMCOMPROBANTE).HasColumnName("NUMCOMPROBANTE");
            this.Property(t => t.FECCOMPROBANTE).HasColumnName("FECCOMPROBANTE");
            this.Property(t => t.TIPOIVA).HasColumnName("TIPOIVA");
            this.Property(t => t.IMPORTEEXENTA).HasColumnName("IMPORTEEXENTA");
            this.Property(t => t.PORCENTAJEIVA).HasColumnName("PORCENTAJEIVA");
            this.Property(t => t.COHEFICIENTE).HasColumnName("COHEFICIENTE");
            this.Property(t => t.IMPORTERETENCION).HasColumnName("IMPORTERETENCION");
            this.Property(t => t.IMPORTEGRABADA).HasColumnName("IMPORTEGRABADA");
            this.Property(t => t.IMPORTEIVA).HasColumnName("IMPORTEIVA");
            this.Property(t => t.IMPORTEBASEIMPO).HasColumnName("IMPORTEBASEIMPO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.ACCION).HasColumnName("ACCION");
            this.Property(t => t.CODTIPOGASTO).HasColumnName("CODTIPOGASTO");
            this.Property(t => t.CODTIPOGASTODET).HasColumnName("CODTIPOGASTODET");
            this.Property(t => t.LIBRO).HasColumnName("LIBRO");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.IMPORTERETENCIONRENTA).HasColumnName("IMPORTERETENCIONRENTA");

            // Relationships
            this.HasOptional(t => t.ASIENTO)
                .WithMany(t => t.CONCOMPRAS)
                .HasForeignKey(d => d.CODASIENTO);
            this.HasOptional(t => t.CENTROCOSTO)
                .WithMany(t => t.CONCOMPRAS)
                .HasForeignKey(d => d.CODCENTRO);
            this.HasOptional(t => t.COMPRA)
                .WithMany(t => t.CONCOMPRAS)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.IVA)
                .WithMany(t => t.CONCOMPRAS)
                .HasForeignKey(d => d.CODIVA);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.CONCOMPRAS)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.CONCOMPRAS)
                .HasForeignKey(d => d.CUENTAH);
            this.HasOptional(t => t.PLANCUENTA1)
                .WithMany(t => t.CONCOMPRAS1)
                .HasForeignKey(d => d.CUENTAD);
            this.HasOptional(t => t.PLANCUENTA2)
                .WithMany(t => t.CONCOMPRAS2)
                .HasForeignKey(d => d.CUENTAI);
            this.HasOptional(t => t.PROVEEDOR)
                .WithMany(t => t.CONCOMPRAS)
                .HasForeignKey(d => d.CODPROVEEDOR);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.CONCOMPRAS)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.CONCOMPRAS1)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CONCOMPRAS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.TIPOGASTODET)
                .WithMany(t => t.CONCOMPRAS)
                .HasForeignKey(d => d.CODTIPOGASTODET);

        }
    }
}
