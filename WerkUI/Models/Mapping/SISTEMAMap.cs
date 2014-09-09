using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class SISTEMAMap : EntityTypeConfiguration<SISTEMA>
    {
        public SISTEMAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODSISTEMAS);

            // Properties
            this.Property(t => t.CODSISTEMAS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMSISTEMAS)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESSISTEMAS)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("SISTEMAS");
            this.Property(t => t.CODSISTEMAS).HasColumnName("CODSISTEMAS");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMSISTEMAS).HasColumnName("NUMSISTEMAS");
            this.Property(t => t.DESSISTEMAS).HasColumnName("DESSISTEMAS");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.SISTEMAS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
