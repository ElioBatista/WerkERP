using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CAJAMap : EntityTypeConfiguration<CAJA>
    {
        public CAJAMap()
        {
            // Primary Key
            this.HasKey(t => t.NUMCAJA);

            // Properties
            this.Property(t => t.NUMCAJA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMEROCAJA)
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("CAJA");
            this.Property(t => t.NUMCAJA).HasColumnName("NUMCAJA");
            this.Property(t => t.NUMEROCAJA).HasColumnName("NUMEROCAJA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.CODCOBRADOR).HasColumnName("CODCOBRADOR");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.COBRADOR)
                .WithMany(t => t.CAJAs)
                .HasForeignKey(d => d.CODCOBRADOR);
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.CAJAs)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.CAJAs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CAJAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
