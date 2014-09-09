using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class INVENTARIOMap : EntityTypeConfiguration<INVENTARIO>
    {
        public INVENTARIOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODINVENTARIO);

            // Properties
            this.Property(t => t.CODINVENTARIO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMINVENTARIO)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("INVENTARIO");
            this.Property(t => t.CODINVENTARIO).HasColumnName("CODINVENTARIO");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMINVENTARIO).HasColumnName("NUMINVENTARIO");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.TIPOINVENTARIO).HasColumnName("TIPOINVENTARIO");
            this.Property(t => t.FECHAINVENTARIO).HasColumnName("FECHAINVENTARIO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");

            // Relationships
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.INVENTARIOs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.INVENTARIOs)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.INVENTARIOs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.INVENTARIOs)
                .HasForeignKey(d => d.CODMONEDA);

        }
    }
}
