using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class PRODUCCIONINGRESOPRODUCTODETMap : EntityTypeConfiguration<PRODUCCIONINGRESOPRODUCTODET>
    {
        public PRODUCCIONINGRESOPRODUCTODETMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODINGRESOPROTER, t.CODLINEA });

            // Properties
            this.Property(t => t.CODINGRESOPROTER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODLINEA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PRODUCCIONINGRESOPRODUCTODET");
            this.Property(t => t.CODINGRESOPROTER).HasColumnName("CODINGRESOPROTER");
            this.Property(t => t.CODLINEA).HasColumnName("CODLINEA");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CODORDENPRODUCCION).HasColumnName("CODORDENPRODUCCION");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
            this.Property(t => t.COSTO).HasColumnName("COSTO");

            // Relationships
            this.HasRequired(t => t.PRODUCCIONINGRESOPRODUCTO)
                .WithMany(t => t.PRODUCCIONINGRESOPRODUCTODETs)
                .HasForeignKey(d => d.CODINGRESOPROTER);
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.PRODUCCIONINGRESOPRODUCTODETs)
                .HasForeignKey(d => d.CODPRODUCTO);

        }
    }
}
