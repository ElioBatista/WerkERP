using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class BancoMap : EntityTypeConfiguration<Banco>
    {
        public BancoMap()
        {
            // Primary Key
            this.HasKey(t => t.id_banco);

            // Properties
            this.Property(t => t.banco1)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Bancos", "Core");
            this.Property(t => t.id_banco).HasColumnName("id_banco");
            this.Property(t => t.banco1).HasColumnName("banco");
        }
    }
}
