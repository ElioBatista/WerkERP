using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOCREDITOMap : EntityTypeConfiguration<TIPOCREDITO>
    {
        public TIPOCREDITOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPOCREDITO);

            // Properties
            this.Property(t => t.CODTIPOCREDITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPOCREDITO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESTIPOCREDITO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("TIPOCREDITO");
            this.Property(t => t.CODTIPOCREDITO).HasColumnName("CODTIPOCREDITO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMTIPOCREDITO).HasColumnName("NUMTIPOCREDITO");
            this.Property(t => t.DESTIPOCREDITO).HasColumnName("DESTIPOCREDITO");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");

            // Relationships
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.TIPOCREDITOes)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOCREDITOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
