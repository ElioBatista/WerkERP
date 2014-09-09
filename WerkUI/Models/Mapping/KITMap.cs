using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class KITMap : EntityTypeConfiguration<KIT>
    {
        public KITMap()
        {
            // Primary Key
            this.HasKey(t => t.CODKITS);

            // Properties
            this.Property(t => t.CODKITS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OBSERVACION)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("KITS");
            this.Property(t => t.CODKITS).HasColumnName("CODKITS");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.KITS)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.KITS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
