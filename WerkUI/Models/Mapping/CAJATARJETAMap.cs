using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CAJATARJETAMap : EntityTypeConfiguration<CAJATARJETA>
    {
        public CAJATARJETAMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODFORMACOBRO, t.CODINGRESO, t.CODTARJETA, t.NUMTARJETA });

            // Properties
            this.Property(t => t.CODFORMACOBRO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODINGRESO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODTARJETA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTARJETA)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("CAJATARJETAS");
            this.Property(t => t.CODFORMACOBRO).HasColumnName("CODFORMACOBRO");
            this.Property(t => t.CODINGRESO).HasColumnName("CODINGRESO");
            this.Property(t => t.CODTARJETA).HasColumnName("CODTARJETA");
            this.Property(t => t.NUMTARJETA).HasColumnName("NUMTARJETA");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.ESTADO).HasColumnName("ESTADO");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");

            // Relationships
            this.HasRequired(t => t.CAJAFORMACOBRO)
                .WithMany(t => t.CAJATARJETAS)
                .HasForeignKey(d => new { d.CODFORMACOBRO, d.CODINGRESO });
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.CAJATARJETAS)
                .HasForeignKey(d => d.CODMONEDA);
            this.HasRequired(t => t.TIPOTARJETA)
                .WithMany(t => t.CAJATARJETAS)
                .HasForeignKey(d => d.CODTARJETA);

        }
    }
}
