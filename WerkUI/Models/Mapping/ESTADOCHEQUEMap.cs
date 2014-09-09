using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ESTADOCHEQUEMap : EntityTypeConfiguration<ESTADOCHEQUE>
    {
        public ESTADOCHEQUEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODESTADO);

            // Properties
            this.Property(t => t.CODESTADO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMESTADO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESESTADO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("ESTADOCHEQUE");
            this.Property(t => t.CODESTADO).HasColumnName("CODESTADO");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMESTADO).HasColumnName("NUMESTADO");
            this.Property(t => t.DESESTADO).HasColumnName("DESESTADO");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.ESTADOCHEQUEs)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ESTADOCHEQUEs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
