using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOEGRESOMap : EntityTypeConfiguration<TIPOEGRESO>
    {
        public TIPOEGRESOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPOEGRESO);

            // Properties
            this.Property(t => t.CODTIPOEGRESO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPOEGRESO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESTIPOEGRESO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("TIPOEGRESO");
            this.Property(t => t.CODTIPOEGRESO).HasColumnName("CODTIPOEGRESO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.NUMTIPOEGRESO).HasColumnName("NUMTIPOEGRESO");
            this.Property(t => t.DESTIPOEGRESO).HasColumnName("DESTIPOEGRESO");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.TIPOEGRESOes)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOEGRESOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
