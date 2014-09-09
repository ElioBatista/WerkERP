using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PRECIOPRIORIDADMap : EntityTypeConfiguration<PRECIOPRIORIDAD>
    {
        public PRECIOPRIORIDADMap()
        {
            // Primary Key
            this.HasKey(t => t.CODPRIORIDAD);

            // Properties
            this.Property(t => t.CODPRIORIDAD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMPRIORIDAD)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESPRIORIDAD)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("PRECIOPRIORIDAD");
            this.Property(t => t.CODPRIORIDAD).HasColumnName("CODPRIORIDAD");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMPRIORIDAD).HasColumnName("NUMPRIORIDAD");
            this.Property(t => t.DESPRIORIDAD).HasColumnName("DESPRIORIDAD");
            this.Property(t => t.ORDEN).HasColumnName("ORDEN");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PRECIOPRIORIDADs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
