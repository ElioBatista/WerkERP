using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PROFESIONMap : EntityTypeConfiguration<PROFESION>
    {
        public PROFESIONMap()
        {
            // Primary Key
            this.HasKey(t => t.CODPROFESION);

            // Properties
            this.Property(t => t.CODPROFESION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMPROFESION)
                .HasMaxLength(5);

            this.Property(t => t.DESPROFESION)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("PROFESION");
            this.Property(t => t.CODPROFESION).HasColumnName("CODPROFESION");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMPROFESION).HasColumnName("NUMPROFESION");
            this.Property(t => t.DESPROFESION).HasColumnName("DESPROFESION");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PROFESIONs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
