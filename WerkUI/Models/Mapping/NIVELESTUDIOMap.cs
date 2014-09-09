using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class NIVELESTUDIOMap : EntityTypeConfiguration<NIVELESTUDIO>
    {
        public NIVELESTUDIOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODNIVEL);

            // Properties
            this.Property(t => t.CODNIVEL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMNIVEL)
                .HasMaxLength(5);

            this.Property(t => t.DESNIVEL)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("NIVELESTUDIOS");
            this.Property(t => t.CODNIVEL).HasColumnName("CODNIVEL");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMNIVEL).HasColumnName("NUMNIVEL");
            this.Property(t => t.DESNIVEL).HasColumnName("DESNIVEL");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.NIVELESTUDIOS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
