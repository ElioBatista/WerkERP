using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class NACIONALIDADMap : EntityTypeConfiguration<NACIONALIDAD>
    {
        public NACIONALIDADMap()
        {
            // Primary Key
            this.HasKey(t => t.CODNACIONALIDAD);

            // Properties
            this.Property(t => t.CODNACIONALIDAD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMNACIONALIDAD)
                .HasMaxLength(5);

            this.Property(t => t.DESNACIONALIDAD)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("NACIONALIDAD");
            this.Property(t => t.CODNACIONALIDAD).HasColumnName("CODNACIONALIDAD");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMNACIONALIDAD).HasColumnName("NUMNACIONALIDAD");
            this.Property(t => t.DESNACIONALIDAD).HasColumnName("DESNACIONALIDAD");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.NACIONALIDADs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
