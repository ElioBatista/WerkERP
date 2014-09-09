using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENPRODUCCIONCABECERAMap : EntityTypeConfiguration<ORDENPRODUCCIONCABECERA>
    {
        public ORDENPRODUCCIONCABECERAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODORDENPRODUCCION);

            // Properties
            this.Property(t => t.CODORDENPRODUCCION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OBSERVACION)
                .IsRequired()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("ORDENPRODUCCIONCABECERA");
            this.Property(t => t.CODORDENPRODUCCION).HasColumnName("CODORDENPRODUCCION");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.NUMEROOP).HasColumnName("NUMEROOP");
            this.Property(t => t.FECHAOP).HasColumnName("FECHAOP");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.ORDENPRODUCCIONCABECERAs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.PROVEEDOR)
                .WithMany(t => t.ORDENPRODUCCIONCABECERAs)
                .HasForeignKey(d => d.CODPROVEEDOR);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.ORDENPRODUCCIONCABECERAs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.ORDENPRODUCCIONCABECERAs)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ORDENPRODUCCIONCABECERAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
