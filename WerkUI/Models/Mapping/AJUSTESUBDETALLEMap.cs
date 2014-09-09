using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class AJUSTESUBDETALLEMap : EntityTypeConfiguration<AJUSTESUBDETALLE>
    {
        public AJUSTESUBDETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODAJUSTE, t.CODPRODUCTO, t.CODSUBDETALLE });

            // Properties
            this.Property(t => t.CODAJUSTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODSUBDETALLE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AJUSTESUBDETALLE");
            this.Property(t => t.CODAJUSTE).HasColumnName("CODAJUSTE");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODSUBDETALLE).HasColumnName("CODSUBDETALLE");
            this.Property(t => t.CODTPY).HasColumnName("CODTPY");
            this.Property(t => t.CODEQUIPO).HasColumnName("CODEQUIPO");
            this.Property(t => t.CODSIMCARD).HasColumnName("CODSIMCARD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.AJUSTEDETALLE)
                .WithMany(t => t.AJUSTESUBDETALLEs)
                .HasForeignKey(d => new { d.CODAJUSTE, d.CODPRODUCTO });
            this.HasOptional(t => t.EQUIPOSSTOCK)
                .WithMany(t => t.AJUSTESUBDETALLEs)
                .HasForeignKey(d => d.CODEQUIPO);
            this.HasOptional(t => t.SIMCCARDSTOCK)
                .WithMany(t => t.AJUSTESUBDETALLEs)
                .HasForeignKey(d => d.CODSIMCARD);
            this.HasOptional(t => t.TPYSTOCK)
                .WithMany(t => t.AJUSTESUBDETALLEs)
                .HasForeignKey(d => d.CODTPY);

        }
    }
}
