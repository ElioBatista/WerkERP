using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class VEHICULOMap : EntityTypeConfiguration<VEHICULO>
    {
        public VEHICULOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODVEHICULO);

            // Properties
            this.Property(t => t.NUMVEHICULO)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.CODVEHICULO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESVEHICULO)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.CHAPANRO)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("VEHICULOS");
            this.Property(t => t.NUMVEHICULO).HasColumnName("NUMVEHICULO");
            this.Property(t => t.CODVEHICULO).HasColumnName("CODVEHICULO");
            this.Property(t => t.DESVEHICULO).HasColumnName("DESVEHICULO");
            this.Property(t => t.PROPIEDAD).HasColumnName("PROPIEDAD");
            this.Property(t => t.CODCHOFER).HasColumnName("CODCHOFER");
            this.Property(t => t.CHAPANRO).HasColumnName("CHAPANRO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.CHOFERE)
                .WithMany(t => t.VEHICULOS)
                .HasForeignKey(d => d.CODCHOFER);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.VEHICULOS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
