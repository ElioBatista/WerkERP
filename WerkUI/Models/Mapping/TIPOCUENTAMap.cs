using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOCUENTAMap : EntityTypeConfiguration<TIPOCUENTA>
    {
        public TIPOCUENTAMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPOCUENTA);

            // Properties
            this.Property(t => t.CODTIPOCUENTA)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPOCUENTA)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESTIPOCUENTA)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("TIPOCUENTA");
            this.Property(t => t.CODTIPOCUENTA).HasColumnName("CODTIPOCUENTA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMTIPOCUENTA).HasColumnName("NUMTIPOCUENTA");
            this.Property(t => t.DESTIPOCUENTA).HasColumnName("DESTIPOCUENTA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");

            // Relationships
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOCUENTAs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
