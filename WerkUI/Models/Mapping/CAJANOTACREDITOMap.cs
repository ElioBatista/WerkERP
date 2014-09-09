using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CAJANOTACREDITOMap : EntityTypeConfiguration<CAJANOTACREDITO>
    {
        public CAJANOTACREDITOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODFORMACOBRO, t.CODINGRESO, t.CODCOMPROBANTE, t.NUMNOTACREDITO });

            // Properties
            this.Property(t => t.CODFORMACOBRO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODINGRESO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOMPROBANTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMNOTACREDITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CAJANOTACREDITO");
            this.Property(t => t.CODFORMACOBRO).HasColumnName("CODFORMACOBRO");
            this.Property(t => t.CODINGRESO).HasColumnName("CODINGRESO");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODDEVOLUCION).HasColumnName("CODDEVOLUCION");
            this.Property(t => t.NUMNOTACREDITO).HasColumnName("NUMNOTACREDITO");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");

            // Relationships
            this.HasRequired(t => t.CAJAFORMACOBRO)
                .WithMany(t => t.CAJANOTACREDITOes)
                .HasForeignKey(d => new { d.CODFORMACOBRO, d.CODINGRESO });
            this.HasRequired(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.CAJANOTACREDITOes)
                .HasForeignKey(d => d.CODCOMPROBANTE);

        }
    }
}
