using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PRODUCCIONINGRESOPRODUCTOMap : EntityTypeConfiguration<PRODUCCIONINGRESOPRODUCTO>
    {
        public PRODUCCIONINGRESOPRODUCTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODINGRESOPROTER);

            // Properties
            this.Property(t => t.CODINGRESOPROTER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PRODUCCIONINGRESOPRODUCTO");
            this.Property(t => t.CODINGRESOPROTER).HasColumnName("CODINGRESOPROTER");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.NUMCOMPROBANTE).HasColumnName("NUMCOMPROBANTE");
            this.Property(t => t.FECHACOMPROBANTE).HasColumnName("FECHACOMPROBANTE");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.PRODUCCIONINGRESOPRODUCTOes)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.PROVEEDOR)
                .WithMany(t => t.PRODUCCIONINGRESOPRODUCTOes)
                .HasForeignKey(d => d.CODPROVEEDOR);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.PRODUCCIONINGRESOPRODUCTOes)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.PRODUCCIONINGRESOPRODUCTOes)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PRODUCCIONINGRESOPRODUCTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
