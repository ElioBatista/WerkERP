using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOMOVIMIENTOSUELDODETALLEMap : EntityTypeConfiguration<TIPOMOVIMIENTOSUELDODETALLE>
    {
        public TIPOMOVIMIENTOSUELDODETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODTIPOMOVDET, t.CODTIPOMOV });

            // Properties
            this.Property(t => t.CODTIPOMOVDET)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODTIPOMOV)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TIPOMOVIMIENTOSUELDODETALLE");
            this.Property(t => t.CODTIPOMOVDET).HasColumnName("CODTIPOMOVDET");
            this.Property(t => t.CODTIPOMOV).HasColumnName("CODTIPOMOV");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasRequired(t => t.TIPOMOVIMIENTOSUELDO)
                .WithMany(t => t.TIPOMOVIMIENTOSUELDODETALLEs)
                .HasForeignKey(d => d.CODTIPOMOV);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOMOVIMIENTOSUELDODETALLEs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
