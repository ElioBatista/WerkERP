using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENCOMPRAPROVEEDORMap : EntityTypeConfiguration<ORDENCOMPRAPROVEEDOR>
    {
        public ORDENCOMPRAPROVEEDORMap()
        {
            // Primary Key
            this.HasKey(t => t.CODORDENCOMPRA);

            // Properties
            this.Property(t => t.CODORDENCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ORDENCOMPRAPROVEEDOR");
            this.Property(t => t.CODORDENCOMPRA).HasColumnName("CODORDENCOMPRA");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.NUMEROORDEN).HasColumnName("NUMEROORDEN");
            this.Property(t => t.FECHAORDEN).HasColumnName("FECHAORDEN");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.CODRESPONSABLE).HasColumnName("CODRESPONSABLE");
            this.Property(t => t.ESTADOORDEN).HasColumnName("ESTADOORDEN");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.CODUSUARIOAUTORI).HasColumnName("CODUSUARIOAUTORI");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.FECHAAUTORIZADO).HasColumnName("FECHAAUTORIZADO");
            this.Property(t => t.CODORIGEN).HasColumnName("CODORIGEN");
            this.Property(t => t.TOTALIMPORTE).HasColumnName("TOTALIMPORTE");
            this.Property(t => t.TOTALIVA).HasColumnName("TOTALIVA");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODEMPRESAAUTORI).HasColumnName("CODEMPRESAAUTORI");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.ORDENCOMPRAPROVEEDORs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.ORDENCOMPRAORIGEN)
                .WithMany(t => t.ORDENCOMPRAPROVEEDORs)
                .HasForeignKey(d => d.CODORIGEN);
            this.HasOptional(t => t.ORDENCOMPRARESPONSABLE)
                .WithMany(t => t.ORDENCOMPRAPROVEEDORs)
                .HasForeignKey(d => d.CODRESPONSABLE);
            this.HasOptional(t => t.PROVEEDOR)
                .WithMany(t => t.ORDENCOMPRAPROVEEDORs)
                .HasForeignKey(d => d.CODPROVEEDOR);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.ORDENCOMPRAPROVEEDORs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.ORDENCOMPRAPROVEEDORs)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ORDENCOMPRAPROVEEDORs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.USUARIO1)
                .WithMany(t => t.ORDENCOMPRAPROVEEDORs1)
                .HasForeignKey(d => new { d.CODUSUARIOAUTORI, d.CODEMPRESAAUTORI });

        }
    }
}
