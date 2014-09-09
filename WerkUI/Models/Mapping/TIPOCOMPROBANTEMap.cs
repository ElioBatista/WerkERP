using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOCOMPROBANTEMap : EntityTypeConfiguration<TIPOCOMPROBANTE>
    {
        public TIPOCOMPROBANTEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCOMPROBANTE);

            // Properties
            this.Property(t => t.CODCOMPROBANTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPOCOMPRO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESCOMPROBANTE)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("TIPOCOMPROBANTE");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMTIPOCOMPRO).HasColumnName("NUMTIPOCOMPRO");
            this.Property(t => t.DESCOMPROBANTE).HasColumnName("DESCOMPROBANTE");
            this.Property(t => t.COMPRAS).HasColumnName("COMPRAS");
            this.Property(t => t.VENTAS).HasColumnName("VENTAS");
            this.Property(t => t.COBROS).HasColumnName("COBROS");
            this.Property(t => t.PAGOS).HasColumnName("PAGOS");
            this.Property(t => t.INVENTARIO).HasColumnName("INVENTARIO");
            this.Property(t => t.CONVENTAS).HasColumnName("CONVENTAS");
            this.Property(t => t.CONCOMPRAS).HasColumnName("CONCOMPRAS");
            this.Property(t => t.NCREDITO).HasColumnName("NCREDITO");
            this.Property(t => t.NDEBITO).HasColumnName("NDEBITO");
            this.Property(t => t.OTROS).HasColumnName("OTROS");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.TIPOCOMPROBANTEs)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOCOMPROBANTEs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
