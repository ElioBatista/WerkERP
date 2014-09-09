using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class RUBROMap : EntityTypeConfiguration<RUBRO>
    {
        public RUBROMap()
        {
            // Primary Key
            this.HasKey(t => t.CODRUBRO);

            // Properties
            this.Property(t => t.CODRUBRO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMRUBRO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESRUBRO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("RUBRO");
            this.Property(t => t.CODRUBRO).HasColumnName("CODRUBRO");
            this.Property(t => t.CODLINEA).HasColumnName("CODLINEA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMRUBRO).HasColumnName("NUMRUBRO");
            this.Property(t => t.DESRUBRO).HasColumnName("DESRUBRO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.LINEA)
                .WithMany(t => t.RUBROes)
                .HasForeignKey(d => d.CODLINEA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.RUBROes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
