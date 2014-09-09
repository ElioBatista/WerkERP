using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class SEXOMap : EntityTypeConfiguration<SEXO>
    {
        public SEXOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODSEXO);

            // Properties
            this.Property(t => t.CODSEXO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMSEXO)
                .HasMaxLength(5);

            this.Property(t => t.DESSEXO)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("SEXO");
            this.Property(t => t.CODSEXO).HasColumnName("CODSEXO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMSEXO).HasColumnName("NUMSEXO");
            this.Property(t => t.DESSEXO).HasColumnName("DESSEXO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.SEXOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
