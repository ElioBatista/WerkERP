using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TARJETAMap : EntityTypeConfiguration<TARJETA>
    {
        public TARJETAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODCOBRANZA, t.CODMONEDA, t.CODFORCOBRO, t.CODTARJETA, t.NUMTARJETA });

            // Properties
            this.Property(t => t.CODCOBRANZA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODMONEDA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODFORCOBRO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODTARJETA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTARJETA)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("TARJETA");
            this.Property(t => t.CODCOBRANZA).HasColumnName("CODCOBRANZA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODFORCOBRO).HasColumnName("CODFORCOBRO");
            this.Property(t => t.CODTARJETA).HasColumnName("CODTARJETA");
            this.Property(t => t.NUMTARJETA).HasColumnName("NUMTARJETA");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.CODMONEDATAR).HasColumnName("CODMONEDATAR");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");

            // Relationships
            this.HasRequired(t => t.COBRANZA)
                .WithMany(t => t.TARJETAs)
                .HasForeignKey(d => new { d.CODCOBRANZA, d.CODMONEDA, d.CODFORCOBRO });
            this.HasRequired(t => t.MONEDA)
                .WithMany(t => t.TARJETAs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasRequired(t => t.TIPOTARJETA)
                .WithMany(t => t.TARJETAs)
                .HasForeignKey(d => d.CODTARJETA);

        }
    }
}
