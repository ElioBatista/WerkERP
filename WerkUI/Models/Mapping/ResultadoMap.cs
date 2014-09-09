using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ResultadoMap : EntityTypeConfiguration<Resultado>
    {
        public ResultadoMap()
        {
            // Primary Key
            this.HasKey(t => t.CODPAIS);

            // Properties
            this.Property(t => t.CODPAIS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMPAIS)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESPAIS)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("Resultados");
            this.Property(t => t.CODPAIS).HasColumnName("CODPAIS");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMPAIS).HasColumnName("NUMPAIS");
            this.Property(t => t.DESPAIS).HasColumnName("DESPAIS");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
        }
    }
}
