using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CAJAFORMACOBROMap : EntityTypeConfiguration<CAJAFORMACOBRO>
    {
        public CAJAFORMACOBROMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODFORMACOBRO, t.CODINGRESO });

            // Properties
            this.Property(t => t.CODFORMACOBRO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODINGRESO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CAJAFORMACOBRO");
            this.Property(t => t.CODFORMACOBRO).HasColumnName("CODFORMACOBRO");
            this.Property(t => t.CODINGRESO).HasColumnName("CODINGRESO");
            this.Property(t => t.CODFORCOBRO).HasColumnName("CODFORCOBRO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");

            // Relationships
            this.HasRequired(t => t.CAJAINGRESO)
                .WithMany(t => t.CAJAFORMACOBROes)
                .HasForeignKey(d => d.CODINGRESO);
            this.HasRequired(t => t.MONEDA)
                .WithMany(t => t.CAJAFORMACOBROes)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasRequired(t => t.TIPOFORMACOBRO)
                .WithMany(t => t.CAJAFORMACOBROes)
                .HasForeignKey(d => d.CODFORCOBRO);

        }
    }
}
