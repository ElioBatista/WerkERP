using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PLANCUENTAMap : EntityTypeConfiguration<PLANCUENTA>
    {
        public PLANCUENTAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODPLANCUENTA);

            // Properties
            this.Property(t => t.CODPLANCUENTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESPLANCUENTA)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.DESSUBCUENTA)
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("PLANCUENTAS");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMPLANCUENTA).HasColumnName("NUMPLANCUENTA");
            this.Property(t => t.DESPLANCUENTA).HasColumnName("DESPLANCUENTA");
            this.Property(t => t.TIPOCUENTA).HasColumnName("TIPOCUENTA");
            this.Property(t => t.ASENTABLE).HasColumnName("ASENTABLE");
            this.Property(t => t.NIVELCUENTA).HasColumnName("NIVELCUENTA");
            this.Property(t => t.SUBCUENTA).HasColumnName("SUBCUENTA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.DESSUBCUENTA).HasColumnName("DESSUBCUENTA");

            // Relationships
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.PLANCUENTAS)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PLANCUENTAS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
