using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class V_ORDEN_PAGO_DETALLESMap : EntityTypeConfiguration<V_ORDEN_PAGO_DETALLES>
    {
        public V_ORDEN_PAGO_DETALLESMap()
        {
            // Primary Key
            this.HasKey(t => t.CODORDENPAGOCLIENTE);

            // Properties
            this.Property(t => t.CODORDENPAGOCLIENTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMDESPACHOINTERNO)
                .IsFixedLength()
                .HasMaxLength(9);

            this.Property(t => t.NOMBRE)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.APELLIDO)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.DESTIPOPAGO)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.DESPROPOSITO)
                .IsFixedLength()
                .HasMaxLength(60);

            this.Property(t => t.OBSERVACION)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("V_ORDEN_PAGO_DETALLES");
            this.Property(t => t.CODORDENPAGOCLIENTE).HasColumnName("CODORDENPAGOCLIENTE");
            this.Property(t => t.NUMDESPACHOINTERNO).HasColumnName("NUMDESPACHOINTERNO");
            this.Property(t => t.NOMBRE).HasColumnName("NOMBRE");
            this.Property(t => t.APELLIDO).HasColumnName("APELLIDO");
            this.Property(t => t.DESTIPOPAGO).HasColumnName("DESTIPOPAGO");
            this.Property(t => t.DESPROPOSITO).HasColumnName("DESPROPOSITO");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.FECHAPRESENTACION).HasColumnName("FECHAPRESENTACION");
            this.Property(t => t.FECHARETIRO).HasColumnName("FECHARETIRO");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");
        }
    }
}
