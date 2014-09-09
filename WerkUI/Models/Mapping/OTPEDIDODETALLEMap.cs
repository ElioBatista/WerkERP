using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class OTPEDIDODETALLEMap : EntityTypeConfiguration<OTPEDIDODETALLE>
    {
        public OTPEDIDODETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODOTPEDIDO, t.CODDETALLE });

            // Properties
            this.Property(t => t.CODOTPEDIDO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODDETALLE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OTPEDIDODETALLE");
            this.Property(t => t.CODOTPEDIDO).HasColumnName("CODOTPEDIDO");
            this.Property(t => t.CODDETALLE).HasColumnName("CODDETALLE");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.PRECIO).HasColumnName("PRECIO");
            this.Property(t => t.COSTOULTIMO).HasColumnName("COSTOULTIMO");
            this.Property(t => t.COSTOPP).HasColumnName("COSTOPP");
            this.Property(t => t.PORCENTAJEIVA).HasColumnName("PORCENTAJEIVA");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.CODMONEDAPRODUCTO).HasColumnName("CODMONEDAPRODUCTO");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.OTPEDIDODETALLEs)
                .HasForeignKey(d => d.CODMONEDAPRODUCTO);
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.OTPEDIDODETALLEs)
                .HasForeignKey(d => d.CODPRODUCTO);

        }
    }
}
