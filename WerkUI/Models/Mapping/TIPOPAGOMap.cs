using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOPAGOMap : EntityTypeConfiguration<TIPOPAGO>
    {
        public TIPOPAGOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPOPAGO);

            // Properties
            this.Property(t => t.CODTIPOPAGO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPOPAGO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESTIPOPAGO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("TIPOPAGO");
            this.Property(t => t.CODTIPOPAGO).HasColumnName("CODTIPOPAGO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.NUMTIPOPAGO).HasColumnName("NUMTIPOPAGO");
            this.Property(t => t.DESTIPOPAGO).HasColumnName("DESTIPOPAGO");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
        }
    }
}
