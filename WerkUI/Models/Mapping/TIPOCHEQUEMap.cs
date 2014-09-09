using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOCHEQUEMap : EntityTypeConfiguration<TIPOCHEQUE>
    {
        public TIPOCHEQUEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPOCHEQUE);

            // Properties
            this.Property(t => t.CODTIPOCHEQUE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPOCHEQUE)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESTIPOCHEQUE)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("TIPOCHEQUE");
            this.Property(t => t.CODTIPOCHEQUE).HasColumnName("CODTIPOCHEQUE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMTIPOCHEQUE).HasColumnName("NUMTIPOCHEQUE");
            this.Property(t => t.DESTIPOCHEQUE).HasColumnName("DESTIPOCHEQUE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOCHEQUEs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
