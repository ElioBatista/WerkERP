using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_usuario);

            // Properties
            this.Property(t => t.usuario1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.nombres)
                .HasMaxLength(50);

            this.Property(t => t.apellidos)
                .HasMaxLength(50);

            this.Property(t => t.password)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Usuarios", "Seguridad");
            this.Property(t => t.cod_usuario).HasColumnName("cod_usuario");
            this.Property(t => t.usuario1).HasColumnName("usuario");
            this.Property(t => t.nombres).HasColumnName("nombres");
            this.Property(t => t.apellidos).HasColumnName("apellidos");
            this.Property(t => t.password).HasColumnName("password");
        }
    }
}
