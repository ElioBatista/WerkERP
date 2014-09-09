using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class BULTOMap : EntityTypeConfiguration<BULTO>
    {
        public BULTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODBULTO);

            // Properties
            this.Property(t => t.NUMBULTO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESBULTO)
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.CODBULTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BULTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMBULTO).HasColumnName("NUMBULTO");
            this.Property(t => t.DESBULTO).HasColumnName("DESBULTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODBULTO).HasColumnName("CODBULTO");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.BULTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
