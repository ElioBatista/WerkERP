using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PAGAREMap : EntityTypeConfiguration<PAGARE>
    {
        public PAGAREMap()
        {
            // Primary Key
            this.HasKey(t => t.CODPAGARE);

            // Properties
            this.Property(t => t.CODPAGARE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESPAGARE)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("PAGARE");
            this.Property(t => t.CODPAGARE).HasColumnName("CODPAGARE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODCLIENTE).HasColumnName("CODCLIENTE");
            this.Property(t => t.NUMPAGARE).HasColumnName("NUMPAGARE");
            this.Property(t => t.DESPAGARE).HasColumnName("DESPAGARE");
            this.Property(t => t.FECHAEMISION).HasColumnName("FECHAEMISION");
            this.Property(t => t.FECHAVCTO).HasColumnName("FECHAVCTO");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.SALDOPAGARE).HasColumnName("SALDOPAGARE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODOPERACION).HasColumnName("CODOPERACION");

            // Relationships
            this.HasOptional(t => t.CLIENTE)
                .WithMany(t => t.PAGAREs)
                .HasForeignKey(d => d.CODCLIENTE);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.PAGAREs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.PAGAREs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.PAGAREs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.PAGAREs)
                .HasForeignKey(d => d.CODCOMPROBANTE);

        }
    }
}
