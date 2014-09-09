using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class NOTACREDITOMap : EntityTypeConfiguration<NOTACREDITO>
    {
        public NOTACREDITOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODCOBRANZA, t.CODMONEDA, t.CODFORCOBRO, t.CODCOMPROBANTE, t.NUMNOTACREDITO });

            // Properties
            this.Property(t => t.CODCOBRANZA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODMONEDA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODFORCOBRO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOMPROBANTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMNOTACREDITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("NOTACREDITO");
            this.Property(t => t.CODCOBRANZA).HasColumnName("CODCOBRANZA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODFORCOBRO).HasColumnName("CODFORCOBRO");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.NUMNOTACREDITO).HasColumnName("NUMNOTACREDITO");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.CODMONEDANC).HasColumnName("CODMONEDANC");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.CODDEVOLUCION).HasColumnName("CODDEVOLUCION");

            // Relationships
            this.HasRequired(t => t.COBRANZA)
                .WithMany(t => t.NOTACREDITOes)
                .HasForeignKey(d => new { d.CODCOBRANZA, d.CODMONEDA, d.CODFORCOBRO });
            this.HasRequired(t => t.MONEDA)
                .WithMany(t => t.NOTACREDITOes)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasRequired(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.NOTACREDITOes)
                .HasForeignKey(d => d.CODCOMPROBANTE);

        }
    }
}
