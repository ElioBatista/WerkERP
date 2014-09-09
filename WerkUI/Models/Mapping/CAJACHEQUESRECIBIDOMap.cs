using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class CAJACHEQUESRECIBIDOMap : EntityTypeConfiguration<CAJACHEQUESRECIBIDO>
    {
        public CAJACHEQUESRECIBIDOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODBANCO, t.NUMCHEQUE });

            // Properties
            this.Property(t => t.CODBANCO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NUMCHEQUE)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(30);

            this.Property(t => t.LIBRADOR)
                .IsFixedLength()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("CAJACHEQUESRECIBIDOS");
            this.Property(t => t.CODFORMACOBRO).HasColumnName("CODFORMACOBRO");
            this.Property(t => t.CODINGRESO).HasColumnName("CODINGRESO");
            this.Property(t => t.CODBANCO).HasColumnName("CODBANCO");
            this.Property(t => t.NUMCHEQUE).HasColumnName("NUMCHEQUE");
            this.Property(t => t.CODMONEDA).HasColumnName("CODMONEDA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODESTADO).HasColumnName("CODESTADO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECHAVCTO).HasColumnName("FECHAVCTO");
            this.Property(t => t.IMPORTE).HasColumnName("IMPORTE");
            this.Property(t => t.COTIZACION1).HasColumnName("COTIZACION1");
            this.Property(t => t.COTIZACION2).HasColumnName("COTIZACION2");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");
            this.Property(t => t.LIBRADOR).HasColumnName("LIBRADOR");

            // Relationships
            this.HasRequired(t => t.BANCO)
                .WithMany(t => t.CAJACHEQUESRECIBIDOS)
                .HasForeignKey(d => d.CODBANCO);
            this.HasOptional(t => t.CAJAFORMACOBRO)
                .WithMany(t => t.CAJACHEQUESRECIBIDOS)
                .HasForeignKey(d => new { d.CODFORMACOBRO, d.CODINGRESO });
            this.HasOptional(t => t.ESTADOCHEQUE)
                .WithMany(t => t.CAJACHEQUESRECIBIDOS)
                .HasForeignKey(d => d.CODESTADO);
            this.HasOptional(t => t.MONEDA)
                .WithMany(t => t.CAJACHEQUESRECIBIDOS)
                .HasForeignKey(d => d.CODMONEDA);

        }
    }
}
