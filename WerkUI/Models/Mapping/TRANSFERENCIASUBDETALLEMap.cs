using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TRANSFERENCIASUBDETALLEMap : EntityTypeConfiguration<TRANSFERENCIASUBDETALLE>
    {
        public TRANSFERENCIASUBDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODTRANSFERENCIA, t.CODPRODUCTO, t.CODSUBDETALLE });

            // Properties
            this.Property(t => t.CODTRANSFERENCIA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODSUBDETALLE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("TRANSFERENCIASUBDETALLE");
            this.Property(t => t.CODTRANSFERENCIA).HasColumnName("CODTRANSFERENCIA");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODSUBDETALLE).HasColumnName("CODSUBDETALLE");
            this.Property(t => t.CODTPY).HasColumnName("CODTPY");
            this.Property(t => t.CODEQUIPO).HasColumnName("CODEQUIPO");
            this.Property(t => t.CODSIMCARD).HasColumnName("CODSIMCARD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.EQUIPOSSTOCK)
                .WithMany(t => t.TRANSFERENCIASUBDETALLEs)
                .HasForeignKey(d => d.CODEQUIPO);
            this.HasOptional(t => t.SIMCCARDSTOCK)
                .WithMany(t => t.TRANSFERENCIASUBDETALLEs)
                .HasForeignKey(d => d.CODSIMCARD);
            this.HasOptional(t => t.TPYSTOCK)
                .WithMany(t => t.TRANSFERENCIASUBDETALLEs)
                .HasForeignKey(d => d.CODTPY);
            this.HasRequired(t => t.TRANSFERENCIASDETALLE)
                .WithMany(t => t.TRANSFERENCIASUBDETALLEs)
                .HasForeignKey(d => new { d.CODTRANSFERENCIA, d.CODPRODUCTO });

        }
    }
}
