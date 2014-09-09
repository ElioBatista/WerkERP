using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class LiquidacioneMap : EntityTypeConfiguration<Liquidacione>
    {
        public LiquidacioneMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_liquidacion);

            // Properties
            this.Property(t => t.cod_liquidacion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Liquidaciones", "Liquidacion");
            this.Property(t => t.cod_liquidacion).HasColumnName("cod_liquidacion");
            this.Property(t => t.num_liquidacion).HasColumnName("num_liquidacion");
            this.Property(t => t.fecha).HasColumnName("fecha");
            this.Property(t => t.importe_total).HasColumnName("importe_total");
            this.Property(t => t.cod_usuario).HasColumnName("cod_usuario");
            this.Property(t => t.cod_empresa).HasColumnName("cod_empresa");
            this.Property(t => t.estado).HasColumnName("estado");
            this.Property(t => t.fecha_cierre).HasColumnName("fecha_cierre");
            this.Property(t => t.iva_gastos).HasColumnName("iva_gastos");
            this.Property(t => t.iva_honorarios).HasColumnName("iva_honorarios");
            this.Property(t => t.iva_retencion).HasColumnName("iva_retencion");
            this.Property(t => t.iva_gastos_retencion).HasColumnName("iva_gastos_retencion");
            this.Property(t => t.iva_honorarios_retencion).HasColumnName("iva_honorarios_retencion");
        }
    }
}
