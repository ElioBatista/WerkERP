using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CHOFEREMap : EntityTypeConfiguration<CHOFERE>
    {
        public CHOFEREMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCHOFER);

            // Properties
            this.Property(t => t.CODCHOFER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCHOFER)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.DESCHOFER)
                .IsFixedLength()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("CHOFERES");
            this.Property(t => t.CODCHOFER).HasColumnName("CODCHOFER");
            this.Property(t => t.NUMCHOFER).HasColumnName("NUMCHOFER");
            this.Property(t => t.DESCHOFER).HasColumnName("DESCHOFER");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CHOFERES)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
