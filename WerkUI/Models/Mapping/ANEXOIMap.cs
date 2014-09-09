using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ANEXOIMap : EntityTypeConfiguration<ANEXOI>
    {
        public ANEXOIMap()
        {
            // Primary Key
            this.HasKey(t => t.CODANEXOI);

            // Properties
            this.Property(t => t.CODANEXOI)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ANEXOI");
            this.Property(t => t.CODANEXOI).HasColumnName("CODANEXOI");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasMany(t => t.HACIENDAs)
                .WithMany(t => t.ANEXOIs)
                .Map(m =>
                    {
                        m.ToTable("ANEXOIHACIENDA");
                        m.MapLeftKey("CODANEXOI");
                        m.MapRightKey("CODHACIENDA");
                    });

            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.ANEXOIs)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.ANEXOIs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ANEXOIs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
