using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class NCREDITOMap : EntityTypeConfiguration<NCREDITO>
    {
        public NCREDITOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NUMNCREDITO, t.CODEMPRESA });

            // Properties
            this.Property(t => t.NUMNCREDITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("NCREDITO");
            this.Property(t => t.NUMNCREDITO).HasColumnName("NUMNCREDITO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.FECHA).HasColumnName("FECHA");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.IMPORTEIVA).HasColumnName("IMPORTEIVA");
            this.Property(t => t.IMPORTEDESC).HasColumnName("IMPORTEDESC");
            this.Property(t => t.TOTALEXENTA).HasColumnName("TOTALEXENTA");
            this.Property(t => t.TOTALGRAVADA).HasColumnName("TOTALGRAVADA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.CLIENTE)
                .WithMany(t => t.NCREDITOes)
                .HasForeignKey(d => d.CODCLIENTE);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.NCREDITOes)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.NCREDITOes)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.NCREDITOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.VENTA)
                .WithMany(t => t.NCREDITOes)
                .HasForeignKey(d => d.CODVENTA);

        }
    }
}
