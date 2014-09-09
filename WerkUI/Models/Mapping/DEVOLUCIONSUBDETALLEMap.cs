using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DEVOLUCIONSUBDETALLEMap : EntityTypeConfiguration<DEVOLUCIONSUBDETALLE>
    {
        public DEVOLUCIONSUBDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODDEVOLUCION, t.CODPRODUCTO, t.CODSUBDETALLE });

            // Properties
            this.Property(t => t.CODDEVOLUCION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODSUBDETALLE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DEVOLUCIONSUBDETALLE");
            this.Property(t => t.CODDEVOLUCION).HasColumnName("CODDEVOLUCION");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODSUBDETALLE).HasColumnName("CODSUBDETALLE");
            this.Property(t => t.CODTPY).HasColumnName("CODTPY");
            this.Property(t => t.CODEQUIPO).HasColumnName("CODEQUIPO");
            this.Property(t => t.CODSIMCARD).HasColumnName("CODSIMCARD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.EQUIPOSSTOCK)
                .WithMany(t => t.DEVOLUCIONSUBDETALLEs)
                .HasForeignKey(d => d.CODEQUIPO);
            this.HasOptional(t => t.SIMCCARDSTOCK)
                .WithMany(t => t.DEVOLUCIONSUBDETALLEs)
                .HasForeignKey(d => d.CODSIMCARD);
            this.HasOptional(t => t.TPYSTOCK)
                .WithMany(t => t.DEVOLUCIONSUBDETALLEs)
                .HasForeignKey(d => d.CODTPY);

        }
    }
}
