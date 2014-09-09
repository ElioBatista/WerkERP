using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ANEXOIIMap : EntityTypeConfiguration<ANEXOII>
    {
        public ANEXOIIMap()
        {
            // Primary Key
            this.HasKey(t => t.CODANEXOII);

            // Properties
            this.Property(t => t.CODANEXOII)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ANEXOII");
            this.Property(t => t.CODANEXOII).HasColumnName("CODANEXOII");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasMany(t => t.HACIENDAs)
                .WithMany(t => t.ANEXOIIs)
                .Map(m =>
                    {
                        m.ToTable("ANEXOIIHACIENDA");
                        m.MapLeftKey("CODANEXOII");
                        m.MapRightKey("CODHACIENDA");
                    });

            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.ANEXOIIs)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.ANEXOIIs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ANEXOIIs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
