using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TRANSFERENCIASDETALLEMap : EntityTypeConfiguration<TRANSFERENCIASDETALLE>
    {
        public TRANSFERENCIASDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODTRANSFERENCIA, t.CODPRODUCTO });

            // Properties
            this.Property(t => t.CODTRANSFERENCIA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TRANSFERENCIASDETALLE");
            this.Property(t => t.CODTRANSFERENCIA).HasColumnName("CODTRANSFERENCIA");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CANTIDADTRANFERENCIA).HasColumnName("CANTIDADTRANFERENCIA");
            this.Property(t => t.COSTOPROMEDIO).HasColumnName("COSTOPROMEDIO");
            this.Property(t => t.COSTOULTIMO).HasColumnName("COSTOULTIMO");
            this.Property(t => t.LINEANUMERO).HasColumnName("LINEANUMERO");

            // Relationships
            this.HasRequired(t => t.PRODUCTO)
                .WithMany(t => t.TRANSFERENCIASDETALLEs)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasRequired(t => t.TRANFERENCIA)
                .WithMany(t => t.TRANSFERENCIASDETALLEs)
                .HasForeignKey(d => d.CODTRANSFERENCIA);

        }
    }
}
