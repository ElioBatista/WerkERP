using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COMPRASRECEPCIONMap : EntityTypeConfiguration<COMPRASRECEPCION>
    {
        public COMPRASRECEPCIONMap()
        {
            // Primary Key
            this.HasKey(t => t.CODRECEPCION);

            // Properties
            this.Property(t => t.CODRECEPCION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COMPRASRECEPCION");
            this.Property(t => t.CODRECEPCION).HasColumnName("CODRECEPCION");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODPROVEEDOR).HasColumnName("CODPROVEEDOR");
            this.Property(t => t.NUMRECEPCION).HasColumnName("NUMRECEPCION");
            this.Property(t => t.FECHARECEPCION).HasColumnName("FECHARECEPCION");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasOptional(t => t.PROVEEDOR)
                .WithMany(t => t.COMPRASRECEPCIONs)
                .HasForeignKey(d => d.CODPROVEEDOR);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.COMPRASRECEPCIONs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.COMPRASRECEPCIONs)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.COMPRASRECEPCIONs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
