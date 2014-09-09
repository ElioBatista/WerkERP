using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class MOVIASIENTOMOVIMap : EntityTypeConfiguration<MOVIASIENTOMOVI>
    {
        public MOVIASIENTOMOVIMap()
        {
            // Primary Key
            this.HasKey(t => t.CODMOVIMIENTO);

            // Properties
            // Table & Column Mappings
            this.ToTable("MOVIASIENTOMOVI");
            this.Property(t => t.CODMOVIMIENTO).HasColumnName("CODMOVIMIENTO");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.CODCOBRANZA).HasColumnName("CODCOBRANZA");
            this.Property(t => t.CODMONEDACOB).HasColumnName("CODMONEDACOB");
            this.Property(t => t.CODFORCOBRO).HasColumnName("CODFORCOBRO");
            this.Property(t => t.CODPAGANZAS).HasColumnName("CODPAGANZAS");
            this.Property(t => t.CODMONEDAPAG).HasColumnName("CODMONEDAPAG");
            this.Property(t => t.CODTIPOPAGO).HasColumnName("CODTIPOPAGO");
            this.Property(t => t.CODDEBITO).HasColumnName("CODDEBITO");
            this.Property(t => t.CODCREDITO).HasColumnName("CODCREDITO");
            this.Property(t => t.CODDEVOLUCION).HasColumnName("CODDEVOLUCION");
            this.Property(t => t.CODTRANSFERENCIA).HasColumnName("CODTRANSFERENCIA");
            this.Property(t => t.CODAJUSTE).HasColumnName("CODAJUSTE");
            this.Property(t => t.CODASIENTO).HasColumnName("CODASIENTO");
            this.Property(t => t.NROORDEN).HasColumnName("NROORDEN");
            this.Property(t => t.CODEMPRESAORD).HasColumnName("CODEMPRESAORD");

            // Relationships
            this.HasOptional(t => t.AJUSTE)
                .WithMany(t => t.MOVIASIENTOMOVIs)
                .HasForeignKey(d => d.CODAJUSTE);
            this.HasOptional(t => t.COBRANZA)
                .WithMany(t => t.MOVIASIENTOMOVIs)
                .HasForeignKey(d => new { d.CODCOBRANZA, d.CODMONEDACOB, d.CODFORCOBRO });
            this.HasOptional(t => t.COMPRA)
                .WithMany(t => t.MOVIASIENTOMOVIs)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.CREDITO)
                .WithMany(t => t.MOVIASIENTOMOVIs)
                .HasForeignKey(d => d.CODCREDITO);
            this.HasOptional(t => t.DEBITO)
                .WithMany(t => t.MOVIASIENTOMOVIs)
                .HasForeignKey(d => d.CODDEBITO);
            this.HasOptional(t => t.MOVIASIENTO)
                .WithMany(t => t.MOVIASIENTOMOVIs)
                .HasForeignKey(d => d.CODASIENTO);
            this.HasOptional(t => t.PAGANZA)
                .WithMany(t => t.MOVIASIENTOMOVIs)
                .HasForeignKey(d => new { d.CODPAGANZAS, d.CODTIPOPAGO, d.CODMONEDAPAG });
            this.HasOptional(t => t.TRANFERENCIA)
                .WithMany(t => t.MOVIASIENTOMOVIs)
                .HasForeignKey(d => d.CODTRANSFERENCIA);
            this.HasOptional(t => t.VENTA)
                .WithMany(t => t.MOVIASIENTOMOVIs)
                .HasForeignKey(d => d.CODVENTA);

        }
    }
}
