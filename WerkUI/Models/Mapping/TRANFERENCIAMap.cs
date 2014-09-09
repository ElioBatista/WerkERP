using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TRANFERENCIAMap : EntityTypeConfiguration<TRANFERENCIA>
    {
        public TRANFERENCIAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTRANSFERENCIA);

            // Properties
            this.Property(t => t.CODTRANSFERENCIA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTRANSFERENCIA)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("TRANFERENCIA");
            this.Property(t => t.CODTRANSFERENCIA).HasColumnName("CODTRANSFERENCIA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.NUMTRANSFERENCIA).HasColumnName("NUMTRANSFERENCIA");
            this.Property(t => t.FECHATRANSFERENCIA).HasColumnName("FECHATRANSFERENCIA");
            this.Property(t => t.SUCURSALDESTINO).HasColumnName("SUCURSALDESTINO");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.ASR).HasColumnName("ASR");

            // Relationships
            this.HasMany(t => t.VENTAS)
                .WithMany(t => t.TRANFERENCIAs)
                .Map(m =>
                    {
                        m.ToTable("VENTASASR");
                        m.MapLeftKey("CODTRANSFERENCIA");
                        m.MapRightKey("CODVENTA");
                    });

            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.TRANFERENCIAs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.TRANFERENCIAs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.TRANFERENCIAs)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TRANFERENCIAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
