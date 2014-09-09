using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOCOBROMap : EntityTypeConfiguration<TIPOCOBRO>
    {
        public TIPOCOBROMap()
        {
            // Primary Key
            this.HasKey(t => t.CODCOBRO);

            // Properties
            this.Property(t => t.CODCOBRO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCOBRO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESCOBRO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("TIPOCOBRO");
            this.Property(t => t.CODCOBRO).HasColumnName("CODCOBRO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMCOBRO).HasColumnName("NUMCOBRO");
            this.Property(t => t.DESCOBRO).HasColumnName("DESCOBRO");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOCOBROes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
