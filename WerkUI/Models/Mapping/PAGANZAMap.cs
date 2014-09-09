using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PAGANZAMap : EntityTypeConfiguration<PAGANZA>
    {
        public PAGANZAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPAGANZAS, t.CODTIPOPAGO, t.MON_CODMONEDA });

            // Properties
            this.Property(t => t.CODPAGANZAS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODTIPOPAGO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MON_CODMONEDA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCOMPROBANTE)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("PAGANZAS");
            this.Property(t => t.CODPAGANZAS).HasColumnName("CODPAGANZAS");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODTIPOPAGO).HasColumnName("CODTIPOPAGO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.MON_CODMONEDA).HasColumnName("MON_CODMONEDA");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.TOTALDESCUENTO).HasColumnName("TOTALDESCUENTO");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.FECHAPAGO).HasColumnName("FECHAPAGO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.NUMCOMPROBANTE).HasColumnName("NUMCOMPROBANTE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.VUELTOMR).HasColumnName("VUELTOMR");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.TIPPAGO).HasColumnName("TIPPAGO");
            this.Property(t => t.COTIZACION1MR).HasColumnName("COTIZACION1MR");
            this.Property(t => t.COTIZACION2MR).HasColumnName("COTIZACION2MR");
            this.Property(t => t.SALDO).HasColumnName("SALDO");
            this.Property(t => t.IMPORTERECIBO).HasColumnName("IMPORTERECIBO");
            this.Property(t => t.SALDORECIBO).HasColumnName("SALDORECIBO");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.PAGANZAS)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasRequired(t => t.MONEDA1)
                .WithMany(t => t.PAGANZAS1)
                .HasForeignKey(d => d.MON_CODMONEDA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.PAGANZAS)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.PAGANZAS)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasRequired(t => t.TIPOPAGO)
                .WithMany(t => t.PAGANZAS)
                .HasForeignKey(d => d.CODTIPOPAGO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PAGANZAS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.PROVEEDOR)
                .WithMany(t => t.PAGANZAS)
                .HasForeignKey(d => d.CODPROVEEDOR);

        }
    }
}
