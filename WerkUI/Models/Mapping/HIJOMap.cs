using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class HIJOMap : EntityTypeConfiguration<HIJO>
    {
        public HIJOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODHIJO, t.CODEMPLEADO });

            // Properties
            this.Property(t => t.CODHIJO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPLEADO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NOMBRE)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("HIJOS");
            this.Property(t => t.CODHIJO).HasColumnName("CODHIJO");
            this.Property(t => t.CODEMPLEADO).HasColumnName("CODEMPLEADO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSEXO).HasColumnName("CODSEXO");
            this.Property(t => t.NOMBRE).HasColumnName("NOMBRE");
            this.Property(t => t.FECHANACIMIENTO).HasColumnName("FECHANACIMIENTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.EMPLEADO)
                .WithMany(t => t.HIJOS)
                .HasForeignKey(d => d.CODEMPLEADO);
            this.HasOptional(t => t.SEXO)
                .WithMany(t => t.HIJOS)
                .HasForeignKey(d => d.CODSEXO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.HIJOS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
