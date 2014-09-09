using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CARGOMap : EntityTypeConfiguration<CARGO>
    {
        public CARGOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCARGO);

            // Properties
            this.Property(t => t.CODCARGO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCARGO)
                .HasMaxLength(5);

            this.Property(t => t.DESCARGO)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("CARGO");
            this.Property(t => t.CODCARGO).HasColumnName("CODCARGO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMCARGO).HasColumnName("NUMCARGO");
            this.Property(t => t.DESCARGO).HasColumnName("DESCARGO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CARGOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
