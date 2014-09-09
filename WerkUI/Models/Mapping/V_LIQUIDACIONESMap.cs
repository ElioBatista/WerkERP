using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class V_LIQUIDACIONESMap : EntityTypeConfiguration<V_LIQUIDACIONES>
    {
        public V_LIQUIDACIONESMap()
        {
            // Primary Key
            this.HasKey(t => t.Cod__Liquidación);

            // Properties
            this.Property(t => t.Cod__Liquidación)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nro__Despacho)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.Nro__Despacho_Interno)
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.Usuario)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.Empresa)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.Cliente)
                .HasMaxLength(80);

            this.Property(t => t.Dirección)
                .IsFixedLength()
                .HasMaxLength(80);

            this.Property(t => t.Teléfono)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.R_U_C_)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.Despachante)
                .HasMaxLength(82);

            this.Property(t => t.R_U_C__Despachante)
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("V_LIQUIDACIONES");
            this.Property(t => t.Cod__Liquidación).HasColumnName("Cod. Liquidación");
            this.Property(t => t.Nro__Liquidación).HasColumnName("Nro. Liquidación");
            this.Property(t => t.Nro__Despacho).HasColumnName("Nro. Despacho");
            this.Property(t => t.Nro__Despacho_Interno).HasColumnName("Nro. Despacho Interno");
            this.Property(t => t.Fecha).HasColumnName("Fecha");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Usuario).HasColumnName("Usuario");
            this.Property(t => t.Empresa).HasColumnName("Empresa");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
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
            this.Property(t => t.CODDESPACHANTE).HasColumnName("CODDESPACHANTE");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CodEmpresa).HasColumnName("CodEmpresa");
        }
    }
}
