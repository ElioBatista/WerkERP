using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class VARPATRIMONIOMap : EntityTypeConfiguration<VARPATRIMONIO>
    {
        public VARPATRIMONIOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODVARPATRIMONIO);

            // Properties
            this.Property(t => t.CODVARPATRIMONIO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VARPATRIMONIO");
            this.Property(t => t.CODVARPATRIMONIO).HasColumnName("CODVARPATRIMONIO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.VARPATRIMONIOs)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.VARPATRIMONIOs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.VARPATRIMONIOs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
