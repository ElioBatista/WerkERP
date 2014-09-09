using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class FLUJOEFECTIVOMap : EntityTypeConfiguration<FLUJOEFECTIVO>
    {
        public FLUJOEFECTIVOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODFLUJOEFECTIVO);

            // Properties
            this.Property(t => t.CODFLUJOEFECTIVO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("FLUJOEFECTIVO");
            this.Property(t => t.CODFLUJOEFECTIVO).HasColumnName("CODFLUJOEFECTIVO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.CODPLANCUENTA).HasColumnName("CODPLANCUENTA");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasMany(t => t.HACIENDAs)
                .WithMany(t => t.FLUJOEFECTIVOes)
                .Map(m =>
                    {
                        m.ToTable("FLUJOHACIENDA");
                        m.MapLeftKey("CODFLUJOEFECTIVO");
                        m.MapRightKey("CODHACIENDA");
                    });

            this.HasOptional(t => t.PLANCUENTA)
                .WithMany(t => t.FLUJOEFECTIVOes)
                .HasForeignKey(d => d.CODPLANCUENTA);
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.FLUJOEFECTIVOes)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.FLUJOEFECTIVOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
