using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CAJAINGRESO1Map : EntityTypeConfiguration<CAJAINGRESO1>
    {
        public CAJAINGRESO1Map()
        {
            // Primary Key
            this.HasKey(t => t.CODINGRESO);

            // Properties
            this.Property(t => t.CODINGRESO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OBSERVACION)
                .IsFixedLength()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CAJAINGRESOS");
            this.Property(t => t.CODINGRESO).HasColumnName("CODINGRESO");
            this.Property(t => t.TIPOINGRESO).HasColumnName("TIPOINGRESO");
            this.Property(t => t.CODTIPOEGRESO).HasColumnName("CODTIPOEGRESO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMCAJA).HasColumnName("NUMCAJA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.VUELTO).HasColumnName("VUELTO");
            this.Property(t => t.FECINGRESO).HasColumnName("FECINGRESO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");

            // Relationships
            this.HasMany(t => t.VENTAS)
                .WithMany(t => t.CAJAINGRESOS)
                .Map(m =>
                    {
                        m.ToTable("CAJAFACTURASCOBRADAS");
                        m.MapLeftKey("CODINGRESO");
                        m.MapRightKey("CODVENTA");
                    });

            this.HasOptional(t => t.CAJA)
                .WithMany(t => t.CAJAINGRESOS)
                .HasForeignKey(d => d.NUMCAJA);
            this.HasOptional(t => t.TIPOEGRESO)
                .WithMany(t => t.CAJAINGRESOS)
                .HasForeignKey(d => d.CODTIPOEGRESO);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.CAJAINGRESOS)
                .HasForeignKey(d => d.CODMONEDA);

        }
    }
}
