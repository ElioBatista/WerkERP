using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class OTPEDIDOCABECERAMap : EntityTypeConfiguration<OTPEDIDOCABECERA>
    {
        public OTPEDIDOCABECERAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODOTPEDIDO);

            // Properties
            this.Property(t => t.CODOTPEDIDO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OTPEDIDOCABECERA");
            this.Property(t => t.CODOTPEDIDO).HasColumnName("CODOTPEDIDO");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODTECNICO).HasColumnName("CODTECNICO");
            this.Property(t => t.CODOT).HasColumnName("CODOT");
            this.Property(t => t.FECHAMOV).HasColumnName("FECHAMOV");
            this.Property(t => t.NUMOTPEDIDO).HasColumnName("NUMOTPEDIDO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.OTPEDIDOCABECERAs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.OTCABECERA)
                .WithMany(t => t.OTPEDIDOCABECERAs)
                .HasForeignKey(d => d.CODOT);
            this.HasOptional(t => t.OTCABECERA1)
                .WithMany(t => t.OTPEDIDOCABECERAs1)
                .HasForeignKey(d => d.CODOT);
            this.HasOptional(t => t.OTTECNICO)
                .WithMany(t => t.OTPEDIDOCABECERAs)
                .HasForeignKey(d => d.CODTECNICO);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.OTPEDIDOCABECERAs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.OTPEDIDOCABECERAs)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.OTPEDIDOCABECERAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
