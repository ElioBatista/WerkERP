using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOTRANSPORTEMap : EntityTypeConfiguration<TIPOTRANSPORTE>
    {
        public TIPOTRANSPORTEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTRANSPORTE);

            // Properties
            this.Property(t => t.CODTRANSPORTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTRANSPORTE)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESTRANSPORTE)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("TIPOTRANSPORTE");
            this.Property(t => t.CODTRANSPORTE).HasColumnName("CODTRANSPORTE");
            this.Property(t => t.NUMTRANSPORTE).HasColumnName("NUMTRANSPORTE");
            this.Property(t => t.DESTRANSPORTE).HasColumnName("DESTRANSPORTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOTRANSPORTEs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
