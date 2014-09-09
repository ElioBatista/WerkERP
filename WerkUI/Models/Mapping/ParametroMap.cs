using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ParametroMap : EntityTypeConfiguration<Parametro>
    {
        public ParametroMap()
        {
            // Primary Key
            this.HasKey(t => new { t.parametro1, t.modulo });

            // Properties
            this.Property(t => t.parametro1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.modulo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.valor)
                .IsRequired()
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("Parametros", "Core");
            this.Property(t => t.parametro1).HasColumnName("parametro");
            this.Property(t => t.modulo).HasColumnName("modulo");
            this.Property(t => t.valor).HasColumnName("valor");
        }
    }
}
