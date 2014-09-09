using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOFORMACOBROMap : EntityTypeConfiguration<TIPOFORMACOBRO>
    {
        public TIPOFORMACOBROMap()
        {
            // Primary Key
            this.HasKey(t => t.CODFORCOBRO);

            // Properties
            this.Property(t => t.CODFORCOBRO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMFORCOBRO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESFORCOBRO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("TIPOFORMACOBRO");
            this.Property(t => t.CODFORCOBRO).HasColumnName("CODFORCOBRO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.NUMFORCOBRO).HasColumnName("NUMFORCOBRO");
            this.Property(t => t.DESFORCOBRO).HasColumnName("DESFORCOBRO");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");
            this.Property(t => t.COBRANZAS).HasColumnName("COBRANZAS");
            this.Property(t => t.CAJA).HasColumnName("CAJA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.TIPOFORMACOBROes)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOFORMACOBROes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
