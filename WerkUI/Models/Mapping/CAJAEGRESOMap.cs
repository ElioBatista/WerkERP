using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CAJAEGRESOMap : EntityTypeConfiguration<CAJAEGRESO>
    {
        public CAJAEGRESOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODEGRESO);

            // Properties
            this.Property(t => t.CODEGRESO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OBSERVACION)
                .IsFixedLength()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CAJAEGRESOS");
            this.Property(t => t.CODEGRESO).HasColumnName("CODEGRESO");
            this.Property(t => t.CODTIPOEGRESO).HasColumnName("CODTIPOEGRESO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODPAGANZAS).HasColumnName("CODPAGANZAS");
            this.Property(t => t.NUMEROCUOTA).HasColumnName("NUMEROCUOTA");
            this.Property(t => t.CODCOMPRA).HasColumnName("CODCOMPRA");
            this.Property(t => t.NUMCAJA).HasColumnName("NUMCAJA");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECHAMOVIMIENTO).HasColumnName("FECHAMOVIMIENTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.OBSERVACION).HasColumnName("OBSERVACION");

            // Relationships
            this.HasOptional(t => t.CAJA)
                .WithMany(t => t.CAJAEGRESOS)
                .HasForeignKey(d => d.NUMCAJA);
            this.HasOptional(t => t.FACTURAPAGAR)
                .WithMany(t => t.CAJAEGRESOS)
                .HasForeignKey(d => new { d.NUMEROCUOTA, d.CODCOMPRA });
            this.HasOptional(t => t.TIPOEGRESO)
                .WithMany(t => t.CAJAEGRESOS)
                .HasForeignKey(d => d.CODTIPOEGRESO);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.CAJAEGRESOS)
                .HasForeignKey(d => d.CODMONEDA);

        }
    }
}
