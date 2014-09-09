using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class COMPRASORDENCOMPRAMap : EntityTypeConfiguration<COMPRASORDENCOMPRA>
    {
        public COMPRASORDENCOMPRAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODDETORDEN);

            // Properties
            this.Property(t => t.CODDETORDEN)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("COMPRASORDENCOMPRA");
            this.Property(t => t.CODDETORDEN).HasColumnName("CODDETORDEN");
            this.Property(t => t.CODORDENCOMPRA).HasColumnName("CODORDENCOMPRA");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.CODPRODUCTO).HasColumnName("CODPRODUCTO");
            this.Property(t => t.CANTIDAD).HasColumnName("CANTIDAD");

            // Relationships
            this.HasOptional(t => t.COMPRA)
                .WithMany(t => t.COMPRASORDENCOMPRAs)
                .HasForeignKey(d => d.CODCOMPRA);
            this.HasOptional(t => t.ORDENCOMPRA)
                .WithMany(t => t.COMPRASORDENCOMPRAs)
                .HasForeignKey(d => d.CODORDENCOMPRA);
            this.HasOptional(t => t.PRODUCTO)
                .WithMany(t => t.COMPRASORDENCOMPRAs)
                .HasForeignKey(d => d.CODPRODUCTO);

        }
    }
}
