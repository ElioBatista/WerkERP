using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CHEQUEEMITIDOMap : EntityTypeConfiguration<CHEQUEEMITIDO>
    {
        public CHEQUEEMITIDOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NUMEROCHEQUE, t.CODBANCO });

            // Properties
            this.Property(t => t.NUMEROCHEQUE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCUENTA)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.BENEFICIARIO)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.CODBANCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CHEQUEEMITIDO");
            this.Property(t => t.NUMEROCHEQUE).HasColumnName("NUMEROCHEQUE");
            this.Property(t => t.NUMCUENTA).HasColumnName("NUMCUENTA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECHAVCTO).HasColumnName("FECHAVCTO");
            this.Property(t => t.EFECTIVIZACION).HasColumnName("EFECTIVIZACION");
            this.Property(t => t.CONCILIACION).HasColumnName("CONCILIACION");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.BENEFICIARIO).HasColumnName("BENEFICIARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.CODBANCO).HasColumnName("CODBANCO");
            this.Property(t => t.CODPAGANZAS).HasColumnName("CODPAGANZAS");
            this.Property(t => t.CODTIPOPAGO).HasColumnName("CODTIPOPAGO");
            this.Property(t => t.PAG_CODMONEDA).HasColumnName("PAG_CODMONEDA");
            this.Property(t => t.BAN__CODBANCO).HasColumnName("BAN__CODBANCO");
            this.Property(t => t.BAN_CODBANCO).HasColumnName("BAN_CODBANCO");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.CHEQUEEMITIDOes)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.CHEQUEEMITIDOes)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CHEQUEEMITIDOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.CUENTABANCARIA)
                .WithMany(t => t.CHEQUEEMITIDOes)
                .HasForeignKey(d => new { d.NUMCUENTA, d.BAN__CODBANCO });
            this.HasOptional(t => t.PAGANZA)
                .WithMany(t => t.CHEQUEEMITIDOes)
                .HasForeignKey(d => new { d.CODPAGANZAS, d.CODTIPOPAGO, d.PAG_CODMONEDA });

        }
    }
}
