using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class SALARIOMap : EntityTypeConfiguration<SALARIO>
    {
        public SALARIOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODSALARIO, t.CODEMPLEADO });

            // Properties
            this.Property(t => t.CODSALARIO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPLEADO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SALARIO");
            this.Property(t => t.CODSALARIO).HasColumnName("CODSALARIO");
            this.Property(t => t.CODEMPLEADO).HasColumnName("CODEMPLEADO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.TIPOSALARIO).HasColumnName("TIPOSALARIO");
            this.Property(t => t.FECHAVIGENCIADESDE).HasColumnName("FECHAVIGENCIADESDE");
            this.Property(t => t.FECHAVIGENCIAHASTA).HasColumnName("FECHAVIGENCIAHASTA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODIVA).HasColumnName("CODIVA");

            // Relationships
            this.HasRequired(t => t.EMPLEADO)
                .WithMany(t => t.SALARIOs)
                .HasForeignKey(d => d.CODEMPLEADO);
            this.HasOptional(t => t.IVA)
                .WithMany(t => t.SALARIOs)
                .HasForeignKey(d => d.CODIVA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.SALARIOs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
