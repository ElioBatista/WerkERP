using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class RESPONSABLEMap : EntityTypeConfiguration<RESPONSABLE>
    {
        public RESPONSABLEMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NUMRESPONSABLE, t.CODEMPRESA });

            // Properties
            this.Property(t => t.NUMRESPONSABLE)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.CODEMPRESA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESRESPONSABLE)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("RESPONSABLE");
            this.Property(t => t.NUMRESPONSABLE).HasColumnName("NUMRESPONSABLE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.DESRESPONSABLE).HasColumnName("DESRESPONSABLE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.RESPONSABLEs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
