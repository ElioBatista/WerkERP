using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DIVISIONEMPRESAMap : EntityTypeConfiguration<DIVISIONEMPRESA>
    {
        public DIVISIONEMPRESAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODDIVISION);

            // Properties
            this.Property(t => t.CODDIVISION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMDIVISION)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DESDIVISION)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("DIVISIONEMPRESA");
            this.Property(t => t.CODDIVISION).HasColumnName("CODDIVISION");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMDIVISION).HasColumnName("NUMDIVISION");
            this.Property(t => t.DESDIVISION).HasColumnName("DESDIVISION");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DIVISIONEMPRESAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
