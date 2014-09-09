using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DEPARTAMENTOEMPRESAMap : EntityTypeConfiguration<DEPARTAMENTOEMPRESA>
    {
        public DEPARTAMENTOEMPRESAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODDEPARTAMENTO);

            // Properties
            this.Property(t => t.CODDEPARTAMENTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMDEPARTAMENTO)
                .HasMaxLength(5);

            this.Property(t => t.DESDEPARTAMENTO)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("DEPARTAMENTOEMPRESA");
            this.Property(t => t.CODDEPARTAMENTO).HasColumnName("CODDEPARTAMENTO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMDEPARTAMENTO).HasColumnName("NUMDEPARTAMENTO");
            this.Property(t => t.DESDEPARTAMENTO).HasColumnName("DESDEPARTAMENTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DEPARTAMENTOEMPRESAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
