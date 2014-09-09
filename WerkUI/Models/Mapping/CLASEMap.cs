using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CLASEMap : EntityTypeConfiguration<CLASE>
    {
        public CLASEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCLASE);

            // Properties
            this.Property(t => t.CODCLASE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCLASE)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESCLASE)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("CLASE");
            this.Property(t => t.CODCLASE).HasColumnName("CODCLASE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMCLASE).HasColumnName("NUMCLASE");
            this.Property(t => t.DESCLASE).HasColumnName("DESCLASE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CLASEs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
