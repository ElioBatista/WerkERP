using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CAJAINGRESOMap : EntityTypeConfiguration<CAJAINGRESO>
    {
        public CAJAINGRESOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODINGRESO);

            // Properties
            this.Property(t => t.CODINGRESO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CAJAINGRESO");
            this.Property(t => t.CODINGRESO).HasColumnName("CODINGRESO");
            this.Property(t => t.CODCOBRANZA).HasColumnName("CODCOBRANZA");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODFORCOBRO).HasColumnName("CODFORCOBRO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.NUMCAJA).HasColumnName("NUMCAJA");
            this.Property(t => t.CODVENTA).HasColumnName("CODVENTA");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.COBRANZA)
                .WithMany(t => t.CAJAINGRESOes)
                .HasForeignKey(d => new { d.CODCOBRANZA, d.CODMONEDA, d.CODFORCOBRO });
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.CAJAINGRESOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });
            this.HasOptional(t => t.VENTA)
                .WithMany(t => t.CAJAINGRESOes)
                .HasForeignKey(d => d.CODVENTA);

        }
    }
}
