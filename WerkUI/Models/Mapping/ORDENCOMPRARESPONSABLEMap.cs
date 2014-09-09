using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENCOMPRARESPONSABLEMap : EntityTypeConfiguration<ORDENCOMPRARESPONSABLE>
    {
        public ORDENCOMPRARESPONSABLEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODRESPONSABLE);

            // Properties
            this.Property(t => t.CODRESPONSABLE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMRESPONSABLE)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESCRIPCION)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ORDENCOMPRARESPONSABLE");
            this.Property(t => t.CODRESPONSABLE).HasColumnName("CODRESPONSABLE");
            this.Property(t => t.NUMRESPONSABLE).HasColumnName("NUMRESPONSABLE");
            this.Property(t => t.DESCRIPCION).HasColumnName("DESCRIPCION");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ORDENCOMPRARESPONSABLEs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
