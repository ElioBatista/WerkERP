using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class AJUSTEMap : EntityTypeConfiguration<AJUSTE>
    {
        public AJUSTEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODAJUSTE);

            // Properties
            this.Property(t => t.CODAJUSTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMAJUSTE)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("AJUSTE");
            this.Property(t => t.CODAJUSTE).HasColumnName("CODAJUSTE");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODCONCEPTO).HasColumnName("CODCONCEPTO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.NUMAJUSTE).HasColumnName("NUMAJUSTE");
            this.Property(t => t.FECHAAJUSTE).HasColumnName("FECHAAJUSTE");
            this.Property(t => t.TIPOAJUSTE).HasColumnName("TIPOAJUSTE");
            this.Property(t => t.TOTALCOSTOAJUSTE).HasColumnName("TOTALCOSTOAJUSTE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.AJUSTEs)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.CONCEPTO)
                .WithMany(t => t.AJUSTEs)
                .HasForeignKey(d => d.CODCONCEPTO);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.AJUSTEs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.AJUSTEs)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.AJUSTEs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
