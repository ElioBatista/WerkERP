using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class LiquidacionDetalleMap : EntityTypeConfiguration<LiquidacionDetalle>
    {
        public LiquidacionDetalleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.cod_liquidacion, t.secuencia_interna });

            // Properties
            this.Property(t => t.cod_liquidacion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.secuencia_interna)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.comentario)
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.des_con_liquidacion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("LiquidacionDetalles", "Liquidacion");
            this.Property(t => t.cod_liquidacion).HasColumnName("cod_liquidacion");
            this.Property(t => t.secuencia_interna).HasColumnName("secuencia_interna");
            this.Property(t => t.comentario).HasColumnName("comentario");
            this.Property(t => t.cod_con_liquidacion).HasColumnName("cod_con_liquidacion");
            this.Property(t => t.des_con_liquidacion).HasColumnName("des_con_liquidacion");
            this.Property(t => t.grupo_impresion).HasColumnName("grupo_impresion");
            this.Property(t => t.importe).HasColumnName("importe");

            // Relationships
            this.HasRequired(t => t.Liquidacione)
                .WithMany(t => t.LiquidacionDetalles)
                .HasForeignKey(d => d.cod_liquidacion);

        }
    }
}
