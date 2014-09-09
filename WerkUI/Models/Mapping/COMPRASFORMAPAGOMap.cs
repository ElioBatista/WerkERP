using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COMPRASFORMAPAGOMap : EntityTypeConfiguration<COMPRASFORMAPAGO>
    {
        public COMPRASFORMAPAGOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPAGO, t.CODCOMPRA });

            // Properties
            this.Property(t => t.CODPAGO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOMPRA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COMPRASFORMAPAGO");
            this.Property(t => t.CODPAGO).HasColumnName("CODPAGO");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODTIPOPAGO).HasColumnName("CODTIPOPAGO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");

            // Relationships
            this.HasRequired(t => t.COMPRA)
                .WithMany(t => t.COMPRASFORMAPAGOes)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.COMPRASFORMAPAGOes)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasRequired(t => t.TIPOPAGO)
                .WithMany(t => t.COMPRASFORMAPAGOes)
                .HasForeignKey(d => d.CODTIPOPAGO);

        }
    }
}
