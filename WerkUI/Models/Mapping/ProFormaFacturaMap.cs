using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ProFormaFacturaMap : EntityTypeConfiguration<ProFormaFactura>
    {
        public ProFormaFacturaMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_ProFormafactura);

            // Properties
            this.Property(t => t.ruc)
                .HasMaxLength(50);

            this.Property(t => t.direccion)
                .HasMaxLength(256);

            this.Property(t => t.telefono)
                .HasMaxLength(50);

            this.Property(t => t.nro_despacho)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ProFormaFacturas", "Facturacion");
            this.Property(t => t.cod_ProFormafactura).HasColumnName("cod_ProFormafactura");
            this.Property(t => t.num_factura).HasColumnName("num_factura");
            this.Property(t => t.cod_cliente).HasColumnName("cod_cliente");
            this.Property(t => t.cod_liquidacion).HasColumnName("cod_liquidacion");
            this.Property(t => t.cod_moneda).HasColumnName("cod_moneda");
            this.Property(t => t.fecha).HasColumnName("fecha");
            this.Property(t => t.ruc).HasColumnName("ruc");
            this.Property(t => t.direccion).HasColumnName("direccion");
            this.Property(t => t.cod_empresa).HasColumnName("cod_empresa");
            this.Property(t => t.telefono).HasColumnName("telefono");
            this.Property(t => t.cod_tipo_factura).HasColumnName("cod_tipo_factura");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.iva_gastos).HasColumnName("iva_gastos");
            this.Property(t => t.iva_honorarios).HasColumnName("iva_honorarios");
            this.Property(t => t.retencion_iva).HasColumnName("retencion_iva");
            this.Property(t => t.retencion_iva_gastos).HasColumnName("retencion_iva_gastos");
            this.Property(t => t.retencion_iva_honorarios).HasColumnName("retencion_iva_honorarios");
            this.Property(t => t.nro_despacho_interno).HasColumnName("nro_despacho_interno");
            this.Property(t => t.nro_despacho).HasColumnName("nro_despacho");

            // Relationships
            /*this.HasOptional(t => t.Moneda)
                .WithMany(t => t.ProFormaFacturas)
                .HasForeignKey(d => d.cod_moneda);
            this.HasOptional(t => t.TipoFactura)
                .WithMany(t => t.ProFormaFacturas)
                .HasForeignKey(d => d.cod_tipo_factura);
            */
        }
    }
}
