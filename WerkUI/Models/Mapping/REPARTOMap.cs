using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class REPARTOMap : EntityTypeConfiguration<REPARTO>
    {
        public REPARTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODREPARTO);

            // Properties
            this.Property(t => t.CODREPARTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMREPARTO)
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("REPARTO");
            this.Property(t => t.CODREPARTO).HasColumnName("CODREPARTO");
            this.Property(t => t.NUMREPARTO).HasColumnName("NUMREPARTO");
            this.Property(t => t.CODVEHICULO).HasColumnName("CODVEHICULO");
            this.Property(t => t.CODCHOFER).HasColumnName("CODCHOFER");
            this.Property(t => t.CODRUTA).HasColumnName("CODRUTA");
            this.Property(t => t.FECHAREPARTO).HasColumnName("FECHAREPARTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.CHOFERE)
                .WithMany(t => t.REPARTOes)
                .HasForeignKey(d => d.CODCHOFER);
            this.HasOptional(t => t.RUTA)
                .WithMany(t => t.REPARTOes)
                .HasForeignKey(d => d.CODRUTA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.REPARTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.VEHICULO)
                .WithMany(t => t.REPARTOes)
                .HasForeignKey(d => d.CODVEHICULO);

        }
    }
}
