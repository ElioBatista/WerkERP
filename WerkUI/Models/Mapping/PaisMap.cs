using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PaisMap : EntityTypeConfiguration<Pais>
    {
        public PaisMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_pais);

            // Properties
            this.Property(t => t.pais1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.codigo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Paises", "Core");
            this.Property(t => t.cod_pais).HasColumnName("cod_pais");
            this.Property(t => t.pais1).HasColumnName("pais");
            this.Property(t => t.codigo).HasColumnName("codigo");
        }
    }
}
