using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CUPONEMap : EntityTypeConfiguration<CUPONE>
    {
        public CUPONEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODCUPON, t.CODEMPRESA, t.CODEMISORA });

            // Properties
            this.Property(t => t.CODCUPON)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODEMISORA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CUPONES");
            this.Property(t => t.CODCUPON).HasColumnName("CODCUPON");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODEMISORA).HasColumnName("CODEMISORA");
            this.Property(t => t.CODESTADOCUPON).HasColumnName("CODESTADOCUPON");
            this.Property(t => t.FECREC).HasColumnName("FECREC");
            this.Property(t => t.NUMCUOTA).HasColumnName("NUMCUOTA");
            this.Property(t => t.CANCUOTA).HasColumnName("CANCUOTA");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.EMISORA)
                .WithMany(t => t.CUPONES)
                .HasForeignKey(d => d.CODEMISORA);
            this.HasOptional(t => t.ESTADOCUPON)
                .WithMany(t => t.CUPONES)
                .HasForeignKey(d => d.CODESTADOCUPON);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.CUPONES)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.CUPONES)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CUPONES)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
