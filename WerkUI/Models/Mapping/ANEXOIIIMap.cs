using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ANEXOIIIMap : EntityTypeConfiguration<ANEXOIII>
    {
        public ANEXOIIIMap()
        {
            // Primary Key
            this.HasKey(t => t.CODANEXOIII);

            // Properties
            this.Property(t => t.CODANEXOIII)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ANEXOIII");
            this.Property(t => t.CODANEXOIII).HasColumnName("CODANEXOIII");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasMany(t => t.HACIENDAs)
                .WithMany(t => t.ANEXOIIIs)
                .Map(m =>
                    {
                        m.ToTable("ANEXOIIIHACIENDA");
                        m.MapLeftKey("CODANEXOIII");
                        m.MapRightKey("CODHACIENDA");
                    });

            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.ANEXOIIIs)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.ANEXOIIIs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ANEXOIIIs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
