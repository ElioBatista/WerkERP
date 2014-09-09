using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class OTDEVOLUCIONCABECERAMap : EntityTypeConfiguration<OTDEVOLUCIONCABECERA>
    {
        public OTDEVOLUCIONCABECERAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODOTDEVOLUCION);

            // Properties
            this.Property(t => t.CODOTDEVOLUCION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OTDEVOLUCIONCABECERA");
            this.Property(t => t.CODOTDEVOLUCION).HasColumnName("CODOTDEVOLUCION");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODOTPEDIDO).HasColumnName("CODOTPEDIDO");
            this.Property(t => t.NUMOTDEVOLUCION).HasColumnName("NUMOTDEVOLUCION");
            this.Property(t => t.FECHAMOVIMIENTO).HasColumnName("FECHAMOVIMIENTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.OTDEVOLUCIONCABECERAs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.OTDEVOLUCIONCABECERAs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.OTDEVOLUCIONCABECERAs)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.OTDEVOLUCIONCABECERAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
