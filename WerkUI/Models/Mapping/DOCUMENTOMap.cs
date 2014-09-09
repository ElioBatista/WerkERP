using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DOCUMENTOMap : EntityTypeConfiguration<DOCUMENTO>
    {
        public DOCUMENTOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDOCUMENTO, t.CODEMPLEADO });

            // Properties
            this.Property(t => t.CODDOCUMENTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPLEADO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESDOCUMENTO)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("DOCUMENTOS");
            this.Property(t => t.CODDOCUMENTO).HasColumnName("CODDOCUMENTO");
            this.Property(t => t.CODEMPLEADO).HasColumnName("CODEMPLEADO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.DESDOCUMENTO).HasColumnName("DESDOCUMENTO");
            this.Property(t => t.IMAGEN).HasColumnName("IMAGEN");
            this.Property(t => t.ARCHIVO).HasColumnName("ARCHIVO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.EMPLEADO)
                .WithMany(t => t.DOCUMENTOS)
                .HasForeignKey(d => d.CODEMPLEADO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DOCUMENTOS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
