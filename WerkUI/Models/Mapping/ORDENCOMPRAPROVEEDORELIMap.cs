using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENCOMPRAPROVEEDORELIMap : EntityTypeConfiguration<ORDENCOMPRAPROVEEDORELI>
    {
        public ORDENCOMPRAPROVEEDORELIMap()
        {
            // Primary Key
            this.HasKey(t => t.CODORDENCOMPRA);

            // Properties
            this.Property(t => t.CODORDENCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESELIMINACION)
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("ORDENCOMPRAPROVEEDORELI");
            this.Property(t => t.CODORDENCOMPRA).HasColumnName("CODORDENCOMPRA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
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
            this.Property(t => t.FECHAELIMINACION).HasColumnName("FECHAELIMINACION");
            this.Property(t => t.CODUSUARIOELIMACION).HasColumnName("CODUSUARIOELIMACION");
            this.Property(t => t.DESELIMINACION).HasColumnName("DESELIMINACION");
        }
    }
}
