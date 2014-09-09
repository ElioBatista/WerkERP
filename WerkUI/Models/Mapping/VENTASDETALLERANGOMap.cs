using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class VENTASDETALLERANGOMap : EntityTypeConfiguration<VENTASDETALLERANGO>
    {
        public VENTASDETALLERANGOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODRANGO);

            // Properties
            this.Property(t => t.CODRANGO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RANGO1)
                .HasMaxLength(25);

            this.Property(t => t.RANGO2)
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("VENTASDETALLERANGOS");
            this.Property(t => t.CODRANGO).HasColumnName("CODRANGO");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.RANGO1).HasColumnName("RANGO1");
            this.Property(t => t.RANGO2).HasColumnName("RANGO2");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");
        }
    }
}
