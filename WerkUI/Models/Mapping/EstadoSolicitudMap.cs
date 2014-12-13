using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class EstadoSolicitudMap : EntityTypeConfiguration<EstadoSolicitud>
    {
        public EstadoSolicitudMap()
        {
            // Primary Key
            this.HasKey(t => t.id_estado);

            // Properties
            this.Property(t => t.estado)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EstadoSolicitud", "Pagos");
            this.Property(t => t.id_estado).HasColumnName("id_estado");
            this.Property(t => t.estado).HasColumnName("estado");
        }
    }
}
