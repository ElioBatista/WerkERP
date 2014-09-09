using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class ANEXOIVMap : EntityTypeConfiguration<ANEXOIV>
    {
        public ANEXOIVMap()
        {
            // Primary Key
            this.HasKey(t => t.CODANEXOIV);

            // Properties
            this.Property(t => t.CODANEXOIV)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ANEXOIV");
            this.Property(t => t.CODANEXOIV).HasColumnName("CODANEXOIV");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasMany(t => t.HACIENDAs)
                .WithMany(t => t.ANEXOIVs)
                .Map(m =>
                    {
                        m.ToTable("ANEXOIVHACIENDA");
                        m.MapLeftKey("CODANEXOIV");
                        m.MapRightKey("CODHACIENDA");
                    });

            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.ANEXOIVs)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.ANEXOIVs)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.ANEXOIVs)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
