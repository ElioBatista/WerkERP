using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ORDENPAGOCLIENTEMap : EntityTypeConfiguration<ORDENPAGOCLIENTE>
    {
        public ORDENPAGOCLIENTEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODORDENPAGOCLIENTE);

            // Properties
            this.Property(t => t.CODORDENPAGOCLIENTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMEROCOMPROBANTE)
                .IsFixedLength()
                .HasMaxLength(9);

            // Table & Column Mappings
            this.ToTable("ORDENPAGOCLIENTE");
            this.Property(t => t.CODORDENPAGOCLIENTE).HasColumnName("CODORDENPAGOCLIENTE");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMEROCOMPROBANTE).HasColumnName("NUMEROCOMPROBANTE");
            this.Property(t => t.FECHAMOVIMIENTO).HasColumnName("FECHAMOVIMIENTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODUSUARIOACEPTA).HasColumnName("CODUSUARIOACEPTA");
            this.Property(t => t.CODUSUARIODIF).HasColumnName("CODUSUARIODIF");
        }
    }
}
