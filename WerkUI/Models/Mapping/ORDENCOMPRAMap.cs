using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENCOMPRAMap : EntityTypeConfiguration<ORDENCOMPRA>
    {
        public ORDENCOMPRAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODORDENCOMPRA);

            // Properties
            this.Property(t => t.CODORDENCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PLAZOENTREGA)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("ORDENCOMPRA");
            this.Property(t => t.CODORDENCOMPRA).HasColumnName("CODORDENCOMPRA");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.FECHAORDEN).HasColumnName("FECHAORDEN");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODTRANSPORTE).HasColumnName("CODTRANSPORTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.USUAUTORI).HasColumnName("USUAUTORI");
            this.Property(t => t.EMPAUTORI).HasColumnName("EMPAUTORI");
            this.Property(t => t.NUMORDENCOMPRA).HasColumnName("NUMORDENCOMPRA");
            this.Property(t => t.PLAZOENTREGA).HasColumnName("PLAZOENTREGA");
            this.Property(t => t.FECHAAUTORI).HasColumnName("FECHAAUTORI");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.ORDENCOMPRAs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.PROVEEDOR)
                .WithMany(t => t.ORDENCOMPRAs)
                .HasForeignKey(d => d.CODPROVEEDOR);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.ORDENCOMPRAs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.ORDENCOMPRAs)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.TIPOTRANSPORTE)
                .WithMany(t => t.ORDENCOMPRAs)
                .HasForeignKey(d => d.CODTRANSPORTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ORDENCOMPRAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.USUARIO1)
                .WithMany(t => t.ORDENCOMPRAs1)
                .HasForeignKey(d => new { d.USUAUTORI, d.EMPAUTORI });

        }
    }
}
