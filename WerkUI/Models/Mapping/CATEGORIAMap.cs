using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CATEGORIAMap : EntityTypeConfiguration<CATEGORIA>
    {
        public CATEGORIAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCATEGORIA);

            // Properties
            this.Property(t => t.CODCATEGORIA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCATEGORIA)
                .HasMaxLength(5);

            this.Property(t => t.DESCATEGORIA)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("CATEGORIA");
            this.Property(t => t.CODCATEGORIA).HasColumnName("CODCATEGORIA");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMCATEGORIA).HasColumnName("NUMCATEGORIA");
            this.Property(t => t.DESCATEGORIA).HasColumnName("DESCATEGORIA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CATEGORIAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
