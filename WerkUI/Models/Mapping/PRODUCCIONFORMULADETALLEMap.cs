using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PRODUCCIONFORMULADETALLEMap : EntityTypeConfiguration<PRODUCCIONFORMULADETALLE>
    {
        public PRODUCCIONFORMULADETALLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODFORMULA, t.CODLINEA });

            // Properties
            this.Property(t => t.CODFORMULA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODLINEA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PRODUCCIONFORMULADETALLE");
            this.Property(t => t.CODFORMULA).HasColumnName("CODFORMULA");
            this.Property(t => t.CODLINEA).HasColumnName("CODLINEA");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.CODMEDIDA).HasColumnName("CODMEDIDA");

            // Relationships
            this.HasRequired(t => t.PRODUCCIONFORMULA)
                .WithMany(t => t.PRODUCCIONFORMULADETALLEs)
                .HasForeignKey(d => d.CODFORMULA);
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.PRODUCCIONFORMULADETALLEs)
                .HasForeignKey(d => d.CODPRODUCTO);
            this.HasOptional(t => t.UNIDADMEDIDA)
                .WithMany(t => t.PRODUCCIONFORMULADETALLEs)
                .HasForeignKey(d => d.CODMEDIDA);

        }
    }
}
