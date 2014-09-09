using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CIRCUITODIAMap : EntityTypeConfiguration<CIRCUITODIA>
    {
        public CIRCUITODIAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODDIAS);

            // Properties
            this.Property(t => t.CODDIAS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMDIAS)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESDIAS)
                .IsFixedLength()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("CIRCUITODIAS");
            this.Property(t => t.CODDIAS).HasColumnName("CODDIAS");
            this.Property(t => t.NUMDIAS).HasColumnName("NUMDIAS");
            this.Property(t => t.DESDIAS).HasColumnName("DESDIAS");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CIRCUITODIAS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
