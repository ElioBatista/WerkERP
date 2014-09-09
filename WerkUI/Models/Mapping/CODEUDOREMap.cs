using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CODEUDOREMap : EntityTypeConfiguration<CODEUDORE>
    {
        public CODEUDOREMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CEDULA, t.CODEMPRESA });

            // Properties
            this.Property(t => t.CEDULA)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOMBRE)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.APELLIDO)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.DIRECCION)
                .IsFixedLength()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("CODEUDORES");
            this.Property(t => t.CEDULA).HasColumnName("CEDULA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODCIVIL).HasColumnName("CODCIVIL");
            this.Property(t => t.NOMBRE).HasColumnName("NOMBRE");
            this.Property(t => t.APELLIDO).HasColumnName("APELLIDO");
            this.Property(t => t.DIRECCION).HasColumnName("DIRECCION");
            this.Property(t => t.FECHANACIMIENTO).HasColumnName("FECHANACIMIENTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasMany(t => t.PAGAREs)
                .WithMany(t => t.CODEUDORES)
                .Map(m =>
                    {
                        m.ToTable("PAGAREDEUDORES");
                        m.MapLeftKey("CEDULA", "CODEMPRESA");
                        m.MapRightKey("CODPAGARE");
                    });

            this.HasOptional(t => t.ESTADOCIVIL)
                .WithMany(t => t.CODEUDORES)
                .HasForeignKey(d => d.CODCIVIL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CODEUDORES)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
