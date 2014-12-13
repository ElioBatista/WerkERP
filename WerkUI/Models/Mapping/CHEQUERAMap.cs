using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ChequeraMap : EntityTypeConfiguration<Chequera>
    {
        public ChequeraMap()
        {
            // Primary Key
            this.HasKey(t => t.id_chequera);

            // Properties
            this.Property(t => t.nro_talon)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Chequeras", "Finanzas");
            this.Property(t => t.id_chequera).HasColumnName("id_chequera");
            this.Property(t => t.id_banco).HasColumnName("id_banco");
            this.Property(t => t.fecha_emision).HasColumnName("fecha_emision");
            this.Property(t => t.serie_inicio).HasColumnName("serie_inicio");
            this.Property(t => t.serie_fin).HasColumnName("serie_fin");
            this.Property(t => t.id_tipo_chequera).HasColumnName("id_tipo_chequera");
            this.Property(t => t.nro_talon).HasColumnName("nro_talon");

            // Relationships
            this.HasRequired(t => t.Banco)
                .WithMany(t => t.Chequeras)
                .HasForeignKey(d => d.id_banco);
            this.HasRequired(t => t.Banco1)
                .WithMany(t => t.Chequeras1)
                .HasForeignKey(d => d.id_banco);
            this.HasRequired(t => t.TiposChequera)
                .WithMany(t => t.Chequeras)
                .HasForeignKey(d => d.id_tipo_chequera);

        }
    }
}
