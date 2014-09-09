using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class RUTAMap : EntityTypeConfiguration<RUTA>
    {
        public RUTAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODRUTA);

            // Properties
            this.Property(t => t.CODRUTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMRUTA)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.DESRUTA)
                .IsFixedLength()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("RUTAS");
            this.Property(t => t.CODRUTA).HasColumnName("CODRUTA");
            this.Property(t => t.NUMRUTA).HasColumnName("NUMRUTA");
            this.Property(t => t.DESRUTA).HasColumnName("DESRUTA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.RUTAS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
