using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DIASEMISORAMap : EntityTypeConfiguration<DIASEMISORA>
    {
        public DIASEMISORAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDIASEMISORA, t.CODEMISORA, t.CODEMPRESA });

            // Properties
            this.Property(t => t.CODDIASEMISORA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMISORA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DIASEMISORA");
            this.Property(t => t.CODDIASEMISORA).HasColumnName("CODDIASEMISORA");
            this.Property(t => t.CODEMISORA).HasColumnName("CODEMISORA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECHA).HasColumnName("FECHA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.EMISORA)
                .WithMany(t => t.DIASEMISORAs)
                .HasForeignKey(d => d.CODEMISORA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DIASEMISORAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
