using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class VENTASSUBDETALLEMap : EntityTypeConfiguration<VENTASSUBDETALLE>
    {
        public VENTASSUBDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODVENTA, t.CODPRODUCTO, t.CODSUBDETALLE });

            // Properties
            this.Property(t => t.CODVENTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODSUBDETALLE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("VENTASSUBDETALLE");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODSUBDETALLE).HasColumnName("CODSUBDETALLE");
            this.Property(t => t.CODTPY).HasColumnName("CODTPY");
            this.Property(t => t.CODSIMCARD).HasColumnName("CODSIMCARD");
            this.Property(t => t.CODEQUIPO).HasColumnName("CODEQUIPO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.EQUIPOSSTOCK)
                .WithMany(t => t.VENTASSUBDETALLEs)
                .HasForeignKey(d => d.CODEQUIPO);
            this.HasOptional(t => t.SIMCCARDSTOCK)
                .WithMany(t => t.VENTASSUBDETALLEs)
                .HasForeignKey(d => d.CODSIMCARD);
            this.HasOptional(t => t.TPYSTOCK)
                .WithMany(t => t.VENTASSUBDETALLEs)
                .HasForeignKey(d => d.CODTPY);

        }
    }
}
