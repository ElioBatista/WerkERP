using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ADJUNTOMap : EntityTypeConfiguration<ADJUNTO>
    {
        public ADJUNTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODADJUNTO);

            // Properties
            this.Property(t => t.CODADJUNTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMADJUNTO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESADJUNTO)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("ADJUNTO");
            this.Property(t => t.CODADJUNTO).HasColumnName("CODADJUNTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMADJUNTO).HasColumnName("NUMADJUNTO");
            this.Property(t => t.DESADJUNTO).HasColumnName("DESADJUNTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ADJUNTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
