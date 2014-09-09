using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CIRCUITORUTAMap : EntityTypeConfiguration<CIRCUITORUTA>
    {
        public CIRCUITORUTAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODRUTA);

            // Properties
            this.Property(t => t.CODRUTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMRUTA)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESRUTA)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CIRCUITORUTA");
            this.Property(t => t.CODRUTA).HasColumnName("CODRUTA");
            this.Property(t => t.NUMRUTA).HasColumnName("NUMRUTA");
            this.Property(t => t.DESRUTA).HasColumnName("DESRUTA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CIRCUITORUTAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
