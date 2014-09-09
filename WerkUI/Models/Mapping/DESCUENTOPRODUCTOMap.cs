using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class DESCUENTOPRODUCTOMap : EntityTypeConfiguration<DESCUENTOPRODUCTO>
    {
        public DESCUENTOPRODUCTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODDESCUENTO);

            // Properties
            this.Property(t => t.CODDESCUENTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMDESCUENTO)
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("DESCUENTOPRODUCTO");
            this.Property(t => t.CODDESCUENTO).HasColumnName("CODDESCUENTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMDESCUENTO).HasColumnName("NUMDESCUENTO");
            this.Property(t => t.PORCENTAJEDESCUENTO).HasColumnName("PORCENTAJEDESCUENTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.DESCUENTOPRODUCTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
