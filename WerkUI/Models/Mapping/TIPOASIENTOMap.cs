using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WerkUI.Models.Mapping
{
    public class TIPOASIENTOMap : EntityTypeConfiguration<TIPOASIENTO>
    {
        public TIPOASIENTOMap()
        {
            // Primary Key
            this.HasKey(t => t.CODTIPOASIENTO);

            // Properties
            this.Property(t => t.CODTIPOASIENTO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DESTIPOASIENTO)
                .IsFixedLength()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("TIPOASIENTO");
            this.Property(t => t.CODTIPOASIENTO).HasColumnName("CODTIPOASIENTO");
            this.Property(t => t.CODUSUARIO).HasColumnName("CODUSUARIO");
            this.Property(t => t.CODEMPRESA).HasColumnName("CODEMPRESA");
            this.Property(t => t.CODSUCURSAL).HasColumnName("CODSUCURSAL");
            this.Property(t => t.DESTIPOASIENTO).HasColumnName("DESTIPOASIENTO");
            this.Property(t => t.FECGRA).HasColumnName("FECGRA");

            // Relationships
            this.HasOptional(t => t.SUCURSAL)
                .WithMany(t => t.TIPOASIENTOes)
                .HasForeignKey(d => d.CODSUCURSAL);
            this.HasOptional(t => t.USUARIO)
                .WithMany(t => t.TIPOASIENTOes)
                .HasForeignKey(d => new { d.CODUSUARIO, d.CODEMPRESA });

        }
    }
}
