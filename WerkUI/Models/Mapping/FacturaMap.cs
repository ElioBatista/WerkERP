using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class FacturaMap : EntityTypeConfiguration<Factura>
    {
        public FacturaMap()
        {
            // Primary Key
            this.HasKey(t => t.cod_factura);

            // Properties
            this.Property(t => t.Nro__Factura)
                .HasMaxLength(128);

            this.Property(t => t.Nro__Despacho)
                .HasMaxLength(128);

            this.Property(t => t.Usuario)
                .HasMaxLength(128);

            this.Property(t => t.Empresa)
                .HasMaxLength(128);

            this.Property(t => t.Estado)
                .HasMaxLength(50);

            this.Property(t => t.Cliente)
                .HasMaxLength(128);

            this.Property(t => t.Dirección)
                .HasMaxLength(128);

            this.Property(t => t.Teléfono)
                .HasMaxLength(128);

            this.Property(t => t.R_U_C_)
                .HasMaxLength(128);

            this.Property(t => t.Despachante)
                .HasMaxLength(128);

            this.Property(t => t.R_U_C__Despachante)
                .HasMaxLength(128);

            this.Property(t => t.Tipo_Factura)
                .HasMaxLength(50);

            this.Property(t => t.Timbrado)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Facturas", "Facturacion");
            this.Property(t => t.cod_factura).HasColumnName("cod_factura");
            this.Property(t => t.Nro__Factura).HasColumnName("Nro. Factura");
            this.Property(t => t.Cod__Liquidación).HasColumnName("Cod. Liquidación");
            this.Property(t => t.Nro__Liquidación).HasColumnName("Nro. Liquidación");
            this.Property(t => t.Nro__Despacho).HasColumnName("Nro. Despacho");
            this.Property(t => t.Nro__Despacho_Interno).HasColumnName("Nro. Despacho Interno");
            this.Property(t => t.Fecha).HasColumnName("Fecha");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Usuario).HasColumnName("Usuario");
            this.Property(t => t.Empresa).HasColumnName("Empresa");
            this.Property(t => t.CodEmpresa).HasColumnName("CodEmpresa");
            this.Property(t => t.Estado).HasColumnName("Estado");
            this.Property(t => t.Cierre).HasColumnName("Cierre");
            this.Property(t => t.IVA_Gastos).HasColumnName("IVA Gastos");
            this.Property(t => t.IVA_Honorarios).HasColumnName("IVA Honorarios");
            this.Property(t => t.IVA_Retención).HasColumnName("IVA Retención");
            this.Property(t => t.IVA_Ret__Gastos).HasColumnName("IVA Ret. Gastos");
            this.Property(t => t.IVA_Ret__Honorarios).HasColumnName("IVA Ret. Honorarios");
            this.Property(t => t.Cliente).HasColumnName("Cliente");
            this.Property(t => t.Dirección).HasColumnName("Dirección");
            this.Property(t => t.Teléfono).HasColumnName("Teléfono");
            this.Property(t => t.R_U_C_).HasColumnName("R.U.C.");
            this.Property(t => t.Despachante).HasColumnName("Despachante");
            this.Property(t => t.R_U_C__Despachante).HasColumnName("R.U.C. Despachante");
            this.Property(t => t.Cod__Despachante).HasColumnName("Cod. Despachante");
            this.Property(t => t.Tipo_Factura).HasColumnName("Tipo Factura");
            this.Property(t => t.cod_moneda).HasColumnName("cod_moneda");
            this.Property(t => t.Importe_Gastos).HasColumnName("Importe Gastos");
            this.Property(t => t.Importe_Honorarios).HasColumnName("Importe Honorarios");
            this.Property(t => t.Importe_Descuentos).HasColumnName("Importe Descuentos");
            this.Property(t => t.Total_IVA).HasColumnName("Total IVA");
            this.Property(t => t.Timbrado).HasColumnName("Timbrado");
        }
    }
}
