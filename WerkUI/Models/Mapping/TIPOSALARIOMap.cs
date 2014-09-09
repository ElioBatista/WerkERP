using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOSALARIOMap : EntityTypeConfiguration<TIPOSALARIO>
    {
        public TIPOSALARIOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPOSALARIO);

            // Properties
            this.Property(t => t.CODTIPOSALARIO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPOSALARIO)
                .HasMaxLength(5);

            this.Property(t => t.DESTIPOSALARIO)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("TIPOSALARIO");
            this.Property(t => t.CODTIPOSALARIO).HasColumnName("CODTIPOSALARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMTIPOSALARIO).HasColumnName("NUMTIPOSALARIO");
            this.Property(t => t.DESTIPOSALARIO).HasColumnName("DESTIPOSALARIO");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOSALARIOs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
