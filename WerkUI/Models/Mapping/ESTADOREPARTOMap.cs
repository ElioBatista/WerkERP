using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ESTADOREPARTOMap : EntityTypeConfiguration<ESTADOREPARTO>
    {
        public ESTADOREPARTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODESTADOREPARTO);

            // Properties
            this.Property(t => t.CODESTADOREPARTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMESTADOREPARTO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESESTADOREPARTO)
                .IsFixedLength()
                .HasMaxLength(80);

            // Table & Column Mappings
            this.ToTable("ESTADOREPARTO");
            this.Property(t => t.CODESTADOREPARTO).HasColumnName("CODESTADOREPARTO");
            this.Property(t => t.NUMESTADOREPARTO).HasColumnName("NUMESTADOREPARTO");
            this.Property(t => t.DESESTADOREPARTO).HasColumnName("DESESTADOREPARTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ESTADOREPARTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
