using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class NUMERORECIBOMap : EntityTypeConfiguration<NUMERORECIBO>
    {
        public NUMERORECIBOMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CODCOBRADOR, t.CODCOMPROBANTE });

            // Properties
            this.Property(t => t.CODCOBRADOR)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CODCOMPROBANTE)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("NUMERORECIBO");
            this.Property(t => t.CODCOBRADOR).HasColumnName("CODCOBRADOR");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODCOMPROBANTE).HasColumnName("CODCOMPROBANTE");
            this.Property(t => t.RANGO1).HasColumnName("RANGO1");
            this.Property(t => t.RANGO2).HasColumnName("RANGO2");
            this.Property(t => t.ULTIMO).HasColumnName("ULTIMO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasRequired(t => t.TIPOCOMPROBANTE)
                .WithMany(t => t.NUMERORECIBOes)
                .HasForeignKey(d => d.CODCOMPROBANTE);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.NUMERORECIBOes)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.NUMERORECIBOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
