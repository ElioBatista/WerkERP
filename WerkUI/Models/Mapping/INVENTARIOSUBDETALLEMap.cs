using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class INVENTARIOSUBDETALLEMap : EntityTypeConfiguration<INVENTARIOSUBDETALLE>
    {
        public INVENTARIOSUBDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODPRODUCTO, t.CODINVENTARIO, t.CODSUBDETALLE });

            // Properties
            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODINVENTARIO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODSUBDETALLE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("INVENTARIOSUBDETALLE");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODINVENTARIO).HasColumnName("CODINVENTARIO");
            this.Property(t => t.CODSUBDETALLE).HasColumnName("CODSUBDETALLE");
            this.Property(t => t.CODEQUIPO).HasColumnName("CODEQUIPO");
            this.Property(t => t.CODTPY).HasColumnName("CODTPY");
            this.Property(t => t.CODSIMCARD).HasColumnName("CODSIMCARD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.EQUIPOSSTOCK)
                .WithMany(t => t.INVENTARIOSUBDETALLEs)
                .HasForeignKey(d => d.CODEQUIPO);
            this.HasRequired(t => t.INVENTARIODETALLE)
                .WithMany(t => t.INVENTARIOSUBDETALLEs)
                .HasForeignKey(d => new { d.CODPRODUCTO, d.CODINVENTARIO });
            this.HasOptional(t => t.SIMCCARDSTOCK)
                .WithMany(t => t.INVENTARIOSUBDETALLEs)
                .HasForeignKey(d => d.CODSIMCARD);
            this.HasOptional(t => t.TPYSTOCK)
                .WithMany(t => t.INVENTARIOSUBDETALLEs)
                .HasForeignKey(d => d.CODTPY);

        }
    }
}
