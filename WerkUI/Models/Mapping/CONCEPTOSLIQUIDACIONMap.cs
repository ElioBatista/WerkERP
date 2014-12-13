using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ConceptosLiquidacionMap : EntityTypeConfiguration<ConceptosLiquidacion>
    {
        public ConceptosLiquidacionMap()
        {
            // Primary Key
            this.HasKey(t => t.nro_concepto);

            // Properties
            this.Property(t => t.nro_concepto)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.descripcion)
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("ConceptosLiquidacion", "Pagos");
            this.Property(t => t.cod_concepto_liquidacion).HasColumnName("cod_concepto_liquidacion");
            this.Property(t => t.cod_empresa).HasColumnName("cod_empresa");
            this.Property(t => t.nro_concepto).HasColumnName("nro_concepto");
            this.Property(t => t.descripcion).HasColumnName("descripcion");
            this.Property(t => t.grupo_impresion).HasColumnName("grupo_impresion");
        }
    }
}
