using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class RESPONSABLERECEPCIONMap : EntityTypeConfiguration<RESPONSABLERECEPCION>
    {
        public RESPONSABLERECEPCIONMap()
        {
            // Primary Key
            this.HasKey(t => t.CODRESPONSABLERECEPCION);

            // Properties
            this.Property(t => t.CODRESPONSABLERECEPCION)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMRESPONSABLERECEPCION)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESRESPONSABLERECEPCION)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("RESPONSABLERECEPCION");
            this.Property(t => t.CODRESPONSABLERECEPCION).HasColumnName("CODRESPONSABLERECEPCION");
            this.Property(t => t.NUMRESPONSABLERECEPCION).HasColumnName("NUMRESPONSABLERECEPCION");
            this.Property(t => t.DESRESPONSABLERECEPCION).HasColumnName("DESRESPONSABLERECEPCION");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.RESPONSABLERECEPCIONs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
