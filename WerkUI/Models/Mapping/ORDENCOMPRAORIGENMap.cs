using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENCOMPRAORIGENMap : EntityTypeConfiguration<ORDENCOMPRAORIGEN>
    {
        public ORDENCOMPRAORIGENMap()
        {
            // Primary Key
            this.HasKey(t => t.CODORIGEN);

            // Properties
            this.Property(t => t.CODORIGEN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMORIGEN)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESCRIPCION)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ORDENCOMPRAORIGEN");
            this.Property(t => t.CODORIGEN).HasColumnName("CODORIGEN");
            this.Property(t => t.NUMORIGEN).HasColumnName("NUMORIGEN");
            this.Property(t => t.DESCRIPCION).HasColumnName("DESCRIPCION");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ORDENCOMPRAORIGENs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
