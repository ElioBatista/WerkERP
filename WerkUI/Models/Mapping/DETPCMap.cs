using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DETPCMap : EntityTypeConfiguration<DETPC>
    {
        public DETPCMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IP, t.CODEMPRESA, t.CODSUCURSAL, t.CODCOMPROBANTE });

            // Properties
            this.Property(t => t.IP)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODSUCURSAL)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOMPROBANTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IMPRESORA)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("DETPC");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.RANGO1).HasColumnName("RANGO1");
            this.Property(t => t.RANGO2).HasColumnName("RANGO2");
            this.Property(t => t.ULTIMO).HasColumnName("ULTIMO");
            this.Property(t => t.IMPRESORA).HasColumnName("IMPRESORA");
            this.Property(t => t.USUDESCUENTO).HasColumnName("USUDESCUENTO");
            this.Property(t => t.DESCUENTO).HasColumnName("DESCUENTO");
            this.Property(t => t.TOTALDESCUENTO).HasColumnName("TOTALDESCUENTO");
            this.Property(t => t.ACTIVO).HasColumnName("ACTIVO");

            // Relationships
            this.HasRequired(t => t.PC)
                .WithMany(t => t.DETPCs)
                .HasForeignKey(d => new { d.IP, d.CODEMPRESA, d.CODSUCURSAL });
            this.HasRequired(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.DETPCs)
                .HasForeignKey(d => d.CODCOMPROBANTE);

        }
    }
}
