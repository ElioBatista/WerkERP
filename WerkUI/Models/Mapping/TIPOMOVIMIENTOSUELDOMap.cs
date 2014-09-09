using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOMOVIMIENTOSUELDOMap : EntityTypeConfiguration<TIPOMOVIMIENTOSUELDO>
    {
        public TIPOMOVIMIENTOSUELDOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPOMOV);

            // Properties
            this.Property(t => t.CODTIPOMOV)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPOMOV)
                .HasMaxLength(5);

            this.Property(t => t.DESTIPOMOV)
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("TIPOMOVIMIENTOSUELDO");
            this.Property(t => t.CODTIPOMOV).HasColumnName("CODTIPOMOV");
            this.Property(t => t.CODPLANCUENTAS).HasColumnName("CODPLANCUENTAS");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.NUMTIPOMOV).HasColumnName("NUMTIPOMOV");
            this.Property(t => t.DESTIPOMOV).HasColumnName("DESTIPOMOV");
            this.Property(t => t.SUMARESTA).HasColumnName("SUMARESTA");
            this.Property(t => t.ENRECIBO).HasColumnName("ENRECIBO");
            this.Property(t => t.LIBROS).HasColumnName("LIBROS");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.PORCENTAJE).HasColumnName("PORCENTAJE");
            this.Property(t => t.SALARIOMINIMO).HasColumnName("SALARIOMINIMO");
            this.Property(t => t.SALARIOBASICO).HasColumnName("SALARIOBASICO");
            this.Property(t => t.TOTALSALARIO).HasColumnName("TOTALSALARIO");
            this.Property(t => t.NINGUNO).HasColumnName("NINGUNO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.TIPOMOVIMIENTOSUELDOes)
                .HasForeignKey(d => d.CODPLANCUENTAS);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOMOVIMIENTOSUELDOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
