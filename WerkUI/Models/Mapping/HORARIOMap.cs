using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class HORARIOMap : EntityTypeConfiguration<HORARIO>
    {
        public HORARIOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODHORARIO, t.CODEMPLEADO });

            // Properties
            this.Property(t => t.CODHORARIO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPLEADO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("HORARIO");
            this.Property(t => t.CODHORARIO).HasColumnName("CODHORARIO");
            this.Property(t => t.CODEMPLEADO).HasColumnName("CODEMPLEADO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.ENTRADA).HasColumnName("ENTRADA");
            this.Property(t => t.SALIDA).HasColumnName("SALIDA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.EMPLEADO)
                .WithMany(t => t.HORARIOs)
                .HasForeignKey(d => d.CODEMPLEADO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.HORARIOs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
