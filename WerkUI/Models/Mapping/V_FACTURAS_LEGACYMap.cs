using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class V_FACTURAS_LEGACYMap : EntityTypeConfiguration<V_FACTURAS_LEGACY>
    {
        public V_FACTURAS_LEGACYMap()
        {
            // Primary Key
            this.HasKey(t => t.Technology);

            // Properties
            this.Property(t => t.Nro__Factura)
                .HasMaxLength(20);

            this.Property(t => t.Nro__Despacho)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.Nro__Despacho_Interno)
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.Tipo)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.Despachante)
                .HasMaxLength(82);

            this.Property(t => t.Cliente)
                .HasMaxLength(80);

            this.Property(t => t.Moneda)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.Technology)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Tipo_Movimiento)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("V_FACTURAS_LEGACY");
            this.Property(t => t.Nro__Factura).HasColumnName("Nro. Factura");
            this.Property(t => t.Nro__Despacho).HasColumnName("Nro. Despacho");
            this.Property(t => t.Nro__Liquidación).HasColumnName("Nro. Liquidación");
            this.Property(t => t.Nro__Despacho_Interno).HasColumnName("Nro. Despacho Interno");
            this.Property(t => t.Fecha).HasColumnName("Fecha");
            this.Property(t => t.Total_IVA).HasColumnName("Total IVA");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Importe_Descuentos).HasColumnName("Importe Descuentos");
            this.Property(t => t.Importe_Gastos).HasColumnName("Importe Gastos");
            this.Property(t => t.Importe_Honorarios).HasColumnName("Importe Honorarios");
            this.Property(t => t.Tipo).HasColumnName("Tipo");
            this.Property(t => t.Despachante).HasColumnName("Despachante");
            this.Property(t => t.Cliente).HasColumnName("Cliente");
            this.Property(t => t.Moneda).HasColumnName("Moneda");
            this.Property(t => t.Cod__Despachante).HasColumnName("Cod. Despachante");
            this.Property(t => t.Technology).HasColumnName("Technology");
            this.Property(t => t.Tipo_Movimiento).HasColumnName("Tipo Movimiento");
            this.Property(t => t.Cod__Liquidación).HasColumnName("Cod. Liquidación");
        }
    }
}
