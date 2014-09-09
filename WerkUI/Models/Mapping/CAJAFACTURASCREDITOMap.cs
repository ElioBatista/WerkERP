using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CAJAFACTURASCREDITOMap : EntityTypeConfiguration<CAJAFACTURASCREDITO>
    {
        public CAJAFACTURASCREDITOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODFACTURACREDITO);

            // Properties
            // Table & Column Mappings
            this.ToTable("CAJAFACTURASCREDITO");
            this.Property(t => t.CODFACTURACREDITO).HasColumnName("CODFACTURACREDITO");
            this.Property(t => t.CODINGRESO).HasColumnName("CODINGRESO");
            this.Property(t => t.CODCOBRANZA).HasColumnName("CODCOBRANZA");
            this.Property(t => t.MON_CODMONEDA).HasColumnName("MON_CODMONEDA");
            this.Property(t => t.CODFORCOBRO).HasColumnName("CODFORCOBRO");

            // Relationships
            this.HasOptional(t => t.CAJAINGRESO)
                .WithMany(t => t.CAJAFACTURASCREDITOes)
                .HasForeignKey(d => d.CODINGRESO);
            this.HasOptional(t => t.COBRANZA)
                .WithMany(t => t.CAJAFACTURASCREDITOes)
                .HasForeignKey(d => new { d.CODCOBRANZA, d.MON_CODMONEDA, d.CODFORCOBRO });

        }
    }
}
