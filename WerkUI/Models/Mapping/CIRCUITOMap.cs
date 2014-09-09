using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CIRCUITOMap : EntityTypeConfiguration<CIRCUITO>
    {
        public CIRCUITOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCIRCUITO);

            // Properties
            this.Property(t => t.CODCIRCUITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCIRCUITO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESCIRCUITO)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CIRCUITO");
            this.Property(t => t.CODCIRCUITO).HasColumnName("CODCIRCUITO");
            this.Property(t => t.NUMCIRCUITO).HasColumnName("NUMCIRCUITO");
            this.Property(t => t.DESCIRCUITO).HasColumnName("DESCIRCUITO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODRUTA).HasColumnName("CODRUTA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CIRCUITOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
