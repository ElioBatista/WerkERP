using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ACTIVOFIJOMap : EntityTypeConfiguration<ACTIVOFIJO>
    {
        public ACTIVOFIJOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODACTIVO);

            // Properties
            this.Property(t => t.CODACTIVO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCOMPROBANTE)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.NUMACTIVO)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.DESACTIVO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("ACTIVOFIJO");
            this.Property(t => t.CODACTIVO).HasColumnName("CODACTIVO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.CODCENTRO).HasColumnName("CODCENTRO");
            this.Property(t => t.CUENTAACTIVO).HasColumnName("CUENTAACTIVO");
            this.Property(t => t.CUENTADEPRECIA).HasColumnName("CUENTADEPRECIA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODVIDAUTIL).HasColumnName("CODVIDAUTIL");
            this.Property(t => t.CODCONCOMPRA).HasColumnName("CODCONCOMPRA");
            this.Property(t => t.NUMCOMPROBANTE).HasColumnName("NUMCOMPROBANTE");
            this.Property(t => t.NUMACTIVO).HasColumnName("NUMACTIVO");
            this.Property(t => t.DESACTIVO).HasColumnName("DESACTIVO");
            this.Property(t => t.FECADQUISICION).HasColumnName("FECADQUISICION");
            this.Property(t => t.COSTO).HasColumnName("COSTO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.COHEFIACTUAL).HasColumnName("COHEFIACTUAL");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.CENTROCOSTO)
                .WithMany(t => t.ACTIVOFIJOes)
                .HasForeignKey(d => d.CODCENTRO);
            this.HasOptional(t => t.CONCOMPRA)
                .WithMany(t => t.ACTIVOFIJOes)
                .HasForeignKey(d => d.CODCONCOMPRA);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.ACTIVOFIJOes)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.ACTIVOFIJOes)
                .HasForeignKey(d => d.CUENTADEPRECIA);
            this.HasOptional(t => t.PLANCUENTA1)
                .WithMany(t => t.ACTIVOFIJOes1)
                .HasForeignKey(d => d.CUENTAACTIVO);
            this.HasOptional(t => t.PROVEEDOR)
                .WithMany(t => t.ACTIVOFIJOes)
                .HasForeignKey(d => d.CODPROVEEDOR);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.ACTIVOFIJOes)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.ACTIVOFIJOes)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ACTIVOFIJOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.VIDAUTIL)
                .WithMany(t => t.ACTIVOFIJOes)
                .HasForeignKey(d => d.CODVIDAUTIL);

        }
    }
}
