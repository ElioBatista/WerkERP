using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ESTADOCIVILMap : EntityTypeConfiguration<ESTADOCIVIL>
    {
        public ESTADOCIVILMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCIVIL);

            // Properties
            this.Property(t => t.CODCIVIL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCIVIL)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESCIVIL)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("ESTADOCIVIL");
            this.Property(t => t.CODCIVIL).HasColumnName("CODCIVIL");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMCIVIL).HasColumnName("NUMCIVIL");
            this.Property(t => t.DESCIVIL).HasColumnName("DESCIVIL");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ESTADOCIVILs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
