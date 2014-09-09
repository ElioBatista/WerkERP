using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class MODULOUSUARIOMap : EntityTypeConfiguration<MODULOUSUARIO>
    {
        public MODULOUSUARIOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODUSUARIO, t.CODEMPRESA, t.CODMODULO });

            // Properties
            this.Property(t => t.CODUSUARIO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODMODULO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MODULOUSUARIO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODMODULO).HasColumnName("CODMODULO");
            this.Property(t => t.SELECT).HasColumnName("SELECT");
            this.Property(t => t.INSERT).HasColumnName("INSERT");
            this.Property(t => t.UPDATE).HasColumnName("UPDATE");
            this.Property(t => t.DELETE).HasColumnName("DELETE");
            this.Property(t => t.PRINT).HasColumnName("PRINT");
            this.Property(t => t.VENCIDAS).HasColumnName("VENCIDAS");
            this.Property(t => t.LIMITECREDITO).HasColumnName("LIMITECREDITO");
            this.Property(t => t.DESC).HasColumnName("DESC");
            this.Property(t => t.ANULAR).HasColumnName("ANULAR");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.MODULO)
                .WithMany(t => t.MODULOUSUARIOs)
                .HasForeignKey(d => d.CODMODULO);
            this.HasRequired(t => t.USUARIO)
                .WithMany(t => t.MODULOUSUARIOs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
