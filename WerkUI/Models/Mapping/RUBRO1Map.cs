using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class RUBRO1Map : EntityTypeConfiguration<RUBRO1>
    {
        public RUBRO1Map()
        {
            // Primary Key
            this.HasKey(t => t.CODRUBRO1);

            // Properties
            this.Property(t => t.CODRUBRO1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMRUBRO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESRUBRO)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("RUBRO1");
            this.Property(t => t.CODRUBRO1).HasColumnName("CODRUBRO1");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMRUBRO).HasColumnName("NUMRUBRO");
            this.Property(t => t.DESRUBRO).HasColumnName("DESRUBRO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.RUBRO1)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
