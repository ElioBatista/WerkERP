using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TiposChequeraMap : EntityTypeConfiguration<TiposChequera>
    {
        public TiposChequeraMap()
        {
            // Primary Key
            this.HasKey(t => t.id_tipo_chequera);

            // Properties
            this.Property(t => t.tipo_chequera)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TiposChequera", "Finanzas");
            this.Property(t => t.id_tipo_chequera).HasColumnName("id_tipo_chequera");
            this.Property(t => t.tipo_chequera).HasColumnName("tipo_chequera");
        }
    }
}
