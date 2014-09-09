using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ESTADOPRODUCTOMap : EntityTypeConfiguration<ESTADOPRODUCTO>
    {
        public ESTADOPRODUCTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODESTADOPRODUCTO);

            // Properties
            this.Property(t => t.CODESTADOPRODUCTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMESTADOPRODUCTO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESESTADOPRODUCTO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("ESTADOPRODUCTO");
            this.Property(t => t.CODESTADOPRODUCTO).HasColumnName("CODESTADOPRODUCTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMESTADOPRODUCTO).HasColumnName("NUMESTADOPRODUCTO");
            this.Property(t => t.DESESTADOPRODUCTO).HasColumnName("DESESTADOPRODUCTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ESTADOPRODUCTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
