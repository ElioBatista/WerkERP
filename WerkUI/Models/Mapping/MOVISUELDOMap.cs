using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class MOVISUELDOMap : EntityTypeConfiguration<MOVISUELDO>
    {
        public MOVISUELDOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODMOVI);

            // Properties
            this.Property(t => t.CODMOVI)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MOVISUELDO");
            this.Property(t => t.CODMOVI).HasColumnName("CODMOVI");
            this.Property(t => t.CODTIPOMOV).HasColumnName("CODTIPOMOV");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMMOVI).HasColumnName("NUMMOVI");
            this.Property(t => t.FECHAMOVI).HasColumnName("FECHAMOVI");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.MOVISUELDOes)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.TIPOMOVIMIENTOSUELDO)
                .WithMany(t => t.MOVISUELDOes)
                .HasForeignKey(d => d.CODTIPOMOV);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.MOVISUELDOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
