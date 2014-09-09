using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOCLIENTEMap : EntityTypeConfiguration<TIPOCLIENTE>
    {
        public TIPOCLIENTEMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPOCLIENTE);

            // Properties
            this.Property(t => t.CODTIPOCLIENTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPOCLIENTE)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESTIPOCLIENTE)
                .IsFixedLength()
                .HasMaxLength(40);

            this.Property(t => t.RUC)
                .HasMaxLength(30);

            this.Property(t => t.DIRECCION)
                .HasMaxLength(80);

            this.Property(t => t.TELEFONO)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("TIPOCLIENTE");
            this.Property(t => t.CODTIPOCLIENTE).HasColumnName("CODTIPOCLIENTE");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMTIPOCLIENTE).HasColumnName("NUMTIPOCLIENTE");
            this.Property(t => t.DESTIPOCLIENTE).HasColumnName("DESTIPOCLIENTE");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.RUC).HasColumnName("RUC");
            this.Property(t => t.DIRECCION).HasColumnName("DIRECCION");
            this.Property(t => t.TELEFONO).HasColumnName("TELEFONO");
        }
    }
}
