using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPODEBITOMap : EntityTypeConfiguration<TIPODEBITO>
    {
        public TIPODEBITOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPODEBITO);

            // Properties
            this.Property(t => t.CODTIPODEBITO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMTIPODEBITO)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.DESTIPODEBITO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("TIPODEBITO");
            this.Property(t => t.CODTIPODEBITO).HasColumnName("CODTIPODEBITO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMTIPODEBITO).HasColumnName("NUMTIPODEBITO");
            this.Property(t => t.DESTIPODEBITO).HasColumnName("DESTIPODEBITO");
            this.Property(t => t.PRIORIDAD).HasColumnName("PRIORIDAD");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.IMPRIMECHEQUE).HasColumnName("IMPRIMECHEQUE");

            // Relationships
            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.TIPODEBITOes)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPODEBITOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
