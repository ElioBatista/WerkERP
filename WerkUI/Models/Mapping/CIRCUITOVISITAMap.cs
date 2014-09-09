using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CIRCUITOVISITAMap : EntityTypeConfiguration<CIRCUITOVISITA>
    {
        public CIRCUITOVISITAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODCIRCUITO, t.CODDIAS });

            // Properties
            this.Property(t => t.CODCIRCUITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODDIAS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CIRCUITOVISITAS");
            this.Property(t => t.CODCIRCUITO).HasColumnName("CODCIRCUITO");
            this.Property(t => t.CODDIAS).HasColumnName("CODDIAS");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasRequired(t => t.CIRCUITO)
                .WithMany(t => t.CIRCUITOVISITAS)
                .HasForeignKey(d => d.CODCIRCUITO);
            this.HasRequired(t => t.CIRCUITODIA)
                .WithMany(t => t.CIRCUITOVISITAS)
                .HasForeignKey(d => d.CODDIAS);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CIRCUITOVISITAS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
