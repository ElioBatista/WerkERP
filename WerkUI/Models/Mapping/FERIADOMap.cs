using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class FERIADOMap : EntityTypeConfiguration<FERIADO>
    {
        public FERIADOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODFERIADO);

            // Properties
            this.Property(t => t.CODFERIADO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESFERIADO)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("FERIADOS");
            this.Property(t => t.CODFERIADO).HasColumnName("CODFERIADO");
            this.Property(t => t.FECHA).HasColumnName("FECHA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.DESFERIADO).HasColumnName("DESFERIADO");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.FERIADOS)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
