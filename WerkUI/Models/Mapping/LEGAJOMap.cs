using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class LEGAJOMap : EntityTypeConfiguration<LEGAJO>
    {
        public LEGAJOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODLEGAJO, t.CODEMPLEADO });

            // Properties
            this.Property(t => t.CODLEGAJO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPLEADO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OBSERVACION)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("LEGAJO");
            this.Property(t => t.CODLEGAJO).HasColumnName("CODLEGAJO");
            this.Property(t => t.CODEMPLEADO).HasColumnName("CODEMPLEADO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.EMPLEADO)
                .WithMany(t => t.LEGAJOes)
                .HasForeignKey(d => d.CODEMPLEADO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.LEGAJOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
