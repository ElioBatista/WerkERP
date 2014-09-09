using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class MonedaMap : EntityTypeConfiguration<Moneda>
    {
        public MonedaMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_moneda);

            // Properties
            this.Property(t => t.moneda1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.simbolo)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.formato)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Monedas", "Core");
            this.Property(t => t.cod_moneda).HasColumnName("cod_moneda");
            this.Property(t => t.moneda1).HasColumnName("moneda");
            this.Property(t => t.simbolo).HasColumnName("simbolo");
            this.Property(t => t.formato).HasColumnName("formato");
            this.Property(t => t.cod_pais).HasColumnName("cod_pais");

            // Relationships
            this.HasOptional(t => t.Pais)
                .WithMany(t => t.Monedas)
                .HasForeignKey(d => d.cod_pais);

        }
    }
}
